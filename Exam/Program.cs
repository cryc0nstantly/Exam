using System;

namespace PswGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину пароля: ");
            int len = int.Parse(Console.ReadLine());

            string psw = GenPsw(len);
            Console.WriteLine($"Сгенерированный пароль: " + psw);
        }

        static string GenPsw(int len)
        {
            string kit = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] psw = new char[len];

            for (int i = 0; i < len; i++)
            {
                psw[i] = kit[random.Next(kit.Length)];
            }

            return new string(psw);
        }
    }
}
