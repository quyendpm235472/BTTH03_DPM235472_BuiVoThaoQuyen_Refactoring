using System;

namespace Pattern02_InlineMethod._2_After
{
    public class AfterCode
    {
        private int _numberOfLateDeliveries = 6;

        // Hàm sau khi áp dụng Inline Method: Code gọn gàng, trực quan hơn
        public int GetRating()
        {
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}