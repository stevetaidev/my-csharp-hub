using System;
using System.Collections.Generic;

/*
SortedSet trong C# là một cấu trúc dữ liệu tập hợp (set) mà các phần tử trong nó được duy trì theo thứ tự tăng dần
(sắp xếp). Nó là một phần của không gian tên System.Collections.Generic 
và cho phép bạn thêm, xóa và truy vấn các phần tử một cách hiệu quả, 
với thời gian trung bình O(log n) cho các thao tác cơ bản.
 */
class Program
{
    static void Main()
    {
        // Tạo một SortedSet chứa các số nguyên
        SortedSet<int> sortedSet = new SortedSet<int>();

        // Thêm các phần tử vào SortedSet
        sortedSet.Add(5);
        sortedSet.Add(2);
        sortedSet.Add(8);
        sortedSet.Add(1);
        sortedSet.Add(4);

        // Hiển thị các phần tử trong SortedSet theo thứ tự sắp xếp
        Console.WriteLine("Các phần tử trong SortedSet:");
        foreach (int item in sortedSet)
        {
            Console.WriteLine(item);
        }

        // Kiểm tra xem một phần tử có tồn tại trong SortedSet hay không
        bool contains = sortedSet.Contains(3);
        Console.WriteLine("Phần tử 3 có tồn tại trong SortedSet: " + contains);

        // Xóa một phần tử khỏi SortedSet
        sortedSet.Remove(2);

        // Hiển thị lại các phần tử sau khi xóa
        Console.WriteLine("Các phần tử trong SortedSet sau khi xóa:");
        foreach (int item in sortedSet)
        {
            Console.WriteLine(item);
        }

        // Truy cập phần tử nhỏ nhất và lớn nhất trong SortedSet
        int min = sortedSet.Min;
        int max = sortedSet.Max;
        Console.WriteLine("Phần tử nhỏ nhất: " + min);
        Console.WriteLine("Phần tử lớn nhất: " + max);

        // Tạo một SortedSet mới và thực hiện phép hợp (union) giữa hai SortedSet
        SortedSet<int> otherSet = new SortedSet<int> { 3, 6, 8 };
        sortedSet.UnionWith(otherSet);

        // Hiển thị các phần tử sau phép hợp
        Console.WriteLine("Các phần tử sau phép hợp:");
        foreach (int item in sortedSet)
        {
            Console.WriteLine(item);
        }
    }
}
