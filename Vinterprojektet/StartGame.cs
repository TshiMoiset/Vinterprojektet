using System.Collections.ObjectModel;
using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class StartGame
    {
        Player snakeHead = new Player();        //Anropar på klassen player.
        Food snakeFood = new Food();        //Anropar på klassen food.
        Tail snakeTail = new Tail();        //Anropar på klassen tail.
        Enemy snakeEnemy = new Enemy();     //Anropar på klassen Enemy.

        Color lightPink = new Color(230, 0, 126, 255);      //Egen färg
        Color lightGreen = new Color(15, 209, 163, 255);        //Egen färg
        Color darkLight = new Color(199, 227, 213, 255);    //Egen färg
        Color darkGray = new Color(15, 14, 11, 255);         //Egen färg
        Color gold = new Color(197, 173, 58, 255);         //Egen färg

        public void RunGame()
        {
            //Syftet med kodblocket är att den ska kontrollera ifall att spel objekten som spelare, fienden, och maten kolliderar med varandra. 
            bool eating = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeFood.foodCollision);
            bool collisionWithEnemy = Raylib.CheckCollisionRecs(snakeHead.playerPosition, snakeEnemy.enemyCollision);
            bool enemyAndFoodCollision = Raylib.CheckCollisionRecs(snakeEnemy.enemyCollision, snakeFood.foodCollision);
            //bool createEnemy = false;

            /* if (snakeEnemy.enemy.X == 0)
             {
                 snakeEnemy.updateEnemyPosition();
             }*/

            if (snakeFood.foodPosition.X == 0)
            {
                snakeFood.updateFoodPosition();
            }

            //If satserna nedan fungerar på samma sätt. Med hjälp av boolen jag tidifare skapat kollar den ifall att den är true (Kollisione med de tre olika spel objekten, fienden, maten & spelaren). 
            //Ifall att boolen är true komme koden i if-satsen köras. Detta behövs för att kunna byta matens position och därmed ge spelaren poäng. Fiendens position är också något som ändras. 
            if (eating)
            {
                snakeFood.updateFoodPosition();    //Metoden anropas för att ge maten och poängen ett nytt värde.
                snakeEnemy.updateEnemyPosition();      //Fienden får en ny position.
                snakeFood.FoodPoints();
                snakeFood.score += snakeFood.foodPointWorth;     //Eftersom att int score börjar som 0 adderas den med worths random värde efter att ormen har rört maten.
            }

            if (collisionWithEnemy)
            {
                // snakeFood.updateFoodPosition();
                // snakeEnemy.updateEnemyPosition();
                snakeFood.score -= snakeEnemy.losePoints;
            }

            if (enemyAndFoodCollision)
            {
                snakeFood.updateFoodPosition();
                snakeEnemy.updateEnemyPosition();
            }

            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BLACK);

            Raylib.DrawRectangleRec(snakeFood.foodCollision, Color.BLACK);  //Eftersom att jag har valt att maten ska vara cirkelformad 
            Raylib.DrawCircleV(snakeFood.foodPosition, 20, lightPink);
            Raylib.DrawCircleV(snakeFood.foodPosition, 15, Color.BLACK);

            //Kod för spelaren.
            snakeHead.playerMovement();  //Anropar metod för att kunna förflytta spelaren. 
            Raylib.DrawRectangleRec(snakeHead.playerPosition, Color.BLACK);     //Hämntar rektangelns form från klassen player. 
            Raylib.DrawRectangleLinesEx(snakeHead.playerPosition, 4, lightGreen);

            Raylib.DrawRectangle(0, 0, 1100, 55, darkGray);     //Backgrund för den övre delen av skärmen.

            /*if (snakeFood.score >= -50 && !createEnemy)
            {
                createEnemy = true;
                snakeEnemy.createEnemy();
                Raylib.DrawText("The V.I.P's has arrived", 680, 10, 35, gold);

                for (int i = 0; i < snakeEnemy.enemyList.Count; i++)
                {
                    Raylib.DrawRectangleRec(snakeEnemy.enemyCollision, Color.BLACK);
                    Raylib.DrawPoly(snakeEnemy.enemyList[i], 1, 28, 180, gold);
                    Raylib.DrawPoly(snakeEnemy.enemyList[i], 1, 20, 180, Color.BLACK);
                }
            }*/

            Raylib.DrawText(snakeFood.score.ToString(), 40, 10, 40, darkLight);     //Kod för att visa poäng. 
            Raylib.DrawText("$", 10, 10, 40, darkLight);

            //Kod för svansen.
            //Raylib.DrawTriangle(snakeTail, 90, 90, Color.GREEN);
            //Raylib.DrawText(snakeHead.showTail);

            for (int i = 0; i < snakeTail.tailList.Count; i++)
            {
                Raylib.DrawRectangleRec(snakeEnemy.enemyCollision, Color.BLACK);
                Raylib.DrawCircleV(snakeTail.tailList[i], 15, lightPink);
            }
        }
    }
}
