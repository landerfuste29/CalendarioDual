using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWScorpiaM15
{
    public partial class FormGameplay2 : Form
    {
        int score;
        /// <summary>
        /// Reb la qnt de punts que te del formulari anterior i la mostra al lblPuntuacio
        /// </summary>
        /// <param name="contPuntuacio">qnt de punts que te</param>
        public FormGameplay2(int contPuntuacio)
        {
            score = contPuntuacio;
            InitializeComponent();
            lblPuntuacio.Text = String.Format(Properties.Resources.labScore, contPuntuacio);
        }

        private void tornarAlMenúDIniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Mostra el formulari amb les 5 millors puntuacions i amaga el actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarPuntuacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScore frmScore = new FormScore();
            frmScore.StartPosition = FormStartPosition.CenterScreen;
            frmScore.Show();
            this.Hide();
        }

        /// <summary>
        /// Guarga la puntuacio i el nom del jugador, despres amaga el buto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {

            String UserName = tbNom.Text;
            Score NewScore = new Score(UserName, score);
            this.btn_Save.Hide();
            NewScore.AddScoreInFile();
           
        }

        /// <summary>
        /// Mostra el formulari d'inici i amaga l'actual. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tornarAlMenúDIniciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormInicioFinal WindInicial = new FormInicioFinal();
            WindInicial.StartPosition = FormStartPosition.CenterScreen;
            WindInicial.Show();
            this.Hide();
        }

        /// <summary>
        /// Tanca el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
