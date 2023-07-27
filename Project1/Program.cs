using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name ="Денис";
            age = 22;
            programCount = 1;
            money = 100000;
            time = 604800;
            truth = true;

            Console.WriteLine("Здравствйте меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " лет.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#");
            Console.WriteLine("Когда я закончу обучения я хочу зарабатывать " + money + " денег в " + time + " наносикунд");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");

        }
    }
}
