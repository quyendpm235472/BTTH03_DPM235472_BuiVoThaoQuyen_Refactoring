using System;

namespace Pattern04_InlineTemp._2_After
{
    public class Order
    {
        public double BasePrice { get; set; } = 1200;
    }

    public class AfterCode
    {
        public bool IsOrderExpensive(Order order)
        {
            // Thay thế biến tạm bằng trực tiếp thuộc tính/biểu thức
            return order.BasePrice > 1000;
        }
    }
}