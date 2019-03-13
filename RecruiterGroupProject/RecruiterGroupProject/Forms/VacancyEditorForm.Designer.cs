namespace RecruiterGroupProject
{
    partial class VacancyEditorForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.LanguageNumeric = new System.Windows.Forms.NumericUpDown();
            this.ExperienceNumeric = new System.Windows.Forms.NumericUpDown();
            this.EducationNumeric = new System.Windows.Forms.NumericUpDown();
            this.ShowVacancyCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(667, 579);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(299, 79);
            this.CancelButton.TabIndex = 42;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(981, 579);
            this.EditButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(299, 79);
            this.EditButton.TabIndex = 41;
            this.EditButton.Text = "Сохранить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LanguageNumeric
            // 
            this.LanguageNumeric.Location = new System.Drawing.Point(411, 432);
            this.LanguageNumeric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LanguageNumeric.Name = "LanguageNumeric";
            this.LanguageNumeric.Size = new System.Drawing.Size(227, 38);
            this.LanguageNumeric.TabIndex = 40;
            // 
            // ExperienceNumeric
            // 
            this.ExperienceNumeric.Location = new System.Drawing.Point(411, 339);
            this.ExperienceNumeric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ExperienceNumeric.Name = "ExperienceNumeric";
            this.ExperienceNumeric.Size = new System.Drawing.Size(227, 38);
            this.ExperienceNumeric.TabIndex = 39;
            // 
            // EducationNumeric
            // 
            this.EducationNumeric.Location = new System.Drawing.Point(411, 253);
            this.EducationNumeric.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EducationNumeric.Name = "EducationNumeric";
            this.EducationNumeric.Size = new System.Drawing.Size(227, 38);
            this.EducationNumeric.TabIndex = 38;
            // 
            // ShowVacancyCheckBox
            // 
            this.ShowVacancyCheckBox.AutoSize = true;
            this.ShowVacancyCheckBox.Location = new System.Drawing.Point(411, 525);
            this.ShowVacancyCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ShowVacancyCheckBox.Name = "ShowVacancyCheckBox";
            this.ShowVacancyCheckBox.Size = new System.Drawing.Size(347, 36);
            this.ShowVacancyCheckBox.TabIndex = 37;
            this.ShowVacancyCheckBox.Text = "Показывать вакансию";
            this.ShowVacancyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Языки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Опыт работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Образование";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(411, 165);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(865, 38);
            this.SalaryTextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Зарплата";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(411, 76);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(865, 38);
            this.PositionTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Должность";
            // 
            // VacancyEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 754);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LanguageNumeric);
            this.Controls.Add(this.ExperienceNumeric);
            this.Controls.Add(this.EducationNumeric);
            this.Controls.Add(this.ShowVacancyCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "VacancyEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование вакансии";
            this.Load += new System.EventHandler(this.VacancyEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LanguageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExperienceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EducationNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.NumericUpDown LanguageNumeric;
        private System.Windows.Forms.NumericUpDown ExperienceNumeric;
        private System.Windows.Forms.NumericUpDown EducationNumeric;
        private System.Windows.Forms.CheckBox ShowVacancyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label1;
    }
}