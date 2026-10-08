using System;
using Pattern03_ExtractVariable._1_Before;
using Pattern03_ExtractVariable._2_After;
using Pattern03_ExtractVariable._3_Real;

namespace Pattern03_ExtractVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Tổng giá: {before.GetPrice(100, 20):N0}");

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Tổng giá: {after.GetPrice(100, 20):N0}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.CheckPlatformSupport("MacOS Monterey", "Safari Browser", 105);

            Console.ReadLine();
        }
    }
}