namespace View
{
    partial class FormADDArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADDArtist));
            this.lab_Nom = new System.Windows.Forms.Label();
            this.tb_AdArt = new System.Windows.Forms.TextBox();
            this.btn_AdArt = new System.Windows.Forms.Button();
            this.btn_Can = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Location = new System.Drawing.Point(12, 52);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(61, 13);
            this.lab_Nom.TabIndex = 0;
            this.lab_Nom.Text = "Nom Artista";
            // 
            // tb_AdArt
            // 
            this.tb_AdArt.Location = new System.Drawing.Point(95, 49);
            this.tb_AdArt.Name = "tb_AdArt";
            this.tb_AdArt.Size = new System.Drawing.Size(191, 20);
            this.tb_AdArt.TabIndex = 1;
            // 
            // btn_AdArt
            // 
            this.btn_AdArt.Location = new System.Drawing.Point(39, 138);
            this.btn_AdArt.Name = "btn_AdArt";
            this.btn_AdArt.Size = new System.Drawing.Size(75, 23);
            this.btn_AdArt.TabIndex = 2;
            this.btn_AdArt.Text = "Add";
            this.btn_AdArt.UseVisualStyleBackColor = true;
            // 
            // btn_Can
            // 
            this.btn_Can.Location = new System.Drawing.Point(211, 138);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(75, 23);
            this.btn_Can.TabIndex = 3;
            this.btn_Can.Text = "Cancelar";
            this.btn_Can.UseVisualStyleBackColor = true;
            // 
            // FormADDArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Can);
            this.Controls.Add(this.btn_AdArt);
            this.Controls.Add(this.tb_AdArt);
            this.Controls.Add(this.lab_Nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADDArtist";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormADDArtist";
            this.Load += new System.EventHandler(this.FormADDArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tb_AdArt;
        public System.Windows.Forms.Button btn_AdArt;
        public System.Windows.Forms.Button btn_Can;
        public System.Windows.Forms.Label lab_Nom;
    }
}