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
using SimpleGridBasedGames.Forms;

namespace SimpleGridBasedGames
{
    public partial class UserInterface : Form
    {
        public TestGame Game { get; set; }

        public UserInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewport viewport = new Viewport();
            Hide();
            if (viewport.ShowDialog() == DialogResult.Cancel) Show();
        }
    }
}
