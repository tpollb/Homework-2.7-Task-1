using System;

namespace Homework_2._7_Task_1
{
    class Program
    {
        static void Main()
        {
            //переменные
            string Name = "Сергей";
            string Surname = "Усков";
            string Secondname = "Евгеньевич";
            int ProgrammingGrade = 1;
            int MathsGrade = 2;
            int PhysicsGrade = 3;
                    
            Console.WriteLine(" Name: {0}\n Secondname: {1}\n Surname: {2}\n", Name, Secondname, Surname);
            Console.WriteLine(" Programming Grade: {0}\t Maths Grade: {1}\t Physics Grade: {2}\t", ProgrammingGrade, MathsGrade, PhysicsGrade);

            Console.ReadKey();
        }
    }
}
