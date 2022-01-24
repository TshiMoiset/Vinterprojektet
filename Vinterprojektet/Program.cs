using System.Runtime.CompilerServices;
using System;
using Raylib_cs;
using System.Numerics;


namespace Vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Player snakeHead = new Player();        //Anropar på klassen player.
            Food snakeFood = new Food();        //Anropar på klassen food.
            Tail snakeTail = new Tail();        //Anropar på klassen tail.
            StartGame launchGame = new StartGame();

            Color lightPink = new Color(230, 0, 126, 255);      //Egen färg
            Color lightGreen = new Color(15, 209, 163, 255);
            Color darkLight = new Color(199, 227, 213, 255);

            int yButtonPosition = 685;
            int xTextPostition = 685;
            int textSize = 45;

            /*Rectangle startButton = new Rectangle(160, yButtonPosition, 120, 32);
            Rectangle scoreButton = new Rectangle(428, yButtonPosition, 127, 35);
            Rectangle endButton = new Rectangle(720, yButtonPosition, 120, 35);*/

            // Raylib.GetMousePosition();
            bool hoverOnButton;

            Raylib.InitWindow(1350, 750, "Mamba Games");
            Raylib.SetTargetFPS(60);

            Image menuImage = Raylib.LoadImage(@"MambaGames.png");
            Raylib.ImageResize(ref menuImage, 1350, 750);
            Texture2D menuImgTexture = Raylib.LoadTextureFromImage(menuImage);

            string scene = "menu";

            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();

                if (scene == "menu")
                {
                    Raylib.DrawTexture(menuImgTexture, 0, 0, Color.WHITE);
                    //bool hoverOnButton = Raylib.CheckCollisionRecs(, startButton);

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        scene = "game";
                        Raylib.SetWindowSize(1100, 700);
                    }

                    // Raylib.DrawRectangleRec(startButton, Color.GREEN);
                    Raylib.DrawText("Begin", 160, xTextPostition, textSize, Color.WHITE);


                    // Raylib.DrawRectangleRec(scoreButton, Color.GREEN);
                    Raylib.DrawText("Score", 428, xTextPostition, textSize, Color.WHITE);


                    // Raylib.DrawRectangleRec(endButton, Color.GREEN);
                    Raylib.DrawText("End", 720, xTextPostition, textSize, Color.WHITE);

                }

                else if (scene == "game")
                {
                    launchGame.RunGame();

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE))
                    {
                        scene = "menu";
                        Raylib.SetWindowSize(1350, 750);
                    }
                }

                Raylib.EndDrawing();

            }
        }
    }
}

