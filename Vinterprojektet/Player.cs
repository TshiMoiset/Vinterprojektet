using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System;
using Raylib_cs;

namespace Vinterprojektet
{
    public class Player
    {
        public Rectangle playerPosition = new Rectangle(480, 280, 40, 40);  // Ormens huvud

        //public string[] tail;

        int xMovement = 0;          // X-ledens start hastighet
        int yMovement = 0;          // Y-ledens start hastighet
        int playerSpeed = 5;    // Ormens fart

        public void playerMovement()        //Metod för ormens rörelse. 
        {
            //Spelets logik
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D))        // Trycker man på höger knappen blir yMovement 0;
            {
                xMovement = playerSpeed;
                yMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                xMovement = -playerSpeed;
                yMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) || Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                yMovement = -playerSpeed;
                xMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) || Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                yMovement = playerSpeed;
                xMovement = 0;
            }

            if (playerPosition.x == -40)        // Om man befinner sig på position -40 på x kommer spelarens påsition ändras till 1040.
            {
                playerPosition.x = 1040;
            }

            else if (playerPosition.x == 1040)
            {
                playerPosition.x = -40;
            }

            else if (playerPosition.y == -40)        // Om man befinner sig på position -40 på y kommer spelarens påsition ändras till 640.
            {
                playerPosition.y = 640;
            }

            else if (playerPosition.y == 640)
            {
                playerPosition.y = -40;
            }

            playerPosition.x += xMovement;      // Gör så att Ormens x ändras hela tiden tills at man har tryckt på en annan knapp.
            playerPosition.y += yMovement;      // Gör så att Ormens y ändras hela tiden tills at man har tryckt på en annan knapp.
        }
    }
}

