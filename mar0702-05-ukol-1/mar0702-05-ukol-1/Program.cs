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
            Tetromino3x3L tetromino3x3L = new Tetromino3x3L(orientation, pos, color);
            tetromino3x3L.Draw();
        }
    }
}
