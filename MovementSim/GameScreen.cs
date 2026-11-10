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
        
        
          
     

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Aqua, player.playerX, player.playerY, 100, 100);

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            //handle right
            base.OnKeyDown(e);
            int speed = 10;
            if (e.KeyCode == Keys.D)
            {
                player.MoveRight(10);
                if (player.playerX > ClientSize.Width - player.playerWidth)
                {
                    player.playerX = ClientSize.Width - player.playerWidth;
                }


            }

            //handle lef
            if (e.KeyCode == Keys.A)
            {
                player.MoveLeft(10);
                if (player.playerX < 0)
                {
                    player.playerX = 0;

                }
            }

            //handle up
            if (e.KeyCode == Keys.W)
            {
                player.MoveUp(10);

                if (player.playerY < 0)
                {
                    player.playerY = 0;
                }
            }
            //handle down
            if (e.KeyCode == Keys.S)
            {

                player.MoveDown(10);

                if (player.playerY > ClientSize.Height - player.playerHeight)
                {
                    player.playerY = ClientSize.Height - player.playerHeight;

                }

            }
            Invalidate();


        }


    }
}
