using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_group
{
    internal class Person
    {
        string name;
        string surname;
        int age;
        string phone;
        public Person()
            : this(string.Empty, string.Empty, 0, string.Empty)
        {

        }
        public Person(string name, string surname, int age, string phone)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != "")
                    surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value != "")
                    phone = value;
            }
        }
        public void Print()
        {
            Console.Write($"{name}\t\t{surname}\t\t{age}\t\t{phone}");
        }
        public void Add()
        {
            Console.WriteLine("Введите Имя студента:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию студента:");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст студента:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите телефон студента:");
            Phone = Console.ReadLine();
        }
    }
}
