using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshaga.Manage
{
    public class Generation
    {
        public double MinSalary = 15860;

        public Student student;
        public List<Student> students;

        public void GenegateStudent()
        {
            student = new Student();
            students = new List<Student>();

            Random rand = new Random();
            Generator generator = new Generator();
            for (int i = 0; i < 10;)
            {
                Student student = new Student();
                student.Group = rand.Next(1, 3);
                student.AverageScore = (double)rand.Next(10, 999);
                student.Profit = (double)rand.Next(55000, 120000);
                student.Form = (FormOfTraining)rand.Next(0, 1);
                student.Sex = (sex)rand.Next(0, 1);
                student.Family = rand.Next(1, 5);

                if (student.Sex == sex.male)
                {
                    student.Fio = generator.GenerateDefault(Gender.man);
                }
                else
                    student.Fio = generator.GenerateDefault(Gender.woman);
                students.Add(student);
                i++;
            }

        }

        public void PrintStudents(List<Student> list)
        {
            foreach (Student item in list)
            {
                Console.WriteLine("Fil - " + item.Fio);
                Console.WriteLine("Group - " + item.Group);
                Console.WriteLine("Form - " + item.Form);
                Console.WriteLine("Average score - " + item.AverageScore);
                Console.WriteLine("Profit - " + item.Profit);
                Console.WriteLine("Family - " + item.Family);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
            }
        }

        public List<Student> bufer;

        public void CheckToHostel(List<Student> students)
        {
            bufer = new List<Student>();
            students = students.OrderBy(o => o.Profit).ToList();
            foreach (Student item in students)
            {
                if (students.Count() < 10)
                {
                    if ((item.Profit / item.Family) < (MinSalary * 2))
                    {
                        Console.WriteLine("0000000000000000000000000000000000000000000000");
                        Console.WriteLine(item.Fio);
                        bufer.Add(item);
                        
                    }
                }
            }


            //students = students.OrderBy(o => o.Profit).ToList();

            //foreach (Student item in students)
            //{
            //    if ((item.Profit / item.Family) < (MinSalary * 2))
            //    {
            //        PrintStudents(students);
            //    }

            //}
        }

        public void Print(List<Student> bufer)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            foreach (Student item in bufer)
            {
                Console.WriteLine("Fio - " + item.Fio);
                Console.WriteLine("Group - " + item.Group);
                Console.WriteLine("Profit - " + item.Profit);
                Console.WriteLine("Number of family members - " + item.Family);
                Console.WriteLine("");
            }
        }
        
    }
}




