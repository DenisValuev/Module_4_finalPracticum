namespace Module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Пользователь номер {0}", i + 1);
                // Task 4.5.1
                (string Name, string lastName, string login, int loginLenght, bool hasPet, string[] favColors, double Age) User;

                //Task 4.5.2
                Console.Write("Введите имя пользователя: ");
                User.Name = Console.ReadLine();
                Console.Write("Введите фамилию пользователя: ");
                User.lastName = Console.ReadLine();
                Console.Write("Введите логин пользователя: ");
                User.login = Console.ReadLine();

                // Task 4.5.3
                User.loginLenght = User.login.Length;

                // Task 4.5.4
                Console.WriteLine("Есть ли у вас животные? Да или нет");
                var result = Console.ReadLine();
                if (result == "Да")
                {
                    User.hasPet = true;
                }
                else
                {
                    User.hasPet = false;
                }

                // Task 4.5.5
                Console.Write("Введите возраст пользователя: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                User.favColors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int j = 0; j < User.favColors.Length; j++)
                {
                    Console.WriteLine($"Цвет номер {j + 1}");
                    User.favColors[j] = Console.ReadLine();
                }
            }
        }
    }
}
