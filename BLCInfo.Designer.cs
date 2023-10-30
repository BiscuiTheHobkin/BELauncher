namespace BE_Launcher
{
    partial class BLCInfo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BLCInfo));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(12, 254);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 0;
            button1.Text = "- Download -";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.Info;
            button2.Location = new Point(151, 254);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 1;
            button2.Text = "- Closse -";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(84, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "- BLC Info -";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 197);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BLCInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(251, 289);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BLCInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BLCInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}