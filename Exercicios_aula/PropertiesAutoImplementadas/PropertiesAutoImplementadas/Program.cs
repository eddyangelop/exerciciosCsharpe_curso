﻿using System;
using System.Globalization;

namespace properties_auto_implementadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4k";


            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}

