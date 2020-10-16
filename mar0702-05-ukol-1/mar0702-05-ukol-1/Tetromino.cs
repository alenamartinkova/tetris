using System;

namespace mar0702_05_ukol_1
{
    public abstract class Tetromino
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
