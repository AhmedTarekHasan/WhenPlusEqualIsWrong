namespace PlusEqual.Classes
{
    public class RaiseCalculator
    {
        private static readonly object _lock = new object();

        public decimal Calculate(Employee employee)
        {
            lock (_lock)
            {
                return
                    (employee.Salary <= 1000) ?
                        500 :
                        1000;
            }
        }
    }
}