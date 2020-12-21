using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_to_Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit = 60;
            int freq = 750;
            string Alpha = "";
            int Choice = 0;
            Dictionary<string, string> AlphaToMorse = new Dictionary<string, string>
            {
                {"a", "·–"},
                { "b", "–···"},
                { "c", "–·–·"},
                { "d", "–··"},
                {"e", "·"},
                { "f", "··–·"},
                { "g", "––·"},
                { "h", "····"},
                {"i", "··"},
                { "j", "·–––"},
                { "k", "–·–"},
                { "l", "·–··"},
                {"m", "––"},
                { "n", "–·"},
                { "o", "–––"},
                { "p", "·––·"},
                {"q", "––·–"},
                { "r", "·–·"},
                { "s", "···"},
                { "t", "–"},
                {"u", "··–"},
                { "v", "···–"},
                { "w", "·––"},
                { "x", "–··–"},
                {"y", "–·––"},
                { "z", "––··"},
                { "0", "–––––"},
                { "1", "·––––"},
                {"2", "··–––"},
                { "3", "···––"},
                { "4", "····–"},
                { "5", "·····"},
                {"6", "–····"},
                { "7", "––···"},
                { "8", "–––··"},
                { "9", "––––·"}
            };
            while (Choice != 9)
            {
                DisplayMenu(ref Choice);
                if (Choice == 1)
                {
                    GetText(ref Alpha);
                    OutputMorse(unit, freq, Alpha, AlphaToMorse);
                }
                else if (Choice == 2)
                {
                    DisplayOptions(Choice, ref unit, ref freq);
                }
            }
        }

        static void DisplayMenu(ref int Choice)
        {
            Console.Clear();
            Console.WriteLine("1. Text to Morse");
            Console.WriteLine("2. Options");
            Console.WriteLine("9. Quit");
            Console.WriteLine();
            Console.Write("Input: ");
            try
            {
                Choice = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please try again");
                Console.ReadLine();
            }
        }

        static void GetText(ref string Alpha)
        {
            Console.Write("Enter text to encode: ");
            Alpha = Console.ReadLine();
        }

        static void OutputMorse(int unit, int freq, string Alpha, Dictionary<string, string> AlphaToMorse)
        {
            foreach(char chr in Alpha)
            {
                if (chr == ' ')
                {
                    Console.Write("| ");
                    Thread.Sleep(4 * unit); 
                }
                else
                {
                    string Morse = "";
                    Morse = AlphaToMorse[Convert.ToString(chr)];
                    foreach (char sound in Morse)
                    {
                        if (sound == '·')
                        {
                            Console.Write("·");
                            Console.Beep(freq, unit);
                        }
                        else if (sound == '–')
                        {
                            Console.Write("–");
                            Console.Beep(freq, 3 * unit);
                        }
                        Thread.Sleep(unit);
                    }
                    Console.Write(" ");
                    Thread.Sleep(3 * unit);

                }  
            }
            Console.ReadLine();
        }

        static void DisplayOptions(int Choice, ref int unit, ref int freq)
        {
            while (Choice != 9)
            {
                Console.Clear();
                Console.WriteLine("1. Change time unit. (Current {0}ms)", unit);
                Console.WriteLine("2. Change frequency. (Current {0}Hz)", freq);
                Console.WriteLine("9. Return");
                Console.WriteLine();
                Console.Write("Input: ");
                try
                {
                    Choice = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                if (Choice == 1)
                {
                    Console.Write("New time unit (ms): ");
                    try
                    {
                        unit = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please try again");
                        Console.ReadLine();
                    }
                }
                else if (Choice == 2)
                {
                    Console.Write("New frequency (Hz): ");
                    try
                    {
                        freq = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please try again");
                        Console.ReadLine();
                    }
                }
            }
            
        }
    }
}
