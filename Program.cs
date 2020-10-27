using System;

namespace Step_Homework_3
{
    class Program
    {
        /*Домашнее задание №3*/
        static void Main(string[] args)
        {
            /*Встреча №5*/
            /*Задание 1: Пользователь вводит с клавиатуры расстояние
            до аэропорта и время, за которое нужно доехать.
            Вычислить скорость, с которой ему нужно ехать.*/

            /*Console.Write("Enter S: ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter T: ");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.Write("V = " + S / T);
            Console.ReadKey();*/


            /*Задание 2: Пользователь вводит с клавиатуры время начала
            и время завершения телефонного разговора
            (часы, минуты и секунды). Посчитать стоимость разговора,
            если стоимость минуты – 30 копеек.*/

            /*Console.Write("Введите время начала тел. разговора - часы: ");
            double Time1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время начала тел. разговора - минуты: ");
            double Time2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время начала тел. разговора - секунды: ");
            double Time3 = Convert.ToDouble(Console.ReadLine());
            Time1 = Time1 * 3600;
            Time2 = Time2 * 60;
            Time3 = Time3 * 1;
            Console.Write("Введите время конца тел. разговора - часы: ");
            double Time4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время конца тел. разговора - минуты: ");
            double Time5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время конца тел. разговора - секунды: ");
            double Time6 = Convert.ToDouble(Console.ReadLine());
            Time4 = Time4 * 3600;
            Time5 = Time5 * 60;
            Time6 = Time6 * 1;
            double a = (Time4 + Time5 + Time6) - (Time1 + Time2 + Time3);
            Console.WriteLine("Продолжительность разговора в мин.: " + a / 60);
            Console.WriteLine("Стоимость разговора: " + (a / 60) * 30 + " копеек");
            Console.ReadKey();*/


            /*Задание 3: Пользователь вводит с клавиатуры расстояние, расход бензина
            на 100 км и стоимость трех видов бензина. Вывести на экран
            сравнительную таблицу со стоимостью поездки на разных
            видах бензина.*/

            /*Console.Write("Расстояние (км): ");
            double R = Convert.ToDouble(Console.ReadLine()); // 
            Console.Write("Средний расход топлива (л/100 км): ");
            double SRT = Convert.ToDouble(Console.ReadLine()); // 
            Console.Write("1 - Стоимость 1 л. топлива (грн/литр): ");
            double S1LT_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 - Стоимость 1 л. топлива (грн/литр): ");
            double S1LT_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3 - Стоимость 1 л. топлива (грн/литр): ");
            double S1LT_3 = Convert.ToDouble(Console.ReadLine());
            double NKT = 12 * (R / 100);
            double SP1 = S1LT_1 * NKT;
            double SP2 = S1LT_2 * NKT;
            double SP3 = S1LT_3 * NKT;
            Console.WriteLine(NKT + " - Необходимое количество топлива (л)");
            Console.WriteLine(SP1 + " - Стоимость поездки (грн)");
            Console.WriteLine(SP2 + " - Стоимость поездки (грн)");
            Console.WriteLine(SP3 + " - Стоимость поездки (грн)");
            Console.ReadKey();*/


            /*Встреча №6*/
            /*Пользователь вводит с клавиатуры время в секундах, прошедшее с начала дня. Вывести на
            экран текущее время в часах, минутах и секундах. Посчитать, сколько часов, минут и секунд осталось до полуночи.*/

            /*Console.Write("Введите секунды: ");
            double sec_write = Convert.ToDouble(Console.ReadLine());
            double h = 3600;
            double m = 60;
            Console.WriteLine("\nСейчас:\n" + "Часов - " + (int)(sec_write / h % 12));
            Console.WriteLine("Минут - " + (int)(sec_write / m % 60));
            Console.WriteLine("Секунд - " + (int)(sec_write % 60));
            Console.ReadKey();*/


            /*Задание 2*/
            /*Пользователь вводит с клавиатуры время в секундах, прошедшее с начала рабочего дня.
            Посчитать, сколько целых часов ему осталось сидеть на работе, если рабочий день – 8 часов.*/

            /*Console.Write("Введите секунды: ");
            double sec_write = Convert.ToDouble(Console.ReadLine());
            double h = 3600;
            double m = 60;
            Console.WriteLine("\nСейчас:\n" + "Часов - " + (int)(sec_write / h % 12));
            Console.WriteLine("Минут - " + (int)(sec_write / m % 60));
            Console.WriteLine("Секунд - " + (int)(sec_write % 60));
            Console.Write("\nОсталось до 8-го часа - ");
            Console.Write((int)(8 - sec_write / h % 12) + " часов, ");
            Console.Write((int)((60)-(sec_write / m % 60))%60 + " минут и ");
            Console.Write((int)((60) - (sec_write % 60)) % 60 + " секунд");
            Console.ReadKey();*/
        }
    }
}