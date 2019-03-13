using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruiterGroupProject.Models.Classes;
using RecruiterGroupProject.Services;

namespace RecruiterGroupProject.Models.Repositories
{
    public class ResumeRepository
    {
        private Resume[] resumes;
        private DataService service;

        public ResumeRepository()
        {
            this.service = new DataService();
            this.resumes = this.service.getResumes();
        }

        public ResumeRepository(DataService service)
        {
            this.service = service;
            this.resumes = this.service.getResumes();
        }

        public Resume[] Resumes()
        {
            this.resumes = this.service.getResumes();
            return this.resumes;
        }

        public Resume[] ResumesByLogin(string login)
        {
            // Resume resms[] = this.Resumes();
            List<Resume> resms = this.Resumes().ToList();
            for (int i = resms.Count - 1; i >= 0; i--)
            {
                if (resms[i].Creator != login)
                {
                    resms.RemoveAt(i);
                }
            }
            return resms.ToArray();
        }

        public Resume[] ShownResumes()
        {
            List<Resume> resms = this.Resumes().ToList();
            for (int i = resms.Count - 1; i >= 0; i--)
            {
                if (!resms[i].Show)
                {
                    resms.RemoveAt(i);
                }
            }
            return resms.ToArray();
        }

        public Resume GetResume(int id)
        {
            Resume resume = this.service.getResume(id);
            return resume;
        }

        public void AddResume(string position, double salary, int education, int experience, int languages, bool show, string creator)
        {
            this.service.AddResume(position, salary, education, experience, languages, show, creator);
            this.resumes = this.service.getResumes();
        }

        public void EditResume(int id, string position, double salary, int education, int experience, int languages, bool show, string creator)
        {
            this.service.ChangeResume(id, position, salary, education, experience, languages, show, creator);
            this.resumes = this.service.getResumes();
        }

        public void DeleteResume(int id)
        {
            this.service.DeleteResume(id);
            this.resumes = this.service.getResumes();
        }
    }
}
