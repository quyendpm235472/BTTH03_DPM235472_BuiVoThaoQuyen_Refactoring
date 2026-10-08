using System;

namespace Pattern03_ExtractVariable._3_Real
{
    internal class RealExample
    {
        public void CheckPlatformSupport(string platform, string browser, int buildNumber)
        {
            // Tách các điều kiện kiểm tra môi trường phức tạp thành các biến bool
            bool isMacOs = platform.ToUpper().Contains("MAC");
            bool isSafari = browser.ToUpper().Contains("SAFARI");
            bool isSupportedBuild = buildNumber >= 100;

            if (isMacOs && isSafari && isSupportedBuild)
            {
                Console.WriteLine("Hệ thống hỗ trợ đầy đủ các tính năng nâng cao.");
            }
            else
            {
                Console.WriteLine("Hệ thống đang chạy ở chế độ tương thích cơ bản.");
            }
        }
    }
}