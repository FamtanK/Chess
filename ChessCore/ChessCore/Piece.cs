using System;
using System.Collections.Generic;

namespace ChessCore
{
    public class Piece
    {
        public int x;
        public int y;

        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected virtual bool IsRightMove(int x, int y)
        {
            return true;
        }

        public void Move(int x, int y)
        {
            if (IsRightMove(x, y))
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                throw new Exception("Incorrect coords");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", X = {x}, Y = {y}";
        }
    }
}
