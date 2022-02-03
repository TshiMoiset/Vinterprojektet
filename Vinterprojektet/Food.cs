using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Food
    {
        public int xFood;
        public int yFood;

        public int score;
        public int worth;

        public Vector2 foodPosition;
        public Rectangle collisionControl;

        Random randomNumber = new Random();

        public void updateFoodPosition()
        {
            worth = randomNumber.Next(1, 25);        // Matens värde som blir poäng blir random.

            xFood = randomNumber.Next(30, 1070);        //Maten får en random x.
            yFood = randomNumber.Next(85, 670);        //Maten får en random y.

            foodPosition.X = xFood;     //Vector2 alltså maten får en random positionen xFood har fått.
            foodPosition.Y = yFood;     //Vector2 alltså maten får en random positionen yFood har fått.

            collisionControl = new Rectangle(xFood - 20, yFood - 20, 40, 40);       //Ritar ut en rektangel som kommer ha värdet av xFood & yFood -20 så att den hamnar exakt bakom cirkeln.
        }
    }
}