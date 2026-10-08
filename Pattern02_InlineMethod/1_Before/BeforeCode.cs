using System;

namespace Pattern02_InlineMethod._1_Before
{
    public class BeforeCode
    {
        private int _numberOfLateDeliveries = 6;

        // Hàm gốc chưa Refactor: Gọi một phương thức quá đơn giản
        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        // Phương thức này quá đơn giản, không mang lại giá trị gia tăng nào
        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}