//**Data Hiding with Properties**

//Create a `Student` class where `Name` and `RollNo` are private fields.Use properties to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).


using System;
namespace c__Assignment
{
    class Student
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RollNo cannot be negative.");
                }
                rollNo = value;
            }
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Student student = new Student();
    //        student.Name = "Aravind";
    //        student.RollNo = 441;
    //        Console.WriteLine($"Name: {student.Name}, RollNo: {student.RollNo}");
    //    }
    //}
}