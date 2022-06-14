/*
Ismagilov Ilgam 220 group
Task "Chess - 3"
12.04.2022
*/

using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n King check");
            var k = new King("A1");
            k.Move("B1");
            k.Print();

            Console.WriteLine("\n Rook check");
            Piece r = new Rook("B1");
            r.Move("C3");
            r.Print();

            Console.WriteLine("\n Queen check");
            var q = new Queen("D3");
            q.Move("D7");
            q.Print();

            Console.WriteLine("\n Pawn check");
            var p = new Pawn("E2");
            p.Move("E4");
            p.Print();

            Console.WriteLine("\n Knight check");
            var n = new Knight("B2");
            n.Move("A4");
            n.Print();

            Console.WriteLine("\n Bishop check");
            var b = new Bishop("F2");
            b.Move("H4");
            b.Print();
        }
    }
}