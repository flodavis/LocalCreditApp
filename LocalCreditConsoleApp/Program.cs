using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCreditConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new BankResult();
            result.SetPhoneNumber("A");
            Console.WriteLine(result.PhoneNumber);
            Console.ReadLine();
        }
    }
}
