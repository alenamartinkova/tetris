using System;


namespace mar0702_05_ukol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char orientation = 'N';
            Position pos;
            pos.x = 10;
            pos.y = 10;

            ConsoleColor color = ConsoleColor.Blue;
            //Tetromino tetromino = new Tetromino(orientation, pos, color);
            pos.x = 20;
            pos.y = 20;
            Tetromino2x3L tetromino2x3L = new Tetromino2x3L(orientation, pos, color);
            //tetromino.Draw();
            tetromino2x3L.Draw();
        }
    }
}
