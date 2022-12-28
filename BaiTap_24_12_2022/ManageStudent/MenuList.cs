using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent;
internal class MenuList
{
    public void ShowMenu()
    {
        ListStudent ListStu = new();
        bool check = true;
        while (check)
        {
            Console.WriteLine("===============Function List=============");
            Console.WriteLine("Type 1: Add Student ");
            Console.WriteLine("Type 2: Remove one student in list");
            Console.WriteLine("Type 3: Looking for info about student ( by name )");
            Console.WriteLine("Type 4: Update Info of one student (by masv)");
            Console.WriteLine("Type 5: Show All About Info of Student");
            Console.WriteLine("Type 6: Show Student List Was Sorted by Masv");
            Console.WriteLine("Type 7: Exit The Program");
            Console.WriteLine("==========================================");
            Console.WriteLine("Choise the functions you wanna run:");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1: ListStu.AddNewStu();break;
                case 2: ListStu.DelStudent();break;
                case 3: ListStu.FindInfoStudent();break;
                case 4: ListStu.UpdateInfo();break;
                case 5: ListStu.SelectAllInfo();break;
                case 6: ListStu.SortListStu();break;
                case 7: check = false; break;
                default: check = false; break;
            }
        }
    }
}
