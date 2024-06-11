using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Đảo ngược chuỗi");
            Console.WriteLine("2. Đếm số lượng từ trong chuỗi");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReverseString();
                    break;
                case "2":
                    CountWords();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void ReverseString()
    {
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();

        // Đảo ngược chuỗi
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
    }

    static void CountWords()
    {
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();

        // Đếm số lượng từ trong chuỗi
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine("Số lượng từ trong chuỗi: " + wordCount);
    }
}
