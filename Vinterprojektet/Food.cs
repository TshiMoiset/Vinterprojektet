using System;
using Raylib_cs;
using System.Numerics;

namespace Vinterprojektet
{
    public class Food
    {
        public int xFood = 0;
        public int yFood = 0;
        public int score = 0;
        public int worth = 0;

        Player player = new Player();

        public Vector2 foodPosition;
        public Rectangle collisionControl;

        Random randomNumber = new Random();

        public void updateFoodPosition()
        {
            worth = randomNumber.Next(1, 25);        // Matens värde som blir poäng blir random.

            xFood = randomNumber.Next(30, 1060);        //Maten får en random x.
            yFood = randomNumber.Next(70, 660);        //Maten får en random y.

            foodPosition.X = xFood;
            foodPosition.Y = yFood;

            collisionControl = new Rectangle(xFood - 20, yFood - 20, 40, 40);
        }
    }
}