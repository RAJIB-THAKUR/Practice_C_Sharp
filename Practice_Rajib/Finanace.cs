/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_practice
{
    class Finanace
    {
        private readonly EmployeeSeparator employeeSeparator;
        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("Finance Department: employee separation process related to finance");
        }
    }
}
*/