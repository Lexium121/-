namespace Vigener
{
    partial class Shifr
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
            Vigener = new Label();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Vigener
            // 
            Vigener.Dock = DockStyle.Top;
            Vigener.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Vigener.ForeColor = SystemColors.ActiveCaptionText;
            Vigener.Location = new Point(0, 0);
            Vigener.Name = "Vigener";
            Vigener.Size = new Size(1057, 67);
            Vigener.TabIndex = 0;
            Vigener.Text = "Виженер";
            Vigener.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(692, 106);
            button1.Name = "button1";
            button1.Size = new Size(294, 79);
            button1.TabIndex = 1;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(692, 206);
            button2.Name = "button2";
            button2.Size = new Size(294, 79);
            button2.TabIndex = 1;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(199, 199, 199);
            richTextBox1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(58, 106);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(628, 179);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(199, 199, 199);
            richTextBox2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(58, 348);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(628, 179);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(199, 199, 199);
            textBox1.Location = new Point(58, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(58, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "Ввод";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(58, 286);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Ключ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(58, 330);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Вывод";
            // 
            // Shifr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1057, 584);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Vigener);
            ForeColor = SystemColors.ControlDarkDark;
            MaximumSize = new Size(1073, 623);
            MinimumSize = new Size(1073, 623);
            Name = "Shifr";
            Text = "Шифр";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Vigener;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}