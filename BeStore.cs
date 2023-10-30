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
    public partial class BeStore : Form
    {
        public BeStore()
        {
            InitializeComponent();
        }

        public object Me { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            BLCInfo f2 = new BLCInfo();
            f2.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FsInfo f2 = new FsInfo();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          SPHWIDINFO f2 = new SPHWIDINFO();
            f2.Show();
        }
    }
}
