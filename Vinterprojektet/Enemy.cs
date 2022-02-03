using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Enemy
    {
        int xEnemy;
        int yEnemy;
        public int losePoints;
        //public Vector2 enemy;

        public Vector2 enemy;


        //List<string> listNamn = new List<string>();
        List<Vector2> enemyList = new List<Vector2>();

        int enemyAmount;

        public Rectangle enemyCollision;

        Random randomNumber = new Random();

        public void updateEnemyPosition()
        {
            /*enemy.X = xEnemy;
            enemy.Y = yEnemy;*/

            enemyAmount = randomNumber.Next(1, 7);

            for (var i = 0; i < enemyAmount; i++)
            {
                enemy = new Vector2();
                enemyList.Add(enemy);
                xEnemy = randomNumber.Next(35, 1065);        //Fienden får en random x.
                yEnemy = randomNumber.Next(90, 675);

                enemy.X = xEnemy;
                enemy.Y = yEnemy;
            }

            enemyCollision = new Rectangle(xEnemy - 20, yEnemy - 25, 40, 40);        //Ritar ut en rektangel som kommer ha värdet av xEnemy1 -20 & yEnemy1 -25 så att den hamnar exakt bakom triangeln.
            losePoints = randomNumber.Next(10, 25);
        }
    }
}