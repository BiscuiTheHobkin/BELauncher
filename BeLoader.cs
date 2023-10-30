using System.Diagnostics;
using System.Media;


namespace BE_Launcher
{
    public partial class BLoader : Form
    {
        public BLoader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/BGM.wav");
            simpleSound.PlayLooping();
            //string message = "The Loader Is Detected And You Will Be Ban If U Use It";
            //string title = "[ Detected ]";
            //MessageBox.Show(message, title);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "");
            System.Threading.Thread.Sleep(2000);
            //Process.Start("VRChat.exe", "--no-vr");
            System.Threading.Thread.Sleep(1000);
            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/ModLoader-Startup.wav");
            simpleSound.Play();
            System.Threading.Thread.Sleep(7000);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("VRHustler.exe", "");
            System.Threading.Thread.Sleep(3000);
            Process.Start("start_protected_game.exe", "");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("start_protected_game.exe", "");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("start_protected_game.exe", "--no-vr");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("VRHustlerUpdate.exe", "");
            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/Click.wav");
            simpleSound.Play();
            System.Threading.Thread.Sleep(1000);
            Application.Restart();

        }

        private void X_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"BlazeEngine/BLauncher/Audio/Launcher-Quit.wav");
            simpleSound.Play();
            System.Threading.Thread.Sleep(2000);
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeStore f2 = new BeStore();
            f2.Show();

        }
    }
}
