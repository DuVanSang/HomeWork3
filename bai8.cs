using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Hiển thị bảng mã ASCII");
            Console.WriteLine("2. Hiển thị bảng mã UTF-8 của trang mã 65001");
            Console.WriteLine("3. Phát tiếng beep khi nhấn phím Space");
            Console.WriteLine("4. Đếm số lần xuất hiện của mỗi kí tự trong chuỗi");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayASCII();
                    break;
                case "2":
                    DisplayUTF8();
                    break;
                case "3":
                    BeepOnSpace();
                    break;
                case "4":
                    CountCharacterOccurrences();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void DisplayASCII()
    {
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine($"ASCII {i}: {(char)i}");
        }
    }

    static void DisplayUTF8()
    {
        Encoding utf8 = Encoding.GetEncoding(65001);
        for (int i = 0; i < 128; i++)
        {
            byte[] bytes = { (byte)i };
            string utf8String = utf8.GetString(bytes);
            Console.WriteLine($"UTF-8 {i}: {utf8String}");
        }
    }

    static void BeepOnSpace()
    {
        Console.WriteLine("Nhấn phím Space để phát tiếng beep (Nhấn phím 'ESC' để thoát):");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    static void CountCharacterOccurrences()
    {
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Số lần xuất hiện của mỗi kí tự:");
        foreach (KeyValuePair<char, int> pair in charCount)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }
}