using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesLibrary;

namespace SimpleGridBasedGames.Forms
{
    public partial class Viewport : Form
    {

        private TestGame _game;


        private Pen PenA = new Pen(Color.White);
        public Viewport()
        {
            InitializeComponent();
            _game = new TestGame(10);
        }

        private void uxViewPort_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = uxViewPort.CreateGraphics();

            MessageBox.Show($"{e.Location}");

            graphics.DrawEllipse(PenA, new Rectangle(e.Location, new Size(1, 1)));

            _game.DrawGrid(graphics);

        }

        private void uxTimer_Tick(object sender, EventArgs e)
        {
            _game.DrawGrid(uxViewPort.CreateGraphics());
        }

        private void Viewport_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Space:
                    break;
                case Keys.Left:
                    _game.XOffset += -10;
                    break;
                case Keys.Up:
                    _game.YOffset += -10;
                    break;
                case Keys.Right:
                    _game.XOffset += 10;
                    break;
                case Keys.Down:
                    _game.YOffset += 10;
                    break;
                case Keys.Shift:
                    break;
                default:
                    break;
            }
        }

        private void Viewport_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
