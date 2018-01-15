namespace SWScorpiaM15
{
    partial class FormGameplay2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameplay2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPuntuacióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tornarAlMenúDIniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPuntuacio = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarPuntuacióToolStripMenuItem,
            this.tornarAlMenúDIniciToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // guardarPuntuacióToolStripMenuItem
            // 
            this.guardarPuntuacióToolStripMenuItem.Name = "guardarPuntuacióToolStripMenuItem";
            this.guardarPuntuacióToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.guardarPuntuacióToolStripMenuItem.Text = "Total scores";
            this.guardarPuntuacióToolStripMenuItem.Click += new System.EventHandler(this.guardarPuntuacióToolStripMenuItem_Click);
            // 
            // tornarAlMenúDIniciToolStripMenuItem
            // 
            this.tornarAlMenúDIniciToolStripMenuItem.Name = "tornarAlMenúDIniciToolStripMenuItem";
            this.tornarAlMenúDIniciToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.tornarAlMenúDIniciToolStripMenuItem.Text = "Tornar al Menú d\'Inici";
            this.tornarAlMenúDIniciToolStripMenuItem.Click += new System.EventHandler(this.tornarAlMenúDIniciToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPuntuacio
            // 
            this.lblPuntuacio.AutoSize = true;
            this.lblPuntuacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacio.Location = new System.Drawing.Point(135, 24);
            this.lblPuntuacio.Name = "lblPuntuacio";
            this.lblPuntuacio.Size = new System.Drawing.Size(99, 25);
            this.lblPuntuacio.TabIndex = 1;
            this.lblPuntuacio.Text = "Puntuacio";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(95, 93);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(111, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Introdueix el teu nom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(212, 90);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(114, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(212, 162);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormGameplay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPuntuacio);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGameplay2";
            this.Text = "FormGameplay2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarPuntuacióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tornarAlMenúDIniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblPuntuacio;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
    }
}