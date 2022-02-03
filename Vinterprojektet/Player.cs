using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace Vinterprojektet
{
    public class Player
    {
        public Rectangle playerPosition = new Rectangle(480, 280, 40, 40);  // Ormens huvud

        public int[] tail = new int[100];

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

            if (playerPosition.x == -100)        // Om man befinner sig på position -40 på x kommer spelarens påsition ändras till 1040.
            {
                playerPosition.x = 1090;
            }

            else if (playerPosition.x == 1090)
            {
                playerPosition.x = -100;
            }

            else if (playerPosition.y == -40)        // Om man befinner sig på position -40 på y kommer spelarens påsition ändras till 640.
            {
                playerPosition.y = 700;
            }

            else if (playerPosition.y == 700)
            {
                playerPosition.y = -40;
            }

            playerPosition.x += xMovement;      // Gör så att Ormens x ändras hela tiden tills att man har tryckt på en annan knapp.
            playerPosition.y += yMovement;      // Gör så att Ormens y ändras hela tiden tills att man har tryckt på en annan knapp.
        }

        public void showTail()
        {
            for (int i = 0; i < tail.Length; i++)
            {
                Console.Write(tail[i]);
                //tail = tail[i];
            }

        }

        public void addTail()
        {

        }
    }
}

