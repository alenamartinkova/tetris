using System;

namespace mar0702_05_ukol_1
{
    public class Tetromino
    {
        private char orientation;
        private Position position;
        private ConsoleColor color;
        private Brick[] bricks;

        public Tetromino(char orientation, Position pos, ConsoleColor color, Brick[] bricks)
        {
            this.orientation = orientation;
            this.position = pos;
            this.color = color;
            this.bricks = bricks;
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
