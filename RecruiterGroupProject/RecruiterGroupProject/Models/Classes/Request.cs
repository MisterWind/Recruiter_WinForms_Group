using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterGroupProject.Models.Classes
{
    public class Request
    {
        private int id;
        private int vacancyId;
        private int resumeId;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int VacancyId
        {
            get { return this.vacancyId; }
            set { this.vacancyId = value; }
        }

        public int ResumeId
        {
            get { return this.resumeId; }
            set { this.resumeId = value; }
        }

        public Request()
        {
            this.id = 0;
            this.vacancyId = 0;
            this.resumeId = 0;
        }

        public Request(int id, int vacancyId, int resumeId)
        {
            this.id = id;
            this.vacancyId = vacancyId;
            this.resumeId = resumeId;
        }
    }
}
