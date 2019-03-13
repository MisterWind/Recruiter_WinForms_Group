using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject.Models.Repositories
{
    public class ApplicantRepository
    {
        private Applicant[] applicants;
        private DataService service;
        public ApplicantRepository()
        {
            this.service = new DataService();
            this.applicants = this.service.getApplicants();
        }

        public ApplicantRepository(DataService service)
        {
            this.service = service;
            this.applicants = this.service.getApplicants();
        }

        public Applicant[] Applicants()
        {
            this.applicants = this.service.getApplicants();
            return this.applicants;
        }

        public Applicant GetApplicant(string login)
        {
            Applicant applicant = this.service.getApplicant(login);
            return applicant;
        }

        public void AddApplicant(string login, string password, string fio, string phone, string mail)
        {
            this.service.AddApplicant(login, password, fio, phone, mail);
            this.applicants = this.service.getApplicants();
        }
    }
}
