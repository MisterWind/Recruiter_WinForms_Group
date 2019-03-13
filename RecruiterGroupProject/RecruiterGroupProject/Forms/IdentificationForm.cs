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
    public partial class IdentificationForm : Form
    {
        public DataService service;
        public ApplicantRepository appRepos;
        public EmployerRepository empRepos;


        public IdentificationForm(DataService service)
        {
            this.service = service;
            appRepos = new ApplicantRepository(this.service);
            empRepos = new EmployerRepository(this.service);
            InitializeComponent();
        }

        private void RegisterApplicantButton_Click(object sender, EventArgs e)
        {
            Hide();
            ApplicantRegisterForm form = new ApplicantRegisterForm(this.service);
            form.ShowDialog();
            Close();
        }

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            Applicant applicant = null;
            Employer employer = null;
            if (this.CheckFields())
            {
                if (this.CheckUser(applicant, employer))
                {
                    applicant = appRepos.GetApplicant(LoginTextBox.Text);
                    if (applicant != null)
                    {
                        Hide();
                        ApplicantMainForm appMainForm = new ApplicantMainForm(this.service, applicant);
                        appMainForm.ShowDialog();
                        Close();
                    } else
                    {
                        employer = empRepos.GetEmployer(LoginTextBox.Text);
                        if (employer != null)
                        {
                            Hide();
                            EmployerMainForm empMainForm = new EmployerMainForm(this.service, employer);
                            empMainForm.ShowDialog();
                            Close();
                        } else
                        {
                            MessageBox.Show("Такой пользователь в системе не зарегистрирован");
                        }
                    }
                } else
                {
                    MessageBox.Show("Такой пользователь в системе не зарегистрирован");
                }
            } else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void RegisterEmployerButton_Click(object sender, EventArgs e)
        {
            Hide();
            EmployerRegisterForm form = new EmployerRegisterForm(this.service);
            form.ShowDialog();
            Close();
        }

        private bool CheckFields()
        {
            return LoginTextBox.Text != "" && PasswordMaskBox.Text != "";
        }

        private bool CheckUser(Applicant applicant, Employer employer)
        {
            applicant = appRepos.GetApplicant(LoginTextBox.Text);
            employer = empRepos.GetEmployer(LoginTextBox.Text);
            return employer != null || applicant != null;
        }
    }
}
