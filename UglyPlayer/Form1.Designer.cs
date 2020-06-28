namespace UglyPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Time = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Details = new System.Windows.Forms.PictureBox();
            this.PlayedRemaining = new System.Windows.Forms.PictureBox();
            this.LoadFiles = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.PictureBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TracksList = new System.Windows.Forms.DataGridView();
            this.Playing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayedRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TracksList)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(6, 22);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(473, 108);
            this.Time.TabIndex = 3;
            this.Time.Text = "-00:00:00";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(485, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(424, 35);
            this.Title.TabIndex = 4;
            this.Title.Text = "No track";
            // 
            // Album
            // 
            this.Album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Album.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.Location = new System.Drawing.Point(485, 95);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(424, 35);
            this.Album.TabIndex = 5;
            this.Album.Text = " ";
            // 
            // Artist
            // 
            this.Artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Artist.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.Location = new System.Drawing.Point(485, 57);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(424, 35);
            this.Artist.TabIndex = 6;
            this.Artist.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Time);
            this.groupBox2.Controls.Add(this.Artist);
            this.groupBox2.Controls.Add(this.Title);
            this.groupBox2.Controls.Add(this.Album);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Details);
            this.groupBox1.Controls.Add(this.PlayedRemaining);
            this.groupBox1.Controls.Add(this.LoadFiles);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.Next);
            this.groupBox1.Controls.Add(this.Play);
            this.groupBox1.Controls.Add(this.Pause);
            this.groupBox1.Controls.Add(this.Previous);
            this.groupBox1.Location = new System.Drawing.Point(14, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // Details
            // 
            this.Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.Location = new System.Drawing.Point(705, 25);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(64, 64);
            this.Details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Details.TabIndex = 7;
            this.Details.TabStop = false;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // PlayedRemaining
            // 
            this.PlayedRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayedRemaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayedRemaining.Image = ((System.Drawing.Image)(resources.GetObject("PlayedRemaining.Image")));
            this.PlayedRemaining.Location = new System.Drawing.Point(775, 25);
            this.PlayedRemaining.Name = "PlayedRemaining";
            this.PlayedRemaining.Size = new System.Drawing.Size(64, 64);
            this.PlayedRemaining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayedRemaining.TabIndex = 6;
            this.PlayedRemaining.TabStop = false;
            this.PlayedRemaining.Click += new System.EventHandler(this.PlayedRemaining_Click);
            // 
            // LoadFiles
            // 
            this.LoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadFiles.Image = ((System.Drawing.Image)(resources.GetObject("LoadFiles.Image")));
            this.LoadFiles.Location = new System.Drawing.Point(845, 25);
            this.LoadFiles.Name = "LoadFiles";
            this.LoadFiles.Size = new System.Drawing.Size(64, 64);
            this.LoadFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadFiles.TabIndex = 5;
            this.LoadFiles.TabStop = false;
            this.LoadFiles.Click += new System.EventHandler(this.LoadFiles_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(146, 25);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(64, 64);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 4;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Next
            // 
            this.Next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.Location = new System.Drawing.Point(286, 25);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(64, 64);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Next.TabIndex = 3;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Play
            // 
            this.Play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(216, 25);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(64, 64);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 2;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.Location = new System.Drawing.Point(76, 25);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(64, 64);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause.TabIndex = 1;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Previous
            // 
            this.Previous.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous.Image = ((System.Drawing.Image)(resources.GetObject("Previous.Image")));
            this.Previous.Location = new System.Drawing.Point(6, 25);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(64, 64);
            this.Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Previous.TabIndex = 0;
            this.Previous.TabStop = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TracksList);
            this.groupBox3.Location = new System.Drawing.Point(14, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(925, 326);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tracks";
            // 
            // TracksList
            // 
            this.TracksList.AllowUserToAddRows = false;
            this.TracksList.AllowUserToDeleteRows = false;
            this.TracksList.AllowUserToOrderColumns = true;
            this.TracksList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TracksList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TracksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TracksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TracksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TracksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TracksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Playing,
            this.TrackTitle,
            this.TrackArtist,
            this.TrackAlbum,
            this.Duration});
            this.TracksList.Location = new System.Drawing.Point(4, 29);
            this.TracksList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TracksList.MultiSelect = false;
            this.TracksList.Name = "TracksList";
            this.TracksList.ReadOnly = true;
            this.TracksList.RowHeadersVisible = false;
            this.TracksList.RowHeadersWidth = 62;
            this.TracksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TracksList.ShowEditingIcon = false;
            this.TracksList.Size = new System.Drawing.Size(911, 288);
            this.TracksList.TabIndex = 0;
            this.TracksList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TracksList_CellContentDoubleClick);
            // 
            // Playing
            // 
            this.Playing.DataPropertyName = "Playing";
            this.Playing.FillWeight = 85.22729F;
            this.Playing.HeaderText = "";
            this.Playing.MinimumWidth = 8;
            this.Playing.Name = "Playing";
            this.Playing.ReadOnly = true;
            this.Playing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TrackTitle
            // 
            this.TrackTitle.DataPropertyName = "TrackTitle";
            this.TrackTitle.FillWeight = 103.6932F;
            this.TrackTitle.HeaderText = "Title";
            this.TrackTitle.MinimumWidth = 8;
            this.TrackTitle.Name = "TrackTitle";
            this.TrackTitle.ReadOnly = true;
            // 
            // TrackArtist
            // 
            this.TrackArtist.DataPropertyName = "TrackArtist";
            this.TrackArtist.FillWeight = 103.6932F;
            this.TrackArtist.HeaderText = "Artist";
            this.TrackArtist.MinimumWidth = 8;
            this.TrackArtist.Name = "TrackArtist";
            this.TrackArtist.ReadOnly = true;
            // 
            // TrackAlbum
            // 
            this.TrackAlbum.DataPropertyName = "TrackAlbum";
            this.TrackAlbum.FillWeight = 103.6932F;
            this.TrackAlbum.HeaderText = "Album";
            this.TrackAlbum.MinimumWidth = 8;
            this.TrackAlbum.Name = "TrackAlbum";
            this.TrackAlbum.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "DurationString";
            this.Duration.FillWeight = 103.6932F;
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 8;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "UglyPlayer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayedRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TracksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Previous;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox LoadFiles;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TracksList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Playing;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.PictureBox PlayedRemaining;
        private System.Windows.Forms.PictureBox Details;
    }
}

