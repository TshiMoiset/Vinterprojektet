using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Food
    {
        Player player = new Player();

        int yFood = 0;
        int xFood = 0;
        public int score = 0;
        public int worth = 0;

        public Rectangle foodPosition = new Rectangle(100, 100, 40, 40); //Matens storlek och postition.

        Random number = new Random();

        public void updateFoodPosition()
        {
            worth = number.Next(20, 90);        // Worth blir random.

            xFood = number.Next(20, 969);        //Maten får en random x.
            yFood = number.Next(20, 569);        //Maten får en random y.
            foodPosition.x = xFood;
            foodPosition.y = yFood;
        }
    }
}