using ConsoleApp12.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Создайте класс AuthorizedData, который представляет данные для авторизации некоторого
//  пользователя. Свойства класса:
//   Login – логин пользователя.
//   AccessType – тип доступа: обычный незарегистрированный пользователь (user),
//  оператор (operator) или администратор(admin). Можно использовать enum.
//   Password – пароль пользователя.
//  Методы класса:
//   Show() – вывод данных пользователя на экран консоли (для проверки).
//   В классе должен быть реализован метод деконструкции для применения
//  позиционного паттерна

namespace ConsoleApp12.Class
{
    enum AccessType     //для выбора уровня доступа пользователя
    {
        Admin,
        User,
        Operator
    }
    internal class AuthorizedData
    {
        public string Login { get; set; }   //свойство логин
        public AccessType Access { get; set; }  //свойство уровень доступа
        public string Password { get; set; }    //свойство пароль

        public void Show()  //метод вывод
        {
            Console.Write($"Логин - [{Login}] | Тип доступа - [{Access}] | Пароль - [{Password}]"); 
        }

        public void Deconstruct(out string Login, out AccessType? Access, out string Password)  //деконструктор
        {
            Login = this.Login;
            Access = this.Access;
            Password = this.Password;
        }
    }
}
