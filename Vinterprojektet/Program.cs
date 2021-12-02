using System;
using Raylib_cs;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Player snakeHead = new Player();        //Kallar på klassen player.
            Food snakeFood = new Food();
            snakeFood.updateFoodPosition();

            Raylib.InitWindow(1000, 600, "Snake Remastered ");
            Raylib.SetTargetFPS(60);
            Raylib.DrawGrid(40, 40);

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



                snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
                Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLUE);     //Hämntar rektangelns form från klassen player. 
                Raylib.DrawRectangle((int)Math.Ceiling(snakeFood.foodPosition.x), (int)Math.Ceiling(snakeFood.foodPosition.y), 40, 40, Color.RED);      // Gör en om en float till en int.

                Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, Color.WHITE);

                Raylib.EndDrawing();
            }
        }
    }
}

