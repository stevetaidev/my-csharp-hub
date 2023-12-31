using System;
using System.Collections.Generic;
/*
Là một tính năng cho phép bạn viết các lớp, phương thức và delegate có thể làm việc với nhiều kiểu dữ liệu khác nhau
mà không cần phải xác định kiểu dữ liệu cụ thể cho đến khi bạn sử dụng chúng. 
Điều này giúp tái sử dụng mã và làm cho mã của bạn trở nên linh hoạt hơn. 
Thông qua generic, bạn có thể tạo ra các lớp và phương thức chung 
có thể hoạt động với các kiểu dữ liệu khác nhau mà không cần phải viết lại mã nhiều lần.
 */
public class GenericExample<T>
{
    // Khởi tạo một danh sách các đối tượng kiểu T
    private List<T> items = new List<T>();

    // khởi tạo một phương thức AddItem() cho phép thêm một đối tượng kiểu T vào danh sách
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // Khởi tạo một phương thức GetItem() cho phép lấy một đối tượng kiểu T từ danh sách
    public T GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException("Index out of range.");
    }

    // Khởi tạo một thuộc tính Count cho phép lấy số lượng đối tượng trong danh sách
    public int Count
    {
        get { return items.Count; }
    }
}

class Program
{
    static void Main()
    {
        // Tạo một đối tượng GenericExample sử dụng kiểu int
        GenericExample<int> intExample = new GenericExample<int>();
        intExample.AddItem(10);
        intExample.AddItem(20);
        Console.WriteLine($"Count: {intExample.Count}");
        Console.WriteLine($"Item at index 0: {intExample.GetItem(0)}");
        Console.WriteLine($"Item at index 1: {intExample.GetItem(1)}");

        // Tạo một đối tượng GenericExample sử dụng kiểu string
        GenericExample<string> stringExample = new GenericExample<string>();
        stringExample.AddItem("Hello");
        stringExample.AddItem("World");
        Console.WriteLine($"Count: {stringExample.Count}");
        Console.WriteLine($"Item at index 0: {stringExample.GetItem(0)}");
        Console.WriteLine($"Item at index 1: {stringExample.GetItem(1)}");
    }
}
