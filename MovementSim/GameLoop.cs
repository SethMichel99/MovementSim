using System.Diagnostics;
using System.Windows.Forms;

namespace MovementSim
{
    internal class GameLoop
    {
        private System.Windows.Forms.Timer timer; //timer field to ref Timer class
        GameScreen gameScreen; // field to ref GameScreen class
        Stopwatch watch;
        
        

        public GameLoop(GameScreen gameScreen)
        {
            this.gameScreen = gameScreen; //allows other methods in GameLoop to access GameScreen class
            /////double deltaTime = watch.Elapsed.Seconds; //watch is only measurable in seconds, 2 ms ie 0.0020 seconds

            timer = new System.Windows.Forms.Timer(); //create timer object
            watch = new Stopwatch();
            timer.Interval = 16; //mili seconds
            timer.Tick += OnTick; //interval sets the tick, every tick runs the OnTick method
            
            watch.Start(); //start watch class
            timer.Start(); //start timer class
        }
        public void OnTick(object? sender, EventArgs e)
        {
            double deltaTime = watch.Elapsed.TotalSeconds; //variable to store elapsed time between ticks
            watch.Restart(); //restart after capturing tick time
            gameScreen.UpdateGame(deltaTime, 100); //game gets updated in deltaTime, 
            gameScreen.Invalidate();
        
        }
        
    }
}
