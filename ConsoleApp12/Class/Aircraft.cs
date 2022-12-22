using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класс Aircraft должен иметь свойства Passenger (пассажирский самолет, значение bool) и
//Distance(дальность полета). Метод Show() должен выводить в консоль только название и
//дистанцию полета данного воздушного транспорта.

//         Кроме массива метод получает значение «минимальной дистанции полета». Метод
//    находит в массиве все объекты типа Aircraft, у которых дистанция больше или равна
//    минимальной.При этом сперва выведите все пассажирские самолеты, а затем остальные
//    (используйте для этого паттерн свойств).

namespace ConsoleApp12.Class
{
    internal class Aircraft : Transport
    {
        public Aircraft()   //конструктор по умолчанию
        {
            Name = "Undefined";
            Passenger = false;
            Distance = 0;
        }
        public Aircraft(string name, bool passenger, int distance)  //конструктор с параметрами
        {
            Name = name;
            Passenger = passenger;
            Distance = distance;
        }

        public bool Passenger { get; set; } //свойство пассажирский самолет или нет
        public int Distance { get; set; }   //свойство сколько пролетел самолет
        public override void Show() //метод вывода
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Название - [{Name}] | Дистанция полета - [{Distance}]");
            Console.ResetColor();
        }
    }
}