using System;
using Pattern02_InlineMethod._1_Before;
using Pattern02_InlineMethod._2_After;
using Pattern02_InlineMethod._3_Real;

namespace Pattern02_InlineMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE REFACTORING ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Đánh giá điểm tín nhiệm: {before.GetRating()}");

            Console.WriteLine("\n--- 2. AFTER REFACTORING ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Đánh giá điểm tín nhiệm: {after.GetRating()}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.CheckDiscount(1200000, 3);

            Console.ReadLine();
        }
    }
}