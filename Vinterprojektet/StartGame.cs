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

            bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.collisionControl); //Kontrollerar ifall att maten och spelaren koliderar.

            if (snakeFood.foodPosition.X == 0)
            {
                snakeFood.updateFoodPosition();
            }

            if (snakeEnemy.enemyPosition1.X == 0)
            {
                snakeEnemy.updateEnemyPosition();
            }

            Raylib.BeginDrawing();
            //Spelets logik
            if (eating)        //Om om eating är true körs koden.
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

            Raylib.DrawTriangleLines(snakeEnemy.enemyPosition1, snakeEnemy.enemyPosition2, snakeEnemy.enemyPosition3, gold);

            //Raylib.DrawCircleV(SnakeEnemy.enemyPosition, 20, gold);

            //Kod för svansen.
            //Raylib.DrawTriangle(snakeTail, 90, 90, Color.GREEN);
            //Raylib.DrawText(snakeHead.showTail);

            //Kod för poäng.
            Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);
        }
    }
}