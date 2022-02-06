using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

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

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        scene = "game";
                        Raylib.SetWindowSize(1100, 700);
                    }

                    Raylib.DrawText("Press left mouse key to start", 160, 685, 45, Color.WHITE);
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

