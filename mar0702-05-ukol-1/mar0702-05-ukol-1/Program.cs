using System;


namespace mar0702_05_ukol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick[] bricks = new Brick[4];
            bricks[0].offsetX = 0;
            bricks[0].offsetY = 0;

            bricks[1].offsetX = 0;
            bricks[1].offsetY = 1;

            bricks[2].offsetX = 0;
            bricks[2].offsetY = 2;

            bricks[3].offsetX = 1;
            bricks[3].offsetY = 2;

            char orientation = 'N';
            Position pos;
            pos.x = 10;
            pos.y = 10;

            ConsoleColor color = ConsoleColor.Blue;

            Tetromino tetromino = new Tetromino(orientation, pos, color, bricks);
            tetromino.Draw();
        }
    }
}
