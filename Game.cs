using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Snake_Game
{
    public partial class Game : Form
    {
        int horVelocity;
        int verVelocity;
        int step = 20;

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Height = 600;
            this.Width = 600;
            this.Controls.Add(area);
            area.Top = 75;
            area.Left = 100;

            snake.Render(this);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(mainTimer_Tick);
        }
    }
}
