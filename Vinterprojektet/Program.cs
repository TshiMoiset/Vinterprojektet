using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Player snakeHead = new Player();        //Kallar på klassen player


            Raylib.InitWindow(1000, 600, "Snake Remastered ");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                //Spelets logik




                Raylib.ClearBackground(Color.BLACK);
                // Kod för att rita ut saker till fönstret

                snakeHead.playerMovement();
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLUE);     //Hämntar rektangelns fomr från klassen player


                // Raylib.CloseWindow();   //Stänger fönstret om man trycker på ESC knappen


                Raylib.EndDrawing();


            }
        }
    }
}
