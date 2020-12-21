using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GridLibrary;
using System.Windows.Forms;
using System.Drawing;

namespace GamesLibrary
{
    public class TestGame
    {
        private GridSpace<bool> _gridSpace;

        private SolidBrush _brush = new SolidBrush(Color.White);

        private int _size;

        public int XOffset { get; set; }

        public int YOffset { get; set; }

        public TestGame(int size)
        {
            _size = size;
            _gridSpace = new GridSpace<bool>(_size, _size);
        }

        public void DrawGrid(Graphics graphics)
        {
            graphics.Clear(Color.Black);
            graphics.FillRectangle(_brush, new Rectangle(0 + XOffset, 0 + YOffset, _size * 50, _size * 50));
            DrawFrameRate(graphics);
            for (int i = 0; i < _size; i++)
                for (int j = 0; j < _size; j++)
                    DrawSquare(graphics, i, j);
        }

        private void DrawSquare(Graphics graphics, int x, int y)
        {

        }

        private void DrawFrameRate(Graphics graphics)
        {

        }

    }
}
