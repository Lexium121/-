namespace Vigener
{
    partial class Analyz
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
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gainsboro;
            richTextBox1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(54, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(405, 177);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Gainsboro;
            richTextBox2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(54, 361);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(405, 177);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 81);
            label1.TabIndex = 1;
            label1.Text = "Криптоанализ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(475, 205);
            button1.Name = "button1";
            button1.Size = new Size(272, 80);
            button1.TabIndex = 3;
            button1.Text = "Криптоанализ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 4;
            label2.Text = "Зашифрованный текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 296);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 4;
            label3.Text = "Предполагаемый ключ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 343);
            label4.Name = "label4";
            label4.Size = new Size(240, 15);
            label4.TabIndex = 4;
            label4.Text = "Предполагаемый расшифрованный текст";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(475, 361);
            button2.Name = "button2";
            button2.Size = new Size(272, 80);
            button2.TabIndex = 6;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(405, 23);
            comboBox1.TabIndex = 7;
            // 
            // Analyz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(804, 579);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            MaximumSize = new Size(820, 618);
            MinimumSize = new Size(820, 618);
            Name = "Analyz";
            Text = "Криптоанализ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ComboBox comboBox1;
    }
}