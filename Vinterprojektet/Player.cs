using System.Security.Cryptography.X509Certificates;
using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Player
    {
        public Rectangle playerPosition = new Rectangle(40, 40, 40, 40);

        public string[] tail;

        public void playerMovement()
        {
            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                {
                    playerPosition.x += 2.0f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                {
                    playerPosition.x -= 2.0f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    playerPosition.y -= 2.0f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    playerPosition.y += 2.0f;
                }

                Raylib.BeginDrawing();
                //Spelets logik



                Raylib.ClearBackground(Color.BLACK);
                Raylib.DrawRectangleRec(playerPosition, Color.BLUE);

                // Kod för att rita ut saker till fönstret



                Raylib.EndDrawing();
            }

        }
    }
}