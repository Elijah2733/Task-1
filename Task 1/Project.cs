using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Project
    {
        public string project_name;

        private string git_repo;

        public string description;

        public int duration;

        public DateTime startDate;

        public DateTime endDate;

        public TechLead techLead;

        public List<Task> tasks;

        string status;

        public Project(string name, string git_repo)
        {
            this.project_name = name;
            this.git_repo = git_repo;
        }

        public int setDuration(DateTime startDate, DateTime endDate)
        {
            duration = endDate.Month - startDate.Month;
            return duration;
        }
        public DateTime startProject()
        {
            bool createTask = false;
            startDate = DateTime.Now;
            status= Enum.GetName(typeof(status_options), 0);

            do { 
            Console.Write("Task Name: ");
            string taskName = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Task task = techLead.createtask(taskName, description);
            tasks.Add(task);

            Console.Write("Do you want to add another task?Type y or n :");
            string answer=Console.ReadLine();

            if (answer == "y")
            {
                continue;
            }
            else
            {
                createTask = true;
            }
        } while(!createTask);

            return startDate;
        }

        public void endProject()
        {

            endDate = DateTime.Now;
            status=Enum.GetName(typeof(status_options), 1);
            setDuration(startDate, endDate);

        }
        public bool isProjectComplete()
        {
            return tasks.All(task => task.status == "Complete");
        }

        public void assignTechLead(TechLead tecLead)
        {
            techLead = tecLead;
        }


    }
}
