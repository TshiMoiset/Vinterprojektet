using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {

            Player snakeHead = new Player();


            //snakeHead = Raylib.DrawRectangle(10, 10, 10, 10, Color.BEIGE);

            //Raylib.SetTargetFps(60);
            Raylib.InitWindow(900, 900, "Snake");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                //Spelets logik

                //snakeHead = Raylib.DrawRectangle(10, 10, 10, 10, Color.BEIGE);

                Raylib.ClearBackground(Color.BLACK);
                snakeHead.playerMovement();
                // Kod för att rita ut saker till fönstret
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BEIGE);




                Raylib.EndDrawing();
            }
        }
    }
}
