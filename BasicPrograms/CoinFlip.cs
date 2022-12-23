﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class CoinFlip
    {
        public static void HeadVsTail()
        {
            Console.WriteLine("Please enter how many times you want to flip the coin");
            Random random = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            for (int i = 0; i < n; i++)
            {
                double coinFlipped = random.NextDouble();
                if (coinFlipped > 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double headPercentage = head * 100 / n;
            Console.WriteLine($"Head won {head} times,Hence Head scored : {headPercentage}%");
            double tailPercentage = tail * 100 / n;
            Console.WriteLine($"Tail won {tail} times,Hence Tail scored : {tailPercentage}%");
        }
    }
}
