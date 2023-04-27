using System;
using System.Linq;

namespace Library
{
    public class ZadanieOne
    {
        // Выводим числа в консоль от 1 до N через запятую
        public static void One()
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
    }

    public class ZadanieTwo
    {
        // Отрисовываем квадрат из символов "#", оставляю внутри пробел
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) // Если N - четное число, завершаем функцию
            {
                Console.WriteLine("Вы ввели четное N.");
                return;
            }
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1) // Проверка на центр квадрата, если - true, то ставим пробел
                        Console.Write(" ");
                    else // В остальных случаях ставим символ #
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }

    public class Program
    {
        // Пример вызова методов классов ZadanieOne и ZadanieTwo.
        static void Main(string[] args)
        {
            ZadanieOne.One();
            ZadanieTwo.Two();
        }
    }
}
