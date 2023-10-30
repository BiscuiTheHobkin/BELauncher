namespace BE_Launcher
{
    partial class BLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BLoader));
            VRWithLoader = new Button();
            PcWithLoader = new Button();
            PcNoLoader = new Button();
            VRNoLoader = new Button();
            CheckForUpdates = new Button();
            X = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // VRWithLoader
            // 
            VRWithLoader.FlatStyle = FlatStyle.Popup;
            VRWithLoader.ForeColor = SystemColors.ButtonFace;
            VRWithLoader.Location = new Point(43, 78);
            VRWithLoader.Name = "VRWithLoader";
            VRWithLoader.Size = new Size(136, 35);
            VRWithLoader.TabIndex = 1;
            VRWithLoader.Text = "VR - > Mods Loader";
            VRWithLoader.UseVisualStyleBackColor = true;
            VRWithLoader.Click += button2_Click;
            // 
            // PcWithLoader
            // 
            PcWithLoader.FlatStyle = FlatStyle.Popup;
            PcWithLoader.ForeColor = SystemColors.Control;
            PcWithLoader.Location = new Point(43, 24);
            PcWithLoader.Name = "PcWithLoader";
            PcWithLoader.Size = new Size(136, 37);
            PcWithLoader.TabIndex = 2;
            PcWithLoader.Text = "PC - > Mods Loader";
            PcWithLoader.UseVisualStyleBackColor = true;
            PcWithLoader.Click += button1_Click_1;
            // 
            // PcNoLoader
            // 
            PcNoLoader.FlatStyle = FlatStyle.Popup;
            PcNoLoader.ForeColor = SystemColors.Control;
            PcNoLoader.Location = new Point(131, 119);
            PcNoLoader.Name = "PcNoLoader";
            PcNoLoader.Size = new Size(101, 34);
            PcNoLoader.TabIndex = 3;
            PcNoLoader.Text = "PC - > NoMods";
            PcNoLoader.TextImageRelation = TextImageRelation.ImageBeforeText;
            PcNoLoader.UseVisualStyleBackColor = true;
            PcNoLoader.Click += button3_Click;
            // 
            // VRNoLoader
            // 
            VRNoLoader.FlatStyle = FlatStyle.Popup;
            VRNoLoader.ForeColor = SystemColors.Control;
            VRNoLoader.Location = new Point(3, 119);
            VRNoLoader.Name = "VRNoLoader";
            VRNoLoader.Size = new Size(100, 34);
            VRNoLoader.TabIndex = 4;
            VRNoLoader.Text = "VR - > NoMods";
            VRNoLoader.UseVisualStyleBackColor = true;
            VRNoLoader.Click += button4_Click;
            // 
            // CheckForUpdates
            // 
            CheckForUpdates.FlatStyle = FlatStyle.Popup;
            CheckForUpdates.ForeColor = SystemColors.Control;
            CheckForUpdates.Location = new Point(-1, 186);
            CheckForUpdates.Name = "CheckForUpdates";
            CheckForUpdates.Size = new Size(120, 26);
            CheckForUpdates.TabIndex = 5;
            CheckForUpdates.Text = "Check For Updates";
            CheckForUpdates.UseVisualStyleBackColor = true;
            CheckForUpdates.Click += button5_Click;
            // 
            // X
            // 
            X.FlatStyle = FlatStyle.Popup;
            X.ForeColor = Color.Red;
            X.Location = new Point(519, 0);
            X.Name = "X";
            X.Size = new Size(26, 23);
            X.TabIndex = 6;
            X.Text = "X";
            X.UseVisualStyleBackColor = true;
            X.Click += X_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(45, 16);
            textBox1.TabIndex = 7;
            textBox1.Text = "BLoader ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(238, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(306, 188);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(58, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 16);
            textBox2.TabIndex = 9;
            textBox2.Text = "[ Status : Detected ]";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(125, 186);
            button1.Name = "button1";
            button1.Size = new Size(107, 26);
            button1.TabIndex = 10;
            button1.Text = "BeStore";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuText;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(314, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 16);
            textBox3.TabIndex = 11;
            textBox3.Text = "Updates/ChangeLogs";
            // 
            // BLoader
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(546, 221);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(X);
            Controls.Add(CheckForUpdates);
            Controls.Add(VRNoLoader);
            Controls.Add(PcNoLoader);
            Controls.Add(PcWithLoader);
            Controls.Add(VRWithLoader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BLoader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BLoader Launcher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button VRWithLoader;
        private Button PcWithLoader;
        private Button PcNoLoader;
        private Button VRNoLoader;
        private Button CheckForUpdates;
        private Button X;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
    }
}