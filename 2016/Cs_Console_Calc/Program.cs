using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Console_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string calc = "";
            do
            {
                Console.Write("Calculation: ");
                calc = Console.ReadLine();
                string op1 = "";
                string op2 = "";
                int length = 0;
                string op = "";
                for (int i = 0; i < calc.Length; i++)
                {
                    if (calc[i] == '*' || calc[i] == '/' || calc[i] == '+' || calc[i] == '-')
                    {
                        op += calc[i];
                        length = i - 1;
                    }
                }
                for (int i = 0; i <= length; i++)
                {
                    op1 += calc[i];
                }
                for (int i = length + 2; i < calc.Length; i++)
                {
                    op2 += calc[i];
                }
                if (op == "*")
                {
                    Console.WriteLine(Convert.ToSingle(op1) * Convert.ToSingle(op2));
                }
                else if (op == "/")
                {
                    Console.WriteLine(Convert.ToSingle(op1) / Convert.ToSingle(op2));
                }
                else if (op == "+")
                {
                    Console.WriteLine(Convert.ToSingle(op1) + Convert.ToSingle(op2));
                }
                else if (op == "-")
                {
                    Console.WriteLine(Convert.ToSingle(op1) - Convert.ToSingle(op2));
                }
            } while (calc != "q");
        }
    }
}
