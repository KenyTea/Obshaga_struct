using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace Obshaga
{
    public enum sex { male, female }
    public enum FormOfTraining { fullTime, correspondence }


    /*Ф.И.О. студента, группу, средний балл, доход на члена семьи, пол (перечисление), форма обучения(перечисление).*/
    public struct Student
    {
        public static double MinSalery = 24560;

        public string Fio { get; set; }
        public int Group { get; set; }
        public double AverageScore { get; set; }
        public double Profit { get; set; }
        public sex Sex { get; set; }
        public FormOfTraining Form { get; set; }
        public int Family { get; set; }
        public List<Student> students;

        public void GenegateStudent()
        {
            students = new List<Student>();

            Random rand = new Random();
            Generator generator = new Generator();
            for (int i = 0; i < 10; )
            {
                Student student = new Student();
                Group = rand.Next(1, 3);
                AverageScore = (double)rand.Next(10, 999);
                Profit = (double)rand.Next(55000, 12000);
                Form = (FormOfTraining)rand.Next(0, 1);
                Sex = (sex)rand.Next(0, 1);
                Family = rand.Next(1, 5);

                if (Sex == sex.male)
                {
                    Fio = generator.GenerateDefault(Gender.man);
                }
                else
                    Fio = generator.GenerateDefault(Gender.woman);
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
