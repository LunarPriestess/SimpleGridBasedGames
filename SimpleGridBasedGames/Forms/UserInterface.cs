using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGridBasedGames
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void uxChangeColor1_Click(object sender, EventArgs e)
        {
            if (uxColorDialog.ShowDialog() == DialogResult.OK)
            {
                uxColor1.BackColor = uxColorDialog.Color;
            }
        }

        private void uxChangeColor2_Click(object sender, EventArgs e)
        {
            if (uxColorDialog.ShowDialog() == DialogResult.OK)
            {
                uxColor2.BackColor = uxColorDialog.Color;
            }
        }
    }
}
