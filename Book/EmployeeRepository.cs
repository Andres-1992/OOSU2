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

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(x=>x.Id.Equals(id));                
        }
      public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
