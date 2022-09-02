using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBTP
{
    internal class Program
    {
        static char[][] text = new char[][]
            {
                new char[] { '-', '*', '-', '-', '-', '-', '-', '-', '-' },
                new char[] { '*', '-', '-', '-', '*', '-', '*', '-', '-' },
                new char[] { '-', '*', '-', '-', '*', '*', '*', '-', '*' },
                new char[] { '*', '*', '-', '*', '*', '*', '*', '-', '*' }
            };

        static void Show()
        {
            for (int y = 0; y < text.Length; ++y)
            {
                for (int x = 0; x < text[y].Length; ++x)
                    Console.Write(text[y][x]);

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            for (int y = 0; y < text.Length; ++y) // проход по всем строкам в массиве
            {
                int b = 2 * y + 1;
                int i = text[y].Length / 2 - b / 2;

                for (int x = 0; x < text[y].Length; ++x) // проход по каждому элементу просматриваемой строки
                {
                    if (text[y][x] == '*') // если нашли звездочку
                    {
                        for (int j = i; j <= text[y].Length / 2 + b / 2; ++j) // проходимся по местам, где должны быть звездочки
                        {
                            if (text[y][j] == '-') // если вместо должной звездочки стоит минус, то ...
                            {
                                text[y][x] = '-';
                                text[y][j] = '*';

                                Show();
                                Console.WriteLine('\n');

                                break;
                            }
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
