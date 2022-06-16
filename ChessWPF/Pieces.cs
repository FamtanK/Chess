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

        public int FindPieceIndex(int x, int y)
        {
            int index = -1;
            for(int i = 0; i < pieces.Count; ++i)
            {
                if(pieces[i].x == x && pieces[i].y == y)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Add(Piece piece)
        {
            pieces.Add(piece);
        }

        public void RemoveAt(int index)
        {
            pieces.RemoveAt(index);
        }
    }
}
