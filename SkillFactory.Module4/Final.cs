namespace SkillFactory.Module4 {
    class Final {
		public static void Main(string[] args) {

            //имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

            (string Name, string Surname, string Login, int LoginLength, bool HasPet, int Age, string[] FavColors) User;

            for (byte k = 0; k < 3; k++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.Surname = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string Pet = Console.ReadLine();

                if (Pet == "да")
                    User.HasPet = true;
                else
                    User.HasPet = false;

                Console.WriteLine("Введите возраст пользователя");
                User.Age = Convert.ToInt32(Console.ReadLine());

                User.FavColors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < 3; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }
            }
        }
    }
}
