using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshaga.Manage
{
    public class Generatino
    {
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
                student.Profit = (double)rand.Next(55000, 12000);
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
            }
        }

    }


}

