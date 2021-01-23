using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson_1_C3_vlasoves
{
    
    class Program
    {
        static void Print(string msg, int x, int y)     // Положение курсора на экране
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        static void Pause()     // Функция остановки
        {
            Console.ReadKey();
        }

        static void dataRequest(string quest/*msg*/, out string userData/*, /*string tempVar*/)
        {
            Console.Write(quest);
            userData = Console.ReadLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(Enumerable.Repeat<char>(' ', Console.BufferWidth).ToArray());
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            //tempVar = userData;
        }

        static void lineRewrite()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(Enumerable.Repeat<char>(' ', Console.BufferWidth).ToArray());
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void anketa()
        {
            #region Exercise_1 *** Задание №1 *** ***АНКЕТА***
            /*           
             *  1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
             *  В результате вся информация выводится в одну строчку.
             *  а) используя склеивание;
             *  б) используя форматированный вывод;
             *  в) *используя вывод со знаком $.
             */

            string firstName;   // Переменная Имени
            string lastName;    // Переменнная Фамилии
            string userAge;     // Переменная возраста
            string userHeight;  // Переменная роста
            string userWeight;  // Переменная веса

            string userData;
            //string tempVar;
            string[] quest = { "Укажите Ваше Имя: ", "Укажите Вашу Фамилию: ", "Укажите Ваш возраст: ",
                                "Укажите Ваш рост в см.: ", "Укажите свой вес в кг.: "};
            Console.Write("Задание 'Анкета'\n\n");

            dataRequest(quest[0], out userData);
            firstName = userData;

            dataRequest(quest[1], out userData);
            lastName = userData;

            dataRequest(quest[2], out userData);
            userAge = userData;

            dataRequest(quest[3], out userData);
            userHeight = userData;

            dataRequest(quest[4], out userData);
            userWeight = userData;

            Console.WriteLine("Результат 1: " + firstName + " " + lastName + " " + userAge + " "
                                              + userHeight + " " + userWeight);
            Console.WriteLine(string.Format("Результат 2: {0} {1} {2} {3} {4}", firstName, lastName, userAge, userHeight, userWeight));

            Console.WriteLine($"Результат 3: {firstName} {lastName} {userAge} {userHeight} {userWeight}");
            Pause();

            #endregion
        }
        static void Main(string[] args)
        {
            Console.Title = "Домашие задание по С# Урок 1. Исп. Власов Е. С.";

            Console.WriteLine("Выберети задание для просмотра указав его порядковый номе:\n"+
                              "1) Задание 'Анкета'.\n" +
                              "2) Задание 'Расчет индекса массы тела'.\n"+
                              "3) Задание 'Расчет растояне между точками'.\n"+
                              "4) Задание 'Обмен значениями двух переменных'.\n" +
                              "5) Задание 'Вывод текста на экране сиспользованием метода'.");
            var answer = Convert.ToInt32(Console.ReadLine());
            
            switch(answer)
            {
                case 1:
                    Console.Clear();
                    anketa();
                    break;

                case 2:
                    #region Exercise_2 *** Задание №2 *** ***ИНДЕКС МАССЫ ТЕЛА***
                    /* 
                     * 2.Ввести вес и рост человека.
                     * Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
                     * где m — масса тела в килограммах, h — рост в метрах
                     */
                    Console.Write("Задание **Расчет индекса массы тела**\n\n");

                    Console.Write("Введите Ваш вес в килограммах: ");
                    double m = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите Ваш рост в метрах: ");
                    double h = Convert.ToDouble(Console.ReadLine());

                    double i = m / (h * h);

                    Console.Write("Ваш индекс массы тела равен: {0:0.00}", i);
                    Console.ReadKey();

                    #endregion
                    break;

                case 3:
                    #region Exercise_3 *** Задание №3 *** ***Расчет растояния между точками***
                    /* 
                     * 3.а) Написать программу, которая подсчитывает расстояние между точками 
                     * с координатами x1, y1 и x2,y2 
                     * по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
                     * Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
                     * б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
                     */
                    double x1, y1, x2, y2;

                    Console.Clear();
                    Console.WriteLine("Задание расчета растояния между точками 'x' и 'y' по их коордитатом!");

                    Console.Write("Введите координаты 'х' точки №1: ");
                    x1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите координаты 'y' точки №1: ");
                    y1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите координаты 'х' точки №2: ");
                    x2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите координаты 'y' точки №2: ");
                    y2 = Convert.ToDouble(Console.ReadLine());

                    double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                    Console.Write("Растояние между точками 'x' и 'y' равняется: {0:f}", r);
                    Console.ReadKey();
                    #endregion

                    break;

                case 4:
                    #region Exercise_4 *** Задание №4 *** ***Обмен значениями двух переменных***
                    /*
                     * 4. Написать программу обмена значениями двух переменных.
                     * а) с использованием третьей переменной;
                     * б) *без использования третьей переменной.
                     */

                    Console.Clear();
                    Console.WriteLine("Задание Обмен значениями двух переменных!");

                    Console.Write("Введите значение переменной 'a': ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите значение переменной 'b': ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\na = {0} : b = {1}.\n", a, b);

                    int a1 = a;
                    int b1 = b;

                    int c1 = a1;
                    a1 = b1;
                    b1 = c1;

                    Console.WriteLine("Вариант с использованием 3-й переменной!:\n"+
                        "c = a : {2} = {0}\n" +
                        "a = b : {0} = {1}\n" +
                        "b = c : {1} = {2}\n\n" +
                        "a = {0} : b = {1}.", a1, b1, c1);

                    int a2 = a;
                    int b2 = b;

                    a2 = a2 + b2;
                    b2 = a2 - b2;
                    a2 = a2 - b2;

                    Console.WriteLine("\nВариант без использования 3-й переменной!:\n" +
                        "a = a + b : {0} = {0} + {1}\n" +
                        "b = a - b : {1} = {0} - {1}\n" +
                        "a = a - b : {0} = {0} - {1}\n\n" +
                        "a = {0} : b = {1}", a2, b2);

                    Console.Read();
                     
                    #endregion
                    break;

                case 5:
                    #region Exercise_5 *** Задание №5 *** ***Вывод текста на экране с использованием Метода***

                    Console.Clear();
                    Console.Write("Задание 'Вывод текста на экране сиспользованием метода'.\n");

                    Print("Власов Евгений Сергеевич, г. Санкт-Петербург", 25, 25);


                    #endregion

                    break;
            }




}
}
}
