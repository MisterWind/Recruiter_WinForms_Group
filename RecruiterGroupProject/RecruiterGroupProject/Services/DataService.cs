using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models;
using RecruiterGroupProject.Models.Classes;

namespace RecruiterGroupProject.Services
{
    public class DataService
    {
        // TODO: Расписать датасервис, который будет подключаться к стороннему сервису, подтягиватьи отправлять данные
        private Applicant[] applicantsSet;
        private Employer[] employersSet;
        private Resume[] resumesSet;
        private Vacancy[] vacanciesSet;
        private Request[] requestsSet;

        public void FindService()
        {

        }

        public DataService()
        {
            this.UpdateEntities();
        }

        public void UpdateEntities()
        {
            this.UpdateApplicants();
            this.UpdateEmployers();
            this.UpdateResumes();
            this.UpdateVacancies();
            this.UpdateRequests();
        }

        public void UpdateApplicants()
        {

        }

        public void UpdateEmployers()
        {

        }

        public void UpdateResumes()
        {

        }

        public void UpdateVacancies()
        {

        }

        public void UpdateRequests()
        {

        }

        public Applicant[] getApplicants()
        {
            // Здесь нужно обновлять записи
            return this.applicantsSet;
        }

        public Employer[] getEmployers()
        {
            // Здесь нужно обновлять записи
            return this.employersSet;
        }

        public Resume[] getResumes()
        {
            // Здесь нужно обновлять записи
            return this.resumesSet;
        }

        public Vacancy[] getVacancies()
        {
            // Здесь нужно обновлять записи
            return this.vacanciesSet;
        }

        public Request[] getRequests()
        {
            // Здесь нужно обновлять записи
            return this.requestsSet;
        }

        public Applicant getApplicant(string login)
        {
            // Посылается запрос на соискателя по его логину
            return new Applicant();
        }

        public Employer getEmployer(string login)
        {
            // Посылается запрос на соискателя по его логину
            return new Employer();
        }

        public Resume getResume(int id)
        {
            // Посылается запрос на соискателя по его логину
            return new Resume();
        }

        public Vacancy getVacancy(int id)
        {
            // Посылается запрос на соискателя по его логину
            return new Vacancy();
        }

        public Request getRequest(int id)
        {
            // Посылается запрос на соискателя по его логину
            return new Request();
        }

        public void AddApplicant(string login, string password, string fio, string phone, string mail)
        {
            // Регистрация нового соискателя
        }

        public void AddEmployer(string login, string password, string fio, string inn, string type, string area, string phone, string mail)
        {
            // Регистрация нового работодателя
        }

        public void AddResume(string position, double salary, int education, int experience, int languages, bool show, string creator)
        {
            // Создание нового резюме
        }

        public void ChangeResume(int id, string position, double salary, int education, int experience, int languages, bool show, string creator)
        {
            // Редактирование резюме по ИД
        }

        public void DeleteResume(int id)
        {
            // Удаление резюме по ИД
        }

        public void AddVacancy(string position, double salary, int education, int experience, int languages, bool show, string master)
        {
            // Создание новой вакансии
        }

        public void ChangeVacancy(int id, string position, double salary, int education, int experience, int languages, bool show, string master)
        {
            // Редактирование вакансии по ИД
        }

        public void DeleteVacancy(int id)
        {
            // Удаление вакансии по ИД
        }

        public void AddRequest(int vacancyId, int resumeId)
        {
            // Создание нового запроса
        }

        public void DeleteRequest(int id)
        {
            // Удаление резюме по ИД
        }

    }
}
