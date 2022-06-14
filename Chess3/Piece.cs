/*
Ismagilov Ilgam 220 group
Task "Chess - 3"
12.04.2022
*/

using System;
using System.Collections.Generic;

namespace Chess
{
    class Piece
    {
        protected int x;
        protected int y;
        protected Dictionary<char, int> charToInt = new Dictionary<char, int>()
        {
            {'A', 1},
            {'B', 2},
            {'C', 3},
            {'D', 4},
            {'E', 5},
            {'F', 6},
            {'G', 7},
            {'H', 8}
        };
        protected Dictionary<int, char> intToChar = new Dictionary<int, char>()
        {
            {1, 'A'},
            {2, 'B'},
            {3, 'C'},
            {4, 'D'},
            {5, 'E'},
            {6, 'F'},
            {7, 'G'},
            {8, 'H'}
        };

        public Piece(string coords)
        {
            this.x = charToInt[coords[0]];
            this.y = int.Parse(Convert.ToString(coords[1]));
        }

        protected virtual bool IsRightMove(int x, int y)
        {
            return true;
        }

        public void Move(string coords)
        {
            int newX = charToInt[coords[0]];
            int newY = int.Parse(Convert.ToString(coords[1]));

            if (IsRightMove(newX, newY))
            {
                this.x = newX;
                this.y = newY;
            }
            else
            {
                Console.WriteLine("Not correct move");
            }
        }

        public void Print()
        {
            Console.WriteLine($"{intToChar[x]}{y}");
        }
    }
}
