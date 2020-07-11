using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Snake_Game
{
    class Snake
    {
        List<PictureBox> snakeSegments = new List<PictureBox>();
        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            this.AddSegment(200, 200);
            this.AddSegment(200, 220);
            this.AddSegment(200, 240);
        }

        private void AddSegment (int left, int top)
        {
            PictureBox snakeSegment = new PictureBox();
            snakeSegment.Height = 20;
            snakeSegment.Width = 20;
            snakeSegment.BackColor = Color.LightGoldenrodYellow;
            snakeSegment.Top = top;
            snakeSegment.Left = left;
            snakeSegments.Add(snakeSegment);
        }


        public void Render (Form form)
        {
            foreach(var ss in snakeSegments)
            {
                form.Controls.Add(ss);
                ss.BringToFront();
            }

        }
    }
}
