namespace probnayaIgra
{
    partial class FormGameOfWords
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
            this.lblright = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.Location = new System.Drawing.Point(12, 31);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(133, 15);
            this.lblright.TabIndex = 0;
            this.lblright.Text = "Правильных ответов: 0";
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Location = new System.Drawing.Point(463, 31);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(146, 15);
            this.lblwrong.TabIndex = 1;
            this.lblwrong.Text = "Неправильных ответов: 0";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblword.Location = new System.Drawing.Point(276, 159);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(96, 37);
            this.lblword.TabIndex = 2;
            this.lblword.Text = "Слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Нажмите Enter чтобы проверить текст со словом";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(152, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 43);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // FormGameOfWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblright);
            this.Name = "FormGameOfWords";
            this.Text = "Игра в слова";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblright;
        private Label lblwrong;
        private Label lblword;
        private Label label4;
        private TextBox textBox1;
    }
}