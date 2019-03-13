namespace RecruiterGroupProject
{
    partial class EmployerMainForm
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
            this.UpdateRequestsButton = new System.Windows.Forms.Button();
            this.UpdateResumesButton = new System.Windows.Forms.Button();
            this.UpdateVacanciesButton = new System.Windows.Forms.Button();
            this.DeleteVacancyButton = new System.Windows.Forms.Button();
            this.EditVacancyButton = new System.Windows.Forms.Button();
            this.AddVacancyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVacancyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionVacancyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResume_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionResume_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienceResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguagesResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ResumesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MyVacanciesTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyVacanciesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateRequestsButton
            // 
            this.UpdateRequestsButton.Location = new System.Drawing.Point(2667, 1278);
            this.UpdateRequestsButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateRequestsButton.Name = "UpdateRequestsButton";
            this.UpdateRequestsButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateRequestsButton.TabIndex = 26;
            this.UpdateRequestsButton.Text = "Обновить";
            this.UpdateRequestsButton.UseVisualStyleBackColor = true;
            this.UpdateRequestsButton.Click += new System.EventHandler(this.UpdateRequestsButton_Click);
            // 
            // UpdateResumesButton
            // 
            this.UpdateResumesButton.Location = new System.Drawing.Point(2667, 603);
            this.UpdateResumesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateResumesButton.Name = "UpdateResumesButton";
            this.UpdateResumesButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateResumesButton.TabIndex = 25;
            this.UpdateResumesButton.Text = "Обновить";
            this.UpdateResumesButton.UseVisualStyleBackColor = true;
            this.UpdateResumesButton.Click += new System.EventHandler(this.UpdateResumesButton_Click);
            // 
            // UpdateVacanciesButton
            // 
            this.UpdateVacanciesButton.Location = new System.Drawing.Point(1515, 33);
            this.UpdateVacanciesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateVacanciesButton.Name = "UpdateVacanciesButton";
            this.UpdateVacanciesButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateVacanciesButton.TabIndex = 24;
            this.UpdateVacanciesButton.Text = "Обновить";
            this.UpdateVacanciesButton.UseVisualStyleBackColor = true;
            this.UpdateVacanciesButton.Click += new System.EventHandler(this.UpdateVacanciesButton_Click);
            // 
            // DeleteVacancyButton
            // 
            this.DeleteVacancyButton.Location = new System.Drawing.Point(1899, 33);
            this.DeleteVacancyButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteVacancyButton.Name = "DeleteVacancyButton";
            this.DeleteVacancyButton.Size = new System.Drawing.Size(368, 72);
            this.DeleteVacancyButton.TabIndex = 22;
            this.DeleteVacancyButton.Text = "Удалить";
            this.DeleteVacancyButton.UseVisualStyleBackColor = true;
            this.DeleteVacancyButton.Click += new System.EventHandler(this.DeleteVacancyButton_Click);
            // 
            // EditVacancyButton
            // 
            this.EditVacancyButton.Location = new System.Drawing.Point(2283, 33);
            this.EditVacancyButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EditVacancyButton.Name = "EditVacancyButton";
            this.EditVacancyButton.Size = new System.Drawing.Size(368, 72);
            this.EditVacancyButton.TabIndex = 21;
            this.EditVacancyButton.Text = "Редактировать";
            this.EditVacancyButton.UseVisualStyleBackColor = true;
            this.EditVacancyButton.Click += new System.EventHandler(this.EditVacancyButton_Click);
            // 
            // AddVacancyButton
            // 
            this.AddVacancyButton.Location = new System.Drawing.Point(2667, 33);
            this.AddVacancyButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddVacancyButton.Name = "AddVacancyButton";
            this.AddVacancyButton.Size = new System.Drawing.Size(368, 72);
            this.AddVacancyButton.TabIndex = 20;
            this.AddVacancyButton.Text = "Добавить";
            this.AddVacancyButton.UseVisualStyleBackColor = true;
            this.AddVacancyButton.Click += new System.EventHandler(this.AddVacancyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 1326);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Заявки";
            // 
            // RequestsTable
            // 
            this.RequestsTable.AllowUserToAddRows = false;
            this.RequestsTable.AllowUserToDeleteRows = false;
            this.RequestsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RequestsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.IdVacancyColumn,
            this.PositionVacancyColumn,
            this.dataGridViewTextBoxColumn8,
            this.IdResume_Column,
            this.PositionResume_Column,
            this.SalaryResumeColumn,
            this.EducationResumeColumn,
            this.ExperienceResumeColumn,
            this.LanguagesResumeColumn});
            this.RequestsTable.Location = new System.Drawing.Point(83, 1364);
            this.RequestsTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RequestsTable.MultiSelect = false;
            this.RequestsTable.Name = "RequestsTable";
            this.RequestsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestsTable.Size = new System.Drawing.Size(2952, 563);
            this.RequestsTable.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // IdVacancyColumn
            // 
            this.IdVacancyColumn.HeaderText = "ИД вакансии";
            this.IdVacancyColumn.Name = "IdVacancyColumn";
            // 
            // PositionVacancyColumn
            // 
            this.PositionVacancyColumn.HeaderText = "Должность";
            this.PositionVacancyColumn.Name = "PositionVacancyColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // IdResume_Column
            // 
            this.IdResume_Column.HeaderText = "ID Резюме";
            this.IdResume_Column.Name = "IdResume_Column";
            // 
            // PositionResume_Column
            // 
            this.PositionResume_Column.HeaderText = "Должность в резюме";
            this.PositionResume_Column.Name = "PositionResume_Column";
            // 
            // SalaryResumeColumn
            // 
            this.SalaryResumeColumn.HeaderText = "Зарплата в резюме";
            this.SalaryResumeColumn.Name = "SalaryResumeColumn";
            // 
            // EducationResumeColumn
            // 
            this.EducationResumeColumn.HeaderText = "Образование";
            this.EducationResumeColumn.Name = "EducationResumeColumn";
            // 
            // ExperienceResumeColumn
            // 
            this.ExperienceResumeColumn.HeaderText = "Опыт работы";
            this.ExperienceResumeColumn.Name = "ExperienceResumeColumn";
            // 
            // LanguagesResumeColumn
            // 
            this.LanguagesResumeColumn.HeaderText = "Языки";
            this.LanguagesResumeColumn.Name = "LanguagesResumeColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 644);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Резюме пользователей";
            // 
            // ResumesTable
            // 
            this.ResumesTable.AllowUserToAddRows = false;
            this.ResumesTable.AllowUserToDeleteRows = false;
            this.ResumesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResumesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResumesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.LoginColumn,
            this.FIOColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ResumesTable.Location = new System.Drawing.Point(83, 682);
            this.ResumesTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ResumesTable.MultiSelect = false;
            this.ResumesTable.Name = "ResumesTable";
            this.ResumesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResumesTable.Size = new System.Drawing.Size(2952, 563);
            this.ResumesTable.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // LoginColumn
            // 
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            // 
            // FIOColumn
            // 
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Образование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Опыт работы";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Языки";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Мои вакансии";
            // 
            // MyVacanciesTable
            // 
            this.MyVacanciesTable.AllowUserToAddRows = false;
            this.MyVacanciesTable.AllowUserToDeleteRows = false;
            this.MyVacanciesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyVacanciesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyVacanciesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.PositionColumn,
            this.SalaryColumn,
            this.EducationColumn,
            this.ExperienceColumn,
            this.LanguagesColumn,
            this.ShowColumn});
            this.MyVacanciesTable.Location = new System.Drawing.Point(83, 114);
            this.MyVacanciesTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MyVacanciesTable.MultiSelect = false;
            this.MyVacanciesTable.Name = "MyVacanciesTable";
            this.MyVacanciesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyVacanciesTable.Size = new System.Drawing.Size(2952, 458);
            this.MyVacanciesTable.TabIndex = 14;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            // 
            // PositionColumn
            // 
            this.PositionColumn.HeaderText = "Должность";
            this.PositionColumn.Name = "PositionColumn";
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Зарплата";
            this.SalaryColumn.Name = "SalaryColumn";
            // 
            // EducationColumn
            // 
            this.EducationColumn.HeaderText = "Образование";
            this.EducationColumn.Name = "EducationColumn";
            // 
            // ExperienceColumn
            // 
            this.ExperienceColumn.HeaderText = "Опыт работы";
            this.ExperienceColumn.Name = "ExperienceColumn";
            // 
            // LanguagesColumn
            // 
            this.LanguagesColumn.HeaderText = "Языки";
            this.LanguagesColumn.Name = "LanguagesColumn";
            // 
            // ShowColumn
            // 
            this.ShowColumn.HeaderText = "Видимость";
            this.ShowColumn.Name = "ShowColumn";
            // 
            // EmployerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3109, 1960);
            this.Controls.Add(this.UpdateRequestsButton);
            this.Controls.Add(this.UpdateResumesButton);
            this.Controls.Add(this.UpdateVacanciesButton);
            this.Controls.Add(this.DeleteVacancyButton);
            this.Controls.Add(this.EditVacancyButton);
            this.Controls.Add(this.AddVacancyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RequestsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResumesTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyVacanciesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EmployerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работодатель. Главная";
            this.Load += new System.EventHandler(this.EmployerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyVacanciesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateRequestsButton;
        private System.Windows.Forms.Button UpdateResumesButton;
        private System.Windows.Forms.Button UpdateVacanciesButton;
        private System.Windows.Forms.Button DeleteVacancyButton;
        private System.Windows.Forms.Button EditVacancyButton;
        private System.Windows.Forms.Button AddVacancyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RequestsTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResumesTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MyVacanciesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVacancyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionVacancyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResume_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionResume_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienceResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguagesResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguagesColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ShowColumn;
    }
}