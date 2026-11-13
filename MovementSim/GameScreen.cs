using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementSim
{
    internal class GameScreen : Form
    {
        Player player = new Player(100, 100, 100, 100);


        bool isRight = false;
        bool isLeft = false;
        bool isUp = false;
        bool isDown = false;
     

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Aqua, player.playerX, player.playerY, 100, 100);

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

        public void UpdateGame()
        {
            if (isRight)
            {
                player.MoveRight(10);
                CheckPerim();
            }
            if (isLeft)
            {
                player.MoveLeft(10);
                CheckPerim();
            }
            if (isUp)
            {
                player.MoveUp(10);
                CheckPerim();
            }
            if (isDown)
            {
                player.MoveDown(10);
                CheckPerim();
            
            }

        }
        
    }
}
