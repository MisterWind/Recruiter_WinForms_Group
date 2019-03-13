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
    public partial class EmployerRegisterForm : Form
    {
        public DataService service;
        public ApplicantRepository appRepos;
        public EmployerRepository empRepos;

        public EmployerRegisterForm(DataService service)
        {
            this.service = service;
            appRepos = new ApplicantRepository(this.service);
            empRepos = new EmployerRepository(this.service);
            InitializeComponent();
        }

        private void RegisterEmployerButton_Click(object sender, EventArgs e)
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
                            this.empRepos.AddEmployer(
                                LoginTextBox.Text,
                                PasswordMaskBox.Text,
                                NameTextBox.Text,
                                InnTextBox.Text,
                                TypeCombobox.Items[TypeCombobox.SelectedIndex].ToString(),
                                AreaCombobox.Items[AreaCombobox.SelectedIndex].ToString(),
                                PhoneMaskBox.Text,
                                EmailTextBox.Text);
                            employer = this.empRepos.GetEmployer(LoginTextBox.Text);
                            Hide();
                            EmployerMainForm empMainForm = new EmployerMainForm(service, employer);
                            empMainForm.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                        }
                    }
                    else
                    {
                        MessageBox.Show(text: "Неправильный формат почты");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            IdentificationForm identification = new IdentificationForm(this.service);
            identification.ShowDialog();
            Close();
        }

        private void EmployerRegisterForm_Load(object sender, EventArgs e)
        {
            TypeCombobox.SelectedIndex = 0;
            AreaCombobox.SelectedIndex = 0;
        }

        private bool CheckFields()
        {
            return LoginTextBox.Text != ""
                && PasswordMaskBox.Text != ""
                && RepeatPasswordTextBox.Text != ""
                && NameTextBox.Text != ""
                && InnTextBox.Text != ""
                && NameTextBox.Text != ""
                && TypeCombobox.SelectedIndex != -1
                && AreaCombobox.SelectedIndex != -1
                && EmailTextBox.Text != "";
        }

        private bool CheckUser(Applicant applicant, Employer employer)
        {
            applicant = appRepos.GetApplicant(LoginTextBox.Text);
            employer = empRepos.GetEmployer(LoginTextBox.Text);
            return employer == null && applicant == null;
        }
    }
}
