using System;
using System.Collections.Generic;

namespace ChessCore
{
    static public class FigureFab
    {
        public static Piece Make(string name, int x, int y)
        {
            Piece piece = null;

            switch (name)
            {
                case "King":
                    piece = new King(x, y);
                    break;
                case "Rook":
                    piece = new Rook(x, y);
                    break;
                case "Queen":
                    piece = new Queen(x, y);
                    break;
                case "Pawn":
                    piece = new Pawn(x, y);
                    break;
                case "Knight":
                    piece = new Knight(x, y);
                    break;
                case "Bshop":
                    piece = new Bishop(x, y);
                    break;
            }

            return piece;
        }
    }
}