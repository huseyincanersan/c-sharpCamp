using System;
using System.Collections.Generic;

namespace InterfacesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager employeeManager = new EmployeeManager();
            IPersonManager customerManager = new CustomerManager();
            IPersonManager asistantManager = new AssistantManageer();

            employeeManager.Add();
            Console.WriteLine("----------------------");

            customerManager.Add();
            Console.WriteLine("-----------------------");
            employeeManager.Update();

            Console.WriteLine("-------------------");

            List<IPersonManager> personManagers = new List<IPersonManager> { employeeManager, customerManager };

            personManagers.Add(new AssistantManageer());

            foreach (var item in personManagers)
            {
                Console.WriteLine("-----------------------");
                item.Add();
            }


            Console.WriteLine("**************************");

            ProjectManager project = new ProjectManager();

            project.Add(customerManager);

            


        }
    }
}
