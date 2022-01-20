using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Enemy
    {
        int xEnemy = 0;
        int yEnemy = 0;

        public Vector2 enemyPosition1;
        public Vector2 enemyPosition2;
        public Vector2 enemyPosition3;
        //public Vector2 enemyPositionTest;
        //        public Rectangle collisionControl;

        Random randomNumber = new Random();

        public void updateEnemyPosition()
        {
            xEnemy = randomNumber.Next(20, 969);        //Maten får en random x.
            yEnemy = randomNumber.Next(20, 569);        //Maten får en random y.

            enemyPosition1.X = xEnemy;
            enemyPosition1.Y = yEnemy;

            enemyPosition2.X = xEnemy;
            enemyPosition2.Y = yEnemy;

            enemyPosition3.X = xEnemy;
            enemyPosition3.Y = yEnemy;

            //collisionControl = new Rectangle(xFood - 20, yFood - 20, 40, 40);
        }
    }
}