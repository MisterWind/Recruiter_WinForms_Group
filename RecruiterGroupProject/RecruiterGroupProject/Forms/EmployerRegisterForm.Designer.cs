namespace RecruiterGroupProject
{
    partial class EmployerRegisterForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.RegisterEmployerButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Почта = new System.Windows.Forms.Label();
            this.PhoneMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Byajh = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeCombobox = new System.Windows.Forms.ComboBox();
            this.AreaCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InnTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(429, 830);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(277, 88);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterEmployerButton
            // 
            this.RegisterEmployerButton.Location = new System.Drawing.Point(728, 830);
            this.RegisterEmployerButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RegisterEmployerButton.Name = "RegisterEmployerButton";
            this.RegisterEmployerButton.Size = new System.Drawing.Size(304, 88);
            this.RegisterEmployerButton.TabIndex = 37;
            this.RegisterEmployerButton.Text = "Зарегистрировать";
            this.RegisterEmployerButton.UseVisualStyleBackColor = true;
            this.RegisterEmployerButton.Click += new System.EventHandler(this.RegisterEmployerButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(432, 732);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(593, 38);
            this.EmailTextBox.TabIndex = 36;
            // 
            // Почта
            // 
            this.Почта.AutoSize = true;
            this.Почта.Location = new System.Drawing.Point(80, 739);
            this.Почта.Name = "Почта";
            this.Почта.Size = new System.Drawing.Size(96, 32);
            this.Почта.TabIndex = 35;
            this.Почта.Text = "E-Mail";
            // 
            // PhoneMaskBox
            // 
            this.PhoneMaskBox.Location = new System.Drawing.Point(432, 658);
            this.PhoneMaskBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneMaskBox.Mask = "(999) 000-0000";
            this.PhoneMaskBox.Name = "PhoneMaskBox";
            this.PhoneMaskBox.Size = new System.Drawing.Size(593, 38);
            this.PhoneMaskBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Телефон";
            // 
            // Byajh
            // 
            this.Byajh.AutoSize = true;
            this.Byajh.Location = new System.Drawing.Point(80, 525);
            this.Byajh.Name = "Byajh";
            this.Byajh.Size = new System.Drawing.Size(240, 32);
            this.Byajh.TabIndex = 31;
            this.Byajh.Text = "Тип организации";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(432, 374);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(593, 38);
            this.NameTextBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Название организации";
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(432, 300);
            this.RepeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(593, 38);
            this.RepeatPasswordTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Повторите пароль";
            // 
            // PasswordMaskBox
            // 
            this.PasswordMaskBox.Location = new System.Drawing.Point(432, 234);
            this.PasswordMaskBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordMaskBox.Name = "PasswordMaskBox";
            this.PasswordMaskBox.PasswordChar = '*';
            this.PasswordMaskBox.Size = new System.Drawing.Size(593, 38);
            this.PasswordMaskBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(432, 169);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(593, 38);
            this.LoginTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(309, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 78);
            this.label3.TabIndex = 22;
            this.label3.Text = "Head Hunter Adaptor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 39;
            this.label7.Text = "Область";
            // 
            // TypeCombobox
            // 
            this.TypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCombobox.FormattingEnabled = true;
            this.TypeCombobox.Items.AddRange(new object[] {
            "ЗАО",
            "ОАО",
            "ООО",
            "ГУП",
            "ГУЗ",
            "СОШ",
            "ДШО",
            "Другое"});
            this.TypeCombobox.Location = new System.Drawing.Point(429, 517);
            this.TypeCombobox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TypeCombobox.Name = "TypeCombobox";
            this.TypeCombobox.Size = new System.Drawing.Size(596, 39);
            this.TypeCombobox.TabIndex = 40;
            // 
            // AreaCombobox
            // 
            this.AreaCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaCombobox.FormattingEnabled = true;
            this.AreaCombobox.Items.AddRange(new object[] {
            "Разработка программного обеспечения",
            "Бухгалтерия",
            "Подбор персонала",
            "Банковая деятельность",
            "Автомобильный бизнес",
            "Безопасность",
            "Добыча сырья",
            "Консультирование",
            "Образование"});
            this.AreaCombobox.Location = new System.Drawing.Point(429, 579);
            this.AreaCombobox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AreaCombobox.Name = "AreaCombobox";
            this.AreaCombobox.Size = new System.Drawing.Size(596, 39);
            this.AreaCombobox.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 32);
            this.label8.TabIndex = 42;
            this.label8.Text = "ИНН организации";
            // 
            // InnTextBox
            // 
            this.InnTextBox.Location = new System.Drawing.Point(432, 441);
            this.InnTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InnTextBox.Name = "InnTextBox";
            this.InnTextBox.Size = new System.Drawing.Size(593, 38);
            this.InnTextBox.TabIndex = 43;
            // 
            // EmployerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 1021);
            this.Controls.Add(this.InnTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AreaCombobox);
            this.Controls.Add(this.TypeCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterEmployerButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.Почта);
            this.Controls.Add(this.PhoneMaskBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Byajh);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordMaskBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EmployerRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация работодателя";
            this.Load += new System.EventHandler(this.EmployerRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RegisterEmployerButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Почта;
        private System.Windows.Forms.MaskedTextBox PhoneMaskBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Byajh;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PasswordMaskBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TypeCombobox;
        private System.Windows.Forms.ComboBox AreaCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InnTextBox;
    }
}