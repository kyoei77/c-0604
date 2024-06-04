using GoldMiner;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace GoldMiner
{
    public class Game
{
    //点数
    private int total = 0;

    //回数
    public int times = 5;

    //体力
    private int Time = 60;

    //
    public Game(int times)
    {
        this.times = times;
    }

    public void Play()
    {
        Start();
        int i = 1;
        while (i <= times)
        {
            Console.WriteLine(i + "回目の採掘！");
            Console.WriteLine("採掘の時間は" + this.Time + "秒になります。");
            Console.WriteLine("選択：0～10の半角数字を入力して選びましょう。");
            int index = int.Parse(Console.ReadLine());


            if (index >= 0 && index < 11)
            {
                Place p1 = new Place(index);
                Ore ore = p1.GetOre(index);


                this.total += ore.Point;


                Console.WriteLine("採掘されるもの一覧：" + p1.GetOreAll());
                Console.WriteLine("今回採掘されるもの：" + ore);

                int q = 0;

                switch (ore.Point)
                {
                    case 0:
                        q = 5;
                        break;
                    case 1:
                        q = 5;
                        break;
                    case 40:
                        q = 20;
                        break;
                    case 50:
                        q = 10;
                        break;
                    case 250:
                        q = 20;
                        break;
                    case 500:
                        q = 30;
                        break;
                    case 600:
                        q = 5;
                        break;
                }
                this.Time -= q;

                Console.WriteLine("現在の残った時間は" + this.Time + "秒です。");
                if (this.Time <= 0)
                {
                    Console.WriteLine("\n あなたの採掘時間がなくなってしまいました・・・ \n");
                    break;
                }

                i++;
            }
            else
            {
                Console.WriteLine("【エラー】入力値が不正です。再度入力してください");
            }
            Finish();
        }
     
    }

    


    private void Start()
    {

        Console.WriteLine("【Gold Minerゲーム】");
        Console.WriteLine("スタート！");
    }
    private void Finish()
    {
        Console.WriteLine("\n=========================");
        Console.WriteLine("合計点は" + total + "です！");
    }

}

}
