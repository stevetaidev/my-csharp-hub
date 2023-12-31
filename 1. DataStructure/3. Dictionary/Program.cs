using System;
using System.Collections.Generic;
/*
 Dictionary: Dictionary là một tập hợp các cặp khóa-giá trị, 
trong đó mỗi khóa là duy nhất và được sử dụng để tra cứu giá trị tương ứng. 
Dictionary thường được sử dụng để thực hiện tìm kiếm nhanh chóng.
 */
class Program
{
    static void Main()
    {
        // Khai báo và khởi tạo một Dictionary với khóa là string và giá trị là int.
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm các cặp khóa-giá trị vào Dictionary.
        myDictionary.Add("apple", 10);
        myDictionary.Add("banana", 5);
        myDictionary.Add("cherry", 15);

        // Truy xuất giá trị dựa trên khóa.
        int appleCount = myDictionary["apple"];
        int cherryCount = myDictionary["cherry"];

        Console.WriteLine("Số lượng táo: " + appleCount); 
        Console.WriteLine("Số lượng cherry: " + cherryCount);

        // Kiểm tra xem một khóa có tồn tại trong Dictionary hay không.
        if (myDictionary.ContainsKey("banana"))
        {
            Console.WriteLine("Có chuối trong Dictionary");
        }
        else
        {
            Console.WriteLine("Không có chuối trong Dictionary");
        }

        // Duyệt qua tất cả các cặp khóa-giá trị trong Dictionary.
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine("Khóa: " + kvp.Key + ", Giá trị: " + kvp.Value);
        }

        // Xóa một phần tử khỏi Dictionary bằng khóa.
        myDictionary.Remove("banana");

        // Kiểm tra xem chuối còn tồn tại trong Dictionary sau khi xóa.
        if (myDictionary.ContainsKey("banana"))
        {
            Console.WriteLine("Có chuối trong Dictionary");
        }
        else
        {
            Console.WriteLine("Không có chuối trong Dictionary");
        }
    }
}
