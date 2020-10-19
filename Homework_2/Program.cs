using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.



            int HowMuch = 0; // Переменная количества учащихся и колличества иттераций цикла

            
            for (int i = 0; i < 1; i++) // Данный цикл необходим только для проверки корректности  введенных данных и возвращает в начало программы при ошибочном вводе.
            {
                Console.Write("Введите количество учащихся: "); // Запрос ввода колличества учащихся

                if (int.TryParse(Console.ReadLine(), out HowMuch))  // проверка верности введенных данных
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат"); // Вывод предупреждения о неверном формате введенных данных
                    i--;
                    continue;
                }
            }

            string[] Names = new string[HowMuch]; // Массив введенных имен
            byte[] Ages = new byte[HowMuch]; // Массив введенного возраста
            int[] Rises = new int[HowMuch], AllAverages = new int[HowMuch]; // Массивы роста и среднего балла
            sbyte HystoryPoint, MathsPoint, RusLangPoint; // переменные оценок заданных предметов
            byte Age, Rise; // переменная проверки корректности введенных типов данных
    
            // Цикл заполнения массивов
            for (int i = 0; i < HowMuch; i++)
            {
                Console.Write("Введите Имя: ");   //
                string Name = Console.ReadLine(); // Ввод Имени
                
                if (Name != string.Empty) // условие проверки пустой переменной имени
                {
                    Names[i] = Name; // помещение имени в массив
                }
                else
                {
                    Console.WriteLine("Вы не ввели имя"); //
                    Console.ReadKey();                    // сообщнеие об ошибке
                    i--;
                    continue;                                //
                }


                Console.Write("Введите возраст: ");              

                if (byte.TryParse(Console.ReadLine(), out Age)) // Условие проверки корректности введенного типа данных
                {
                    if (Age < 110) // условие проверки превышения возраста
                    {
                        Ages[i] = Age; // помещение возраста в массив
                    }

                    else
                    {
                        Console.WriteLine("Вы ввели неверный возраст");  //
                        Console.ReadKey();                               // сообщнеие об ошибке
                        i--;                                             //
                        continue;                                        //
                    }
                }
                else
                {
                    Console.WriteLine("Неверый формат возраста.");      //
                    Console.ReadKey();                                  // сообщнеие об ошибке
                    i--;                                                // Возврат к началу итерации
                    continue;                                           //
                }

                Console.Write("Введите Рост: ");

                if (byte.TryParse(Console.ReadLine(), out Rise))// Условие проверки корректности введенного типа данных
                {
                    if (Rise < 200) // условие проверки превышения роста
                    {
                        Rises[i] = Rise; // помещение роста в массив
                    }

                    else
                    {
                        Console.WriteLine("Вы ввели неверный рост");  //
                        Console.ReadKey();                            // сообщнеие об ошибке
                        i--;                                          //Возврат к началу итерации
                        continue;                                     //
                    }

                }
                else
                {
                    Console.WriteLine("Неверый формат роста.");     //
                    Console.ReadKey();                              // сообщнеие об ошибке
                    i--;                                            //Возврат к началу итерации
                    continue;                                       //
                }


                Console.Write("Введите баллы по Истории: ");       //
                HystoryPoint = sbyte.Parse(Console.ReadLine());    // Ввод баллов по Истории

                Console.Write("Введите баллы по Математике: ");
                MathsPoint = sbyte.Parse(Console.ReadLine());      // Ввод баллов по Математике

                Console.Write("Введите баллы по Русскому языку: ");//
                RusLangPoint = sbyte.Parse(Console.ReadLine());    // Ввод баллов по Русскому языку

                int Average = (HystoryPoint + MathsPoint + RusLangPoint) / 3; // расчет среднего балла
                AllAverages[i] = Average;                         // помещение среднего балла в массив
                Console.WriteLine("");                            // Пустая строка для более удобного визуального восприятия
            }

            Console.ForegroundColor = ConsoleColor.Red; // Смена цвета шапки таблицы

            Console.WriteLine($"{"Имя",10} {"Возраст",20} {"Рост",30} {"Средний балл",40}"); // Формирование шапки таблицы

            Console.ForegroundColor = ConsoleColor.Gray; // Смена цвета реультата вывода

            for (int j = 0; j < HowMuch; j++) // Цикл вывода массивов в консоль
            {
                Console.WriteLine($"{Names[j], 10} {Ages[j], 20} {Rises[j], 30} {AllAverages[j],40}"); // Форматирование вывда
            }
            Console.ReadKey();
        }
    }
}
