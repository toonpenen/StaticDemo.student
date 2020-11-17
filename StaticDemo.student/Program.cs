using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo.student
{
    public static class Student
    {
        static Student()
        {

        }
        public static int count { get; set; }
        public static int Id { get; set; }
        public static string Adress { get; set; }
        public static string Name { get; set; }

        public static void Show()
        {

        }
     }    
    
    public class Teacher
    {     
        public Teacher()
        {

        }        
        public string Name { get; set; }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Teacher name";

            Student.Name = "Mauro";
        }
    }
}
