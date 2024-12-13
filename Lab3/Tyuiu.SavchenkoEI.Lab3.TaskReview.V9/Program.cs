
using SolveArray.Lib;
using SolveCalculate.Lib;
using SolveMathFirstExpression.Lib;
using SolveMathSecondExpression.Lib;
using SolveTabMathFuction.Lib;

namespace Tyuiu.SavchenkoEI.Lab3.TaskReview.V9
{
    internal class Program
    {
        public static int indexItem;

        static void UpArrow()
        {
            indexItem--;
            if (indexItem < 1)
            {
                indexItem = 5;
            }
            drawMainMenu();
        }

        static void DownArrow()
        {
            indexItem++;
            if (indexItem > 5)
            {
                indexItem = 1;
            }
            drawMainMenu();
        }
        static void selectItem()
        {
            switch (indexItem)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Option3();
                    break;
                case 4:
                    Option4();
                    break;
                case 5:
                    Option5();
                    break;
            }
        }

        static void Option1()
        {

            MathFirstExpression ds = new MathFirstExpression();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" РАССЧИТАТЬ ПЕРВОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ ИСХОДНЫЕ ДАННЫЕ :                                                          ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write(" Введите значение X:    ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите значение Y:    ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ РЕЗУЛЬТАТ:                                                                 ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.WriteLine(ds.CalculateFirstExpression(x, y));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option1();
            }
        }

        static void Option2()
        {
            MathSecondExpression ds = new MathSecondExpression();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" РАССЧИТАТЬ ВТОРОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ ИСХОДНЫЕ ДАННЫЕ :                                                          ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write(" Введите значение X:    ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ РЕЗУЛЬТАТ:                                                                 ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.WriteLine(ds.CalculateSecondExpression(x));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option2();
            }
        }


        static void Option3()
        {
            TabMathFuction ds = new TabMathFuction();

            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" ПРОТАБУЛИРОВАТЬ ФУНКЦИЮ НА ЗАДАННОМ ДИАПАЗОНЕ.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ ИСХОДНЫЕ ДАННЫЕ :                                                          ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write("Старт шага = ");
            int startStep = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец шага = ");
            int endStep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ РЕЗУЛЬТАТ:                                                                 ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            double[][] result = ds.CalculateTabMathFuction(startStep, endStep);

            Console.Write('╔'); Console.Write(new string('═', 10)); Console.Write('╤'); Console.Write(new string('═', 10)); Console.WriteLine('╗');
            Console.WriteLine("║{0,10}│{1,10}║", "x", "f(x)");
            Console.Write('╟'); Console.Write(new string('─', 10)); Console.Write('┼'); Console.Write(new string('─', 10)); Console.WriteLine('╢');

            foreach (double[] elem in result)
            {
                Console.WriteLine("║{0,10}│{1,10}║", elem[0], elem[1]);
            }

            Console.Write('╚'); Console.Write(new string('═', 10)); Console.Write('╧'); Console.Write(new string('═', 10)); Console.WriteLine('╝');


            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");
            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option3();
            }
        }

        static void Option4()
        {
            Calculate calc = new Calculate();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" КАЛЬКУЛЯТОР.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ ИСХОДНЫЕ ДАННЫЕ :                                                          ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write(" Число a = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Число b = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ РЕЗУЛЬТАТ:                                                                 ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write(string.Format(" Сумма: {0} + {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateSumma(num1, num2));
            Console.Write(string.Format(" Разность: {0} - {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateDifference(num1, num2));
            Console.Write(string.Format(" Произведение: {0} * {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateMultiplication(num1, num2));
            Console.Write(string.Format(" Частное: {0} / {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateQuotient(num1, num2));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option4();
            }
        }

        static void Option5()
        {

            Random random = new Random();
            ArraySEI ds = new ArraySEI();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine(" ОБРАБОТКА ОДНОМЕРНОГО МАССИВА.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 3);

            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ ИСХОДНЫЕ ДАННЫЕ :                                                          ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");
            Console.Write(" Начало диапазона генерации значений x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Конец диапазона генерации значений x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Количество эллементов в массиве n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(x1, x2);
            }
            Console.WriteLine("╓────────────────────────────────────────────────────────────────────────────╖");
            Console.WriteLine("║ РЕЗУЛЬТАТ:                                                                 ║");
            Console.WriteLine("╙────────────────────────────────────────────────────────────────────────────╜");

            Console.Write(" Массив: ");
            foreach (int elem in arr)
            {
                Console.Write("{0}, ", elem);
            }
            Console.WriteLine("");
            Console.WriteLine(string.Format(" Минимальный элемент: {0} ", ds.CalculateMinimum(arr)));
            Console.WriteLine(string.Format(" Максимальный элемент: {0} ", ds.CalculateMaximum(arr)));
            Console.WriteLine(string.Format(" Среднее: {0} ", ds.CalculateAverage(arr)));
            Console.WriteLine(string.Format(" Медиана: {0} ", ds.CalculateMedian(arr)));
            Console.WriteLine(string.Format(" Количество чётных элементов: {0} ", ds.CalculateNumberOfEven(arr)));
            Console.WriteLine(string.Format(" Количество нечётных элементов: {0} ", ds.CalculateNumberOfOdd(arr)));
            Console.WriteLine(string.Format(" Количество элементов с признаками делимости на 2: {0} ", ds.SignsOfDivisibilityByTwo(arr)));
            Console.WriteLine(string.Format(" Количество элементов с признаками делимости на 3: {0} ", ds.SignsOfDivisibilityByThree(arr)));
            Console.WriteLine(string.Format(" Количество элементов с признаками делимости на 5: {0} ", ds.SignsOfDivisibilityByFive(arr)));
            Console.WriteLine(string.Format(" Количество элементов с признаками делимости на 10: {0} ", ds.SignsOfDivisibilityByTen(arr)));
            Console.SetCursorPosition(0, 24);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option5();
            }
        }



        static void OptionFS()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine(" СПРАВКА.");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Справочные сведения по работе с программной");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" Раздел меню");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(" Описание");
            Console.SetCursorPosition(64, 6);
            Console.WriteLine(" Параметр ком. строки");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 1. Расчитать первое математическое");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine(" Вычисляет математическое выражение");
            Console.SetCursorPosition(64, 8);
            Console.WriteLine(" /1 ");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 2. Рассчитать второе математическое");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine(" Вычисляет математическое выражение");
            Console.SetCursorPosition(64, 10);
            Console.WriteLine(" /2 ");
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" 3. Протабулиролвать функцию");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine(" Табулирует функцию");
            Console.SetCursorPosition(64, 12);
            Console.WriteLine(" /3 ");
            Console.SetCursorPosition(1, 14);
            Console.WriteLine(" 4. Калькулятор");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(" Выполняет расчёт +, -, *, / ");
            Console.SetCursorPosition(64, 14);
            Console.WriteLine(" /4 ");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine(" 5. Обработка одномерного массива ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine(" Обрабатывает одномерный массив ");
            Console.SetCursorPosition(64, 16);
            Console.WriteLine(" /5 ");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine(" Программу разработал: Савченко Егор Игоревич | НТм-23-1 | ТИУ 2024");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                OptionFS();
            }
        }


        static void OptionExit()
        {
            Environment.Exit(0);
        }

        static void drawMainMenu()
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.ResetColor();


            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("║                           Лабораторная работа #3                           ║");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("║                      СОЗДАНИЕ КОНСОЛЬНОГО ИНТЕРФЕЙСА.                      ║");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("╟────────────────────────────────────────────────────────────────────────────╢");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("║                      Выполнил: Савченко Егор Игоревич.                     ║");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("║                         ТИУ-2024 | группа НТм-23-1                         ║");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("     ");
            switch (indexItem)
            {
                case 0:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 1:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 2:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 4.");
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Выберите пункт меню стрелками или нажмите номер пункта [ ] ");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[9]");
            Console.ResetColor();
            Console.Write(" - Справка | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[0]");
            Console.ResetColor();
            Console.Write(" - Выход    Перемещение:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[СТРЕЛКА ВНИЗ]");
            Console.ResetColor();
            Console.Write(" | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[СТРЕЛКА ВВЕРХ]");
            Console.ResetColor();

            Console.SetCursorPosition(57, 16);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Option1();
                    break;
                case ConsoleKey.D2:
                    Option2();
                    break;
                case ConsoleKey.D3:
                    Option3();
                    break;
                case ConsoleKey.D4:
                    Option4();
                    break;
                case ConsoleKey.D5:
                    Option5();
                    break;
                case ConsoleKey.D9:
                    OptionFS();
                    break;
                case ConsoleKey.D0:
                    OptionExit();
                    break;
                default:
                    drawMainMenu();
                    break;
                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;
                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;
                case ConsoleKey.Enter:
                    selectItem();
                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 26);

            foreach (string arg in args)
            {
                if (arg == "\\1")
                {
                    Option1();
                }
                if (arg == "\\2")
                {
                    Option2();
                }
                if (arg == "\\3")
                {
                    Option3();
                }
                if (arg == "\\4")
                {
                    Option4();
                }
                if (arg == "\\5")
                {
                    Option5();
                }
            }

            drawMainMenu();
            Console.ReadKey();
        }
    }
}