namespace SkillFactory.Module4 {
    class Switch {
		public static void Main(string[] args) {
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //string color = "red";

            //while (color != "stop")
            //{
            //    color = Console.ReadLine();                
            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        //Добавьте в программу обработку ввода цвета cyan, а в блоке default поменяйте на желтый цвет цвет фона, а цвет текста — на красный.
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;

            //        case "stop":
            //            Console.BackgroundColor = ConsoleColor.White;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ending coloring.");
            //            break;

            //        default:
            //            Console.BackgroundColor = ConsoleColor.Magenta;
            //            Console.ForegroundColor = ConsoleColor.Yellow;

            //            Console.WriteLine("Your color is iNcoRrEct!");
            //            break;
            //    }
            //}



            //Console.WriteLine("Цикл while");
            //int k = 0;
            //int y = Convert.ToInt32(Console.ReadLine());

            //while (k < y)
            //{
            //	Console.WriteLine(k);

            //	Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //	switch (Console.ReadLine())
            //	{
            //                 case "red":
            //                     Console.BackgroundColor = ConsoleColor.Red;
            //                     Console.ForegroundColor = ConsoleColor.Black;

            //                     Console.WriteLine("Your color is red!");
            //                     break;

            //                 case "green":
            //                     Console.BackgroundColor = ConsoleColor.Green;
            //                     Console.ForegroundColor = ConsoleColor.Black;

            //                     Console.WriteLine("Your color is green!");
            //                     break;
            //                 //Добавьте в программу обработку ввода цвета cyan, а в блоке default поменяйте на желтый цвет цвет фона, а цвет текста — на красный.
            //                 case "cyan":
            //                     Console.BackgroundColor = ConsoleColor.Cyan;
            //                     Console.ForegroundColor = ConsoleColor.Black;

            //                     Console.WriteLine("Your color is cyan!");
            //                     break;

            //                 case "stop":
            //                     Console.BackgroundColor = ConsoleColor.White;
            //                     Console.ForegroundColor = ConsoleColor.Black;

            //                     Console.WriteLine("Ending coloring.");
            //                     break;

            //                 default:
            //                     Console.BackgroundColor = ConsoleColor.Magenta;
            //                     Console.ForegroundColor = ConsoleColor.Yellow;

            //                     Console.WriteLine("Your color is iNcoRrEct!");
            //                     break;
            //             }

            //             k++;
            //}

            //Console.WriteLine("Цикл do");
            //int t = 0;

            //do
            //{
            //	Console.WriteLine(t);

            //	Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //	switch (Console.ReadLine())
            //	{
            //		case "red":
            //			Console.BackgroundColor = ConsoleColor.Red;
            //			Console.ForegroundColor = ConsoleColor.Black;

            //			Console.WriteLine("Your color is red!");
            //			break;

            //		case "green":
            //			Console.BackgroundColor = ConsoleColor.Green;
            //			Console.ForegroundColor = ConsoleColor.Black;

            //			Console.WriteLine("Your color is green!");
            //			break;
            //		//Добавьте в программу обработку ввода цвета cyan, а в блоке default поменяйте на желтый цвет цвет фона, а цвет текста — на красный.
            //		case "cyan":
            //			Console.BackgroundColor = ConsoleColor.Cyan;
            //			Console.ForegroundColor = ConsoleColor.Black;

            //			Console.WriteLine("Your color is cyan!");
            //			break;

            //		case "stop":
            //			Console.BackgroundColor = ConsoleColor.White;
            //			Console.ForegroundColor = ConsoleColor.Black;

            //			Console.WriteLine("Ending coloring.");
            //			break;

            //		default:
            //			Console.BackgroundColor = ConsoleColor.Magenta;
            //			Console.ForegroundColor = ConsoleColor.Yellow;

            //			Console.WriteLine("Your color is iNcoRrEct!");
            //			break;
            //	}

            //	t++;
            //} while (t < y);
            //int sum = 0, add;
            //while (true)
            //{
            //    Console.Write("Введите число: ");
            //    add = Convert.ToInt32(Console.ReadLine());

            //    if (add > 0)
            //        sum = sum + add;
            //    else if (add == 0)
            //        break;
            //}
            //Console.WriteLine("Сумма равна: " + sum);


            //Console.Write("Введите Ваше имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Ваше имя по буквам: ");
            //foreach (char letter in name)
            //{
            //    Console.Write(letter + " ");
            //}

            //Console.Write("\nПоследняя буква Вашего имени: " + name[name.Length - 1]);

            //Console.Write("Введите Ваше имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Ваше имя в обратном порядке: ");

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(name[i] + " ");
            //}


            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //Console.WriteLine(array.Length);

            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Количество строк: ");
            //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            //Console.Write("Количество колонок: ");
            //Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");

            //    Console.WriteLine();
            //}

            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //        Console.Write(array[k, i] + " ");

            //    Console.WriteLine();
            //}

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int t = 0; t < arr.Length - 1; t++)
            //    {
            //        if (arr[t] > arr[t + 1])
            //        {
            //            int a = arr[t];
            //            arr[t] = arr[t + 1];
            //            arr[t + 1] = a;
            //        }
            //    }
            //}


            //int sum = 0;
            //foreach (int element in arr)
            //    sum = sum + element;
            //foreach (int el in arr)
            //    Console.Write(el + " ");
            //Console.WriteLine("\nСумма равна: " + sum);
            //int[][] array = new int[3][];
            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (var el in array)
            //{
            //    foreach (int elem in el)
            //        Console.Write(elem + " ");
            //}


            //foreach (var color in favcolors)
            //{
            //    foreach (var item in color)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}



            //Задайте одномерный массив и напишите алгоритм, который находит в нем количество положительных чисел.
            //int[,] nums = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //int count = 0;
            //foreach (int el in nums) {
            //    if (el > 0)
            //        count++;
            //}
            //Console.WriteLine("Количество положительных чисел: " + count);


            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int t = 0; t < arr.GetUpperBound(1) + 1; t++)
                {
                    Console.Write(arr[i, t] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                {
                    for (int t = 0; t < arr.GetUpperBound(1); t++)
                    {
                        if (arr[i, t] > arr[i, t + 1])
                        {
                            int a = arr[i, t];
                            arr[i, t] = arr[i, t + 1];
                            arr[i, t + 1] = a;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int t = 0; t < arr.GetUpperBound(1) + 1; t++)
                {
                    Console.Write(arr[i, t] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
