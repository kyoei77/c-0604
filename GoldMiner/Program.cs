using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldMiner
{
    internal class Program
    {
        static void Main()
        {
            Game game = new Game(5);
            game.Play();

            while (true)
            {
                Console.WriteLine(" 終了しますか？[0] 続けますか？[1]");

                int isContinue = int.Parse(Console.ReadLine());
                if (isContinue == 1)
                {
                    game.Play();
                }
                else
                {
                    Console.WriteLine("おつかれさまでした！またのお越しをお待ちしてます\n");
                    break;
                }


            }
        }
    }
}
