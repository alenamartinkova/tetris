using System;
namespace mar0702_05_ukol_1
{
    public class Tetromino3x3L : Tetromino
    {
        public Tetromino3x3L(char orientation, Position pos, ConsoleColor color) : base (orientation, pos, color)
        {
            this.bricks = new Brick[5];

            this.bricks[0].offsetX = 0;
            this.bricks[0].offsetY = 0;

            this.bricks[1].offsetX = 0;
            this.bricks[1].offsetY = 1;

            this.bricks[2].offsetX = 0;
            this.bricks[2].offsetY = 2;

            this.bricks[3].offsetX = 1;
            this.bricks[3].offsetY = 2;

            this.bricks[4].offsetX = 2;
            this.bricks[4].offsetY = 2;
        }
    }
}
