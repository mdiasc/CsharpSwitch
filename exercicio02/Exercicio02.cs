﻿using System;
class Exercicio01
{
    public static void Main(string[] args)
    {
        int day = 4;
        switch (day)
        {
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }
    }
}