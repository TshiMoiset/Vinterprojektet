using System.Runtime.CompilerServices;
using System;
using Raylib_cs;
using System.Numerics;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Player snakeHead = new Player();        //Kallar på klassen player.
            Food snakeFood = new Food();        //Kallar på klassen food.
            Color lightPink = new Color(244, 71, 134, 255);

            Color lightGreen = new Color(15, 209, 163, 255);
            Color darkLight = new Color(199, 227, 213, 255);

            snakeFood.updateFoodPosition();

            Raylib.InitWindow(1000, 600, "Snake Remastered ");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.collisionControl); //Kontrollerar ifall att maten och spelaren koliderar.

                Raylib.BeginDrawing();
                //Spelets logik
                if (eating)         //Om om eating är true körs koden.
                {
                    snakeFood.updateFoodPosition();    //Metoden anropas för att ge maten och poängen ett nytt värde.
                    snakeFood.score += snakeFood.worth;     //Eftersom att int score börjar som 0 adderas den med worths random värde efter att ormen har rört maten.
                }

                Raylib.ClearBackground(Color.BLACK);

                //Kod för maten.
                Raylib.DrawRectangleRec(snakeFood.collisionControl, Color.BLACK);
                Raylib.DrawCircleV(snakeFood.foodPosition, 20, lightPink);
                Raylib.DrawCircleV(snakeFood.foodPosition, 15, Color.BLACK);

                //Kod för spelaren.
                snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLACK);     //Hämntar rektangelns form från klassen player. 
                Raylib.DrawRectangleLinesEx(snakeHead.playerPosition, 4, lightGreen);

                //Kod för poäng.
                Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);

                Raylib.EndDrawing();
            }
        }
    }
}

