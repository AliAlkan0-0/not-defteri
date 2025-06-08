namespace NotDefteri
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 134);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Not Yaz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Katagori Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Katgoriler";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 249);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(407, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(407, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 462);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
