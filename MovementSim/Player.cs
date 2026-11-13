namespace MovementSim
{
    internal class Player
    {
        public int playerX;
        public int playerY;

        public int playerWidth;

        public int playerHeight;

       
        public Player(int playerWidth, int playerX, int playerY, int playerHeight)
        {
            
            this.playerHeight = playerHeight;
            this.playerWidth = playerWidth;
            this.playerX = playerX;
            this.playerY = playerY;
            
        }

        public void MoveRight(int speed)
        {
            playerX += speed;
        }
        public void MoveLeft(int speed)
        {
            playerX -= speed;
        
        }
        public void MoveUp(int speed)
        {
            playerY -= speed;

        
        }

        public void MoveDown(int speed)
        {
            playerY += speed;
        }

        
    }
}
