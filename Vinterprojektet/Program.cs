using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {

            Player snakeHead = new Player();



            Raylib.InitWindow(3000, 500, "Snake");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                //Spelets logik




                Raylib.ClearBackground(Color.BLACK);
                // Kod för att rita ut saker till fönstret

                snakeHead.playerMovement();
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BEIGE);


                Raylib.CloseWindow();   //Stänger fönstret


                Raylib.EndDrawing();


            }
        }
    }
}
