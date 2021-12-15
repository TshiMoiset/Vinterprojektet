using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Menu
    {

        int yButtonPosition = 686;
        int xTextPostition = yButtonPosition;

        public Rectangle startButton;
        public Rectangle scoreButton;
        public Rectangle exitButton;

        public void gameMenu()
        {
            Raylib.InitWindow(1350, 750, "Mamba Games");

            Image menuImage = Raylib.LoadImage(@"MambaGames.png");
            Raylib.ImageResize(ref menuImage, 30, 30);
            Texture2D menuImgTexture = Raylib.LoadTextureFromImage(menuImage);

            //Bilder
            Raylib.DrawTexture(menuImgTexture, 0, 0, Color.WHITE);
            /*startButton = new Rectangle(xButtonPosition, 100, 400, 300);
            scoreButton = new Rectangle(xButtonPosition, 200, 400, 300);
            exitButton = new Rectangle(xButtonPosition, 300, 400, 300);*/

            Raylib.DrawTexture(menuImgTexture, 0, 0, Color.WHITE);

            Raylib.DrawTexture(menuImgTexture, 0, 0, Color.WHITE);

            Raylib.DrawRectangle(110, yButtonPosition, 120, 35, Color.BLACK);
            Raylib.DrawText("Begin", 115, xTextPostition, 40, Color.WHITE);


            Raylib.DrawRectangle(380, yButtonPosition, 127, 35, Color.BLACK);
            Raylib.DrawText("Score", 383, xTextPostition, 40, Color.WHITE);


            Raylib.DrawRectangle(650, yButtonPosition, 120, 35, Color.BLACK);
            Raylib.DrawText("End", 675, xTextPostition, 40, Color.WHITE);

        }
    }
}