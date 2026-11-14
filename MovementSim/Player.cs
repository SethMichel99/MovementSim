namespace MovementSim
{
    internal class Player
    {
        public double playerX;
        public double playerY;

        public double playerWidth;

        public double playerHeight;

       
        public Player(double playerWidth, double playerX, double playerY, double playerHeight)
        {
            
            this.playerHeight = playerHeight;
            this.playerWidth = playerWidth;
            this.playerX = playerX;
            this.playerY = playerY;
            
        }

        public void MoveRight(double speed)
        {
            playerX += speed;
        }
        public void MoveLeft(double speed)
        {
            playerX -= speed;
        
        }
        public void MoveUp(double speed)
        {
            playerY -= speed;

        
        }

        public void MoveDown(double speed)
        {
            playerY += speed;
        }

        
    }
}
