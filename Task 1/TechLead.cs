using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
   
    internal class TechLead
    {
        public string name;
        public Project project;

        public TechLead(string name, Project project)
        {
            this.name = name;
            this.project = project;
        }

        //Project? project
        public Task createtask(string name, string description )
        {
            Task task = new Task(name,description);
            return task;
            Console.Write("Intern: ");
            string intern_name=Console.ReadLine();
            Console.Write("Stack: ");
            string iStack=Console.ReadLine();
            Intern intern = new Intern(intern_name,iStack);
            Console.Write("Trainee Programmer: ");
            string programmer_name = Console.ReadLine();
            Console.Write("Stack: ");
            string pStack = Console.ReadLine();
            TraineeProgrammer programmer = new TraineeProgrammer(programmer_name, pStack);
            Task task=return this;
            assignTask(intern, programmer);




        }

        public void assignTask(Intern? intern, TraineeProgrammer? programmer,Task task)
        {
            task.intern= intern;
            task.programmer= programmer;
            task.startTask();
        }

        public void reviewTask(Task task)
        {
            task.reviewed= true;
            task.endTask();
        }

        
    }
}
