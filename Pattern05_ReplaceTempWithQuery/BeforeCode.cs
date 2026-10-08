using System;

namespace Pattern05_ReplaceTempWithQuery._1_Before
{
    public class BeforeCode
    {
        private int _quantity = 10;
        private double _itemPrice = 150.0;

        public double CalculateTotal()
        {
            // Sử dụng các biến tạm tính toán nội bộ
            double basePrice = _quantity * _itemPrice;
            double discountFactor;

            if (basePrice > 1000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }
}