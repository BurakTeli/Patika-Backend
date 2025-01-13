using System;

namespace CompanyApp
{
    // Abstract class representing a generic employee
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        // Abstract method to be implemented by derived classes
        public abstract void Job();
    }

    // Class for Software Developer, inherits from Employee
    public class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Implementing the Job method
        public override void Job()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a Software Developer in the {Department} department.\n");
        }
    }

    // Class for Project Manager, inherits from Employee
    public class ProjectManager : Employee
    {
        public ProjectManager(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Implementing the Job method
        public override void Job()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a Project Manager in the {Department} department.\n");
        }
    }

    // Class for Sales Representative, inherits from Employee
    public class SalesRepresentative : Employee
    {
        public SalesRepresentative(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        // Implementing the Job method
        public override void Job()
        {
            Console.WriteLine($"{FirstName} {LastName} is working as a Sales Representative in the {Department} department.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of each employee type
            Employee developer = new SoftwareDeveloper("Hasan", "Çıldırmış", "Development");
            Employee projectManager = new ProjectManager("Ali", "Veli", "Project Management");
            Employee salesRep = new SalesRepresentative("Ayşe", "Kaya", "Sales");

            // Calling the Job method for each employee
            developer.Job();
            projectManager.Job();
            salesRep.Job();
        }
    }
}
