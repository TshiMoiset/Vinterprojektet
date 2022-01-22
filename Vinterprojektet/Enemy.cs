using System.Collections.Generic;
using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Enemy
    {
        Food snakeFood = new Food();

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

            xEnemy1 = randomNumber.Next(30, 1055);        //Fienden får en random x.
            yEnemy1 = randomNumber.Next(70, 660);        //Fienden får en random y.

            xEnemy2 = randomNumber.Next(30, 1055);        //Fienden får en random x.
            yEnemy2 = randomNumber.Next(70, 660);        //Fienden får en random y.

            xEnemy3 = randomNumber.Next(30, 1055);        //Fienden får en random x.
            yEnemy3 = randomNumber.Next(70, 660);        //Fienden får en random y.

            enemy1.X = xEnemy1;
            enemy1.Y = yEnemy1;

            enemy2.X = xEnemy2;
            enemy2.Y = yEnemy2;

            enemy3.X = xEnemy3;
            enemy3.Y = yEnemy3;

            enemy1Collision = new Rectangle(xEnemy1 - 20, yEnemy1 - 25, 40, 40);
            enemy2Collision = new Rectangle(xEnemy2 - 20, yEnemy2 - 25, 40, 40);
            enemy3Collision = new Rectangle(xEnemy3 - 20, yEnemy3 - 25, 40, 40);

            /* if (xEnemy1 == xEnemy2 && xEnemy1 == xEnemy3 && xEnemy2 == xEnemy3)
             {
                 xEnemy1 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy1 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy2 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy2 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy3 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy3 = randomNumber.Next(70, 660);        //Fienden får en random y.
             }

             if (yEnemy1 == yEnemy2 && yEnemy1 == xEnemy3 && xEnemy2 == xEnemy3)
             {
                 xEnemy1 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy1 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy2 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy2 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy3 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy3 = randomNumber.Next(70, 660);        //Fienden får en random y.
             }

             if (snakeFood.xFood == xEnemy1 && snakeFood.xFood == xEnemy2 && snakeFood.xFood == xEnemy3)
             {
                 xEnemy1 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy1 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy2 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy2 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy3 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy3 = randomNumber.Next(70, 660);        //Fienden får en random y.
             }

             if (snakeFood.yFood == yEnemy1 && snakeFood.yFood == yEnemy2 && snakeFood.yFood == yEnemy3)
             {
                 xEnemy1 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy1 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy2 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy2 = randomNumber.Next(70, 660);        //Fienden får en random y.

                 xEnemy3 = randomNumber.Next(30, 1055);        //Fienden får en random x.
                 yEnemy3 = randomNumber.Next(70, 660);        //Fienden får en random y.
             }*/

        }
    }
}