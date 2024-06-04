using GoldMiner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldMiner
{
    public class Place
    {
        public List<Ore> pbox = new List<Ore>();
        public Place()
        {
            Ore_list fl1 = new Ore_list();
            this.pbox.Add(fl1.RandomOre());
            this.pbox.Add(fl1.RandomOre());
            this.pbox.Add(fl1.RandomOre());
            this.pbox.Add(fl1.RandomOre());
            this.pbox.Add(fl1.RandomOre());
        }
        public Place(int index)
        {
            Ore_list fl1 = new Ore_list();
            this.pbox.Add(fl1.RandomOre(index));
            this.pbox.Add(fl1.RandomOre(index));
            this.pbox.Add(fl1.RandomOre(index));
            this.pbox.Add(fl1.RandomOre(index));
            this.pbox.Add(fl1.RandomOre(index));
        }
        public Ore GetOre(int index)
        {
            return this.pbox[index];
        }
        public String GetOreAll()
        {
            String allOreName = "";
            foreach (Ore ore in this.pbox)
            {
                allOreName += ore + " , ";
            }
            return allOreName;
        }
        public int NumOfPlaces()
        {
            return this.pbox.Count;
        }
        public static void Test()
        {
            Console.WriteLine("-------------------");
            Place p1 = new Place();
            Console.WriteLine("場所の数:" + p1.NumOfPlaces());

            
            for (int i = 0; i < p1.NumOfPlaces(); i++)
            {
              
                Console.WriteLine(p1.GetOre(i));
            }
        }


    }
}

