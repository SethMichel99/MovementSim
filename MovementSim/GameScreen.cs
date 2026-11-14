using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementSim
{
    internal class GameScreen : Form
    {
        Player player = new Player(100, 100.0, 100.0, 100);


        bool isRight = false;
        bool isLeft = false;
        bool isUp = false;
        bool isDown = false;
     

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Aqua, (float)player.playerX, (float)player.playerY, 100, 100);

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.D) //RIGHT MOVEMENT
            {
              
               isRight = true;   
            }
                 
            //handle left
            if (e.KeyCode == Keys.A)
            {
                isLeft = true;
            }

            //handle up
            if (e.KeyCode == Keys.W)
            {
                isUp = true;
            }
            //handle down
            if (e.KeyCode == Keys.S)
            {
                isDown = true;
            }
           
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.D)
            {
                isRight = false;
            }
            if (e.KeyCode == Keys.A)
            {
                isLeft = false;
            }
            if (e.KeyCode == Keys.W)
            {

                isUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                isDown = false;
            
            
            }
         
        }

        public void CheckPerim()
        {
            if (player.playerX > ClientSize.Width - player.playerWidth)
            {
                player.playerX = ClientSize.Width - player.playerWidth;
            }

            if (player.playerX < 0)
            {
                player.playerX = 0;
            }

            if (player.playerY > ClientSize.Height - player.playerHeight)
            {
                player.playerY = ClientSize.Height - player.playerHeight;
            
            }

            if (player.playerY < 0)
            {
                player.playerY = 0;
            }
        }

        public void UpdateGame(double deltaTime, double speed)
        {
            // speed = 10 * deltaTime; //wrong logic, 10 = 10 * deltaTime

            double movement = speed * deltaTime; //movement will capture correct distance measured for player using speed and deltaTime
            
            if (isRight)
            {
                player.MoveRight(movement);
            }
            if (isLeft)
            {
                player.MoveLeft(movement);
            }
            if (isUp)
            {
                player.MoveUp(movement);             
            }
            if (isDown)
            {
                player.MoveDown(movement);
            }
            CheckPerim();
        }
        
    }
}
