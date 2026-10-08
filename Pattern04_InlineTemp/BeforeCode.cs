using System;

namespace Pattern04_InlineTemp._1_Before
{
    public class Order
    {
        public double BasePrice { get; set; } = 1200;
    }

    public class BeforeCode
    {
        public bool IsOrderExpensive(Order order)
        {
            // Biến tạm basePrice chỉ gán lại thuộc tính có sẵn, không cần thiết
            double basePrice = order.BasePrice;
            return basePrice > 1000;
        }
    }
}