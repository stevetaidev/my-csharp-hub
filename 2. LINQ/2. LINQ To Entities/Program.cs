using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


// Định nghĩa lớp đối tượng đại diện cho bảng Students trong cơ sở dữ liệu
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// Kế thừa từ DbContext để tạo đối tượng kết nối với cơ sở dữ liệu
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}

class Program
{
    static void Main()
    {
        // Khởi tạo đối tượng DbContext để làm việc với cơ sở dữ liệu
        using (var context = new SchoolContext())
        {
            // Tạo và thêm một sinh viên vào cơ sở dữ liệu
            var newStudent = new Student { FirstName = "John", LastName = "Doe" };
            context.Students.Add(newStudent);
            context.SaveChanges();

            // Sử dụng LINQ to Entities để truy vấn dữ liệu từ cơ sở dữ liệu
            var students = context.Students.Where(s => s.FirstName == "John").ToList();

            // In danh sách sinh viên ra màn hình
            Console.WriteLine("Danh sách sinh viên có FirstName là 'John':");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        Console.ReadLine();
    }
}
