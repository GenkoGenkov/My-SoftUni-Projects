using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char WallSymbol = '\u25A0';

        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            InitalizeWall();
        }

        private void InitalizeWall()
        {

            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, 0, WallSymbol);
            }

            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, this.TopY, WallSymbol);
            }

            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(0, topY, WallSymbol);
            }

            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(this.LeftX, topY, WallSymbol);
            }

            Console.WriteLine();
        }
    }
}
