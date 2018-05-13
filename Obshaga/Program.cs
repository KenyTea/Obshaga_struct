using Obshaga.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obshaga
{
    /*2.	Для получения места в общежитии формируется список студентов,который включает:
      Ф.И.О. студента, группу, средний балл, доход на члена семьи, пол (перечисление), форма обучения(перечисление).
      Общежитие в первую очередь предоставляется тем, у кого доход на члена семьи меньше двух минимальных зарплат,
      затем остальным в порядке уменьшения среднего балла. Вывести список очередности предоставления мест в общежитии.*/

    class Program
    {
        static void Main(string[] args)
        {
            

            Generatino gen = new Generatino();
            gen.GenegateStudent();
            gen.PrintStudents(gen.students);
        }
    }
}
