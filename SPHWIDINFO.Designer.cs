namespace BE_Launcher
{
    partial class SPHWIDINFO
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(192, 26);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "U can spoof ur hwid with thi plugin";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(0, 69);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 1;
            button1.Text = "- Download -";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(112, 69);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 2;
            button2.Text = "- Close -";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SPHWIDINFO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(195, 93);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SPHWIDINFO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPHWIDINFO";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}