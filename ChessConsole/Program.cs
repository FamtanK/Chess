using System;
using ChessCore;

namespace ChessConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            var pieces = new List<Piece>();
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("  Create Bishop - Bishop");
                Console.WriteLine("  Create King - King");
                Console.WriteLine("  Create Knight - Knight");
                Console.WriteLine("  Create Pawn - Pawn");
                Console.WriteLine("  Create Queen - Queen");
                Console.WriteLine("  Create Rook - Rook");

                string choose = Console.ReadLine();
                Console.WriteLine("Enter X coords");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y coords");
                int y = int.Parse(Console.ReadLine());
                pieces.Add(FigureFab.Make(choose, x, y));
            }
        }
    }
}