using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterGroupProject.Models.Classes
{
    public class Applicant
    {
        private string login;
        private string password;
        private string fio;
        private string phone;
        private string mail;

        public string Login
        {
            get {
                return this.login;
            }
            set {
                if (value != "")
                {
                    this.login = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (value != "")
                {
                    this.password = value;
                }
            }
        }

        public string Fio
        {
            get
            {
                return this.fio;
            }
            set
            {
                if (value != "")
                {
                    this.fio = value;
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (value != "")
                {
                    this.phone = value;
                }
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                if (value != "")
                {
                    this.mail = value;
                }
            }
        }


        public Applicant()
        {
            this.login = "some_login";
            this.password = "123qwe";
            this.fio = "some_name";
            this.phone = "8(999)-999-9999";
            this.mail = "mail@domen.ru";
        }

        public Applicant(string login, string password, string fio, string phone, string mail)
        {
            this.login = login;
            this.password = password;
            this.fio = fio;
            this.phone = phone;
            this.mail = mail;
        }
    }
}
