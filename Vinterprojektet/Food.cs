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

        Random generator = new Random();
        public Rectangle foodPosition = new Rectangle(100, 100, 40, 40); //Matens storlek och postition 

        public void updateFoodPosition()
        {
            xFood = generator.Next(20, 980);        //Maten får en random x
            yFood = generator.Next(20, 580);        //Maten får en random x
            foodPosition.x = xFood;
            foodPosition.y = yFood;
            worth = generator.Next(20, 100);        // Worth blir random
        }
    }
}