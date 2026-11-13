using System.Windows.Forms;

namespace MovementSim
{
    internal class GameLoop
    {
        private System.Windows.Forms.Timer timer; //timer field to ref Timer class
        GameScreen gameScreen; // field to ref GameScreen class


        public GameLoop(GameScreen gameScreen)
        {
            this.gameScreen = gameScreen; //allows other methods in GameLoop to access GameScreen class
            timer = new System.Windows.Forms.Timer(); //create timer object
            timer.Interval = 16; //mili seconds
            timer.Tick += OnTick; //interval sets the tick, every tick runs the OnTick method
            timer.Start(); //start timer class
        }
        public void OnTick(object? sender, EventArgs e)
        {
            gameScreen.UpdateGame();
            gameScreen.Invalidate();
        
        }
        
    }
}
