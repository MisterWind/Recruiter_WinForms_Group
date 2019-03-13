using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject.Models.Repositories
{
    public class EmployerRepository
    {
        private Employer[] employers;
        private DataService service;
        public EmployerRepository()
        {
            this.service = new DataService();
            this.employers = this.service.getEmployers();
        }

        public EmployerRepository(DataService service)
        {
            this.service = service;
            this.employers = this.service.getEmployers();
        }

        public Employer[] Employers()
        {
            this.employers = this.service.getEmployers();
            return this.employers;
        }

        public Employer GetEmployer(string login)
        {
            Employer employer = this.service.getEmployer(login);
            return employer;
        }

        public void AddEmployer(string login, string password, string name, string inn, string type, string area, string phone, string mail)
        {
            this.service.AddEmployer(login, password, name, inn, type, area, phone, mail);
            this.employers = this.service.getEmployers();
        }
    }
}
