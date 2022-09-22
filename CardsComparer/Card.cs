using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Markup;

namespace CardsComparer
{
    internal class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public  string Name { get { return $"{Value} of {Suit}"; } }
        
        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public override string ToString()
        {
             return Name;
        }
    }
}
