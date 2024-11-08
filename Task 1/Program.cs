// See https://aka.ms/new-console-template for more information
using Task_1;

Project project;
Console.Write("CTO:");
string cto_name=Console.ReadLine();
CTO cto= new CTO(cto_name);

Console.Write("Do you want to a start project? Type y or n: ");
string answer = Console.ReadLine();

if (answer == "y")
{
    project=cto.startProject();
    Console.WriteLine($"Project: {project.project_name
        }");    
    Console.WriteLine($"Description: {project.description}");
    Console.WriteLine($"Tech Lead: {project.techLead}");
    Console.WriteLine(($"Status: {project.status}");

    for(int task=1;task<project.tasks.Count+1;task++)
    {
        Console.WriteLine($"{task}.Task {project.tasks[task]} Status:{project.tasks[task].status}");

        Console.Write("Assignees:");
        if (!(project.tasks[task].intern==null))
        {
            Console.WriteLine($"Intern {project.tasks[task].intern.name}");
        }
        else if (!(project.tasks[task].programmer == null))
            {
                Console.WriteLine($"Intern {project.tasks[task].programmer.name}");
            }
    }
}
else
{
    Console.WriteLine("Do you want to end a project.Type y:");
    string answer2=Console.ReadLine();

    if(answer2 == "y") {
        //Console.Write("Project name/id:");
        //string projectName=Console.ReadLine();
        //cto.endProject(project);
        Console.WriteLine("The project has been completed");
    }

    
}


