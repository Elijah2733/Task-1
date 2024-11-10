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
    Console.WriteLine($"Tech Lead: {project.techLead.name}");
    Console.WriteLine($"Status: {project.status}");

    for(int task=0;task<project.tasks.Count;task++)
    {
        Console.WriteLine($"{task+1}.Task {project.tasks[task].name} Status:{project.tasks[task].status}");

        Console.WriteLine("Assignees:");
        if (!string.IsNullOrEmpty(project.tasks[task].intern.name))
        {
            Console.WriteLine($"Intern: {project.tasks[task].intern.name}");
            Console.WriteLine($"Intern: {project.tasks[task].intern.stack}");
        }
        if (!string.IsNullOrEmpty(project.tasks[task].programmer.name))
            {
                Console.WriteLine($"Trainee Programmer: {project.tasks[task].programmer.name}");
                Console.WriteLine($"Intern: {project.tasks[task].programmer.stack}");
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


