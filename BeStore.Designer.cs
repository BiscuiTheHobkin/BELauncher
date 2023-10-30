namespace BE_Launcher
{
    partial class BeStore
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(517, 0);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(3, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "BeStore";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(218, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(120, 16);
            textBox2.TabIndex = 31;
            textBox2.Text = "Welcome To BeStore !";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(6, 32);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 32;
            button2.Text = "BetterLoadingScreen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 162);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plugins";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuText;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(6, 61);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 34;
            button3.Text = "FlipScreen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(6, 90);
            button4.Name = "button4";
            button4.Size = new Size(124, 23);
            button4.TabIndex = 34;
            button4.Text = "HWID Spoof";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BeStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(544, 215);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BeStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeStore";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
    }
}