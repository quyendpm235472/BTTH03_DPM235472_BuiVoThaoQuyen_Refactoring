using System;

namespace Pattern05_ReplaceTempWithQuery._2_After
{
    public class AfterCode
    {
        private int _quantity = 10;
        private double _itemPrice = 150.0;

        public double CalculateTotal()
        {
            // Thay biến tạm bằng phương thức truy vấn (Query)
            return BasePrice() * DiscountFactor();
        }

        private double BasePrice() => _quantity * _itemPrice;

        private double DiscountFactor() => BasePrice() > 1000 ? 0.95 : 0.98;
    }
}