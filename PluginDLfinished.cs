using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE_Launcher
{
    public partial class PluginDLfinished : Form
    {
        public PluginDLfinished()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PluginDLfinished_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/Notif7.wav");
            simpleSound.Play();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"Modules");
            this.Hide();
            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/BGM.wav");
            simpleSound.Play();
        }
    }
}
