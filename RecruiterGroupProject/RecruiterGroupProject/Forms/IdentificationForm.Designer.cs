namespace RecruiterGroupProject
{
    partial class IdentificationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdentifyButton = new System.Windows.Forms.Button();
            this.RegisterApplicantButton = new System.Windows.Forms.Button();
            this.RegisterEmployerButton = new System.Windows.Forms.Button();
            this.PasswordMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(235, 231);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(580, 38);
            this.LoginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(120, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 78);
            this.label3.TabIndex = 4;
            this.label3.Text = "Head Hunter Adaptor";
            // 
            // IdentifyButton
            // 
            this.IdentifyButton.Location = new System.Drawing.Point(120, 379);
            this.IdentifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdentifyButton.Name = "IdentifyButton";
            this.IdentifyButton.Size = new System.Drawing.Size(696, 76);
            this.IdentifyButton.TabIndex = 5;
            this.IdentifyButton.Text = "Войти";
            this.IdentifyButton.UseVisualStyleBackColor = true;
            this.IdentifyButton.Click += new System.EventHandler(this.IdentifyButton_Click);
            // 
            // RegisterApplicantButton
            // 
            this.RegisterApplicantButton.Location = new System.Drawing.Point(120, 484);
            this.RegisterApplicantButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterApplicantButton.Name = "RegisterApplicantButton";
            this.RegisterApplicantButton.Size = new System.Drawing.Size(336, 114);
            this.RegisterApplicantButton.TabIndex = 6;
            this.RegisterApplicantButton.Text = "Зарегистрироваться как соискатель";
            this.RegisterApplicantButton.UseVisualStyleBackColor = true;
            this.RegisterApplicantButton.Click += new System.EventHandler(this.RegisterApplicantButton_Click);
            // 
            // RegisterEmployerButton
            // 
            this.RegisterEmployerButton.Location = new System.Drawing.Point(477, 484);
            this.RegisterEmployerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterEmployerButton.Name = "RegisterEmployerButton";
            this.RegisterEmployerButton.Size = new System.Drawing.Size(336, 114);
            this.RegisterEmployerButton.TabIndex = 7;
            this.RegisterEmployerButton.Text = "Зарегистрироваться как работодатель";
            this.RegisterEmployerButton.UseVisualStyleBackColor = true;
            this.RegisterEmployerButton.Click += new System.EventHandler(this.RegisterEmployerButton_Click);
            // 
            // PasswordMaskBox
            // 
            this.PasswordMaskBox.Location = new System.Drawing.Point(235, 308);
            this.PasswordMaskBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordMaskBox.Name = "PasswordMaskBox";
            this.PasswordMaskBox.PasswordChar = '*';
            this.PasswordMaskBox.Size = new System.Drawing.Size(580, 38);
            this.PasswordMaskBox.TabIndex = 8;
            // 
            // IdentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 651);
            this.Controls.Add(this.PasswordMaskBox);
            this.Controls.Add(this.RegisterEmployerButton);
            this.Controls.Add(this.RegisterApplicantButton);
            this.Controls.Add(this.IdentifyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IdentificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Идентификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IdentifyButton;
        private System.Windows.Forms.Button RegisterApplicantButton;
        private System.Windows.Forms.Button RegisterEmployerButton;
        private System.Windows.Forms.MaskedTextBox PasswordMaskBox;
    }
}

