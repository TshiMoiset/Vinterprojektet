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

            Vector2 pos = new Vector2(60, 70);

            Color lightPink = new Color(236, 29, 84, 255);
            Color lightGreen = new Color(15, 209, 163, 255);
            Color darkLight = new Color(199, 227, 213, 255);

            Player snakeHead = new Player();        //Kallar på klassen player.
            Food snakeFood = new Food();        //Kallar på klassen food.

            snakeFood.updateFoodPosition();


            Raylib.InitWindow(1000, 600, "Snake Remastered ");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.foodPosition); //Kontrollerar ifall att maten och spelaren koliderar.

                Raylib.BeginDrawing();
                //Spelets logik
                if (eating)         //Om om eating är true körs koden.
                {
                    snakeFood.updateFoodPosition();    //Metoden anropas för att ge maten och poängen ett nytt värde.
                    snakeFood.score += snakeFood.worth;     //Eftersom att int score börjar som 0 adderas den med worths random värde efter att ormen har rört maten.
                }

                Raylib.ClearBackground(Color.BLACK);


                //Raylib.DrawGrid(100, 10000000000);


                Raylib.DrawRectangle((int)Math.Ceiling(snakeFood.foodPosition.x), (int)Math.Ceiling(snakeFood.foodPosition.y), 40, 40, lightPink);      // Gör en om en float till en int.




                // Raylib.DrawEllipse(620, 300, 15, 15, Color.BEIGE);
                // Raylib.DrawEllipseLines(620, 300, 20, 20, Color.YELLOW);

                Raylib.DrawCircleV(pos, 50, Color.BLUE);
                Raylib.DrawCircleV(pos, 40, Color.BLACK);

                // Raylib.DrawCircleLines((int)pos.X, (int)pos.Y, 50, Color.GREEN);


                // Raylib.DrawCircleLines(620, 200, 20, Color.MAGENTA);

                snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLACK);     //Hämntar rektangelns form från klassen player. 
                Raylib.DrawRectangleLinesEx(snakeHead.playerPosition, 4, lightGreen);


                Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);


                Raylib.EndDrawing();
            }
        }
    }
}

