using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Student
    {
        private string name;
        private int age;
        private double gpa;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
        }

        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("GPA must be between 0 and 4.0.");
                }
            }
        }

        public bool IsHonorStudent
        {
            get
            {
                return GPA > 3.5;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"Honor Student: {IsHonorStudent}");
        }
    }

    class properties
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.Name = "John Doe";
            student1.Age = 20;
            student1.GPA = 3.8;

            student1.DisplayInfo();
            Console.ReadLine();
        }
    }
}
