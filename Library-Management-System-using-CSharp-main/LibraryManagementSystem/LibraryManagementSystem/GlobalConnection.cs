using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class GlobalConnection
    {
        // Chuỗi kết nối tĩnh
        public static string ConnectionString = @"Data Source=LAPTOP-FG3V00LO\SQLEXPRESS03;Initial Catalog=library_management;Integrated Security=True";
        public static string ImagesFolder = @"F:\Coding\Library-Management-System-using-CSharp-main\Library-Management-System-using-CSharp-main\LibraryManagementSystem\LibraryManagementSystem\DashBoardImage";
        public static string Books_Diretory = @"F:\Coding\Library-Management-System-using-CSharp-main\Library-Management-System-using-CSharp-main\LibraryManagementSystem\LibraryManagementSystem\Books_Directory\";
        public static string Student_Directory = @"F:\Coding\Library-Management-System-using-CSharp-main\Library-Management-System-using-CSharp-main\LibraryManagementSystem\LibraryManagementSystem\Student_Directory\";
    }


}
