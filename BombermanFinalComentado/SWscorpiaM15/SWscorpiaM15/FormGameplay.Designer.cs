namespace SWScorpiaM15
{
    partial class FormGameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameplay));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbPJ = new System.Windows.Forms.PictureBox();
            this.timerExplosion = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.timerBombRandom = new System.Windows.Forms.Timer(this.components);
            this.pbLive1 = new System.Windows.Forms.PictureBox();
            this.pbLive2 = new System.Windows.Forms.PictureBox();
            this.pbLive3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SWScorpiaM15.Properties.Resources.door0;
            this.pictureBox1.Location = new System.Drawing.Point(281, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ptbPJ
            // 
            this.ptbPJ.BackColor = System.Drawing.Color.Transparent;
            this.ptbPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPJ.Image = global::SWScorpiaM15.Properties.Resources.Bomber_MV_F_0;
            this.ptbPJ.Location = new System.Drawing.Point(338, 183);
            this.ptbPJ.Name = "ptbPJ";
            this.ptbPJ.Size = new System.Drawing.Size(23, 33);
            this.ptbPJ.TabIndex = 3;
            this.ptbPJ.TabStop = false;
            // 
            // timerExplosion
            // 
            this.timerExplosion.Tick += new System.EventHandler(this.timerExplosion_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SWScorpiaM15.Properties.Resources.bomb;
            this.pictureBox2.Location = new System.Drawing.Point(581, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.BackColor = System.Drawing.Color.Transparent;
            this.lblcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.Location = new System.Drawing.Point(656, -4);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(57, 63);
            this.lblcont.TabIndex = 6;
            this.lblcont.Text = "0";
            // 
            // timerBombRandom
            // 
            this.timerBombRandom.Tick += new System.EventHandler(this.timerBombRandom_Tick);
            // 
            // pbLive1
            // 
            this.pbLive1.BackColor = System.Drawing.Color.Transparent;
            this.pbLive1.Image = global::SWScorpiaM15.Properties.Resources.siLive;
            this.pbLive1.Location = new System.Drawing.Point(6, 304);
            this.pbLive1.Name = "pbLive1";
            this.pbLive1.Size = new System.Drawing.Size(28, 25);
            this.pbLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive1.TabIndex = 8;
            this.pbLive1.TabStop = false;
            // 
            // pbLive2
            // 
            this.pbLive2.BackColor = System.Drawing.Color.Transparent;
            this.pbLive2.Image = global::SWScorpiaM15.Properties.Resources.siLive;
            this.pbLive2.Location = new System.Drawing.Point(40, 304);
            this.pbLive2.Name = "pbLive2";
            this.pbLive2.Size = new System.Drawing.Size(28, 25);
            this.pbLive2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive2.TabIndex = 9;
            this.pbLive2.TabStop = false;
            // 
            // pbLive3
            // 
            this.pbLive3.BackColor = System.Drawing.Color.Transparent;
            this.pbLive3.Image = global::SWScorpiaM15.Properties.Resources.siLive;
            this.pbLive3.Location = new System.Drawing.Point(74, 304);
            this.pbLive3.Name = "pbLive3";
            this.pbLive3.Size = new System.Drawing.Size(28, 25);
            this.pbLive3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLive3.TabIndex = 10;
            this.pbLive3.TabStop = false;
            // 
            // FormGameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(164)))));
            this.BackgroundImage = global::SWScorpiaM15.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 332);
            this.Controls.Add(this.ptbPJ);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblcont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLive3);
            this.Controls.Add(this.pbLive2);
            this.Controls.Add(this.pbLive1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGameplay";
            this.Text = "FormGameplay";
            this.Load += new System.EventHandler(this.FormGameplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameplay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGameplay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbPJ;
        private System.Windows.Forms.Timer timerExplosion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.Timer timerBombRandom;
        private System.Windows.Forms.PictureBox pbLive1;
        private System.Windows.Forms.PictureBox pbLive2;
        private System.Windows.Forms.PictureBox pbLive3;
    }
}