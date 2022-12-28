using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent;
internal class ListStudent
{
    List<Student> ListStu;
    public int total;
    public ListStudent() {
        ListStu = new List<Student>();
    }
    public List<Student> GetListStu() { return ListStu; }
    public void SetListStu(List<Student> ListStu) 
    {
        this.ListStu = ListStu;
            
    }

    public void AddNewStu()
    {
        Student stu = new();
        stu.AddStudent();
        ListStu.Add(stu);
    }

    public void DelStudent()
    {
        Console.WriteLine("Enter the id you wanna delete");
        string IdStu = Console.ReadLine();
        ListStu.RemoveAll(stu => stu.MaSv == IdStu);
        Console.WriteLine("Student was deleted");
    }

    public void FindInfoStudent()
    {
        Console.WriteLine("Enter the name of Student: ");
        string StuName = Console.ReadLine();
        ListStu.Where(stu => stu.TenSv == StuName).ToList().ForEach(Console.WriteLine);
    }

    public void UpdateInfo()
    {
        Console.WriteLine("Enter the MaSv you wanna Update Info: ");
        string masv = Console.ReadLine();
        ListStu.ForEach(stu => 
        { 
            if (stu.MaSv == masv)
            {
                Console.WriteLine("Enter the name: ");
                stu.TenSv = Console.ReadLine();
                Console.WriteLine("Gender: ");
                stu.GioiTinh = Console.ReadLine();
                Console.WriteLine("DoB (yyyy-MM-dd)");
                stu.DoB = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("The Info of Student was updated");
                Console.WriteLine(stu);
            }
        
        });
    }

    public void SelectAllInfo()
    {
        IEnumerator<Student> enu = ListStu.GetEnumerator();
        while (enu.MoveNext())
        {
            Console.WriteLine(enu.Current.ToString());
        }
    }

    public void SortListStu()
    {
        ListStu.OrderByDescending(stu => stu.MaSv).ToList().ForEach(Console.WriteLine);
    }

}
