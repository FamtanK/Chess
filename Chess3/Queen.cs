/*
Ismagilov Ilgam 220 group
Task "Chess - 3"
12.04.2022
*/

using System;
using System.Collections.Generic;

namespace Chess
{
    class Queen : Piece
    {
        public Queen(string coords) : base(coords) { }

        protected override bool IsRightMove(int x, int y)
        {
            return (this.x == x) || (this.y == y) || (Math.Abs(this.x - x) == Math.Abs(this.y - y));
        }
    }
}
