using PlusEqual.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusEqual.Trials.Right
{
    public class RightWay
    {
        public static async Task Run()
        {
            var calculator = new RaiseCalculator();

            for (var i = 1; i <= 10; i++)
            {
                var employee = new Employee { Salary = 1000 };

                var tasks = new Task[2];

                tasks[0] = Task.Run(() => {
                    employee.Salary = calculator.Calculate(employee) + employee.Salary;
                });

                tasks[1] = Task.Run(() => {
                    employee.Salary = calculator.Calculate(employee) + employee.Salary;
                });

                await Task.WhenAll(tasks);
                await Task.Delay(500);

                Console.WriteLine("Final: " + employee.Salary); // Expected 2500
            }
        }
    }
}
