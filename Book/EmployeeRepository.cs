using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class EmployeeRepository
    {
        List<Employee> employees = new List<Employee>();

        public Employee getEmployeeById(int id)
        {
            return employees.FirstOrDefault(x=>x.id.Equals(id));                
        }
      public void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
