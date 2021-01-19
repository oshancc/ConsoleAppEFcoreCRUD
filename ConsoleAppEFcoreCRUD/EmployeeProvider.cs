using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFcoreCRUD
{
    internal class EmployeeProvider : IEmployeeProvider 
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProvider(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        public Employee Get(int id)
        {
            return employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();   
        }
    }


}
