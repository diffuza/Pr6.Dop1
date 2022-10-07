using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // Изменяем шапку программы(цветовая гамма)
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("********************"); //вывод на экран цветоизмененной строки "..."
            Console.WriteLine("**** Мой проект ****"); //вывод на экран цветоизмененной строки "..."
            Console.WriteLine("********************"); //вывод на экран цветоизмененной строки "..."
            // Изменяем цветовую гамму основной программы.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");//вывод на экран цветоизмененной строки "..."
                       
            Console.ReadLine(); // Ожидание нажатия клавиши Enter перед завершением работы.
        }
    }
}
