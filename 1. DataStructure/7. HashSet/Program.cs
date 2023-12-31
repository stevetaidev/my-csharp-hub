using System;
using System.Collections.Generic;
/*
 HashSet trong C# là một tập hợp (collection) không có thứ tự và không cho phép các phần tử trùng lặp. 
 */
class Program
{
    static void Main()
    {
        // Khởi tạo một HashSet kiểu int
        HashSet<int> numbers = new HashSet<int>();

        // Thêm phần tử vào HashSet sử dụng phương thức Add
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // Thêm một phần tử trùng lặp
        bool isAdded = numbers.Add(2); 

        Console.WriteLine("Phần tử 2 đã được thêm vào HashSet: " + isAdded); 

        // Loại bỏ phần tử sử dụng phương thức Remove
        bool isRemoved = numbers.Remove(3); 
        Console.WriteLine("Phần tử 3 đã bị loại bỏ khỏi HashSet: " + isRemoved); 

        // Kiểm tra sự tồn tại của một phần tử trong HashSet
        bool exists = numbers.Contains(1);
        Console.WriteLine("Phần tử 1 tồn tại trong HashSet: " + exists); 

        // Duyệt qua các phần tử trong HashSet
        Console.WriteLine("Các phần tử trong HashSet:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
