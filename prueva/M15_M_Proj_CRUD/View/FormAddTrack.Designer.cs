namespace View
{
    partial class FormAddTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTrack));
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cbx_MediaType = new System.Windows.Forms.ComboBox();
            this.cbx_Genere = new System.Windows.Forms.ComboBox();
            this.nud_PreuUnit = new System.Windows.Forms.NumericUpDown();
            this.nud_Milisegons = new System.Windows.Forms.NumericUpDown();
            this.nud_Bytes = new System.Windows.Forms.NumericUpDown();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Compositor = new System.Windows.Forms.TextBox();
            this.lab_MeTy = new System.Windows.Forms.Label();
            this.lab_Nom = new System.Windows.Forms.Label();
            this.lab_Gen = new System.Windows.Forms.Label();
            this.lab_Comp = new System.Windows.Forms.Label();
            this.lab_Mili = new System.Windows.Forms.Label();
            this.lab_Byt = new System.Windows.Forms.Label();
            this.lab_UnPri = new System.Windows.Forms.Label();
            this.lab_Art = new System.Windows.Forms.Label();
            this.cbx_Artis = new System.Windows.Forms.ComboBox();
            this.cbx_Album = new System.Windows.Forms.ComboBox();
            this.lab_Alb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PreuUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Milisegons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bytes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(349, 335);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(527, 335);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // cbx_MediaType
            // 
            this.cbx_MediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MediaType.FormattingEnabled = true;
            this.cbx_MediaType.Location = new System.Drawing.Point(39, 268);
            this.cbx_MediaType.Name = "cbx_MediaType";
            this.cbx_MediaType.Size = new System.Drawing.Size(161, 21);
            this.cbx_MediaType.TabIndex = 2;
            // 
            // cbx_Genere
            // 
            this.cbx_Genere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Genere.FormattingEnabled = true;
            this.cbx_Genere.Location = new System.Drawing.Point(243, 268);
            this.cbx_Genere.Name = "cbx_Genere";
            this.cbx_Genere.Size = new System.Drawing.Size(161, 21);
            this.cbx_Genere.TabIndex = 3;
            // 
            // nud_PreuUnit
            // 
            this.nud_PreuUnit.Location = new System.Drawing.Point(482, 268);
            this.nud_PreuUnit.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_PreuUnit.Name = "nud_PreuUnit";
            this.nud_PreuUnit.Size = new System.Drawing.Size(120, 20);
            this.nud_PreuUnit.TabIndex = 4;
            // 
            // nud_Milisegons
            // 
            this.nud_Milisegons.Location = new System.Drawing.Point(316, 170);
            this.nud_Milisegons.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_Milisegons.Name = "nud_Milisegons";
            this.nud_Milisegons.Size = new System.Drawing.Size(120, 20);
            this.nud_Milisegons.TabIndex = 5;
            // 
            // nud_Bytes
            // 
            this.nud_Bytes.Location = new System.Drawing.Point(482, 170);
            this.nud_Bytes.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_Bytes.Name = "nud_Bytes";
            this.nud_Bytes.Size = new System.Drawing.Size(120, 20);
            this.nud_Bytes.TabIndex = 6;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(39, 42);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(309, 20);
            this.txb_Name.TabIndex = 7;
            // 
            // txb_Compositor
            // 
            this.txb_Compositor.Location = new System.Drawing.Point(39, 170);
            this.txb_Compositor.Name = "txb_Compositor";
            this.txb_Compositor.Size = new System.Drawing.Size(194, 20);
            this.txb_Compositor.TabIndex = 8;
            // 
            // lab_MeTy
            // 
            this.lab_MeTy.AutoSize = true;
            this.lab_MeTy.Location = new System.Drawing.Point(36, 250);
            this.lab_MeTy.Name = "lab_MeTy";
            this.lab_MeTy.Size = new System.Drawing.Size(60, 13);
            this.lab_MeTy.TabIndex = 9;
            this.lab_MeTy.Text = "MediaType";
            // 
            // lab_Nom
            // 
            this.lab_Nom.AutoSize = true;
            this.lab_Nom.Location = new System.Drawing.Point(36, 24);
            this.lab_Nom.Name = "lab_Nom";
            this.lab_Nom.Size = new System.Drawing.Size(35, 13);
            this.lab_Nom.TabIndex = 10;
            this.lab_Nom.Text = "Name";
            // 
            // lab_Gen
            // 
            this.lab_Gen.AutoSize = true;
            this.lab_Gen.Location = new System.Drawing.Point(240, 250);
            this.lab_Gen.Name = "lab_Gen";
            this.lab_Gen.Size = new System.Drawing.Size(42, 13);
            this.lab_Gen.TabIndex = 11;
            this.lab_Gen.Text = "Genere";
            // 
            // lab_Comp
            // 
            this.lab_Comp.AutoSize = true;
            this.lab_Comp.Location = new System.Drawing.Point(36, 152);
            this.lab_Comp.Name = "lab_Comp";
            this.lab_Comp.Size = new System.Drawing.Size(59, 13);
            this.lab_Comp.TabIndex = 12;
            this.lab_Comp.Text = "Compositor";
            // 
            // lab_Mili
            // 
            this.lab_Mili.AutoSize = true;
            this.lab_Mili.Location = new System.Drawing.Point(313, 152);
            this.lab_Mili.Name = "lab_Mili";
            this.lab_Mili.Size = new System.Drawing.Size(61, 13);
            this.lab_Mili.TabIndex = 13;
            this.lab_Mili.Text = "Mil·lisegons";
            // 
            // lab_Byt
            // 
            this.lab_Byt.AutoSize = true;
            this.lab_Byt.Location = new System.Drawing.Point(479, 152);
            this.lab_Byt.Name = "lab_Byt";
            this.lab_Byt.Size = new System.Drawing.Size(33, 13);
            this.lab_Byt.TabIndex = 14;
            this.lab_Byt.Text = "Bytes";
            // 
            // lab_UnPri
            // 
            this.lab_UnPri.AutoSize = true;
            this.lab_UnPri.Location = new System.Drawing.Point(479, 250);
            this.lab_UnPri.Name = "lab_UnPri";
            this.lab_UnPri.Size = new System.Drawing.Size(60, 13);
            this.lab_UnPri.TabIndex = 15;
            this.lab_UnPri.Text = "Preu Unitat";
            // 
            // lab_Art
            // 
            this.lab_Art.AutoSize = true;
            this.lab_Art.Location = new System.Drawing.Point(411, 24);
            this.lab_Art.Name = "lab_Art";
            this.lab_Art.Size = new System.Drawing.Size(30, 13);
            this.lab_Art.TabIndex = 17;
            this.lab_Art.Text = "Artist";
            // 
            // cbx_Artis
            // 
            this.cbx_Artis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Artis.FormattingEnabled = true;
            this.cbx_Artis.Location = new System.Drawing.Point(414, 42);
            this.cbx_Artis.Name = "cbx_Artis";
            this.cbx_Artis.Size = new System.Drawing.Size(121, 21);
            this.cbx_Artis.TabIndex = 16;
            // 
            // cbx_Album
            // 
            this.cbx_Album.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Album.FormattingEnabled = true;
            this.cbx_Album.Location = new System.Drawing.Point(39, 101);
            this.cbx_Album.Name = "cbx_Album";
            this.cbx_Album.Size = new System.Drawing.Size(309, 21);
            this.cbx_Album.TabIndex = 18;
            // 
            // lab_Alb
            // 
            this.lab_Alb.AutoSize = true;
            this.lab_Alb.Location = new System.Drawing.Point(36, 83);
            this.lab_Alb.Name = "lab_Alb";
            this.lab_Alb.Size = new System.Drawing.Size(36, 13);
            this.lab_Alb.TabIndex = 19;
            this.lab_Alb.Text = "Album";
            // 
            // FormAddTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 399);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Alb);
            this.Controls.Add(this.cbx_Album);
            this.Controls.Add(this.lab_Art);
            this.Controls.Add(this.cbx_Artis);
            this.Controls.Add(this.lab_UnPri);
            this.Controls.Add(this.lab_Byt);
            this.Controls.Add(this.lab_Mili);
            this.Controls.Add(this.lab_Comp);
            this.Controls.Add(this.lab_Gen);
            this.Controls.Add(this.lab_Nom);
            this.Controls.Add(this.lab_MeTy);
            this.Controls.Add(this.txb_Compositor);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.nud_Bytes);
            this.Controls.Add(this.nud_Milisegons);
            this.Controls.Add(this.nud_PreuUnit);
            this.Controls.Add(this.cbx_Genere);
            this.Controls.Add(this.cbx_MediaType);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTrack";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddTrack";
            ((System.ComponentModel.ISupportInitialize)(this.nud_PreuUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Milisegons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.TextBox txb_Name;
        public System.Windows.Forms.TextBox txb_Compositor;
        public System.Windows.Forms.ComboBox cbx_MediaType;
        public System.Windows.Forms.ComboBox cbx_Genere;
        public System.Windows.Forms.NumericUpDown nud_PreuUnit;
        public System.Windows.Forms.NumericUpDown nud_Milisegons;
        public System.Windows.Forms.NumericUpDown nud_Bytes;
        public System.Windows.Forms.ComboBox cbx_Artis;
        public System.Windows.Forms.ComboBox cbx_Album;
        public System.Windows.Forms.Label lab_Nom;
        public System.Windows.Forms.Label lab_Art;
        public System.Windows.Forms.Label lab_Alb;
        public System.Windows.Forms.Label lab_Comp;
        public System.Windows.Forms.Label lab_Mili;
        public System.Windows.Forms.Label lab_MeTy;
        public System.Windows.Forms.Label lab_Byt;
        public System.Windows.Forms.Label lab_Gen;
        public System.Windows.Forms.Label lab_UnPri;
    }
}