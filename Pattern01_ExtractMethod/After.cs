using System;

namespace Pattern01_ExtractMethod
{
    public class After
    {
        private string name = "Nguyễn Văn A";

        public void PrintOwing()
        {
            this.PrintBanner();
            this.PrintDetails();
        }

        private void PrintDetails()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("amount: " + this.GetOutstanding());
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private double GetOutstanding()
        {
            return 250000.0;
        }
    }
}