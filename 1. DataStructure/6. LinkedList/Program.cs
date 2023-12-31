using System;
using System.Collections.Generic;
/*
LinkedList trong C# là một cấu trúc dữ liệu tuyến tính 
mà bạn có thể sử dụng để lưu trữ và quản lý danh sách các phần tử. 
Mỗi phần tử trong LinkedList được gọi là một "nút" và chứa dữ liệu của nó 
cùng với một tham chiếu đến nút tiếp theo trong danh sách. 
LinkedList thường được sử dụng khi bạn cần thêm hoặc xóa các phần tử thường xuyên trong danh sách 
mà không cần sao chép lại toàn bộ danh sách, điều này làm giảm đáng kể thời gian thực hiện các thao tác này so với mảng.
 */
class Program
{
    static void Main()
    {
        // Khởi tạo một LinkedList của kiểu int
        LinkedList<int> linkedList = new LinkedList<int>();

        // Thêm các phần tử vào LinkedList
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // In ra các phần tử trong LinkedList
        Console.WriteLine("Danh sách sau khi thêm:");
        PrintLinkedList(linkedList);

        // Xóa phần tử đầu tiên
        linkedList.RemoveFirst();
        Console.WriteLine("Danh sách sau khi xóa phần tử đầu tiên:");
        PrintLinkedList(linkedList);

        // Xóa phần tử cuối cùng
        linkedList.RemoveLast();
        Console.WriteLine("Danh sách sau khi xóa phần tử cuối cùng:");
        PrintLinkedList(linkedList);

        // Kiểm tra xem LinkedList có chứa một phần tử cụ thể hay không
        int elementToCheck = 20;
        bool containsElement = linkedList.Contains(elementToCheck);
        Console.WriteLine($"LinkedList có chứa phần tử {elementToCheck}: {containsElement}");

        // Tìm và in ra index của một phần tử trong LinkedList
        int elementToFind = 5;
        int index = FindIndex(linkedList, elementToFind);
        Console.WriteLine($"Index của phần tử {elementToFind}: {index}");
    }

    // Phương thức in ra các phần tử trong LinkedList
    static void PrintLinkedList(LinkedList<int> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    // Phương thức tìm index của một phần tử trong LinkedList
    static int FindIndex(LinkedList<int> list, int element)
    {
        int index = 0;
        foreach (var item in list)
        {
            if (item == element)
            {
                return index;
            }
            index++;
        }
        return -1; // Trả về -1 nếu không tìm thấy phần tử
    }
}
