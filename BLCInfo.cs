using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE_Launcher
{
    public partial class BLCInfo : Form
    {
        public BLCInfo()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var client = new WebClient())

            client.DownloadFile("https://www.icefrag.ru/openfiles/BetterLoadingScreen.dll", "BetterLoadingScreen.dll");
            this.Hide();
            System.Threading.Thread.Sleep(100);
            PluginDLfinished f2 = new PluginDLfinished();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
