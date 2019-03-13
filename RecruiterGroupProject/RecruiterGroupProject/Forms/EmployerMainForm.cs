using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecruiterGroupProject.Services;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Models.Repositories;

namespace RecruiterGroupProject
{
    public partial class EmployerMainForm : Form
    {
        private DataService service;
        private Employer employer;
        private ApplicantRepository appRepos;
        private EmployerRepository empRepos;
        private VacancyRepository vacRepos;
        private ResumeRepository resRepos;
        private RequestRepository reqRepos;
        private Vacancy[] vacancies;
        private Resume[] resumes;
        private Request[] requests;

        public EmployerMainForm(DataService service, Employer employer)
        {
            this.service = service;
            this.employer = employer;
            this.appRepos = new ApplicantRepository(this.service);
            this.empRepos = new EmployerRepository(this.service);
            this.vacRepos = new VacancyRepository(this.service);
            this.resRepos = new ResumeRepository(this.service);
            this.reqRepos = new RequestRepository(this.service);
            this.vacancies = vacRepos.VacanciesByLogin(this.employer.Login);
            this.resumes = resRepos.ShownResumes();
            this.requests = reqRepos.RequestsByEmployer(vacRepos, this.employer.Login);
            InitializeComponent();
        }

        private void EmployerMainForm_Load(object sender, EventArgs e)
        {
            this.FullfillMyVacanciesTable();
            this.FullfillResumesTable();
            this.FullfillRequestsTable();
        }

        private void UpdateVacanciesButton_Click(object sender, EventArgs e)
        {
            this.vacancies = vacRepos.VacanciesByLogin(this.employer.Login);
            this.FullfillMyVacanciesTable();
        }

        private void DeleteVacancyButton_Click(object sender, EventArgs e)
        {
            if (MyVacanciesTable.SelectedRows.Count != 0)
            {
                int deletingId = Int32.Parse(MyVacanciesTable.SelectedRows[0].Cells[0].Value.ToString());
                this.vacRepos.DeleteVacancy(deletingId);
                this.UpdateVacanciesButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Для удаления вакансии нужно выбрать ее в таблице");
            }
        }

        private void EditVacancyButton_Click(object sender, EventArgs e)
        {
            if (MyVacanciesTable.SelectedRows.Count != 0)
            {
                int editingId = Int32.Parse(MyVacanciesTable.SelectedRows[0].Cells[0].Value.ToString());
                Vacancy vacancy = this.vacRepos.GetVacancy(editingId);
                Hide();
                VacancyEditorForm editorForm = new VacancyEditorForm(this.service, this.employer, vacancy);
                editorForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Для редактирования вакансии нужно выбрать ее в таблице");
            }
        }

        private void AddVacancyButton_Click(object sender, EventArgs e)
        {
            Hide();
            VacancyAdderForm adderForm = new VacancyAdderForm(this.service, this.employer);
            adderForm.ShowDialog();
            Close();
        }

        private void UpdateResumesButton_Click(object sender, EventArgs e)
        {
            this.resumes = resRepos.ShownResumes();
            this.FullfillResumesTable();
        }

        private void UpdateRequestsButton_Click(object sender, EventArgs e)
        {
            this.requests = reqRepos.RequestsByEmployer(vacRepos, this.employer.Login);
            this.FullfillRequestsTable();
        }

        private void FullfillMyVacanciesTable()
        {
            MyVacanciesTable.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (Vacancy vac in this.vacancies)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = vac.Id;
                row.Cells[1].Value = vac.Position;
                row.Cells[2].Value = vac.Salary;
                row.Cells[3].Value = vac.Education;
                row.Cells[4].Value = vac.Experience;
                row.Cells[5].Value = vac.Languages;
                row.Cells[6].Value = vac.Show;
                rows.Add(row);
            }
            MyVacanciesTable.Rows.AddRange(rows.ToArray());
        }

        private void FullfillResumesTable()
        {
            ResumesTable.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (Resume res in this.resumes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = res.Id;
                row.Cells[1].Value = res.Creator;
                row.Cells[2].Value = this.appRepos.GetApplicant(res.Creator).Fio;
                row.Cells[3].Value = res.Position;
                row.Cells[4].Value = res.Salary;
                row.Cells[5].Value = res.Education;
                row.Cells[6].Value = res.Experience;
                row.Cells[7].Value = res.Languages;
                rows.Add(row);
            }
            ResumesTable.Rows.AddRange(rows.ToArray());
        }

        private void FullfillRequestsTable()
        {
            RequestsTable.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (Request req in this.requests)
            {
                Vacancy vacancy = this.vacRepos.GetVacancy(req.VacancyId);
                Resume resume = this.resRepos.GetResume(req.ResumeId);
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = req.Id;
                row.Cells[1].Value = req.VacancyId;
                row.Cells[2].Value = vacancy.Position;
                row.Cells[3].Value = resume.Creator;
                row.Cells[4].Value = req.ResumeId;
                row.Cells[5].Value = resume.Position;
                row.Cells[6].Value = resume.Salary;
                row.Cells[7].Value = resume.Education;
                row.Cells[8].Value = resume.Experience;
                row.Cells[9].Value = resume.Languages;
                rows.Add(row);
            }
            RequestsTable.Rows.AddRange(rows.ToArray());
        }
    }
}
