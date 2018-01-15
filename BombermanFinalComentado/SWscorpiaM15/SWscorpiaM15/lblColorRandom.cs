using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWScorpiaM15
{
    public partial class lblColorRandom : UserControl
    {
        FormInicioFinal cForm;
        public Random rnd = new Random();
        public lblColorRandom()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Passant-li el formulari en el que esta per paràmetre el referenciarà
        /// per poder amagar despres.
        /// </summary>
        /// <param name="oldForm">Formulari en el que esta el UserControl</param>
        public void currForm(FormInicioFinal oldForm)
        {
            cForm = oldForm;
        }
        /// <summary>
        /// Amagar el formulari al fer clic.
        /// </summary>
        private void hidCurrForm()
        {
            cForm.Hide();
        }
        /// <summary>
        /// ????????
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblColorRandom_MouseHover(object sender, EventArgs e)
        {
            lblPlay.ForeColor = Color.Pink;
        }

        /// <summary>
        /// si el ratoli esta sobre el label, el timer s'iniciara.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlay_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /// <summary>
        /// Per cada tic del timer el color de les lletres del label cambiaran de color,
        /// amb un random.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblPlay.ForeColor = randomColor;
        }

        /// <summary>
        /// Si el ratoli es treu de sobre del label el timer s'atura.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlay_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /// <summary>
        /// Al clicar sobre el label s'obrira el formulari del joc al mig de la pantalla,
        /// Amagar el formulari actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlay_Click(object sender, EventArgs e)
        {
            FormGameplay frmGame = new FormGameplay();
            frmGame.StartPosition = FormStartPosition.CenterScreen;

            frmGame.Show();
            hidCurrForm();

        }
    }
}
