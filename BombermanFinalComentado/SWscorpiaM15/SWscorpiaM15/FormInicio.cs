using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWScorpiaM15
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormGameplay frmGame = new FormGameplay();

            frmGame.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            FormScore frmScore = new FormScore();

            frmScore.Show();
        }
    }
}
