﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Karty karty = new Karty();

            while (true)
            {
                Console.WriteLine(karty.pullCard());
            }
        }
    }
}