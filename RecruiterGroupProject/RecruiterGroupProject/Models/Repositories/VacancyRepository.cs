using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject.Models.Repositories
{
    public class VacancyRepository
    {
        private Vacancy[] vacancies;
        private DataService service;

        public VacancyRepository()
        {
            this.service = new DataService();
            this.vacancies = this.service.getVacancies();
        }

        public VacancyRepository(DataService service)
        {
            this.service = service;
            this.vacancies = this.service.getVacancies();
        }

        public Vacancy[] Vacancies()
        {
            this.vacancies = this.service.getVacancies();
            return this.vacancies;
        }

        public Vacancy[] VacanciesByLogin(string login)
        {
            // Resume resms[] = this.Resumes();
            List<Vacancy> vacs = this.Vacancies().ToList();
            for (int i = vacs.Count - 1; i >= 0; i--)
            {
                if (vacs[i].Master != login)
                {
                    vacs.RemoveAt(i);
                }
            }
            return vacs.ToArray();
        }

        public Vacancy[] ShownVacancies()
        {
            List<Vacancy> vacs = this.Vacancies().ToList();
            for (int i = vacs.Count - 1; i >= 0; i--)
            {
                if (!vacs[i].Show)
                {
                    vacs.RemoveAt(i);
                }
            }
            return vacs.ToArray();
        }

        public Vacancy GetVacancy(int id)
        {
            Vacancy vacancy = this.service.getVacancy(id);
            return vacancy;
        }

        public void AddVacancy(string position, double salary, int education, int experience, int languages, bool show, string master)
        {
            this.service.AddVacancy(position, salary, education, experience, languages, show, master);
            this.vacancies = this.service.getVacancies();
        }

        public void EditVacancy(int id, string position, double salary, int education, int experience, int languages, bool show, string master)
        {
            this.service.ChangeVacancy(id, position, salary, education, experience, languages, show, master);
            this.vacancies = this.service.getVacancies();
        }

        public void DeleteVacancy(int id)
        {
            this.service.DeleteVacancy(id);
            this.vacancies = this.service.getVacancies();
        }
    }
}
