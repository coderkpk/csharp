namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create Global Variables of String type arrays  to store the paths of songs and their names
        String[] paths, files;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to close the app
            this.Close();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to select songs 
            OpenFileDialog ofd = new OpenFileDialog();
            //to allow multiselect of songs
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Store the names of the songs in files array
                paths = ofd.FileNames; //Store the paths of the songs in paths array
                //Display music tiles in listboc
                for (int i = 0; i < files.Length; i++)
                {
                    //Add the names of the songs to the listbox
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write to code to play the selected song
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];

        }
          
    }
}
