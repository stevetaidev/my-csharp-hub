using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Khởi tạo một List các số nguyên
        List<int> numbers = new List<int> { 1, 4, 6, 8, 3, 9, 2, 5, 7 };

        // Sử dụng phương thức Where để lọc các số chẵn
        var evenNumbers = numbers.Where(x => x % 2 == 0);

        Console.WriteLine("Các số chẵn:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        // Sử dụng phương thức OrderBy để sắp xếp dãy số theo thứ tự tăng dần
        var sortedNumbers = numbers.OrderBy(x => x);

        Console.WriteLine("\nDãy số sắp xếp theo thứ tự tăng dần:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }

        // Sử dụng phương thức GroupBy để nhóm các số theo chia hết cho 3
        var groupedNumbers = numbers.GroupBy(x => x % 3);

        Console.WriteLine("\nCác số được nhóm theo phần dư khi chia cho 3:");
        foreach (var group in groupedNumbers)
        {
            // Key là phần dư khi chia cho 3 , Value là một List các số có cùng phần dư
            Console.WriteLine("Phần dư " + group.Key + ":");
            foreach (var number in group)
            {
                Console.WriteLine(number);
            }
        }

        Console.ReadLine();
    }
}
