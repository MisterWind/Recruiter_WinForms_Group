using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterGroupProject.Models.Classes
{
    public class Vacancy
    {
        private int id;
        private string position;
        private double salary;
        private int education;
        private int experience;
        private int languages;
        private bool show;
        private string master;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value != -1)
                {
                    this.id = value;
                }
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                if (value != "")
                {
                    this.position = value;
                }
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value != -1)
                {
                    this.salary = value;
                }
            }
        }

        public int Education
        {
            get
            {
                return this.education;
            }
            set
            {
                if (value != -1)
                {
                    this.education = value;
                }
            }
        }

        public int Experience
        {
            get
            {
                return this.experience;
            }
            set
            {
                if (value != -1)
                {
                    this.experience = value;
                }
            }
        }

        public int Languages
        {
            get
            {
                return this.languages;
            }
            set
            {
                if (value != -1)
                {
                    this.languages = value;
                }
            }
        }

        public bool Show
        {
            get
            {
                return this.show;
            }
            set
            {
                this.show = value;
            }
        }

        public string Master
        {
            get
            {
                return this.master;

            }
            set
            {
                if (value != "")
                {
                    this.master = value;
                }
            }
        }

        public Vacancy()
        {
            this.id = 0;
            this.position = "Programmer";
            this.salary = 35000;
            this.education = 0;
            this.experience = 0;
            this.languages = 0;
            this.show = false;
            this.master = "some_org_name";
        }

        public Vacancy(int id, string position, double salary, int education, int experience, int languages, bool show, string master)
        {
            this.id = id;
            this.position = position;
            this.salary = salary;
            this.education = education;
            this.experience = experience;
            this.languages = languages;
            this.show = show;
            this.master = master;
        }
    }
}
