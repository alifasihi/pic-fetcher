# Pic Fetcher

دانلود سادهٔ تصویر از اینترنت با C# و ذخیره روی Desktop با نام یکتا (Timestamp).

## ویژگی‌ها
- استفاده از `HttpClient` برای دانلود امن و سریع
- ساخت URL نهایی از `baseUrl` و `joinUrl`
- ذخیرهٔ مستقیم روی Desktop کاربر
- جلوگیری از overwrite با نام‌گذاری مبتنی بر تاریخ/ساعت

## پیش‌نیازها
- [.NET 6+](https://dotnet.microsoft.com/)
- دسترسی اینترنت

## نصب و اجرا
```bash
git clone https://github.com/<your-username>/pic-fetcher.git
cd pic-fetcher
dotnet run
