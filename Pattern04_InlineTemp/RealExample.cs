using System;

namespace Pattern04_InlineTemp._3_Real
{
    internal class RealExample
    {
        public void VerifyEmployeeBonus(int yearsOfService, int kpiScore)
        {
            // Nhúng trực tiếp điều kiện xét thưởng thay vì gán biến trung gian
            if (yearsOfService >= 3 && kpiScore >= 85)
            {
                Console.WriteLine("Nhân viên đạt tiêu chuẩn thưởng cuối năm.");
            }
            else
            {
                Console.WriteLine("Nhân viên chưa đạt tiêu chuẩn thưởng.");
            }
        }
    }
}