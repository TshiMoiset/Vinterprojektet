using System.Collections.Generic;
using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Enemy
    {

        int xEnemy = 0;
        int yEnemy = 0;

        int xTriangle = 0;
        int yTriangle = 0;



        /*int xEnemy1 = 0;
        int yEnemy1 = 0;

        int xEnemy2 = 0;
        int yEnemy2 = 0;

        int xEnemy3 = 0;
        int yEnemy3 = 0;

        int xEnemy4 = 0;
        int yEnemy4 = 0;

        int xEnemy5 = 0;
        int yEnemy5 = 0;

        int xEnemy6 = 0;
        int yEnemy6 = 0;*/

        public int losePoints = 0;
        //string[] enemies = { "enemy1", "enemy2", "enemy3", "enemy4", "enemy5", "enemy6" };

        public Vector2 enemy1;
        public Vector2 enemy2;
        public Vector2 enemy3;
        public Vector2 enemy4;
        public Vector2 enemy5;
        public Vector2 enemy6;

        public Vector2 enemyPosition;

        public Vector2 triangle1;
        public Vector2 triangle2;
        public Vector2 triangle3;

        public Rectangle enemyCollisionControl;

        Random randomNumber = new Random();

        public void updateEnemyPosition()
        {
            losePoints = randomNumber.Next(10, 25);
            xEnemy = randomNumber.Next(0, 1055);        //Fienden får en random x.
            yEnemy = randomNumber.Next(60, 660);        //Fienden får en random y.

            /*xEnemy1 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy1 = randomNumber.Next(20, 569);        //Fienden får en random y.

            xEnemy2 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy2 = randomNumber.Next(20, 569);        //Fienden får en random y.

            xEnemy3 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy3 = randomNumber.Next(20, 569);        //Fienden får en random y.

            xEnemy4 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy4 = randomNumber.Next(20, 569);        //Fienden får en random y.

            xEnemy5 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy5 = randomNumber.Next(20, 569);        //Fienden får en random y.

            xEnemy6 = randomNumber.Next(20, 969);        //Fienden får en random x.
            yEnemy6 = randomNumber.Next(20, 569);        Fienden får en random y.*/

            enemyPosition.X = xEnemy;
            enemyPosition.Y = yEnemy;

            /*enemy1.X = xEnemy1;
            enemy1.Y = yEnemy1;

            enemy2.X = xEnemy2;
            enemy2.Y = yEnemy2;

            enemy3.X = xEnemy3;
            enemy3.Y = yEnemy3;

            enemy4.X = xEnemy4;
            enemy4.Y = xEnemy4;

            enemy5.X = xEnemy5;
            enemy5.Y = xEnemy5;

            enemy6.X = xEnemy6;
            enemy6.Y = xEnemy6; */

            enemyCollisionControl = new Rectangle(xEnemy - 20, yEnemy - 25, 40, 40);
        }
    }
}