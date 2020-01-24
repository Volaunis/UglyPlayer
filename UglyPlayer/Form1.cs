using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IrrKlang;
using UglyPlayer.Extensions;
using UglyPlayer.Models;

namespace UglyPlayer
{
    public partial class MainForm : Form
    {
        private delegate void SetCallback(StopEventCause stopEventCause);

        private readonly List<PictureBox> _buttons = new List<PictureBox>();
        private readonly ISoundEngine _player;
        private ISound _currentSound;
        private readonly Timer _timer = new Timer();
        private PlayedRemainingType _playedRemaining = PlayedRemainingType.Remaining;

        public TrackEntry CurrentTrack;

        public MainForm()
        {
            InitializeComponent();
            _player = new ISoundEngine();

            _timer.Tick += UpdateRemainingTime;
            _timer.Interval = 1000;
            _timer.Start();
        }

        private void UpdateRemainingTime(object sender, EventArgs e)
        {
            Time.Text =
                _playedRemaining == PlayedRemainingType.Played
                    ? TimePlayed().ToPlayedDuration()
                    : TimeRemaining().ToRemainingDuration();
        }

        public void HandleStop(StopEventCause stopEventCause)
        {
            if (stopEventCause != StopEventCause.SoundFinishedPlaying) return;

            if (TracksList.InvokeRequired)
            {
                SetCallback d = HandleStop;
                BeginInvoke(d, stopEventCause);
            }
            else
            {
                // We continue to the next track
                SetTrackToPlay(CurrentTrack.NextTrack);
            }
        }

        private void SetButtonEnable(object ActiveObject)
        {
            var activeButton = (PictureBox)ActiveObject;
            foreach (var button in _buttons)
            {
                button.BackColor = button == activeButton
                    ? Color.FromArgb(0, 192, 192)
                    : Color.FromKnownColor(KnownColor.Control);
            }        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _buttons.Add(Previous);
            _buttons.Add(Pause);
            _buttons.Add(Stop);
            _buttons.Add(Play);
            _buttons.Add(Next);
        }

        private void PlayedRemaining_Click(object sender, EventArgs e)
        {
            _playedRemaining =
                _playedRemaining == PlayedRemainingType.Played
                    ? PlayedRemainingType.Remaining
                    : PlayedRemainingType.Played;

            UpdateTrackInfo(CurrentTrack);
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (CurrentTrack == null) return;
            SetButtonEnable(sender);
            SetTrackToPlay(CurrentTrack.PreviousTrack);
            SetButtonEnable(Play);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            SetButtonEnable(sender);
            _currentSound.Paused = !_currentSound.Paused;
            if (!_currentSound.Paused)
                SetButtonEnable(Play);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SetButtonEnable(sender);
            StopTrack();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            SetButtonEnable(sender);

            if (_currentSound != null && _currentSound.Paused)
                _currentSound.Paused = false;
            else
            {
                var selectedTrack = (TrackEntry) TracksList.SelectedRows[0].DataBoundItem;
                SetTrackToPlay(selectedTrack);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CurrentTrack == null) return;
            SetButtonEnable(sender);
            SetTrackToPlay(CurrentTrack.NextTrack);
            SetButtonEnable(Play);
        }

        private void TracksList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetButtonEnable(Play);
            var selectedTrack = (TrackEntry)TracksList.SelectedRows[0].DataBoundItem;
            SetTrackToPlay(selectedTrack);
        }

        private void LoadFiles_Click(object sender, EventArgs e)
        {
            var loadFilesButton = (PictureBox)sender;

            loadFilesButton.BackColor = Color.FromArgb(208, 104, 0);

            FolderBrowserDialog.SelectedPath = "C:\\Data\\Examples";
            FolderBrowserDialog.ShowDialog();
            var folder = FolderBrowserDialog.SelectedPath;

            var fileList = Directory.GetFiles(folder);

            var tracksList = fileList.Select(f => new TrackEntry(f,this)).ToList();

            for (var i = 0; i < tracksList.Count; i++)
            {
                var currentTrack = tracksList[i];
                if (tracksList.Count == 1)
                {
                    currentTrack.NextTrack = currentTrack;
                    currentTrack.PreviousTrack = currentTrack;
                }
                else if (i == 0)
                {
                    currentTrack.NextTrack = tracksList[i + 1];
                    currentTrack.PreviousTrack = tracksList[tracksList.Count - 1];
                }
                else if (i == tracksList.Count - 1)
                {
                    currentTrack.NextTrack = tracksList[0];
                    currentTrack.PreviousTrack = tracksList[i - 1];
                }
                else
                {
                    currentTrack.NextTrack = tracksList[i + 1];
                    currentTrack.PreviousTrack = tracksList[i - 1];
                }
            }

            TracksList.AutoGenerateColumns = false;
            TracksList.DataSource = tracksList;
            TracksList.Refresh();
            
            loadFilesButton.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void SetTrackToPlay(TrackEntry selectedTrack)
        {
            StopTrack();
            
            CurrentTrack = selectedTrack;
            _currentSound = _player.Play2D(selectedTrack.Filename);
            _currentSound.setSoundStopEventReceiver(new Event(this));

            UpdateTrackInfo(selectedTrack);

            for(var i=0;i<TracksList.RowCount;i++)
                if (TracksList.Rows[i].DataBoundItem == selectedTrack)
                    TracksList.Rows[i].Selected = true;
        }

        private void UpdateTrackInfo(TrackEntry selectedTrack)
        {
            Title.Text = selectedTrack.TrackTitle;
            Artist.Text = selectedTrack.TrackArtist;
            Album.Text = selectedTrack.TrackAlbum;

            Time.Text =
                _playedRemaining == PlayedRemainingType.Played
                    ? TimePlayed().ToPlayedDuration()
                    : TimeRemaining().ToRemainingDuration();
        }

        private long TimePlayed()
        {
            if (_currentSound == null) return 0;
            return (_currentSound.PlayPosition) / 1000;
        }

        private long TimeRemaining()
        {
            if (_currentSound == null) return 0;
            return (_currentSound.PlayLength - _currentSound.PlayPosition) / 1000;
        }

        private void StopTrack()
        {
            if (_currentSound == null) return;

            if (!_currentSound.Finished)
                _currentSound.Stop();
            _currentSound = null;
        }
    }
}
