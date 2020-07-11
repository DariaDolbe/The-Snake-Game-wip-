using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Snake_Game
{
    class Area : PictureBox
    {
        public Area()
        {
            InitializeArea();
        }

        private void InitializeArea()
        {
            this.BackColor = Color.ForestGreen;
            this.Height = 400;
            this.Width = 400;

        }
    }
}
