using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldMiner
{
    public class Ore
    {
        //  フィールド
        public string name;
        public int point;
        //  コンストラクタ
        public Ore(string name, int point)
        {
            this.name = name;
            this.point = point;
        }
        public override string ToString()
        {
            return this.name + "(" + this.point + "pt)";
        }
        public int Point
        {
            get { return this.point; }
        }
    }
}
