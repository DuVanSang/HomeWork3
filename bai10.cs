using System;
using System.Text;

class Program
{
    struct Student
    {
        public string Name;
        public double Score;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int studentCount = 0;
        Student[] students = InputStudentInformation(out studentCount);
        DisplayStudentsInformation(students, studentCount);
    }

    static Student[] InputStudentInformation(out int studentCount)
    {
        Console.Write("Nhập số lượng sinh viên: ");
        studentCount = int.Parse(Console.ReadLine());
        Student[] students = new Student[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
            Console.Write("Tên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Điểm: ");
            students[i].Score = double.Parse(Console.ReadLine());
        }

        return students;
    }

    static void DisplayStudentsInformation(Student[] students, int studentCount)
    {
        double totalScore = 0;

        Console.WriteLine("\nThông tin sinh viên:");
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Sinh viên {i + 1}: Tên: {students[i].Name}, Điểm: {students[i].Score}");
            totalScore += students[i].Score;
        }

        double averageScore = totalScore / studentCount;
        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore}");
    }
}
