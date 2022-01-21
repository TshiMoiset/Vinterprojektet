using System.Reflection.Metadata;
using System.Numerics;
using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class StartGame
    {
        Player snakeHead = new Player();        //Anropar på klassen player.
        Food snakeFood = new Food();        //Anropar på klassen food.
        Tail snakeTail = new Tail();        //Anropar på klassen tail.
        Enemy snakeEnemy = new Enemy();     //Anropar på klassen Enemy.
        Menu gameMenu = new Menu();     //Anropar på klassen menu.


        Color lightPink = new Color(230, 0, 126, 255);        //Egen färg
        Color lightGreen = new Color(15, 209, 163, 255);     //Egen färg
        Color darkLight = new Color(199, 227, 213, 255);    //Egen färg
        Color gold = new Color(197, 173, 58, 255);         //Egen färg


        public void RunGame()
        {

            bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.collisionControl); //Kontrollerar ifall att maten och spelaren kolliderar.

            bool collisionWithEnemy = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeEnemy.enemyCollisionControl); //Kontrollerar ifall att fienden och spelaren kolliderar.

            if (snakeFood.foodPosition.X == 0)
            {
                snakeFood.updateFoodPosition();
            }

            if (snakeEnemy.enemyPosition.X == 0)
            {
                snakeEnemy.updateEnemyPosition();
            }

            Raylib.BeginDrawing();
            //Spelets logik
            if (eating)        //Om om eating är true körs koden.
            {
                snakeFood.updateFoodPosition();    //Metoden anropas för att ge maten och poängen ett nytt värde.
                snakeEnemy.updateEnemyPosition();      //Fienden får en ny position.
                snakeFood.score += snakeFood.worth;     //Eftersom att int score börjar som 0 adderas den med worths random värde efter att ormen har rört maten.
            }

            if (collisionWithEnemy)
            {
                snakeEnemy.updateEnemyPosition();      //Fienden får en ny position.
                snakeFood.score -= snakeEnemy.pointLose;     //Tar bort poäng om man krockar med fienden. 

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

            if (snakeFood.score >= 100)
            {
                Raylib.DrawText("The V.I.P's has arrived", 570, 10, 35, gold);
                Raylib.DrawRectangleRec(snakeEnemy.enemyCollisionControl, Color.BLACK);
                Raylib.DrawPoly(snakeEnemy.enemyPosition, 1, 28, 180, gold);
                Raylib.DrawPoly(snakeEnemy.enemyPosition, 1, 20, 180, Color.BLACK);
            }


            //Kod för svansen.
            //Raylib.DrawTriangle(snakeTail, 90, 90, Color.GREEN);
            //Raylib.DrawText(snakeHead.showTail);

            //Kod för poäng.
            Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);
        }
    }
}
