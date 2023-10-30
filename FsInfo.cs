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
    public partial class FsInfo : Form
    {
        public FsInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())

                client.DownloadFile("https://www.icefrag.ru/openfiles/FlipScreen.dll", "FlipScreen.dll");
            this.Hide();
            System.Threading.Thread.Sleep(100);
            PluginDLfinished f2 = new PluginDLfinished();
            f2.Show();
        }
    }
}
