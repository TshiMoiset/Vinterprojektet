using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Enemy
    {
        int xEnemy = 0;
        int yEnemy = 0;

        public int pointLose = 0;

        public Vector2 enemyPosition;
        public Rectangle enemyCollisionControl;

        Random randomNumber = new Random();

        public void updateEnemyPosition()
        {
            xEnemy = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy = randomNumber.Next(20, 569);        //Fienden får en random y.

            pointLose = randomNumber.Next(10, 25);

            enemyPosition.X = 570;
            enemyPosition.Y = 10;

            enemyCollisionControl = new Rectangle(xEnemy - 20, yEnemy - 25, 40, 40);
        }
    }
}