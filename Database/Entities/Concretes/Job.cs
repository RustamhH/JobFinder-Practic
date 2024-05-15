using Database.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities.Concretes
{
    public class Job : BaseEntity
    {

        public string Title { get; set; }
        public string StateType { get; set; }
        public string WorkingSchedule { get; set; }
        public string StandartEntranceProccess { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string VacancyCode { get; set; }
        public string VacancyUrl { get; set; }
        public string ProfileRequierments { get; set; }
        public DateTime ExpireDateTime { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}
