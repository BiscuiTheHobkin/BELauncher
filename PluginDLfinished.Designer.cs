namespace BE_Launcher
{
    partial class PluginDLfinished
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
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InfoText;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.Window;
            richTextBox2.Location = new Point(2, 13);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(177, 68);
            richTextBox2.TabIndex = 2;
            richTextBox2.TabStop = false;
            richTextBox2.Text = "               Downloaded !\n\nU need to move the dll to module before start :)";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(49, 87);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InfoText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(177, 73);
            richTextBox1.TabIndex = 2;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "               Downloaded !\n\nU need to move the dll to module before start :)";
            richTextBox1.TextChanged += richTextBox2_TextChanged;
            // 
            // PluginDLfinished
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(179, 116);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PluginDLfinished";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PluginDLfinished";
            Load += PluginDLfinished_Load;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox2;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}