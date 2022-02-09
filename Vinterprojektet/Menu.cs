using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Menu
    {
        public void runMenu()
        {
            StartGame launchGame = new StartGame();

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