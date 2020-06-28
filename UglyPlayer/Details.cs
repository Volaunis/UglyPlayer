using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyPlayer.Helpers;
using UglyPlayer.Models;

namespace UglyPlayer
{
    public partial class Details : Form
    {
        private TrackEntry _trackEntry;

        public Details()
        {
            InitializeComponent();
        }

        public void LoadTrack(TrackEntry trackEntry)
        {
            if (trackEntry == null) return;

            _trackEntry = trackEntry;

            TrackInfo.Text = $"Title:\t\t{trackEntry.TrackTitle}";

            TrackInfo.Find("Title:", RichTextBoxFinds.None);
            TrackInfo.SelectionFont = new Font("Courier New", 8,FontStyle.Bold);
            //Artist.Text = trackEntry.TrackArtist;
            //Album.Text = trackEntry.TrackAlbum;

            //Duration.Text = trackEntry.DurationString;

            //Filename.Text = new FileInfo(trackEntry.Filename).Name;

            //Comments.Text = trackEntry.Comments;

        }

    }
}
