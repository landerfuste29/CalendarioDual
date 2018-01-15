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
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        private void FormScore_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// Recull tota l'informacio del document "mydocpath", la fica al dataGridView,
        /// l'ordena de gran a petit i amaga despres de la fila 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormScore_Load(object sender, EventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Score.txt";
           // string mydocpath = Properties.Resources.PuntuacionsBomberman;

            if (File.Exists(mydocpath))
            {

                string line;

                System.IO.StreamReader file =
                    new System.IO.StreamReader(mydocpath);
                while ((line = file.ReadLine()) != null)
                {
                    string[] row = line.Split('#');
                    dataGridView1.Rows.Add(row[0], row[1]);
                }
                file.Close();
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
                for (int i = dataGridView1.Rows.Count-1; i >=5; i--)
                {
                    dataGridView1.Rows[i].Visible = false;

                }

            }
            else
            {
                MessageBox.Show(Properties.Resources.noScore);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guardarPuntuacióToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tornarAlMenúDIniciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Mostra el formulari del joc i l'inicia amagant el actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarPuntuacióToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGameplay frmGame = new FormGameplay();
            frmGame.StartPosition = FormStartPosition.CenterScreen;
            frmGame.Show();
            this.Hide();


        }

        /// <summary>
        /// Mostra el formulari inicial i amaga l'actual. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tornarAlMenúDIniciToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
