using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFcoreCRUD
{
    internal interface IEmployeeRepo
    {
        Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone);

        Employee Update(Employee employee);

        void Delete(Employee employee);
    }
}
