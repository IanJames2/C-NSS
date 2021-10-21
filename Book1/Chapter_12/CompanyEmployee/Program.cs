using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company FedEx = new Company("FedEx", new DateTime(2021, 08, 30));

            // Create three employees
            var Frank = new Employee();
                Frank.FirstName = "Frank"; Frank.LastName = "Guford"; Frank.Title = "Manager"; Frank.StartDate = new DateTime(2021, 08, 30);
            var Fred = new Employee();
                Fred.FirstName = "Fred"; Fred.LastName = "Guford"; Fred.Title = "Manager"; Fred.StartDate = new DateTime(2021, 08, 30);
            var Ed = new Employee();
                Ed.FirstName = "Ed"; Ed.LastName = "Guford"; Ed.Title = "Manager"; Ed.StartDate = new DateTime(2021, 08, 30);


            // Assign the employees to the company
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            FedEx.Employees.Add(Frank);
            FedEx.Employees.Add(Fred);
            FedEx.Employees.Add(Ed);

            foreach (Employee employee in FedEx.Employees)
            {
                FedEx.ListEmployees(employee, FedEx);
            }

        }
    }
}

