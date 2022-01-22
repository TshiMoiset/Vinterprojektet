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


        Color lightPink = new Color(230, 0, 126, 255);      //Egen färg
        Color lightGreen = new Color(15, 209, 163, 255);        //Egen färg
        Color darkLight = new Color(199, 227, 213, 255);    //Egen färg
        Color darkGray = new Color(15, 14, 11, 255);         //Egen färg
        Color gold = new Color(197, 173, 58, 255);         //Egen färg


        public void RunGame()
        {

            bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.collisionControl); //Kontrollerar ifall att maten och spelaren kolliderar.
            bool collisionWithEnemy1 = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeEnemy.enemy1Collision); //Kontrollerar ifall att fienden och spelaren kolliderar.
            bool collisionWithEnemy2 = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeEnemy.enemy2Collision); //Kontrollerar ifall att fienden och spelaren kolliderar.
            bool collisionWithEnemy3 = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeEnemy.enemy3Collision); //Kontrollerar ifall att fienden och spelaren kolliderar.

            if (snakeFood.foodPosition.X == 0)
            {
                snakeFood.updateFoodPosition();
            }

            if (snakeEnemy.enemy1.X == 0 && snakeEnemy.enemy2.X == 0 && snakeEnemy.enemy3.X == 0)
            {
                snakeEnemy.updateEnemyPosition();
            }

            //Spelets logik
            if (eating)        //Om om eating är true körs koden.
            {
                snakeFood.updateFoodPosition();    //Metoden anropas för att ge maten och poängen ett nytt värde.
                snakeEnemy.updateEnemyPosition();      //Fienden får en ny position.
                snakeFood.score += snakeFood.worth;     //Eftersom att int score börjar som 0 adderas den med worths random värde efter att ormen har rört maten.
            }

            if (collisionWithEnemy1 || collisionWithEnemy2 || collisionWithEnemy3)
            {
                snakeEnemy.updateEnemyPosition();      //Fienden får en ny position.
                snakeFood.score -= snakeEnemy.losePoints;     //Tar bort poäng om man krockar med fienden. 
            }

            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BLACK);

            //Kod för maten.
            Raylib.DrawRectangleRec(snakeFood.collisionControl, Color.BLACK);
            Raylib.DrawCircleV(snakeFood.foodPosition, 20, lightPink);
            Raylib.DrawCircleV(snakeFood.foodPosition, 15, Color.BLACK);

            //Kod för spelaren.
            snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
            Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLACK);     //Hämntar rektangelns form från klassen player. 
            Raylib.DrawRectangleLinesEx(snakeHead.playerPosition, 4, lightGreen);

            Raylib.DrawRectangle(0, 0, 1100, 55, darkGray);     //Backgrund för den övre delen av skärmen.



            Raylib.DrawRectangle(0, 55, 40, 40, Color.DARKPURPLE); //Radera kod sen
            Raylib.DrawRectangle(1060, 660, 40, 40, Color.GREEN);   //Radera kod sen

            if (snakeFood.score >= 1)
            {
                Raylib.DrawText("The V.I.P's has arrived", 680, 10, 35, gold);
                Raylib.DrawRectangleRec(snakeEnemy.enemy1Collision, Color.BLACK);
                Raylib.DrawPoly(snakeEnemy.enemy1, 6, 28, 180, gold);
                Raylib.DrawPoly(snakeEnemy.enemy1, 6, 20, 180, Color.BLACK);

                Raylib.DrawRectangleRec(snakeEnemy.enemy2Collision, Color.BLACK);
                Raylib.DrawPoly(snakeEnemy.enemy2, 6, 28, 180, gold);
                Raylib.DrawPoly(snakeEnemy.enemy2, 6, 20, 180, Color.BLACK);

                Raylib.DrawRectangleRec(snakeEnemy.enemy3Collision, Color.BLACK);
                Raylib.DrawPoly(snakeEnemy.enemy3, 6, 28, 180, gold);
                Raylib.DrawPoly(snakeEnemy.enemy3, 6, 20, 180, Color.BLACK);
            }

            Raylib.DrawText(snakeFood.score.ToString(), 10, 10, 40, darkLight);     //Kod för att visa poäng. 

            //Kod för svansen.
            //Raylib.DrawTriangle(snakeTail, 90, 90, Color.GREEN);
            //Raylib.DrawText(snakeHead.showTail);

        }
    }
}
