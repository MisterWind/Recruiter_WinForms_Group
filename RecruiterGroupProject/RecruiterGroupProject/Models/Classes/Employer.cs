using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterGroupProject.Models.Classes
{
    public class Employer
    {
        private string login;
        private string password;
        private string name;
        private string inn;
        private string type;
        private string area;
        private string phone;
        private string mail;

        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
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

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != "")
                {
                    this.name = value;
                }
            }
        }

        public string Inn
        {
            get
            {
                return this.inn;
            }
            set
            {
                if (value != "")
                {
                    this.inn = value;
                }
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value != "")
                {
                    this.type = value;
                }
            }
        }

        public string Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value != "")
                {
                    this.area = value;
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


        public Employer()
        {
            this.login = "some_login";
            this.password = "123qwe";
            this.name = "some_org_name";
            this.inn = "000000000";
            this.type = "OOO";
            this.area = "IT";
            this.phone = "8(999)-999-9999";
            this.mail = "mail@domen.ru";
        }

        public Employer(string login, string password, string name, string inn, string type, string area, string phone, string mail)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.inn = inn;
            this.type = type;
            this.area = area;
            this.phone = phone;
            this.mail = mail;
        }
    }
}
