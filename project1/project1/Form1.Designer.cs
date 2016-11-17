namespace project1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tp1_label1 = new System.Windows.Forms.Label();
            this.Tp1_textBox1 = new System.Windows.Forms.TextBox();
            this.Tp1_textBox2 = new System.Windows.Forms.TextBox();
            this.Tp1_textBox3 = new System.Windows.Forms.TextBox();
            this.Tp1_button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tp2_button1 = new System.Windows.Forms.Button();
            this.Tp2_label1 = new System.Windows.Forms.Label();
            this.Tp2_textBox3 = new System.Windows.Forms.TextBox();
            this.Tp2_textBox2 = new System.Windows.Forms.TextBox();
            this.Tp2_textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tp1_label1
            // 
            this.Tp1_label1.AutoSize = true;
            this.Tp1_label1.Location = new System.Drawing.Point(243, 26);
            this.Tp1_label1.Name = "Tp1_label1";
            this.Tp1_label1.Size = new System.Drawing.Size(90, 13);
            this.Tp1_label1.TabIndex = 0;
            this.Tp1_label1.Text = "Сложение чисел";
            // 
            // Tp1_textBox1
            // 
            this.Tp1_textBox1.Location = new System.Drawing.Point(209, 74);
            this.Tp1_textBox1.Name = "Tp1_textBox1";
            this.Tp1_textBox1.Size = new System.Drawing.Size(156, 20);
            this.Tp1_textBox1.TabIndex = 1;
            // 
            // Tp1_textBox2
            // 
            this.Tp1_textBox2.Location = new System.Drawing.Point(209, 165);
            this.Tp1_textBox2.Name = "Tp1_textBox2";
            this.Tp1_textBox2.Size = new System.Drawing.Size(156, 20);
            this.Tp1_textBox2.TabIndex = 2;
            // 
            // Tp1_textBox3
            // 
            this.Tp1_textBox3.Location = new System.Drawing.Point(209, 315);
            this.Tp1_textBox3.Name = "Tp1_textBox3";
            this.Tp1_textBox3.Size = new System.Drawing.Size(156, 20);
            this.Tp1_textBox3.TabIndex = 3;
            // 
            // Tp1_button1
            // 
            this.Tp1_button1.Location = new System.Drawing.Point(246, 242);
            this.Tp1_button1.Name = "Tp1_button1";
            this.Tp1_button1.Size = new System.Drawing.Size(87, 30);
            this.Tp1_button1.TabIndex = 4;
            this.Tp1_button1.Text = "Вычислить";
            this.Tp1_button1.UseVisualStyleBackColor = true;
            this.Tp1_button1.Click += new System.EventHandler(this.Tp1_button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 425);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Tp1_textBox1);
            this.tabPage1.Controls.Add(this.Tp1_label1);
            this.tabPage1.Controls.Add(this.Tp1_textBox3);
            this.tabPage1.Controls.Add(this.Tp1_button1);
            this.tabPage1.Controls.Add(this.Tp1_textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сложение";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.Tp2_button1);
            this.tabPage2.Controls.Add(this.Tp2_label1);
            this.tabPage2.Controls.Add(this.Tp2_textBox3);
            this.tabPage2.Controls.Add(this.Tp2_textBox2);
            this.tabPage2.Controls.Add(this.Tp2_textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вычитание";
            // 
            // Tp2_button1
            // 
            this.Tp2_button1.Location = new System.Drawing.Point(245, 228);
            this.Tp2_button1.Name = "Tp2_button1";
            this.Tp2_button1.Size = new System.Drawing.Size(99, 31);
            this.Tp2_button1.TabIndex = 4;
            this.Tp2_button1.Text = "Вычислить";
            this.Tp2_button1.UseVisualStyleBackColor = true;
            this.Tp2_button1.Click += new System.EventHandler(this.Tp2_button1_Click);
            // 
            // Tp2_label1
            // 
            this.Tp2_label1.AutoSize = true;
            this.Tp2_label1.Location = new System.Drawing.Point(258, 28);
            this.Tp2_label1.Name = "Tp2_label1";
            this.Tp2_label1.Size = new System.Drawing.Size(62, 13);
            this.Tp2_label1.TabIndex = 3;
            this.Tp2_label1.Text = "Вычитание";
            // 
            // Tp2_textBox3
            // 
            this.Tp2_textBox3.Location = new System.Drawing.Point(205, 305);
            this.Tp2_textBox3.Name = "Tp2_textBox3";
            this.Tp2_textBox3.Size = new System.Drawing.Size(181, 20);
            this.Tp2_textBox3.TabIndex = 2;
            // 
            // Tp2_textBox2
            // 
            this.Tp2_textBox2.Location = new System.Drawing.Point(205, 135);
            this.Tp2_textBox2.Name = "Tp2_textBox2";
            this.Tp2_textBox2.Size = new System.Drawing.Size(181, 20);
            this.Tp2_textBox2.TabIndex = 1;
            // 
            // Tp2_textBox1
            // 
            this.Tp2_textBox1.Location = new System.Drawing.Point(205, 72);
            this.Tp2_textBox1.Name = "Tp2_textBox1";
            this.Tp2_textBox1.Size = new System.Drawing.Size(181, 20);
            this.Tp2_textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(573, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 331);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Project";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tp1_label1;
        private System.Windows.Forms.TextBox Tp1_textBox1;
        private System.Windows.Forms.TextBox Tp1_textBox2;
        private System.Windows.Forms.TextBox Tp1_textBox3;
        private System.Windows.Forms.Button Tp1_button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Tp2_button1;
        private System.Windows.Forms.Label Tp2_label1;
        private System.Windows.Forms.TextBox Tp2_textBox3;
        private System.Windows.Forms.TextBox Tp2_textBox2;
        private System.Windows.Forms.TextBox Tp2_textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

