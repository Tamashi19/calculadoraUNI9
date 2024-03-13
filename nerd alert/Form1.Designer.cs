namespace nerd_alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 53);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 4;
            label1.Text = "VALOR 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 188);
            label2.Name = "label2";
            label2.Size = new Size(229, 46);
            label2.TabIndex = 5;
            label2.Text = "RESULTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 122);
            label3.Name = "label3";
            label3.Size = new Size(162, 46);
            label3.TabIndex = 6;
            label3.Text = "VALOR 2";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(426, 66);
            button1.Name = "button1";
            button1.Size = new Size(61, 50);
            button1.TabIndex = 7;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(268, 99);
            label4.Name = "label4";
            label4.Size = new Size(0, 46);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(424, 131);
            button2.Name = "button2";
            button2.Size = new Size(63, 50);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(493, 66);
            button3.Name = "button3";
            button3.Size = new Size(56, 50);
            button3.TabIndex = 10;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gold;
            button4.Location = new Point(502, 131);
            button4.Name = "button4";
            button4.Size = new Size(47, 50);
            button4.TabIndex = 11;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(30, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CALCULADORA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
    }
}