using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFcoreCRUD
{
    class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeRepo(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone)
        {
            var response = employeeContext.Add(new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                HomePhone = homePhone,
                CellPhone = cellPhone
            });
            employeeContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }
    }
}
