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
                update();

                Raylib.BeginDrawing();
                //Spelets logik
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    playerPosition.x += 2.0f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    playerPosition.x -= 2.0f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    playerPosition.y -= 2.0f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    playerPosition.y += 2.0f;
                }

                Raylib.ClearBackground(Color.BLACK);
                // Kod för att rita ut saker till fönstret

                Raylib.DrawRectangleRec(playerPosition, Color.BLUE);



                Raylib.EndDrawing();
            }

            void update()
            {
                int playerSpeed = 7 * 4;
            }



        }
    }
}
