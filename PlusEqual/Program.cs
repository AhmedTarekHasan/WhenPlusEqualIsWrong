using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlusEqual.Trials.Right;
using PlusEqual.Trials.Wrong;

namespace PlusEqual
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await WrongWay.Run();
            //await RightWay.Run();

            Console.ReadLine();
        }
    }
}
