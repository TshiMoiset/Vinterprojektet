using System.Security.Cryptography.X509Certificates;
using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Enemy
    {
        int xEnemy;     //Fiendens x position. 
        int yEnemy;     //Fiendens y position.
        public int losePoints;      //Poängen spelaren kommer att förlora efter att ha krockat med fienden. 
        int enemyAmount;

        public Vector2 enemy;       //Fienden skapas som en triangel med hjälp av vector2.

        public List<Vector2> enemyList = new List<Vector2>();       //En lista där alla fiender kommar att placeras efter att ha skapats. 

        public Rectangle enemyCollision;        //Kollar ifall att fienden kolliderar med maten.

        Random randomNumber = new Random();     //Randrom generator. 

        public void createEnemy()
        {
            enemyAmount = randomNumber.Next(1, 7);

            for (var i = 0; i < enemyAmount; i++)
            {
                enemyList.Add(enemy);
                xEnemy = randomNumber.Next(35, 1065);        //Fienden får en random x.
                yEnemy = randomNumber.Next(90, 675);        //Fienden får en random x.

                enemy.X = xEnemy;       //Maten får en random positionen xFood har fått.
                enemy.Y = yEnemy;       //Maten får en random positionen yFood har fått.

                Console.WriteLine(enemyList[i]);
            }

            enemyCollision = new Rectangle(xEnemy - 20, yEnemy - 25, 40, 40);     //Ritar ut en rektangel som kommer ha värdet av xEnemy1 -20 & yEnemy1 -25 så att den hamnar exakt bakom triangeln.
            losePoints = randomNumber.Next(10, 25);     //Antalet poängen som spelaren kommer förlora slumpas. 
        }

        public void updateEnemyPosition()       //Koden ska köras när spelaren har krockat med fienden eller maten. 
        {
            xEnemy = randomNumber.Next(35, 1065);        //Fienden får en random x.
            yEnemy = randomNumber.Next(90, 675);        //Fienden får en random x.

            enemy.X = xEnemy;
            enemy.Y = yEnemy;
        }
    }
}