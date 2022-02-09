using System.Security.Cryptography.X509Certificates;
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
        int enemyAmount;
        public int losePoints;      //Poängen spelaren kommer att förlora efter att ha krockat med fienden. 

        public Vector2 enemy;       //Fienden skapas som en triangel med hjälp av vector2.

        public List<Vector2> enemyList = new List<Vector2>();       //En lista där alla fiender kommar att placeras efter att ha skapats. 

        public Rectangle enemyCollision;        //Kollar ifall att fienden kolliderar med maten.

        Random randomNumber = new Random();     //Randrom generator. 
        Random newRandomNumber = new Random();

        public void createEnemy()
        {
            enemyAmount = randomNumber.Next(1, 5);

            for (var i = 0; i < enemyAmount; i++)
            {
                enemyList.Add(enemy);
                xEnemy = newRandomNumber.Next(35, 1065);        //Fienden får en random x.
                yEnemy = newRandomNumber.Next(90, 675);        //Fienden får en random x.      //Fienden får en random x.


                enemy.X = xEnemy;
                enemy.Y = yEnemy;
            }

            Console.WriteLine();
            Console.WriteLine("EJ RANDOM " + enemy.X);

        }

        public void updateEnemyPosition()       //Koden ska köras när spelaren har krockat med fienden eller maten. 
        {

            for (int i = 0; i < enemyAmount; i++)
            {
                xEnemy = newRandomNumber.Next(35, 1065);        //Fienden får en random x.
                yEnemy = newRandomNumber.Next(90, 675);        //Fienden får en random x.

                enemy.X = xEnemy;
                enemy.Y = yEnemy;
            }

            Console.WriteLine();
            Console.WriteLine("New X " + enemy.X);
            Console.WriteLine("New Y " + enemy.Y);
        }

        public void playerLosePoints()
        {
            losePoints = randomNumber.Next(10, 25);     //Antalet poängen som spelaren kommer förlora slumpas. 
        }
    }
}