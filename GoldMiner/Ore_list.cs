using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldMiner
{
    public class Ore_list
    {
        public Random rnd = new Random();
        //
        public List<Ore> box = new List<Ore>();

        public Ore_list() 
        {
            this.box.Add(new Ore("骨", 20));
            this.box.Add(new Ore("石", 40));
            this.box.Add(new Ore("小さいゴールド", 50));
            this.box.Add(new Ore("普通のゴールド", 250));
            this.box.Add(new Ore("ゴールド", 500));
            this.box.Add(new Ore("ダイヤモンド", 600));
            this.box.Add(new Ore("爆弾", 1));
            this.box.Add(new Ore("なし", 0));
            this.box.Add(new Ore("なし", 0));
            this.box.Add(new Ore("なし", 0));
        }

        public Ore RandomOre()
        {
            int n = rnd.Next(0,box.Count);
            return this.box[n];
        }

        public Ore RandomOre(int index)
        {
            int n = index;
            switch (index)
            {
                case 0:
                    n = rnd.Next(5, 11);
                    break;
                case 1:
                    n = rnd.Next(3, 8);
                    break;
                case 2:
                    n = rnd.Next(1, 9);
                    break;
                case 4:
                    n = rnd.Next(0, 5);
                    n = n == 4 ? 6 : n; 
                    break;
            }
            return this.box[n];

         
        }

    }
}
