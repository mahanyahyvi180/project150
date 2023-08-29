using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp112
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");


            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);
        }
            public static void PolicyInNoFaultState(AutoPolicy policy)
            {
                Console.WriteLine("The auto policy:");
                Console.Write($"Account #:{policy.AccountNumber};");
                Console.WriteLine($"Car:{policy.State}; ");
                Console.Write($"{(policy.IsNoFaultState ? "is" : "is not")}");
                Console.WriteLine("a no-fault state\n");
            Console.ReadLine();
        }
    }
}
