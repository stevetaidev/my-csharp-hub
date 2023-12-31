using Newtonsoft.Json.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Chuỗi JSON đầu vào
        string json = @"
        {
            ""name"": ""John Doe"",
            ""age"": 30,
            ""isStudent"": false,
            ""languages"": [""C#"", ""JavaScript"", ""Python""]
        }";

        // Đọc và deserialize JSON thành đối tượng JObject
        JObject jsonObject = JObject.Parse(json);

        // Truy xuất giá trị từ JSON bằng cách sử dụng LINQ
        string name = (string)jsonObject["name"];
        int age = (int)jsonObject["age"];
        bool isStudent = (bool)jsonObject["isStudent"];
        JArray languages = (JArray)jsonObject["languages"];

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Is Student: {isStudent}");

        Console.WriteLine("Languages:");
        foreach (var language in languages)
        {
            Console.WriteLine(language);
        }

        // Sửa đổi giá trị JSON
        jsonObject["age"] = 31;
        jsonObject["isStudent"] = true;
        jsonObject["languages"].Add("Java");

        // Serialize JObject thành chuỗi JSON mới
        string newJson = jsonObject.ToString();
        Console.WriteLine("\nModified JSON:");
        Console.WriteLine(newJson);

        Console.ReadLine();
    }
}
