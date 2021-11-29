using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Food
    {
        public int score = 0;
        Player player = new Player();

        int yFood = 0;
        int xFood = 0;
        Random generator = new Random();

        public Rectangle foodPosition = new Rectangle(100, 100, 40, 40);

        public void updateFoodPosition()
        {
            xFood = generator.Next(20, 980);
            yFood = generator.Next(20, 580);
            foodPosition.x = xFood;
            foodPosition.y = yFood;
        }


    }
}