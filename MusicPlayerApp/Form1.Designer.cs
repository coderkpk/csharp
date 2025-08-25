namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            lblFooter = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.PaleTurquoise;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(lblLogo);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 40);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(754, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(22, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(148, 22);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "My Music Player";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 21;
            listBoxSongs.Location = new Point(535, 46);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(253, 340);
            listBoxSongs.TabIndex = 1;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.Location = new Point(535, 392);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(253, 46);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Select Songs";
            btnSelectSongs.UseVisualStyleBackColor = true;
            btnSelectSongs.Click += btnSelectSongs_Click;
            // 
            // axWindowsMediaPlayerMusic
            // 
            axWindowsMediaPlayerMusic.Enabled = true;
            axWindowsMediaPlayerMusic.Location = new Point(12, 46);
            axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            axWindowsMediaPlayerMusic.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayerMusic.OcxState");
            axWindowsMediaPlayerMusic.Size = new Size(508, 392);
            axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.BackColor = Color.Transparent;
            lblFooter.ForeColor = SystemColors.ControlDarkDark;
            lblFooter.Location = new Point(305, 451);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(167, 20);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "Developed by coderkpk";
            // 
            // MusicPlayerApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(lblFooter);
            Controls.Add(axWindowsMediaPlayerMusic);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Player App";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayerMusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label lblLogo;
        private PictureBox pictureBox1;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private Label lblFooter;
    }
}
