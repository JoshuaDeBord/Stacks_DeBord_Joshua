﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_DeBord_Joshua
{
    internal class Card
    {
        public string Number { get; set; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit= suitParam;
        }
    }
}
