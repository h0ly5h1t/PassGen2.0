using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool passTrue = true;
            Console.WriteLine("Введите длину пароля:");
            int.TryParse(Console.ReadLine(), out int symCount);
            while (passTrue)
            {
                if (symCount < 8)
                {
                    Console.WriteLine("Минимальная длина пароля составляет - 8 символов!");
                    Console.ReadKey();
                    passTrue = false;
                }
                else
                {
                    Console.WriteLine($"Ваш пароль - \u001b[32;1m{PassGenerator.RandomPass(symCount)}\u001b[0m\nДлина пароля - {symCount}");
                    Console.WriteLine("Закройте программу или нажмите любую клавишу, чтобы сгенерировать новый пароль!");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }

        class PassGenerator
        {
            public static string RandomPass(int symCount)
            {
                Random randomChar = new Random();
                StringBuilder charList = new StringBuilder();

                for (int i = 0; i < symCount; i++)
                    charList.Append((char)randomChar.Next(33, 127));

                return charList.ToString();
            }
        }
    }
}
