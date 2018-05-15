using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int s = Convert.ToInt32(Console.ReadLine());
                if (s < 1)
                {
                    Console.WriteLine("Введенные вами данные не верны");
                    Environment.Exit(0);
                }
                Game game = new Game(s);
                while (!game.check())
                {
                    int x = 0, y = 0, num = 0;
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    num = Convert.ToInt32(Console.ReadLine());
                    if (x > s || x < 0 || y > s || y < 0 || (num != 0 && num != 1))
                    {
                        Console.WriteLine("Введенные вами данные не верны");
                        Environment.Exit(0);
                    }

                    game.add(x, y, num);
                    Console.WriteLine(game.gameFild());
                }
                Console.WriteLine("Game Over!!! \n" + game.gameFild());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка \n" + ex);
                Environment.Exit(0);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка \n" + ex);
                Environment.Exit(0);
            }
        }
    }
}
