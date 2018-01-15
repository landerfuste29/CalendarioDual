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
    public partial class FormGameplay : Form
    {
        int contBomb = 0;
        int contPuntuacio = 0;
        Random rand = new Random();
        char posicion = 's';
        int sec_mo = 0;
        int sec_bom = 0;
        int sec_bomRandomExplo = 0;
        int sec_bomRandom = 0;
        int lives = 3;
        PictureBox imgBomb;
        PictureBox imgBombNice;
        int timeSpeedBom=70;

        Boolean doorOpen = false;
        Boolean bomE = false;
        Boolean getBom = true;
        Boolean mov = true;
        Boolean isLive = true;

        public FormGameplay()
        {

            InitializeComponent();

        }


        public FormGameplay(FormInicioFinal oldForm)
        {
            //timerExplosion.Start();
            InitializeComponent();
              //oldForm.Hide();

        }

        /// <summary>
        /// Metode que controla las teclas que pulsas per donar ordres als timers  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGameplay_KeyDown(object sender, KeyEventArgs e)
        {
            DoubleBuffered = true;
            if (mov) { 
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                timer1.Start();
                posicion = 'd';
                this.ptbPJ.Location = new Point(ptbPJ.Location.X + 2, ptbPJ.Location.Y);
            }

            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                timer1.Start();
                posicion = 's';
                this.ptbPJ.Location = new Point(ptbPJ.Location.X, ptbPJ.Location.Y + 2);
            }

            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                timer1.Start();
                posicion = 'a';
                this.ptbPJ.Location = new Point(ptbPJ.Location.X - 2, ptbPJ.Location.Y);
            }

            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                timer1.Start();
                posicion = 'w';
                this.ptbPJ.Location = new Point(ptbPJ.Location.X, ptbPJ.Location.Y - 2);
            }
            else if (e.KeyCode == Keys.E && !bomE)
            {
                
                    if (contBomb > 0) {
                        bomE = true;
                        crearBomb(posicion);
                        contBomb--;
                        lblcont.Text = contBomb.ToString();
                    }
               
            }
            }
        }

        /// <summary>
        /// Metode que controla els moviments de el picture box ptbPJ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerExplosion.Start();
            
            if (ptbPJ.Bounds.IntersectsWith(imgBomb.Bounds) && getBom)
            {
                getBom = false;
                imgBomb.Visible = false;
                contBomb++;
                contPuntuacio =contPuntuacio + 100;
                crearBombRnd();
                lblcont.Text = contBomb.ToString();
                sec_bomRandom = 0;
                sec_bomRandomExplo = 0;

            }
            else if (contBomb == 1 && !doorOpen)
            {
                mov = false;

                if (sec_mo <= 0)
                {
                    this.pictureBox1.Image = Properties.Resources.door0;
                    sec_mo++;
                }
                else if (sec_mo <= 2)
                {
                    this.pictureBox1.Image = Properties.Resources.door1;
                    sec_mo++;
                }
                else if (sec_mo <= 6)
                {
                    this.pictureBox1.Image = Properties.Resources.door2;
                    sec_mo++;

                }
                else if (sec_mo <= 10)
                {
                    this.pictureBox1.Image = Properties.Resources.door3;
                    sec_mo++;

                }
                else
                {
                    sec_mo = 0;
                    doorOpen = true;
                    this.pictureBox1.Image = Properties.Resources.door3;
                    mov = true;

                }
            }
            else if (ptbPJ.Bounds.IntersectsWith(pictureBox1.Bounds) && doorOpen)
            {
                FormGameplay2 frmGame2 = new FormGameplay2(contPuntuacio);
                frmGame2.StartPosition = FormStartPosition.CenterScreen;
                frmGame2.Show();
                timer1.Stop();
                timerExplosion.Stop();
                timerBombRandom.Stop();
                this.Hide();

            }
            else if (posicion == 's')
            {
                if (sec_mo <= 0)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_1;
                    sec_mo++;
                }
                else if (sec_mo <= 1)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_2;
                    sec_mo++;
                }
                else if (sec_mo <= 2)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_3;
                    sec_mo++;
                }
                else if (sec_mo <= 3)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_4;
                    sec_mo++;
                }
                else
                {
                    sec_mo = 0;
                    timer1.Stop();
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_0;
                }
            }
            else if (posicion == 'd')
            {
                if (sec_mo <= 0)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_L_1;
                    sec_mo++;
                }
                else if (sec_mo <= 1)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_L_2;
                    sec_mo++;
                }
                else if (sec_mo <= 2)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_L_3;
                    sec_mo++;
                }
                else if (sec_mo <= 3)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_L_4;
                    sec_mo++;
                }
                else
                {
                    sec_mo = 0;
                    timer1.Stop();
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_L_0;
                }
            }
            else if (posicion == 'w')
            {
                if (sec_mo <= 0)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_U_1;
                    sec_mo++;
                }
                else if (sec_mo <= 1)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_U_2;
                    sec_mo++;
                }
                else if (sec_mo <= 2)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_U_3;
                    sec_mo++;
                }
                else if (sec_mo <= 3)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_U_4;
                    sec_mo++;
                }
                else
                {
                    sec_mo = 0;
                    timer1.Stop();
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_U_0;
                }
            }
            else if (posicion == 'a')
            {
                if (sec_mo <= 0)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_R_1;
                    sec_mo++;
                }
                else if (sec_mo <= 1)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_R_2;
                    sec_mo++;
                }
                else if (sec_mo <= 2)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_R_3;
                    sec_mo++;
                }
                else if (sec_mo <= 3)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_R_4;
                    sec_mo++;
                }
                else
                {
                    sec_mo = 0;
                    timer1.Stop();
                    this.ptbPJ.Image = Properties.Resources.Bomber_MV_R_0;
                }
            }
        }

        private void FormGameplay_KeyUp(object sender, KeyEventArgs e)
        {

        }

        /// <summary>
        /// Metode que al carregar el formulari en mostrara un misatge i creara la 
        /// primera bomba aleatoria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGameplay_Load(object sender, EventArgs e)
        {

            MessageBox.Show(Properties.Resources.goPlay);
            crearBombRnd();

        }

        /// <summary>
        /// Crea bombas aleatories per tot el formulari.
        /// </summary>
        private void crearBombRnd()
        {
            getBom = true;
            imgBomb = new PictureBox();
            imgBomb.BringToFront();
            var viewRange = this.Size - imgBomb.Size;
            var left = rand.Next(0, viewRange.Width);
            var top = rand.Next(0, viewRange.Height);
            imgBomb.Location = new Point(left, top);
            imgBomb.Size = new System.Drawing.Size(20, 20);
            imgBomb.BackColor = Color.Transparent;
            imgBomb.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBomb.Image = Properties.Resources.explosion0;
            imgBomb.BringToFront();
            Controls.Add(imgBomb);
            imgBomb.Visible = true;
            timerBombRandom.Start();
        }

        /// <summary>
        /// Crea una bomba davant del picture box ptbPJ quan premem la E
        /// </summary>
        /// <param name="posicio"></param>
        private void crearBomb(char posicio)
        {
            imgBombNice = new PictureBox();
            imgBombNice.BringToFront();
            pictureBox2.SendToBack();
            imgBombNice.BringToFront();

            if (posicio=='w')
            {
                imgBombNice.Location = new Point(ptbPJ.Location.X, ptbPJ.Location.Y - 20);
            }else if (posicio == 's')
            {
                imgBombNice.Location = new Point(ptbPJ.Location.X, ptbPJ.Location.Y + 40);
            }
            else if (posicio == 'a')
            {
                imgBombNice.Location = new Point(ptbPJ.Location.X-30, ptbPJ.Location.Y+10);
            }
            else if (posicio == 'd')
            {
                imgBombNice.Location = new Point(ptbPJ.Location.X+30, ptbPJ.Location.Y+10);
            }
            imgBombNice.Size = new System.Drawing.Size(20, 20);
            imgBombNice.BackColor = Color.Transparent;
            imgBombNice.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBombNice.Image = Properties.Resources.explosion0;
            imgBombNice.BringToFront();
            Controls.Add(imgBombNice);
            imgBomb.Visible = true;
        }


        /// <summary>
        /// Fa la animacio de la explosio de la bomba generada am la E
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerExplosion_Tick(object sender, EventArgs e)
        {
            if (bomE) { 
            this.imgBombNice.Visible = true;
            if (sec_bom <= 2)
            {
                this.imgBombNice.Image = Properties.Resources.explosion0;
                sec_bom++;
            }
            else if (sec_bom <= 3)
            {

                this.imgBombNice.Image = Properties.Resources.explosion1;
                sec_bom++;
            }
            else if (sec_bom <= 4)
            {
                this.imgBombNice.Image = Properties.Resources.explosion2;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 5)
            {

                this.imgBombNice.Image = Properties.Resources.explosion3;
                sec_bom++;
            }
            else if (sec_bom <= 6)
            {
                this.imgBombNice.Image = Properties.Resources.explosion4;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 7)
            {
                this.imgBombNice.Image = Properties.Resources.explosion5;
                this.imgBombNice.Visible = false;
                sec_bom++;
            }
            else if (sec_bom <= 8)
            {
                this.imgBombNice.Image = Properties.Resources.explosion6;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 9)
            {
                this.imgBombNice.Image = Properties.Resources.explosion7;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 10)
            {
                this.imgBombNice.Image = Properties.Resources.explosion8;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 11)
            {
                this.imgBombNice.Image = Properties.Resources.explosion9;
                this.imgBombNice.Visible = true;
                sec_bom++;
            }
            else if (sec_bom <= 12)
            {
                this.imgBombNice.Image = Properties.Resources.explosion10;
                this.imgBombNice.Visible = true;
                sec_bom++;
            
            }
            else
            {
                this.imgBombNice.Visible = false;
                sec_bom = 0;
                timerExplosion.Stop();
                bomE = false;

            }

          }
        }


        /// <summary>
        /// Comprova si el ptbPJ esta al costat de una bomba
        /// </summary>
        /// <returns>si esta al costat true</returns>
        private Boolean compBombaLado() {
            if (ptbPJ.Bounds.IntersectsWith(imgBomb.Bounds)) {
                this.ptbPJ.Image = Properties.Resources.Bomber_MV_F_0;

                mov = false;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metode que controla el final del joc
        /// </summary>
        private void Muerto()
        {
            mov = false;
            pbLive1.Image = Properties.Resources.noLive;
            pbLive2.Image = Properties.Resources.noLive;
            pbLive3.Image = Properties.Resources.noLive;
            isLive = false;
            posicion = 'M';
        }


        /// <summary>
        /// Controla les bombes generades aleatoriament i el final del joc
        /// si el ptbPJ mor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBombRandom_Tick(object sender, EventArgs e)
        {
            if (posicion == 'M')
            {
                if (sec_mo <= 6)
                {
                    this.ptbPJ.Image = Properties.Resources.Bomber_dead;
                    sec_mo++;

                }
                else if (sec_mo <= 10)
                {
                    this.BackgroundImage = Properties.Resources.gameOve_2;
                      imgBomb.Visible = false;
                      pictureBox1.Visible = false;
                      ptbPJ.Visible = false;

                    sec_mo++;

                }
                else if (sec_mo <= 25)
                {
                    sec_mo++;

                }
                else
                {
                    FormInicioFinal formInici = new FormInicioFinal();
                    formInici.StartPosition = FormStartPosition.CenterScreen;
                    formInici.Show();
                    timer1.Stop();
                    timerExplosion.Stop();
                    timerBombRandom.Stop();
                    this.Hide();


                }
            }
            if (lives == 2) { pbLive3.Image = Properties.Resources.noLive;
            }
            if (lives == 1) { pbLive2.Image = Properties.Resources.noLive; }
            if (lives == 0 && isLive)
            {
                Muerto();

            }
            if (sec_bomRandom == timeSpeedBom) { 

                if (sec_bomRandomExplo <= 2)
            {
                this.imgBomb.Image = Properties.Resources.explosion0;
                sec_bomRandomExplo++;
            }
            else if (sec_bomRandomExplo <= 3)
            {

                this.imgBomb.Image = Properties.Resources.explosion1;
                sec_bomRandomExplo++;
            }
            else if (sec_bomRandomExplo <= 4)
            {
                this.imgBomb.Image = Properties.Resources.explosion2;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
            }
            else if (sec_bomRandomExplo <= 5)
            {

                this.imgBomb.Image = Properties.Resources.explosion3;
                sec_bomRandomExplo++;
                    getBom = false;
                    if (compBombaLado()&& isLive)
                    {
                        Muerto();
                    }

                }
                else if (sec_bomRandomExplo <= 6)
            {
                this.imgBomb.Image = Properties.Resources.explosion4;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 7)
            {
                this.imgBomb.Image = Properties.Resources.explosion5;
                this.imgBomb.Visible = false;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 8)
            {
                this.imgBomb.Image = Properties.Resources.explosion6;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 9)
            {
                this.imgBomb.Image = Properties.Resources.explosion7;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 10)
            {
                this.imgBomb.Image = Properties.Resources.explosion8;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 11)
            {
                this.imgBomb.Image = Properties.Resources.explosion9;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
            else if (sec_bomRandomExplo <= 12)
            {
                this.imgBomb.Image = Properties.Resources.explosion10;
                this.imgBomb.Visible = true;
                sec_bomRandomExplo++;
                    if (compBombaLado() && isLive)
                    {
                        Muerto();
                    }
                }
                else
            {
                lives--;
                this.imgBomb.Visible = false;
                sec_bomRandomExplo = 0;
                timerBombRandom.Stop();
                crearBombRnd();
                sec_bomRandom = 0;
                timeSpeedBom = timeSpeedBom - 5;
            
                }
            }
            else
            {
                sec_bomRandom++;
            }

        }

    }
}
