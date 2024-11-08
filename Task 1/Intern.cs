using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Intern:ITask
    {
        public string name;

        public string stack;

        public Intern(string name, string stack)
        {
            this.name = name;
            this.stack = stack;
        }

        public void completeTask()
        {
            Console.WriteLine("I've completed the task");
        }

        public void sendForReview()
        {
            Console.WriteLine("I've sent the task to Tech Lead for review");
        }
        public void push()
        {
            Console.WriteLine("I've pushed to test");
        }

    }
}
