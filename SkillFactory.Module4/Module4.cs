namespace SkillFactory.Module4 {
    class Module4 {
        static void Main()  {
            //Запишите код, который проверяет следующее выражение: переменная A типа string не равна переменной B типа string.
            //string A = "A", B = "B";
            //bool C = A != B;
            //Console.WriteLine(C);

            //переменная A типа int меньше переменной B типа int, или переменная X типа double больше переменной Y типа double.
            //int A = 13, B = 54;
            //double X = 0.5, Y = 5.4;
            //bool C = A < B | X > Y;
            //Console.WriteLine(C);

            ////Пример с тернарным оператором
            //var a = 13;
            //var b = 7;

            //var c = a != b ? a + b : b;

            //Console.WriteLine(c);

			//Приколы с цветами
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

			var color = Console.ReadLine();

			if (color == "red")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			}

			else if (color == "green")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			}
			else if (color == "yellow")
			{
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.DarkRed;

				Console.WriteLine("Your color is yellow!");
			}
			else if (color == "magneta")
			{
				Console.BackgroundColor = ConsoleColor.Magenta;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is magneta!");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");				
			}
		}
    }
}
