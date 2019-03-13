namespace RecruiterGroupProject
{
    partial class ApplicantRegisterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.Почта = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RegisterApplicantButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(275, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 78);
            this.label3.TabIndex = 5;
            this.label3.Text = "Head Hunter Adaptor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(397, 129);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(593, 38);
            this.LoginTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // PasswordMaskBox
            // 
            this.PasswordMaskBox.Location = new System.Drawing.Point(397, 193);
            this.PasswordMaskBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordMaskBox.Name = "PasswordMaskBox";
            this.PasswordMaskBox.PasswordChar = '*';
            this.PasswordMaskBox.Size = new System.Drawing.Size(593, 38);
            this.PasswordMaskBox.TabIndex = 9;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(397, 260);
            this.RepeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(593, 38);
            this.RepeatPasswordTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Повторите пароль";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(397, 334);
            this.FioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(593, 38);
            this.FioTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Телефон";
            // 
            // PhoneMaskBox
            // 
            this.PhoneMaskBox.Location = new System.Drawing.Point(400, 408);
            this.PhoneMaskBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneMaskBox.Mask = "(999) 000-0000";
            this.PhoneMaskBox.Name = "PhoneMaskBox";
            this.PhoneMaskBox.Size = new System.Drawing.Size(593, 38);
            this.PhoneMaskBox.TabIndex = 17;
            // 
            // Почта
            // 
            this.Почта.AutoSize = true;
            this.Почта.Location = new System.Drawing.Point(77, 489);
            this.Почта.Name = "Почта";
            this.Почта.Size = new System.Drawing.Size(96, 32);
            this.Почта.TabIndex = 18;
            this.Почта.Text = "E-Mail";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(400, 482);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(593, 38);
            this.EmailTextBox.TabIndex = 19;
            // 
            // RegisterApplicantButton
            // 
            this.RegisterApplicantButton.Location = new System.Drawing.Point(693, 572);
            this.RegisterApplicantButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RegisterApplicantButton.Name = "RegisterApplicantButton";
            this.RegisterApplicantButton.Size = new System.Drawing.Size(304, 88);
            this.RegisterApplicantButton.TabIndex = 20;
            this.RegisterApplicantButton.Text = "Зарегистрировать";
            this.RegisterApplicantButton.UseVisualStyleBackColor = true;
            this.RegisterApplicantButton.Click += new System.EventHandler(this.RegisterApplicantButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(400, 572);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(277, 88);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplicantRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 734);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterApplicantButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.Почта);
            this.Controls.Add(this.PhoneMaskBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordMaskBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplicantRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация соискателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PasswordMaskBox;
        private System.Windows.Forms.MaskedTextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PhoneMaskBox;
        private System.Windows.Forms.Label Почта;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button RegisterApplicantButton;
        private System.Windows.Forms.Button CancelButton;
    }
}