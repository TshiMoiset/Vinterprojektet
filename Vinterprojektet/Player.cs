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

        int xMovement = 0;
        int yMovement = 0;
        int playerSpeed = 5;

        public void playerMovement()        //Metod för ormens rörelse. 
        {
            //Spelets logik
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                xMovement = playerSpeed;
                yMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                xMovement = -playerSpeed;
                yMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                yMovement = -playerSpeed;
                xMovement = 0;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                yMovement = playerSpeed;
                xMovement = 0;
            }

            playerPosition.x += xMovement;
            playerPosition.y += yMovement;


        }
    }
}

