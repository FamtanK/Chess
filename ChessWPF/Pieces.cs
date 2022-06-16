using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessCore;

namespace ChessWPF
{
    public class Pieces
    {
        List<Piece> pieces;

        public Pieces()
        {
            pieces = new List<Piece>();
        }

        public Piece FindPiece(int x, int y)
        {
            foreach(Piece piece in pieces)
            {
                if(piece.x == x && piece.y == y)
                {
                    return piece;
                }
            }
            return null;
        }

        public void Add(Piece piece)
        {
            pieces.Add(piece);
        }
    }
}
