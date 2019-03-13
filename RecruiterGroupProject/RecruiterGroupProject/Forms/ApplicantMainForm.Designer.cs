namespace RecruiterGroupProject
{
    partial class ApplicantMainForm
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
            this.MyResumesTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VacanciesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionResumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddResumeButton = new System.Windows.Forms.Button();
            this.EditResumeButton = new System.Windows.Forms.Button();
            this.DeleteResumeButton = new System.Windows.Forms.Button();
            this.RespondButton = new System.Windows.Forms.Button();
            this.UpdateResumeButton = new System.Windows.Forms.Button();
            this.UpdateVacanciesButton = new System.Windows.Forms.Button();
            this.UpdateRequestsButton = new System.Windows.Forms.Button();
            this.DeleteRequestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyResumesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacanciesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MyResumesTable
            // 
            this.MyResumesTable.AllowUserToAddRows = false;
            this.MyResumesTable.AllowUserToDeleteRows = false;
            this.MyResumesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyResumesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyResumesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.PositionColumn,
            this.SalaryColumn,
            this.EducationColumn,
            this.ExperienceColumn,
            this.LanguagesColumn,
            this.ShowColumn});
            this.MyResumesTable.Location = new System.Drawing.Point(40, 126);
            this.MyResumesTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MyResumesTable.MultiSelect = false;
            this.MyResumesTable.Name = "MyResumesTable";
            this.MyResumesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyResumesTable.Size = new System.Drawing.Size(2952, 458);
            this.MyResumesTable.TabIndex = 0;
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
            this.PositionColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои резюме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 656);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вакансии";
            // 
            // VacanciesTable
            // 
            this.VacanciesTable.AllowUserToAddRows = false;
            this.VacanciesTable.AllowUserToDeleteRows = false;
            this.VacanciesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VacanciesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VacanciesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CompanyColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.VacanciesTable.Location = new System.Drawing.Point(40, 694);
            this.VacanciesTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.VacanciesTable.MultiSelect = false;
            this.VacanciesTable.Name = "VacanciesTable";
            this.VacanciesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VacanciesTable.Size = new System.Drawing.Size(2952, 563);
            this.VacanciesTable.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.HeaderText = "Компания";
            this.CompanyColumn.Name = "CompanyColumn";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 1338);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заявки";
            // 
            // RequestsTable
            // 
            this.RequestsTable.AllowUserToAddRows = false;
            this.RequestsTable.AllowUserToDeleteRows = false;
            this.RequestsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RequestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Company_Column,
            this.IdPositionColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.IdResumeColumn,
            this.PositionResumeColumn});
            this.RequestsTable.Location = new System.Drawing.Point(40, 1376);
            this.RequestsTable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RequestsTable.MultiSelect = false;
            this.RequestsTable.Name = "RequestsTable";
            this.RequestsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestsTable.Size = new System.Drawing.Size(2952, 563);
            this.RequestsTable.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Company_Column
            // 
            this.Company_Column.HeaderText = "Компания";
            this.Company_Column.Name = "Company_Column";
            // 
            // IdPositionColumn
            // 
            this.IdPositionColumn.HeaderText = "ID Должности";
            this.IdPositionColumn.Name = "IdPositionColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Должность в вакансии";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Зарплата в вакансии";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Образование";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Опыт работы";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Языки";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // IdResumeColumn
            // 
            this.IdResumeColumn.HeaderText = "ID резюме";
            this.IdResumeColumn.Name = "IdResumeColumn";
            // 
            // PositionResumeColumn
            // 
            this.PositionResumeColumn.HeaderText = "Должность в резюме";
            this.PositionResumeColumn.Name = "PositionResumeColumn";
            // 
            // AddResumeButton
            // 
            this.AddResumeButton.Location = new System.Drawing.Point(2624, 45);
            this.AddResumeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddResumeButton.Name = "AddResumeButton";
            this.AddResumeButton.Size = new System.Drawing.Size(368, 72);
            this.AddResumeButton.TabIndex = 6;
            this.AddResumeButton.Text = "Добавить";
            this.AddResumeButton.UseVisualStyleBackColor = true;
            this.AddResumeButton.Click += new System.EventHandler(this.AddResumeButton_Click);
            // 
            // EditResumeButton
            // 
            this.EditResumeButton.Location = new System.Drawing.Point(2240, 45);
            this.EditResumeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EditResumeButton.Name = "EditResumeButton";
            this.EditResumeButton.Size = new System.Drawing.Size(368, 72);
            this.EditResumeButton.TabIndex = 7;
            this.EditResumeButton.Text = "Редактировать";
            this.EditResumeButton.UseVisualStyleBackColor = true;
            this.EditResumeButton.Click += new System.EventHandler(this.EditResumeButton_Click);
            // 
            // DeleteResumeButton
            // 
            this.DeleteResumeButton.Location = new System.Drawing.Point(1856, 45);
            this.DeleteResumeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteResumeButton.Name = "DeleteResumeButton";
            this.DeleteResumeButton.Size = new System.Drawing.Size(368, 72);
            this.DeleteResumeButton.TabIndex = 8;
            this.DeleteResumeButton.Text = "Удалить";
            this.DeleteResumeButton.UseVisualStyleBackColor = true;
            this.DeleteResumeButton.Click += new System.EventHandler(this.DeleteResumeButton_Click);
            // 
            // RespondButton
            // 
            this.RespondButton.Location = new System.Drawing.Point(2624, 608);
            this.RespondButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RespondButton.Name = "RespondButton";
            this.RespondButton.Size = new System.Drawing.Size(368, 72);
            this.RespondButton.TabIndex = 9;
            this.RespondButton.Text = "Откликнуться";
            this.RespondButton.UseVisualStyleBackColor = true;
            this.RespondButton.Click += new System.EventHandler(this.RespondButton_Click);
            // 
            // UpdateResumeButton
            // 
            this.UpdateResumeButton.Location = new System.Drawing.Point(1472, 45);
            this.UpdateResumeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateResumeButton.Name = "UpdateResumeButton";
            this.UpdateResumeButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateResumeButton.TabIndex = 10;
            this.UpdateResumeButton.Text = "Обновить";
            this.UpdateResumeButton.UseVisualStyleBackColor = true;
            this.UpdateResumeButton.Click += new System.EventHandler(this.UpdateResumeButton_Click);
            // 
            // UpdateVacanciesButton
            // 
            this.UpdateVacanciesButton.Location = new System.Drawing.Point(2240, 608);
            this.UpdateVacanciesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateVacanciesButton.Name = "UpdateVacanciesButton";
            this.UpdateVacanciesButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateVacanciesButton.TabIndex = 11;
            this.UpdateVacanciesButton.Text = "Обновить";
            this.UpdateVacanciesButton.UseVisualStyleBackColor = true;
            this.UpdateVacanciesButton.Click += new System.EventHandler(this.UpdateVacanciesButton_Click);
            // 
            // UpdateRequestsButton
            // 
            this.UpdateRequestsButton.Location = new System.Drawing.Point(2624, 1290);
            this.UpdateRequestsButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UpdateRequestsButton.Name = "UpdateRequestsButton";
            this.UpdateRequestsButton.Size = new System.Drawing.Size(368, 72);
            this.UpdateRequestsButton.TabIndex = 12;
            this.UpdateRequestsButton.Text = "Обновить";
            this.UpdateRequestsButton.UseVisualStyleBackColor = true;
            this.UpdateRequestsButton.Click += new System.EventHandler(this.UpdateRequestsButton_Click);
            // 
            // DeleteRequestButton
            // 
            this.DeleteRequestButton.Location = new System.Drawing.Point(2240, 1290);
            this.DeleteRequestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteRequestButton.Name = "DeleteRequestButton";
            this.DeleteRequestButton.Size = new System.Drawing.Size(368, 72);
            this.DeleteRequestButton.TabIndex = 13;
            this.DeleteRequestButton.Text = "Удалить";
            this.DeleteRequestButton.UseVisualStyleBackColor = true;
            this.DeleteRequestButton.Click += new System.EventHandler(this.DeleteRequestButton_Click);
            // 
            // ApplicantMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3109, 2005);
            this.Controls.Add(this.DeleteRequestButton);
            this.Controls.Add(this.UpdateRequestsButton);
            this.Controls.Add(this.UpdateVacanciesButton);
            this.Controls.Add(this.UpdateResumeButton);
            this.Controls.Add(this.RespondButton);
            this.Controls.Add(this.DeleteResumeButton);
            this.Controls.Add(this.EditResumeButton);
            this.Controls.Add(this.AddResumeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RequestsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VacanciesTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyResumesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ApplicantMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соискатель. Главная";
            this.Load += new System.EventHandler(this.ApplicantMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyResumesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VacanciesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyResumesTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VacanciesTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RequestsTable;
        private System.Windows.Forms.Button AddResumeButton;
        private System.Windows.Forms.Button EditResumeButton;
        private System.Windows.Forms.Button DeleteResumeButton;
        private System.Windows.Forms.Button RespondButton;
        private System.Windows.Forms.Button UpdateResumeButton;
        private System.Windows.Forms.Button UpdateVacanciesButton;
        private System.Windows.Forms.Button UpdateRequestsButton;
        private System.Windows.Forms.Button DeleteRequestButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionResumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguagesColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ShowColumn;
    }
}