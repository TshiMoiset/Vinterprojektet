using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Food
    {
        public int xFood;       //Matens x position.
        public int yFood;       //Matens y position.

        public int score;       //Spelarens score.
        public int foodPointWorth;       //Hur mycket poäng som ska läggas till spelaren. 

        public Vector2 foodPosition;        //Maten form. 
        public Rectangle foodCollision;     //Rektangel som ska kolla ifall att maten koliderar med andra objekt. 

        Random randomNumber = new Random();     //Random generator

        public void updateFoodPosition()        //Metoden ska köras varje gång spelaren kolliderar med spelaren så att den får en ny position.
        {
            xFood = randomNumber.Next(30, 1070);        //Maten får en random x.
            yFood = randomNumber.Next(85, 670);        //Maten får en random y.

            foodPosition.X = xFood;     //Vector2 alltså maten får en random positionen xFood har fått.
            foodPosition.Y = yFood;     //Vector2 alltså maten får en random positionen yFood har fått.

            foodCollision = new Rectangle(xFood - 20, yFood - 20, 40, 40);      //Ritar ut en rektangel som kommer ha värdet av xFood & yFood -20 så att den hamnar exakt bakom cirkeln.
        }

        public void FoodPoints()
        {
            foodPointWorth = randomNumber.Next(1, 25);
        }
    }
}