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
        private string Fio_;
        public string Fio
        {
            get
            {
                return Fio_;
            }
            set
            {
                Fio_ = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int Group { get; set; }
        public double AverageScore { get; set; }
        public double Profit { get; set; }
        public sex Sex { get; set; }
        public FormOfTraining Form { get; set; }
        public int Family { get; set; }
    }
}
