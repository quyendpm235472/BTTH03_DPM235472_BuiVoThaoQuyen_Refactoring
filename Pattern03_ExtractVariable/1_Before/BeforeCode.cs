using System;

namespace Pattern03_ExtractVariable._1_Before
{
    public class BeforeCode
    {
        public double GetPrice(int quantity, double itemPrice)
        {
            // Biểu thức tính toán quá phức tạp và khó đọc
            return quantity * itemPrice - Math.Max(0, quantity - 50) * itemPrice * 0.05 + Math.Min(quantity * itemPrice * 0.1, 100.0);
        }
    }
}