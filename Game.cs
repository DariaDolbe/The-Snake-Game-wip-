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

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
        }

        private void InitializeGame()
        {
            this.Height = 600;
            this.Width = 600;
            this.Controls.Add(area);
            area.Top = 75;
            area.Left = 100;

            snake.Render(this);

            this.KeyDown += new KeyEventHandler(Game_keydown);
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(mainTimer_Tick);
            mainTimer.Start();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            snake.Move();
        }
        
        private void Game_keydown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (snake.HorizontalVelocity != -1)
                    {
                        snake.HorizontalVelocity = 1;
                    }
                    snake.VerticalVelocity = 0;
                    break;
                case Keys.Left:
                    if (snake.HorizontalVelocity != 1)
                    {
                        snake.HorizontalVelocity = -1;
                    }
                    snake.VerticalVelocity = 0;
                    break;
                case Keys.Down:
                    snake.HorizontalVelocity = 0;
                    if (snake.VerticalVelocity != -1)
                    {
                        snake.VerticalVelocity = 1;
                    }
                    break;
                case Keys.Up:
                    snake.HorizontalVelocity = 0;
                    if (snake.VerticalVelocity != 1)
                    {
                        snake.VerticalVelocity = -1;
                    }
                    break;
            }
        }
    }
}
