namespace View
{
    partial class FormAddAlb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAlb));
            this.cbx_Artis = new System.Windows.Forms.ComboBox();
            this.lab_Artis = new System.Windows.Forms.Label();
            this.lab_NomMasAlbum = new System.Windows.Forms.Label();
            this.tb_AdAlb = new System.Windows.Forms.TextBox();
            this.btn_AddAl = new System.Windows.Forms.Button();
            this.btn_Canc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_Artis
            // 
            this.cbx_Artis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Artis.FormattingEnabled = true;
            this.cbx_Artis.Location = new System.Drawing.Point(31, 50);
            this.cbx_Artis.Name = "cbx_Artis";
            this.cbx_Artis.Size = new System.Drawing.Size(121, 21);
            this.cbx_Artis.TabIndex = 0;
            // 
            // lab_Artis
            // 
            this.lab_Artis.AutoSize = true;
            this.lab_Artis.Location = new System.Drawing.Point(28, 34);
            this.lab_Artis.Name = "lab_Artis";
            this.lab_Artis.Size = new System.Drawing.Size(30, 13);
            this.lab_Artis.TabIndex = 1;
            this.lab_Artis.Text = "Artist";
            // 
            // lab_NomMasAlbum
            // 
            this.lab_NomMasAlbum.AutoSize = true;
            this.lab_NomMasAlbum.Location = new System.Drawing.Point(12, 89);
            this.lab_NomMasAlbum.Name = "lab_NomMasAlbum";
            this.lab_NomMasAlbum.Size = new System.Drawing.Size(61, 13);
            this.lab_NomMasAlbum.TabIndex = 2;
            this.lab_NomMasAlbum.Text = "Nom Album";
            // 
            // tb_AdAlb
            // 
            this.tb_AdAlb.Location = new System.Drawing.Point(95, 86);
            this.tb_AdAlb.Name = "tb_AdAlb";
            this.tb_AdAlb.Size = new System.Drawing.Size(290, 20);
            this.tb_AdAlb.TabIndex = 3;
            // 
            // btn_AddAl
            // 
            this.btn_AddAl.Location = new System.Drawing.Point(52, 161);
            this.btn_AddAl.Name = "btn_AddAl";
            this.btn_AddAl.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAl.TabIndex = 4;
            this.btn_AddAl.Text = "Add";
            this.btn_AddAl.UseVisualStyleBackColor = true;
            // 
            // btn_Canc
            // 
            this.btn_Canc.Location = new System.Drawing.Point(312, 161);
            this.btn_Canc.Name = "btn_Canc";
            this.btn_Canc.Size = new System.Drawing.Size(73, 23);
            this.btn_Canc.TabIndex = 5;
            this.btn_Canc.Text = "Cancelar";
            this.btn_Canc.UseVisualStyleBackColor = true;
            // 
            // FormAddAlb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 234);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Canc);
            this.Controls.Add(this.btn_AddAl);
            this.Controls.Add(this.tb_AdAlb);
            this.Controls.Add(this.lab_NomMasAlbum);
            this.Controls.Add(this.lab_Artis);
            this.Controls.Add(this.cbx_Artis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddAlb";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddAlb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbx_Artis;
        public System.Windows.Forms.TextBox tb_AdAlb;
        public System.Windows.Forms.Button btn_AddAl;
        public System.Windows.Forms.Button btn_Canc;
        public System.Windows.Forms.Label lab_Artis;
        public System.Windows.Forms.Label lab_NomMasAlbum;
    }
}