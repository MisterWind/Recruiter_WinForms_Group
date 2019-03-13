using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject.Models.Repositories
{
    public class RequestRepository
    {
        private Request[] requests;
        private DataService service;

        public RequestRepository()
        {
            this.service = new DataService();
            this.requests = this.service.getRequests();
        }

        public RequestRepository(DataService service)
        {
            this.service = service;
            this.requests = this.service.getRequests();
        }

        public Request[] RequestByApplicant(ResumeRepository repo, string login)
        {
            List<Request> reqs = this.Requests().ToList();
            Resume[] resumes = repo.ResumesByLogin(login);
            List<int> resumeIds = new List<int>();
            foreach(Resume res in resumes)
            {
                resumeIds.Add(res.Id);
            }

            for (int i = reqs.Count - 1; i >= 0; i--)
            {
                if (resumeIds.IndexOf(reqs[i].ResumeId) == -1)
                {
                    reqs.RemoveAt(i);
                }
            }
            return reqs.ToArray();
        }

        public Request[] RequestsByEmployer(VacancyRepository repo, string login)
        {
            List<Request> reqs = this.Requests().ToList();
            Vacancy[] vacancies = repo.VacanciesByLogin(login);
            List<int> vacancIds = new List<int>();
            foreach (Vacancy vac in vacancies)
            {
                vacancIds.Add(vac.Id);
            }

            for (int i = reqs.Count - 1; i >= 0; i--)
            {
                if (vacancIds.IndexOf(reqs[i].VacancyId) == -1)
                {
                    reqs.RemoveAt(i);
                }
            }
            return reqs.ToArray();
        }

        public Request[] Requests()
        {
            this.requests = this.service.getRequests();
            return this.requests;
        }

        public Request GetRequest(int id)
        {
            Request request = this.service.getRequest(id);
            return request;
        }

        public void AddRequest(int resumeId, int vacancyId)
        {
            this.service.AddRequest(resumeId, vacancyId);
            this.requests = this.service.getRequests();
        }

        public void DeleteRequest(int id)
        {
            this.service.DeleteRequest(id);
            this.requests = this.service.getRequests();
        }
    }
}
