using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Tạo một đối tượng Queue
        Queue myQueue = new Queue();

        // Thêm các phần tử vào hàng đợi
        myQueue.Enqueue("Apple");
        myQueue.Enqueue("Banana");
        myQueue.Enqueue("Cherry");
        myQueue.Enqueue("Date");

        // In ra số phần tử trong hàng đợi
        Console.WriteLine("Số phần tử trong hàng đợi: " + myQueue.Count);

        // Lấy ra phần tử đầu tiên và in ra
        string firstItem = (string)myQueue.Dequeue();
        Console.WriteLine("Phần tử đầu tiên: " + firstItem);

        // In ra số phần tử còn lại sau khi lấy ra một phần tử
        Console.WriteLine("Số phần tử trong hàng đợi sau khi lấy ra một phần tử: " + myQueue.Count);

        // Kiểm tra xem có phần tử "Cherry" trong hàng đợi hay không
        bool containsCherry = myQueue.Contains("Cherry");
        Console.WriteLine("Có phần tử 'Cherry' trong hàng đợi: " + containsCherry);

        // Lấy ra và in ra tất cả các phần tử còn lại trong hàng đợi
        Console.WriteLine("Các phần tử còn lại trong hàng đợi:");
        while (myQueue.Count > 0)
        {
            string item = (string)myQueue.Dequeue();
            Console.WriteLine(item);
        }
    }
}
