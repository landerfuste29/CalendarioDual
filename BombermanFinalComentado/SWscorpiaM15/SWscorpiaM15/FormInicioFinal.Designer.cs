namespace SWScorpiaM15
{
    partial class FormInicioFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioFinal));
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblColorRandom1 = new SWScorpiaM15.lblColorRandom();
            this.labTutorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(214)))));
            this.lblScore.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(163, 246);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(178, 25);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "S H O W   S C O R E S  !";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(214)))));
            this.pictureBox3.Image = global::SWScorpiaM15.Properties.Resources.infoPortada;
            this.pictureBox3.Location = new System.Drawing.Point(161, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(368, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SWScorpiaM15.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblColorRandom1
            // 
            this.lblColorRandom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(214)))));
            this.lblColorRandom1.Location = new System.Drawing.Point(161, 208);
            this.lblColorRandom1.Name = "lblColorRandom1";
            this.lblColorRandom1.Size = new System.Drawing.Size(151, 30);
            this.lblColorRandom1.TabIndex = 5;
            this.lblColorRandom1.Load += new System.EventHandler(this.lblColorRandom1_Load);
            this.lblColorRandom1.Click += new System.EventHandler(this.lblColorRandom1_Click);
            // 
            // labTutorial
            // 
            this.labTutorial.AutoSize = true;
            this.labTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(214)))));
            this.labTutorial.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.labTutorial.Location = new System.Drawing.Point(163, 280);
            this.labTutorial.Name = "labTutorial";
            this.labTutorial.Size = new System.Drawing.Size(115, 25);
            this.labTutorial.TabIndex = 6;
            this.labTutorial.Text = "T U T O R I A L";
            this.labTutorial.Click += new System.EventHandler(this.labTutorial_Click);
            // 
            // FormInicioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 358);
            this.Controls.Add(this.labTutorial);
            this.Controls.Add(this.lblColorRandom1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicioFinal";
            this.Text = "FormInicioFinal";
            this.Load += new System.EventHandler(this.FormInicioFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private lblColorRandom lblColorRandom1;
        private System.Windows.Forms.Label labTutorial;
    }
}