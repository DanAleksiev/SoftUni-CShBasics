﻿using System;

namespace _02._Equal_Sums_Even_Odd_Position
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
                {
                string currentNum = i.ToString();
                int odd = 0;
                int even = 0;

                for (int j = 0; j < currentNum.Length; j++)
                    {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j %2 == 0)
                        {
                        even += currentDigit;

                        }
                    else
                        {
                        odd += currentDigit;
                        }
                    }
                if (odd == even)
                    {
                    Console.Write(i + " ");
                    }

                }
            }
        }
    }