using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Player
    {
        public Rectangle playerPosition = new Rectangle(480, 280, 40, 40);

        //public string[] tail;



        int direcionMovemnet = 0;
        //int movementDirection = 0;

        public void playerMovement()        //Metod för ormens rörelse. 
        {
            while (!Raylib.WindowShouldClose())
            {
                //update();

                Raylib.BeginDrawing();
                //Spelets logik
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                {
                    playerPosition.x += 25f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                {
                    playerPosition.x -= 25f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                {
                    playerPosition.y -= 25f;
                }

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                {
                    playerPosition.y += 25f;
                }

                Raylib.ClearBackground(Color.BLACK);
                // Kod för att rita ut saker till fönstret

                Raylib.DrawRectangleRec(playerPosition, Color.BLUE);



                Raylib.EndDrawing();
            }

            /*void update()
            {
                int playerSpeed = 7 * 4;
            }*/



        }
    }
}
