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
    public partial class ResumeEditorForm : Form
    {
        private DataService service;
        private Applicant applicant;
        private Resume resume;
        private ApplicantRepository appRepos;
        private EmployerRepository empRepos;
        private VacancyRepository vacRepos;
        private ResumeRepository resRepos;
        private RequestRepository reqRepos;
        public ResumeEditorForm(DataService service, Applicant applicant, Resume resume)
        {
            this.service = service;
            this.applicant = applicant;
            this.resume = resume;
            this.appRepos = new ApplicantRepository(this.service);
            this.empRepos = new EmployerRepository(this.service);
            this.vacRepos = new VacancyRepository(this.service);
            this.resRepos = new ResumeRepository(this.service);
            this.reqRepos = new RequestRepository(this.service);
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.CheckField())
            {
                double salary = Double.Parse(SalaryTextBox.Text);
                this.resRepos.EditResume(
                    resume.Id,
                    PositionTextBox.Text,
                    salary,
                    (int)EducationNumeric.Value,
                    (int)ExperienceNumeric.Value,
                    (int)LanguageNumeric.Value,
                    ShowResumeCheckBox.Checked,
                    this.applicant.Login
                    );
                Hide();
                ApplicantMainForm mainForm = new ApplicantMainForm(this.service, this.applicant);
                mainForm.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("Не все поля заполнены или заполнены неправильно. Проверьте, число ли записано напротив зарплаты.");
            }
        }

        private void ResumeEditorForm_Load(object sender, EventArgs e)
        {
            PositionTextBox.Text = resume.Position;
            SalaryTextBox.Text = resume.Salary.ToString();
            EducationNumeric.Value = resume.Education;
            ExperienceNumeric.Value = resume.Experience;
            LanguageNumeric.Value = resume.Languages;
            ShowResumeCheckBox.Checked = resume.Show;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            ApplicantMainForm mainForm = new ApplicantMainForm(this.service, this.applicant);
            mainForm.ShowDialog();
            Close();
        }

        private bool CheckField()
        {
            double salary = 0;
            bool parsed = Double.TryParse(SalaryTextBox.Text, out salary);
            return PositionTextBox.Text != ""
                && SalaryTextBox.Text != ""
                && parsed
                && EducationNumeric.Value >= 0
                && ExperienceNumeric.Value >= 0
                && LanguageNumeric.Value >= 0;
        }
    }
}
