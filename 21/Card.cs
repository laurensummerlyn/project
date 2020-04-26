using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Card
    {
        private double Face;
        private string Suit;

        public Card(double face, string suit)
        {
            Face = face;
            Suit = suit;
        }
        public override string ToString()
        {
            return  Face + " of " + Suit;
        }
        public string GetSuit()
        {
            string suitName = Suit.Substring(0, 1);
            return suitName;
        }
        public double GetFace()
        {
            return Face;
        }

    }
}
