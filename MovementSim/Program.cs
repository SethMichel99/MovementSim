using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using MovementSim;


class Program
{
    [STAThread]

    static void Main()
    {
        Application.EnableVisualStyles(); //default method to enable ui in c#?
        Application.SetCompatibleTextRenderingDefault(false); //not sure purpose?

        GameScreen screen = new GameScreen(); //create new Form object window for our game panel window
        
        screen.Text = "MovementSim";
        //  screen.Height = 600;
        // screen.Width = 800;

        screen.ClientSize = new Size(800, 600);

        screen.StartPosition = FormStartPosition.CenterScreen; //method to find start position of screen at runtime

       

        Application.Run(screen);
    }
}