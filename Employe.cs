using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Employe
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employe(int id, string fullName, DateTime dateOfBirth, string position, decimal salary)
        {
            Id = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Табельный номер: {Id}\nФИО: {FullName}\nДата рождения: {DateOfBirth.ToShortDateString()}\nДолжность: {Position}\nОклад: {Salary:C2}";
            // Количество сотрудников
            int n = 5;

            // Создание массива сотрудников
            Employe[] employees = new Employe[n];

            // Заполнение массива данными
            employees[0] = new Employe(1, "Иванов Иван Иванович", new DateTime(1980, 1, 1), "Менеджер", 50000);
            employees[1] = new Employe(2, "Петрова Мария Сергеевна", new DateTime(1985, 2, 2), "Инженер", 40000);
            employees[2] = new Employe(3, "Сидоров Сергей Петрович", new DateTime(1990, 3, 3), "Разработчик", 60000);
            employees[3] = new Employe(4, "Кузнецова Анна Владимировна", new DateTime(1995, 4, 4), "Бугалтер", 45000);
            employees[4] = new Employe(5, null, DateTime.MinValue, null, 0); // Отсутствует информация

            // Вывод информации в табличном виде
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-20} {4,-10}", "Таб. номер", "ФИО", "Дата рождения", "Должность", "Оклад");
            Console.WriteLine(new string('-', 80));

            foreach (Employe employee in employees)
            {
                if (employee.FullName == null)
                {
                    Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-20} {4,-10}", employee.Id, "Информация отсутствует", employee.DateOfBirth.ToShortDateString(), employee.Position, employee.Salary);
                }
                else
                {
                    Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-20} {4,-10}", employee.Id, employee.FullName, employee.DateOfBirth.ToShortDateString(), employee.Position, employee.Salary);
                }
            }
        }
    }
}

