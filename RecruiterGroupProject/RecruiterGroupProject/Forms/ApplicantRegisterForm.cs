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

    public partial class ApplicantRegisterForm : Form
    {
        public DataService service;
        public ApplicantRepository appRepos;
        public EmployerRepository empRepos;

        public ApplicantRegisterForm(DataService service)
        {
            this.service = service;
            appRepos = new ApplicantRepository(this.service);
            empRepos = new EmployerRepository(this.service);
            InitializeComponent();
        }

        private void RegisterApplicantButton_Click(object sender, EventArgs e)
        {
            Applicant applicant = null;
            Employer employer = null;
            if (this.CheckFields())
            {
                if (PasswordMaskBox.Text == RepeatPasswordTextBox.Text)
                {
                    if (Utils.Utils.IsValidEmail(EmailTextBox.Text))
                    {
                        if (this.CheckUser(applicant, employer))
                        {
                            this.appRepos.AddApplicant(
                                LoginTextBox.Text,
                                PasswordMaskBox.Text,
                                FioTextBox.Text,
                                PhoneMaskBox.Text,
                                EmailTextBox.Text);
                            applicant = this.appRepos.GetApplicant(LoginTextBox.Text);
                            Hide();
                            ApplicantMainForm appMainForm = new ApplicantMainForm(service, applicant);
                            appMainForm.ShowDialog();
                            Close();
                        } else
                        {
                            MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                        }
                    }
                    else
                    {
                        MessageBox.Show(text: "Неправильный формат почты");
                    }
                } else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            } else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private bool CheckFields()
        {
            return LoginTextBox.Text != "" 
                && PasswordMaskBox.Text != "" 
                && RepeatPasswordTextBox.Text != "" 
                && FioTextBox.Text != "" 
                && PhoneMaskBox.Text != "" 
                && EmailTextBox.Text !="";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            IdentificationForm identification = new IdentificationForm(this.service);
            identification.ShowDialog();
            Close();
        }

        private bool CheckUser(Applicant applicant, Employer employer)
        {
            applicant = appRepos.GetApplicant(LoginTextBox.Text);
            employer = empRepos.GetEmployer(LoginTextBox.Text);
            return employer == null && applicant == null;
        }


    }
}
