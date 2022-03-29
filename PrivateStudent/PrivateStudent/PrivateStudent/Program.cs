using System;

namespace PrivateStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Fazile";
            string groupNo = "as21f";
            Student student = new Student();
            student.FullName = fullName;
            student.GroupNo = groupNo;
            Console.WriteLine(student.GroupNo);
        }
    }
}
