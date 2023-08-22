using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        // Create global variables of String type array to save the titles or name of the tracks and path of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple files
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Save the names of the tracks in files array
                paths = ofd.FileNames; // Save the paths of the tracks in paths array

                // Display the music titles in ListBox
                for(int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Display songs in ListBox

                }

            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code to close the app
            this.Close();
        }
    }
}
