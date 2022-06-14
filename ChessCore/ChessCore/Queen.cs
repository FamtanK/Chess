/*
Ismagilov Ilgam 220 group
Task "Chess - 3"
12.04.2022
*/

using System;
using System.Collections.Generic;

namespace ChessCore
{
    class Queen : Piece
    {
        public Queen(int x, int y) : base(x, y) { }

        protected override bool IsRightMove(int x, int y)
        {
            return (this.x == x) || (this.y == y) || (Math.Abs(this.x - x) == Math.Abs(this.y - y));
        }
    }
}
