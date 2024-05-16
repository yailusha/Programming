using System; //Подключение объектов в области видимости System

namespace LB1._1._2 //Объявление пространства имён
{
    class program //Объявление класса
    {
        static void Main(string[] args) //Точка входа 
        {
            decimal a; //Объявление переменной для математических операций
            Console.WriteLine("Введите число: "); //Вывод информации
            a = decimal.Parse(Console.ReadLine()); //Ввод передаваемых данных
            decimal a2 = a * a; //Возведение числа во 2 степень
            decimal a4 = a2 * a2; //Возведение числа в 4 степень
            decimal a8 = a4 * a4; //Возведение числа в 8 степень
            decimal a12 = a4 * a8; //Возведение числа в 12 степень
            decimal a13 = a12 * a; //Возведение числа в 13 степень
            Console.WriteLine("Число в 13 степени: " + a13 + "."); //Вывод числа 
            Console.ReadLine(); //Ожидание действий
        }
    }
}