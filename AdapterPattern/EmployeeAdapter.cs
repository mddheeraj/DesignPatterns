using System.Collections.Generic;

namespace AdapterPattern
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class EmployeeAdapter : ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            HRSystem hrSystem = new HRSystem();

            string[][] employees = hrSystem.GetEmployees();
            foreach(string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }
}
