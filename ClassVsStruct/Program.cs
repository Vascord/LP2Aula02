﻿using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1, p2;
            p1 = new Player() { Health = 21.2f, Armor = 53.9f };
            p2 = p1;
            Console.WriteLine("\tP1: Health = {0}, Armor={1}", p1.Health, 
                p1.Armor);
            Console.WriteLine("\tP2: Health = {0}, Armor={1}", p2.Health, 
                p2.Armor);

            DupHealth(p1);

            Console.WriteLine("\tP1: Health = {0}, Armor={1}", p1.Health, 
                p1.Armor);
            Console.WriteLine("\tP2: Health = {0}, Armor={1}", p2.Health, 
                p2.Armor);
        }

        private static DupHealth(Player p)
        {
            p.Health *=2;
        }
    }
}
