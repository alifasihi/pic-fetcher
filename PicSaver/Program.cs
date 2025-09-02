using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string baseUrl = "";
        string joinUrl = "";

        string url = new Uri(new Uri(baseUrl), joinUrl).ToString();

        using (HttpClient client = new HttpClient())
        {
            try
            {
                byte[] content = await client.GetByteArrayAsync(url);

                // مسیر دسکتاپ کاربر
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // ساخت اسم یکتا با تاریخ و ساعت
                string fileName = "image_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

                // مسیر کامل
                string filePath = Path.Combine(desktopPath, fileName);

                File.WriteAllBytes(filePath, content);

                Console.WriteLine("✅ عکس روی دسکتاپ ذخیره شد: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ خطا: " + ex.Message);
            }
        }
    }
}
