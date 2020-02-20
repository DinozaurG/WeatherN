using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Player
    {
        public double cash;
        public int cntPapers;
        public Player() { cash = 1000; cntPapers = 0; }
        public Player(double C) { cash = C; cntPapers = 0; }
        public Player(double C, int P) { cash = C; cntPapers = P; }
        public void BuyPapers(double price)
        {
            cash -= price;
            cntPapers++;
        }
        public void SellPapers(double price)
        {
            cash += price;
            cntPapers--;
        }
    }
}
