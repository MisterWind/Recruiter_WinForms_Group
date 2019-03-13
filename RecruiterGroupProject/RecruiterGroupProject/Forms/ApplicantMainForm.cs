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
    public partial class ApplicantMainForm : Form
    {
        private DataService service;
        private Applicant applicant;
        private ApplicantRepository appRepos;
        private EmployerRepository empRepos;
        private VacancyRepository vacRepos;
        private ResumeRepository resRepos;
        private RequestRepository reqRepos;
        private Resume[] resumes;
        private Vacancy[] vacancies;
        private Request[] requests;

        public ApplicantMainForm(DataService service, Applicant applicant)
        {
            this.service = service;
            this.applicant = applicant;
            this.appRepos = new ApplicantRepository(this.service);
            this.empRepos = new EmployerRepository(this.service);
            this.vacRepos = new VacancyRepository(this.service);
            this.resRepos = new ResumeRepository(this.service);
            this.reqRepos = new RequestRepository(this.service);
            this.resumes = resRepos.ResumesByLogin(this.applicant.Login);
            this.vacancies = vacRepos.ShownVacancies();
            this.requests = reqRepos.RequestByApplicant(this.resRepos, this.applicant.Login);
            InitializeComponent();
        }

        private void ApplicantMainForm_Load(object sender, EventArgs e)
        {
            this.FullfillMyResumeTable();
            this.FullfillVacanciesTable();
            this.FullfillRequestsTable();
        }

        private void UpdateResumeButton_Click(object sender, EventArgs e)
        {
            this.resumes = resRepos.ResumesByLogin(applicant.Login);
            this.FullfillMyResumeTable();
        }

        private void DeleteResumeButton_Click(object sender, EventArgs e)
        {
            if(MyResumesTable.SelectedRows.Count != 0)
            {
                int deletingId = Int32.Parse(MyResumesTable.SelectedRows[0].Cells[0].Value.ToString());
                this.resRepos.DeleteResume(deletingId);
                this.UpdateResumeButton_Click(sender, e);
            } else
            {
                MessageBox.Show("Для удаления резюме нужно выбрать его в таблице");
            }
        }

        private void EditResumeButton_Click(object sender, EventArgs e)
        {
            if (MyResumesTable.SelectedRows.Count != 0)
            {
                int editingId = Int32.Parse(MyResumesTable.SelectedRows[0].Cells[0].Value.ToString());
                Resume resume = this.resRepos.GetResume(editingId);
                Hide();
                ResumeEditorForm editorForm = new ResumeEditorForm(this.service, this.applicant, resume);
                editorForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Для редактирования резюме нужно выбрать его в таблице");
            }
        }

        private void AddResumeButton_Click(object sender, EventArgs e)
        {
            Hide();
            ResumeAdderForm adderForm = new ResumeAdderForm(this.service, this.applicant);
            adderForm.ShowDialog();
            Close();
        }

        private void UpdateVacanciesButton_Click(object sender, EventArgs e)
        {
            this.vacancies = vacRepos.ShownVacancies();
            this.FullfillVacanciesTable();
        }

        private void RespondButton_Click(object sender, EventArgs e)
        {
            if (MyResumesTable.SelectedRows.Count != 0 && VacanciesTable.SelectedRows.Count != 0)
            {
                int resumeId = Int32.Parse(MyResumesTable.SelectedRows[0].Cells[0].Value.ToString());
                int vacancyId = Int32.Parse(VacanciesTable.SelectedRows[0].Cells[0].Value.ToString());
                this.reqRepos.AddRequest(resumeId, vacancyId);
                this.UpdateRequestsButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Для отправки запроса нужно выбрать резюме и вакансию в таблицах");
            }
        }

        private void DeleteRequestButton_Click(object sender, EventArgs e)
        {
            if (RequestsTable.SelectedRows.Count != 0)
            {
                int deletingId = Int32.Parse(RequestsTable.SelectedRows[0].Cells[0].Value.ToString());
                this.reqRepos.DeleteRequest(deletingId);
                this.UpdateRequestsButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Для удаления запроса нужно выбрать его в таблице");
            }
        }

        private void UpdateRequestsButton_Click(object sender, EventArgs e)
        {
            this.requests = reqRepos.RequestByApplicant(resRepos, applicant.Login);
            this.FullfillRequestsTable();
        }

        private void FullfillMyResumeTable()
        {
            MyResumesTable.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach(Resume res in this.resumes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = res.Id;
                row.Cells[1].Value = res.Position;
                row.Cells[2].Value = res.Salary;
                row.Cells[3].Value = res.Education;
                row.Cells[4].Value = res.Experience;
                row.Cells[5].Value = res.Languages;
                row.Cells[6].Value = res.Show;
                rows.Add(row);
            }
            MyResumesTable.Rows.AddRange(rows.ToArray());
        }

        private void FullfillVacanciesTable()
        {
            VacanciesTable.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (Vacancy vac in this.vacancies)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = vac.Id;
                row.Cells[1].Value = this.empRepos.GetEmployer(vac.Master).Name;
                row.Cells[2].Value = vac.Position;
                row.Cells[3].Value = vac.Salary;
                row.Cells[4].Value = vac.Education;
                row.Cells[5].Value = vac.Experience;
                row.Cells[6].Value = vac.Languages;
                rows.Add(row);
            }
            VacanciesTable.Rows.AddRange(rows.ToArray());
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
                row.Cells[1].Value = this.empRepos.GetEmployer(vacancy.Master).Name;
                row.Cells[2].Value = req.VacancyId;
                row.Cells[3].Value = vacancy.Position;
                row.Cells[4].Value = vacancy.Salary;
                row.Cells[5].Value = vacancy.Education;
                row.Cells[6].Value = vacancy.Experience;
                row.Cells[7].Value = vacancy.Languages;
                row.Cells[8].Value = req.ResumeId;
                row.Cells[9].Value = resume.Position;
                rows.Add(row);
            }
            RequestsTable.Rows.AddRange(rows.ToArray());
        }


    }
}
