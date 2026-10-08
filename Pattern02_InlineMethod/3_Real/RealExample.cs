using System;

namespace Pattern02_InlineMethod._3_Real
{
    internal class RealExample
    {
        // Bài toán thực tế: Kiểm tra điều kiện ưu đãi khách hàng
        public void CheckDiscount(double totalAmount, int membershipYears)
        {
            // Thay vì tạo hàm IsEligible() riêng chỉ có 1 dòng, ta nhúng thẳng biểu thức vào đây
            bool isEligibleForDiscount = totalAmount >= 1000000 && membershipYears >= 2;

            if (isEligibleForDiscount)
            {
                Console.WriteLine("Khách hàng ĐỦ ĐIỀU KIỆN nhận voucher giảm giá 15%!");
            }
            else
            {
                Console.WriteLine("Khách hàng CHƯA ĐỦ ĐIỀU KIỆN nhận voucher.");
            }
        }
    }
}