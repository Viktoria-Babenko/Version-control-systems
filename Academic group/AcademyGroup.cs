using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_group
{
    internal class AcademyGroup 
    {
        private ArrayList array;
        public AcademyGroup()
        {
            array = new ArrayList();
        }
        public AcademyGroup(int size)
        {
            array = new ArrayList(size);
        }
        public void Add() // метод Add для добавления студентов в группу;
        {
            try
            {
                Console.Clear();
                Console.Write(" Сколько студентов добавить? ");
                string? s = Console.ReadLine();
                int number = int.Parse(s);

                for (int i = 0; i < number; i++)
                {
                    Student student = new Student();
                    Console.WriteLine("Введите данные " + (i + 1) + " студента");
                    student.Add();
                    array.Add(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "\n");
            }

        }
        public void Print() //метод печати группы Print;
        {
            Console.Clear();
            Console.WriteLine("Группа студентов :");
            Console.Write("Имя \tФамилия \tВозраст \tТелефон \tСредний балл \tНомер группы\n");
            for (int i = 0; i < array.Count; i++)
            {
                Student? student = array[i] as Student;
                student.Print();
            }
        }
    }
}
