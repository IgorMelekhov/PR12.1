using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR12._1
{
    internal class Program
    {

        static string EncryptString(string input)
        {
            string encryptedString = "";

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i += 2) // Итерируемся по парным индексам
                {
                    encryptedString += input[i + 1]; // Меняем местами символы в паре
                    encryptedString += input[i];
                }
            }
            else
            {
                encryptedString = input;
            }

            return encryptedString;
        }
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    bool flag = false;
                    Console.Write("Нажмите Y чтобы продолжить или N чтобы прекратить: ");
                    string select_key = Console.ReadLine();

                    switch (select_key)
                    {
                        case "Y":
                        try
                        {
                            try
                            {
                                Console.WriteLine("Здравствуйте\nПрактическая работа номер 9");
                                Console.Write("Введите строку ");
                                string inputString = Convert.ToString(Console.ReadLine());
                                if (string.IsNullOrWhiteSpace(inputString))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ошибка - отсутсвует строка");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Thread.Sleep(2000);
                                    continue;
                                }
                                string encryptedString =  EncryptString(inputString);
                                Console.WriteLine("Зашифрованная строка: " + encryptedString);
                            }
                            catch (FormatException fe)
                            {
                                Console.WriteLine(fe.Message);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message); 
                        }
                            Console.ReadKey();
                            break;
                        case "N":
                            Console.WriteLine("До свидания");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                    }
                }
            }        
    }
}



