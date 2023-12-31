using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một stack rỗng
        Stack<int> stack = new Stack<int>();

        // Thêm các phần tử vào stack bằng phương thức Push()
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Hiển thị các phần tử trong stack
        Console.WriteLine("Các phần tử trong stack:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Lấy và loại bỏ phần tử đầu tiên trong stack bằng phương thức Pop()
        int poppedItem = stack.Pop();
        Console.WriteLine($"Phần tử được lấy ra và loại bỏ: {poppedItem}");

        // Hiển thị lại các phần tử còn lại trong stack
        Console.WriteLine("Các phần tử còn lại trong stack sau khi loại bỏ:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Xem phần tử đầu tiên trong stack mà không loại bỏ nó bằng phương thức Peek()
        int topItem = stack.Peek();
        Console.WriteLine($"Phần tử đầu tiên trong stack (không loại bỏ): {topItem}");

        // Kiểm tra xem stack có rỗng hay không bằng phương thức Count
        if (stack.Count == 0)
        {
            Console.WriteLine("Stack hiện tại đang rỗng.");
        }
        else
        {
            Console.WriteLine($"Số phần tử trong stack: {stack.Count}");
        }
    }
}
