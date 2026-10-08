using System;
using Pattern04_InlineTemp._1_Before;
using Pattern04_InlineTemp._2_After;
using Pattern04_InlineTemp._3_Real;

namespace Pattern04_InlineTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Đơn hàng đắt tiền: {before.IsOrderExpensive(new _1_Before.Order())}");

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Đơn hàng đắt tiền: {after.IsOrderExpensive(new _2_After.Order())}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.VerifyEmployeeBonus(4, 90);

            Console.ReadLine();
        }
    }
}