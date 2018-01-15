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
    public partial class FormInicioFinal : Form
    {

        public FormInicioFinal()
        {
            
            InitializeComponent();
        }
       
        /// <summary>
        /// Al clicar sobre el label s'obrira el formulari de score al mig de la pantalla,
        /// Si es tancara  l'actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblScore_Click(object sender, EventArgs e)
        {
            FormScore frmScore = new FormScore();
            frmScore.StartPosition = FormStartPosition.CenterScreen;
            frmScore.Show();
            this.Hide();
        }


        private void FormInicioFinal_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        ///   ????? 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblColorRandom1_Load(object sender, EventArgs e)
        {
            lblColorRandom1.currForm(this);
        }

        private void lblColorRandom1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Al clicar sobre el label s'obrira el formulari del tutorial al mig de la pantalla,
        /// No es tancara l'actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labTutorial_Click(object sender, EventArgs e)
        {
            FormTutorial frmTuto = new FormTutorial();
            frmTuto.StartPosition = FormStartPosition.CenterScreen;
            frmTuto.Show();

        }
    }
}
