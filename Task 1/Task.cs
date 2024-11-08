using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public enum status_options
    {
        Inprogress,
        Complete
    }
    internal class Task
    {
        public string name;

        public string description;

        Project project;

        public string status;

        public TraineeProgrammer programmer;

        public Intern intern;

        public bool reviewed;

        public DateTime startDate;

        public DateTime endDate;

        public int duration;


        public Task(string name, string description)
        {
            this.name = name;
            this.description = description;
            //this.project = project;
            startTask();
        }

        public void startTask()
        {
            startDate= DateTime.Now;
            status = Enum.GetName(typeof(status_options), 0);
        }

        public void endTask()
        {
            endDate= DateTime.Now;
            status = Enum.GetName(typeof(status_options), 1);
        }

        public void setDuration(DateTime start, DateTime end)
        {
            duration = end.Month - start.Month;
        }

    }
}
