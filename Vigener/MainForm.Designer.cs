namespace Vigener
{
    partial class MainForm
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
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(428, 222);
            button1.Name = "button1";
            button1.Size = new Size(308, 133);
            button1.TabIndex = 0;
            button1.Text = "Криптоанализ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(42, 222);
            button2.Name = "button2";
            button2.Size = new Size(308, 133);
            button2.TabIndex = 0;
            button2.Text = "Шифр";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 69);
            label1.Name = "label1";
            label1.Size = new Size(576, 40);
            label1.TabIndex = 1;
            label1.Text = "Какое действие вы хотите совершить?";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}