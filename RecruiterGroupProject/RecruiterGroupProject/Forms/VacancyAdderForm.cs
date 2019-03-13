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
    public partial class VacancyAdderForm : Form
    {
        private DataService service;
        private Employer employer;
        private ApplicantRepository appRepos;
        private EmployerRepository empRepos;
        private VacancyRepository vacRepos;
        private ResumeRepository resRepos;
        private RequestRepository reqRepos;
        public VacancyAdderForm(DataService service, Employer employer)
        {
            this.service = service;
            this.employer = employer;
            this.appRepos = new ApplicantRepository(this.service);
            this.empRepos = new EmployerRepository(this.service);
            this.vacRepos = new VacancyRepository(this.service);
            this.resRepos = new ResumeRepository(this.service);
            this.reqRepos = new RequestRepository(this.service);
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.CheckField())
            {
                double salary = Double.Parse(SalaryTextBox.Text);
                this.vacRepos.AddVacancy(
                    PositionTextBox.Text,
                    salary,
                    (int)EducationNumeric.Value,
                    (int)ExperienceNumeric.Value,
                    (int)LanguageNumeric.Value,
                    ShowVacancyCheckBox.Checked,
                    this.employer.Login
                    );
                Hide();
                EmployerMainForm mainForm = new EmployerMainForm(this.service, this.employer);
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены или заполнены неправильно. Проверьте, число ли записано напротив зарплаты.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            EmployerMainForm mainForm = new EmployerMainForm(this.service, this.employer);
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
