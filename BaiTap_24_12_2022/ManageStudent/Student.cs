using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent;
internal class Student
{
    public string MaSv { get; set; }
    public string TenSv { get; set; }
    public string GioiTinh { get; set; }
    public DateTime DoB { get; set; }
    public Student() { }
    public void AddStudent()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        //=====================================
        Console.WriteLine("Enter The MaSv: ");
        MaSv = Console.ReadLine();
        Console.WriteLine("Enter The Name: ");
        TenSv = Console.ReadLine();
        Console.WriteLine("Gender: ");
        GioiTinh = Console.ReadLine();
        Console.WriteLine("DoB (yyyy-MM-dd): ");
        DoB = DateTime.Parse(Console.ReadLine());
    }


    public override string ToString()
    {
        return $"{{{nameof(MaSv)}={MaSv.ToString()}, {nameof(TenSv)}={TenSv}, {nameof(GioiTinh)}={GioiTinh.ToString()}, {nameof(DoB)}={DoB.ToString("dd/MM/yyyy")}}}";
    }
}
