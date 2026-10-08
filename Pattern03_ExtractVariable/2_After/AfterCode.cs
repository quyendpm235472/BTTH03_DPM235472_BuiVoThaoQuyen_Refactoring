using System;

namespace Pattern03_ExtractVariable._2_After
{
    public class AfterCode
    {
        public double GetPrice(int quantity, double itemPrice)
        {
            // Tách các phần của biểu thức thành biến tạm có tên rõ nghĩa
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 50) * itemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100.0);

            return basePrice - quantityDiscount + shipping;
        }
    }
}