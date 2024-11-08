using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class CTO
    {
        public string name;
        public CTO(string name)
        {
            this.name = name;
        }

        public Project startProject()
        {
            Console.Write("Project Name: ");
            string project_name = Console.ReadLine();

            Console.Write("Git Repository URL: ");
            string git_repo = Console.ReadLine();

            Project project = new Project(project_name, git_repo);

            Console.Write("Tech Lead: ");
            string tech_leadName = Console.ReadLine();
            TechLead techLead = new TechLead(tech_leadName, project);
            project.assignTechLead(techLead);

            project.startProject();
            return project;
        }

        public void endProject(Project project)
        {
            if (project.isProjectComplete())
            {
                project.endProject();
            }
        }
    }
}
