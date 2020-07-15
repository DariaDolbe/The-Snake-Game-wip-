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
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 0;
        public int Step { get; set; } = 20;

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

        public void Move()
        {
            for (int i = snakeSegments.Count - 1; i > 0; i--)
            {
                snakeSegments[i].Location = snakeSegments[i - 1].Location;
            }

            snakeSegments[0].Left += this.HorizontalVelocity * this.Step;
            snakeSegments[0].Top += this.VerticalVelocity * this.Step;
        }
    }
}
