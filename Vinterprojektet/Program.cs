using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Player snakeHead = new Player();        //Kallar på klassen player
            Food snakeFood = new Food();
            snakeFood.updateFoodPosition();

            Raylib.InitWindow(1000, 600, "Snake Remastered ");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.foodPosition);

                Raylib.BeginDrawing();
                //Spelets logik
                if (eating)
                {
                    snakeFood.updateFoodPosition();
                    snakeFood.score += snakeFood.worth;
                }

                Raylib.ClearBackground(Color.BLACK);
                // Kod för att rita ut saker till fönstret

                snakeHead.playerMovement();
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLUE);     //Hämntar rektangelns fomr från klassen player
                Raylib.DrawRectangle((int)Math.Ceiling(snakeFood.foodPosition.x), (int)Math.Ceiling(snakeFood.foodPosition.y), 40, 40, Color.RED);       //maten

                Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, Color.WHITE);

                Raylib.EndDrawing();
            }
        }
    }
}

