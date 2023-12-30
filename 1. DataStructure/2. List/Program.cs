using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khai báo và khởi tạo một List kiểu string
        List<string> fruits = new List<string>();

        // Thêm các phần tử vào List
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");
        fruits.Add("Date");

        // Truy cập và in giá trị của List
        Console.WriteLine("The first fruit is: " + fruits[0]); 

        // Duyệt qua tất cả các phần tử của List và in chúng
        Console.WriteLine("The fruits in the list are:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Kiểm tra xem một phần tử có tồn tại trong List hay không
        string searchFruit = "Cherry";
        bool exists = fruits.Contains(searchFruit);
        Console.WriteLine(searchFruit + " exists in the list: " + exists); 

        // Xóa một phần tử khỏi List
        fruits.Remove("Banana");

        // Sắp xếp List theo thứ tự bảng chữ cái
        fruits.Sort();

        // In danh sách sau khi xóa và sắp xếp
        Console.WriteLine("The sorted fruits in the list are:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
