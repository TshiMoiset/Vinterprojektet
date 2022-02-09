using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Food
    {
        public int score;            //Spelarens score.
        public int foodPointWorth;       //Hur mycket poäng som ska läggas till spelaren. 

        public Vector2 foodPosition;        //Maten form. 
        public Rectangle foodCollision;     //Rektangel som ska kolla ifall att maten koliderar med andra objekt. 

        Random randomNumber = new Random();     //Random generator

        public void updateFoodPosition()        //Metoden ska köras varje gång spelaren kolliderar med spelaren så att den får en ny position.
        {
            foodPosition.X = randomNumber.Next(30, 1070);        //Maten får en random x.
            foodPosition.Y = randomNumber.Next(85, 670);        //Maten får en random y.
        }

        public void FoodPoints()
        {
            foodPointWorth = randomNumber.Next(1, 25);
        }
    }
}