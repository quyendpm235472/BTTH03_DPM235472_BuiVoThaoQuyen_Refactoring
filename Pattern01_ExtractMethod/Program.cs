using System;
using System.Collections.Generic;

namespace Pattern01_ExtractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("==================================================");
            Console.WriteLine("     DEMO PATTERN 01: EXTRACT METHOD (TÁCH HÀM)   ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("--- 1. CHẠY CODE BEFORE (TRƯỚC REFACTOR) ---");
            Before beforeDemo = new Before();
            beforeDemo.PrintOwing();
            Console.WriteLine();

            Console.WriteLine("--- 2. CHẠY CODE AFTER (SAU REFACTOR) ---");
            After afterDemo = new After();
            afterDemo.PrintOwing();
            Console.WriteLine();

            Console.WriteLine("--- 3. CHẠY CODE REAL (ỨNG DỤNG THỰC TẾ) ---");
            Real.InvoiceService invoiceService = new Real.InvoiceService();

            List<Real.OrderItem> cart = new List<Real.OrderItem>
            {
                new Real.OrderItem("Sữa tươi Vinamilk 1L", 35000, 2),
                new Real.OrderItem("Bánh mì Sandwich", 22000, 1),
                new Real.OrderItem("Cà phê Highlands", 15000, 3)
            };

            
            invoiceService.ExportInvoice("Bùi Vũ Thảo Quyên", cart, 0.1);

            Console.WriteLine("\n==================================================");
            Console.WriteLine("Chương trình chạy hoàn tất. Bấm phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}