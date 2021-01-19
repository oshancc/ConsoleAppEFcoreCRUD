using System;

namespace ConsoleAppEFcoreCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new EmployeeContext("Data Source=THELA;Initial Catalog=TimeManagement;Integrated Security=True");

            var provider = new EmployeeProvider(context);

            var emp = provider.Get(1);
            Console.WriteLine(emp.FirstName);

            var repo = new EmployeeRepo(context);
            // repo.Create("ben", "ten", "Äddressss", "071-3425678", "041-2223331");

            var emp1 = provider.Get(2);
            emp1.FirstName = "NewFirstName";
            // repo.Update(emp1);

            repo.Delete(emp1);
            
           
        }
    }
}
