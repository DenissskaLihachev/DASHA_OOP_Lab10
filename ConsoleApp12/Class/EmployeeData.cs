using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Class
{
    public enum Status //для выбора директор это или работник
    {
        Director,
        Worker
    }

    public delegate int SalaryCalculate(Status status);    //делегат
    public delegate double Rate(int Experience);
    internal class EmployeeData
    {
        SalaryCalculate salarycalculate  = SalaryCalcul;     //добавляем в делегат метод
        Rate rate = CalcRate;   //добавляем в делегат метод

        private int experience; //опыт
        public string? Name { get; set; }   //имя
        public Status Status { get; set; }  //должность
        public int Experience { get => experience; set => experience = value >= 0 ? value : 0; }    //свойство опыт
        public double Salary { get => salarycalculate(Status) * rate(experience); } //зарплата, которая высчитывается, исходя из опыта

        public void Show()  //метод вывода
        { 
            Console.Write("Имя - ["); 
            Console.Write(Name);
 
            Console.Write("] | Должность - [");
            Console.Write(Status);
 
            Console.Write("] | Опыт - ["); 
            Console.Write(Experience);

            Console.Write("] | Зарплата - [");
            Console.Write(Salary); 
            Console.Write("]\n");
        }

        public static int SalaryCalcul(Status status) => status switch  //метод высчитывания запрлаты
        {
            (Status.Director) => 999999,
            (Status.Worker) => 99999,
            (_) => 0
        };

        public static double CalcRate(int exp)  //метод выщитывания коэффициента (нужен для высчитывания заплаты) высчитывается, исходя из опыта
        {
            return exp switch
            {
                < 3 => 1,
                >= 3 and < 5 => 1.1,
                >= 5 => 2
            };
        }
    }
}