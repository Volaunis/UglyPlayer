﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UglyPlayer.Models
{
    public class TrackEntry
    {
        private readonly MainForm _owner;

        public TrackEntry(string filename, MainForm owner)
        {
            Filename = filename;
            _owner = owner;

            var fileType = new FileInfo(filename).Extension;
            TrackTitle = new FileInfo(filename).Name;

            if (new FileInfo(filename).Extension.ToLower() != ".mp3") return; 
                
            var tag = TagLib.File.Create(filename);

            if (!string.IsNullOrWhiteSpace(TrackTitle))
                TrackTitle = tag.Tag.Title; // Overrides above

            TrackArtist =
                (!string.IsNullOrWhiteSpace(tag.Tag.JoinedAlbumArtists))
                    ? tag.Tag.JoinedAlbumArtists
                    : tag.Tag.JoinedPerformers;

            TrackAlbum = tag.Tag.Album;

            Duration = tag.Properties.Duration.TotalSeconds;
            
        }

        public string Playing => this == _owner.CurrentTrack ? "Playing" : "";

        public string Filename { get; set; }
        public string TrackTitle { get; set; }

        public string TrackArtist { get; set; }

        public string TrackAlbum { get; set; }

        public double Duration { get; set; }

        public string DurationString
        {
            get
            {
                var ts = TimeSpan.FromSeconds(Duration);
                return ts.ToString( @"hh\:mm\:ss");
            }
        }

        public TrackEntry PreviousTrack { get; set; }
        public TrackEntry NextTrack { get; set; }
    }
}
