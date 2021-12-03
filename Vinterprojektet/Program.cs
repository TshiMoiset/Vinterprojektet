using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {

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

                snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
                Raylib.DrawRectangleRec(snakeHead.playerPosition, lightGreen);     //Hämntar rektangelns form från klassen player. 
                Raylib.DrawRectangleRec(snakeHead.innerRectangle, Color.BLACK);


                Raylib.DrawRectangle((int)Math.Ceiling(snakeFood.foodPosition.x), (int)Math.Ceiling(snakeFood.foodPosition.y), 40, 40, lightPink);      // Gör en om en float till en int.


                Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);

                Raylib.EndDrawing();
            }
        }
    }
}

