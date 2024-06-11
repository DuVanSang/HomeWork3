using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập tên file (bao gồm cả phần mở rộng): ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Nhập nội dung muốn ghi vào file:");
        string content = Console.ReadLine();

        // Ghi nội dung vào file
        WriteToFile(fileName, content);

        // Đọc và hiển thị nội dung từ file
        string readContent = ReadFromFile(fileName);
        Console.WriteLine("\nNội dung trong file:");
        Console.WriteLine(readContent);
    }

    static void WriteToFile(string fileName, string content)
    {
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine("Ghi nội dung vào file thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Có lỗi xảy ra: {ex.Message}");
        }
    }

    static string ReadFromFile(string fileName)
    {
        try
        {
            string content = File.ReadAllText(fileName);
            return content;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Có lỗi xảy ra khi đọc file: {ex.Message}");
            return string.Empty;
        }
    }
}