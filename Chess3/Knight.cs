/*
Ismagilov Ilgam 220 group
Task "Chess - 3"
12.04.2022
*/

using System;
using System.Collections.Generic;

namespace Chess
{
    class Knight : Piece
    {
        public Knight(string coords) : base(coords) { }

        protected override bool IsRightMove(int x, int y)
        {
            return (Math.Abs(this.x - x) == 1 && Math.Abs(this.y - y) == 2) || (Math.Abs(this.x - x) == 2 && Math.Abs(this.y - y) == 1);
        }
    }
}
