using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace hw4
{
    /*
    class CaesarCipher
    {
        static void Main()
        {
            Console.WriteLine("Введіть рядок для шифрування:");
            string input = Console.ReadLine();

            Console.Write("Введіть ключ шифру (ціле число): ");
            int key = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(input, key);
            Console.WriteLine($"Зашифрований текст: {encryptedText}");

            string decryptedText = Encrypt(encryptedText, -key); 
            Console.WriteLine($"Розшифрований текст: {decryptedText}");
        }

        static string Encrypt(string input, int key)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    char baseChar = char.IsUpper(chars[i]) ? 'A' : 'a';
                    chars[i] = (char)(((chars[i] - baseChar + key) % 26 + 26) % 26 + baseChar);
                }
            }

            return new string(chars);
        }
    }
    */
    class ArithmeticCalculator
    {
        static void Main()
        {
            Console.Write("Введіть арифметичний вираз +/-: ");
            string expression = Console.ReadLine();

            double result = CalculateArithmeticExpression(expression);

            Console.WriteLine($"Результат: {result}");
        }

        static double CalculateArithmeticExpression(string expression)
        {
            string[] parts = expression.Split(' ');

            if (parts.Length % 2 == 0)
            {
                Console.WriteLine("Помилка");
                return 0;
            }

            double result = double.Parse(parts[0]);

            for (int i = 1; i < parts.Length; i += 2)
            {
                string operation = parts[i];
                double operand = double.Parse(parts[i + 1]);

                if (operation == "+")
                {
                    result += operand;
                }
                else if (operation == "-")
                {
                    result -= operand;
                }
                else
                {
                    Console.WriteLine("Помилка");
                    return 0;
                }
            }

            return result;
        }
    }
}