using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_group
{
    internal class Student : Person , IComparable
    {
        double average;
        int number_of_group;
        public Student() : this(string.Empty, string.Empty, 0, string.Empty, 0, 0)
        {

        }
        public Student(string name, string surname, int age, string phone, double average, int number_of_group)
            : base(name, surname, age, phone)
        {
            Average = average;
            Number_Of_Group = number_of_group;
        }

        public double Average
        {
            get
            {
                return average;
            }
            set
            {
                if (value > 0)
                    average = value;
            }
        }
        public int Number_Of_Group
        {
            get
            {
                return number_of_group;
            }
            set
            {
                if (value > 0)
                    number_of_group = value;
            }
        }
        public void Print()
        {
            base.Print();
            Console.Write($"\t\t{average}\t\t{number_of_group}\n");
        }
        public void Add()
        {
            base.Add();
            Console.WriteLine("Введите средний балл студента:");
            Average = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер группы студента:");
            Number_Of_Group = int.Parse(Console.ReadLine());
        }
        public int CompareTo(object obj)
        {
            if (obj is Student)
                return this.Surname.CompareTo((obj as Student).Surname);

            throw new NotImplementedException();
        }
        public class SortByAge : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Age.CompareTo((obj2 as Student).Age);

                throw new NotImplementedException();
            }
        }
        public class SortByAverage : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Average.CompareTo((obj2 as Student).Average);

                throw new NotImplementedException();
            }
        }
        public class SortByNumberOfGroup : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Number_Of_Group.CompareTo((obj2 as Student).Number_Of_Group);

                throw new NotImplementedException();
            }
        }
    }
}
