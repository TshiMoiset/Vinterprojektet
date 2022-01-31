using System.Collections.Generic;
using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Enemy
    {
        int xEnemy1 = 0;
        int yEnemy1 = 0;

        int xEnemy2 = 0;
        int yEnemy2 = 0;

        int xEnemy3 = 0;
        int yEnemy3 = 0;

        public Vector2 enemy1;
        public Vector2 enemy2;
        public Vector2 enemy3;

        public Rectangle enemy1Collision;
        public Rectangle enemy2Collision;
        public Rectangle enemy3Collision;

        Random randomNumber = new Random();

        public int losePoints = 0;

        public void updateEnemyPosition()
        {
            losePoints = randomNumber.Next(10, 25);

            xEnemy1 = randomNumber.Next(35, 1065);        //Fienden får en random x.
            yEnemy1 = randomNumber.Next(90, 675);        //Fienden får en random y.

            xEnemy2 = randomNumber.Next(35, 1065);        //Fienden får en random x.
            yEnemy2 = randomNumber.Next(90, 675);        //Fienden får en random y.

            xEnemy3 = randomNumber.Next(35, 1065);        //Fienden får en random x.
            yEnemy3 = randomNumber.Next(90, 675);        //Fienden får en random y.

            enemy1.X = xEnemy1;     //Vector2 alltså fienden får en random positionen xEnemy1 har fått.
            enemy1.Y = yEnemy1;

            enemy2.X = xEnemy2;
            enemy2.Y = yEnemy2;

            enemy3.X = xEnemy3;
            enemy3.Y = yEnemy3;

            enemy1Collision = new Rectangle(xEnemy1 - 20, yEnemy1 - 25, 40, 40);        //Ritar ut en rektangel som kommer ha värdet av xEnemy1 -20 & yEnemy1 -25 så att den hamnar exakt bakom triangeln.
            enemy2Collision = new Rectangle(xEnemy2 - 20, yEnemy2 - 25, 40, 40);
            enemy3Collision = new Rectangle(xEnemy3 - 20, yEnemy3 - 25, 40, 40);
        }
    }
}