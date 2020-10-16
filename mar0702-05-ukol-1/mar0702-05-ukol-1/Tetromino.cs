using System;

namespace mar0702_05_ukol_1
{
    public class Tetromino
    {
        protected char orientation;
        protected Position position;
        protected ConsoleColor color;
        protected Brick[] bricks;

        public Tetromino(char orientation, Position pos, ConsoleColor color)
        {
            this.orientation = orientation;
            this.position = pos;
            this.color = color;
            this.bricks = new Brick[4];

            this.bricks[0].offsetX = 0;
            this.bricks[0].offsetY = 0;

            this.bricks[1].offsetX = 0;
            this.bricks[1].offsetY = 1;

            this.bricks[2].offsetX = 1;
            this.bricks[2].offsetY = 0;

            this.bricks[3].offsetX = 1;
            this.bricks[3].offsetY = 1;

        }

        public void Draw()
        {
            Console.ForegroundColor = this.color;

            for(int i = 0; i < this.bricks.Length; i++)
            {
                Console.CursorLeft = this.position.x + this.bricks[i].offsetX;
                Console.CursorTop = this.position.y + this.bricks[i].offsetY;
                Console.Write('\u2588');
            }
        }
    }
}
