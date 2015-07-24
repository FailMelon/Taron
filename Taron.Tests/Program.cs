﻿using System;

using Taron.Parsing;

namespace Taron.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Lexer lexer = new Lexer();
            TokenStream strm = new TokenStream(lexer.Tokenise(Tests.test_a));
            Parser parser = new Parser();

            try
            {
                var root = parser.Parse(strm);
                Console.WriteLine("It worked! {0}", root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
