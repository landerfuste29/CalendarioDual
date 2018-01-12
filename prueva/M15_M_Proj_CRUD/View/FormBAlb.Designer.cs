namespace View
{
    partial class FormBAlb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBAlb));
            this.dgv_Album = new System.Windows.Forms.DataGridView();
            this.dgv_Artist = new System.Windows.Forms.DataGridView();
            this.dgv_Track = new System.Windows.Forms.DataGridView();
            this.tbx_Buscar = new System.Windows.Forms.TextBox();
            this.lab_Busc = new System.Windows.Forms.Label();
            this.rb_Artist = new System.Windows.Forms.RadioButton();
            this.rb_Album = new System.Windows.Forms.RadioButton();
            this.rb_Track = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Cleat = new System.Windows.Forms.Button();
            this.btn_AddDB = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_FiltTrac = new System.Windows.Forms.ComboBox();
            this.btn_Dell = new System.Windows.Forms.Button();
            this.cmb_GenMedi = new System.Windows.Forms.ComboBox();
            this.nUpD_consulta = new System.Windows.Forms.NumericUpDown();
            this.cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.lab_idioma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Track)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpD_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Album
            // 
            this.dgv_Album.AllowUserToAddRows = false;
            this.dgv_Album.AllowUserToDeleteRows = false;
            this.dgv_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Album.Location = new System.Drawing.Point(279, 149);
            this.dgv_Album.Name = "dgv_Album";
            this.dgv_Album.ReadOnly = true;
            this.dgv_Album.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Album.Size = new System.Drawing.Size(260, 348);
            this.dgv_Album.TabIndex = 0;
            // 
            // dgv_Artist
            // 
            this.dgv_Artist.AllowUserToAddRows = false;
            this.dgv_Artist.AllowUserToDeleteRows = false;
            this.dgv_Artist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Artist.Location = new System.Drawing.Point(12, 149);
            this.dgv_Artist.Name = "dgv_Artist";
            this.dgv_Artist.ReadOnly = true;
            this.dgv_Artist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Artist.Size = new System.Drawing.Size(261, 348);
            this.dgv_Artist.TabIndex = 1;
            // 
            // dgv_Track
            // 
            this.dgv_Track.AllowUserToAddRows = false;
            this.dgv_Track.AllowUserToDeleteRows = false;
            this.dgv_Track.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Track.Location = new System.Drawing.Point(545, 149);
            this.dgv_Track.Name = "dgv_Track";
            this.dgv_Track.ReadOnly = true;
            this.dgv_Track.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Track.Size = new System.Drawing.Size(536, 348);
            this.dgv_Track.TabIndex = 2;
            // 
            // tbx_Buscar
            // 
            this.tbx_Buscar.Location = new System.Drawing.Point(201, 30);
            this.tbx_Buscar.Name = "tbx_Buscar";
            this.tbx_Buscar.Size = new System.Drawing.Size(257, 20);
            this.tbx_Buscar.TabIndex = 3;
            // 
            // lab_Busc
            // 
            this.lab_Busc.AutoSize = true;
            this.lab_Busc.Location = new System.Drawing.Point(152, 32);
            this.lab_Busc.Name = "lab_Busc";
            this.lab_Busc.Size = new System.Drawing.Size(43, 13);
            this.lab_Busc.TabIndex = 4;
            this.lab_Busc.Text = "Buscar:";
            this.lab_Busc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rb_Artist
            // 
            this.rb_Artist.AutoSize = true;
            this.rb_Artist.Location = new System.Drawing.Point(27, 18);
            this.rb_Artist.Name = "rb_Artist";
            this.rb_Artist.Size = new System.Drawing.Size(48, 17);
            this.rb_Artist.TabIndex = 5;
            this.rb_Artist.TabStop = true;
            this.rb_Artist.Text = "Artist";
            this.rb_Artist.UseVisualStyleBackColor = true;
            // 
            // rb_Album
            // 
            this.rb_Album.AutoSize = true;
            this.rb_Album.Location = new System.Drawing.Point(26, 41);
            this.rb_Album.Name = "rb_Album";
            this.rb_Album.Size = new System.Drawing.Size(59, 17);
            this.rb_Album.TabIndex = 6;
            this.rb_Album.TabStop = true;
            this.rb_Album.Text = "Albums";
            this.rb_Album.UseVisualStyleBackColor = true;
            // 
            // rb_Track
            // 
            this.rb_Track.AutoSize = true;
            this.rb_Track.Location = new System.Drawing.Point(27, 64);
            this.rb_Track.Name = "rb_Track";
            this.rb_Track.Size = new System.Drawing.Size(58, 17);
            this.rb_Track.TabIndex = 7;
            this.rb_Track.TabStop = true;
            this.rb_Track.Text = "Tracks";
            this.rb_Track.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_Album);
            this.groupBox1.Controls.Add(this.rb_Track);
            this.groupBox1.Controls.Add(this.rb_Artist);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(464, 28);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Cleat
            // 
            this.btn_Cleat.Location = new System.Drawing.Point(545, 28);
            this.btn_Cleat.Name = "btn_Cleat";
            this.btn_Cleat.Size = new System.Drawing.Size(75, 23);
            this.btn_Cleat.TabIndex = 10;
            this.btn_Cleat.Text = "Cleat";
            this.btn_Cleat.UseVisualStyleBackColor = true;
            // 
            // btn_AddDB
            // 
            this.btn_AddDB.Location = new System.Drawing.Point(384, 82);
            this.btn_AddDB.Name = "btn_AddDB";
            this.btn_AddDB.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDB.TabIndex = 11;
            this.btn_AddDB.Text = "Add";
            this.btn_AddDB.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(500, 82);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // cmb_FiltTrac
            // 
            this.cmb_FiltTrac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltTrac.FormattingEnabled = true;
            this.cmb_FiltTrac.Items.AddRange(new object[] {
            "Nom",
            "Compositor",
            "Bytes",
            "Mil·liseconds",
            "Preu unitari",
            "Genere",
            "MediaType"});
            this.cmb_FiltTrac.Location = new System.Drawing.Point(152, 82);
            this.cmb_FiltTrac.Name = "cmb_FiltTrac";
            this.cmb_FiltTrac.Size = new System.Drawing.Size(121, 21);
            this.cmb_FiltTrac.TabIndex = 13;
            this.cmb_FiltTrac.Visible = false;
            // 
            // btn_Dell
            // 
            this.btn_Dell.Location = new System.Drawing.Point(608, 82);
            this.btn_Dell.Name = "btn_Dell";
            this.btn_Dell.Size = new System.Drawing.Size(75, 23);
            this.btn_Dell.TabIndex = 14;
            this.btn_Dell.Text = "Dell";
            this.btn_Dell.UseVisualStyleBackColor = true;
            // 
            // cmb_GenMedi
            // 
            this.cmb_GenMedi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GenMedi.FormattingEnabled = true;
            this.cmb_GenMedi.Location = new System.Drawing.Point(152, 109);
            this.cmb_GenMedi.Name = "cmb_GenMedi";
            this.cmb_GenMedi.Size = new System.Drawing.Size(121, 21);
            this.cmb_GenMedi.TabIndex = 15;
            this.cmb_GenMedi.Visible = false;
            // 
            // nUpD_consulta
            // 
            this.nUpD_consulta.Location = new System.Drawing.Point(279, 83);
            this.nUpD_consulta.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nUpD_consulta.Name = "nUpD_consulta";
            this.nUpD_consulta.Size = new System.Drawing.Size(78, 20);
            this.nUpD_consulta.TabIndex = 16;
            this.nUpD_consulta.Visible = false;
            // 
            // cmb_Idioma
            // 
            this.cmb_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Idioma.FormattingEnabled = true;
            this.cmb_Idioma.Items.AddRange(new object[] {
            "Español",
            "Catalan",
            "Ingles"});
            this.cmb_Idioma.Location = new System.Drawing.Point(821, 30);
            this.cmb_Idioma.Name = "cmb_Idioma";
            this.cmb_Idioma.Size = new System.Drawing.Size(86, 21);
            this.cmb_Idioma.TabIndex = 17;
            // 
            // lab_idioma
            // 
            this.lab_idioma.AutoSize = true;
            this.lab_idioma.Location = new System.Drawing.Point(760, 33);
            this.lab_idioma.Name = "lab_idioma";
            this.lab_idioma.Size = new System.Drawing.Size(55, 13);
            this.lab_idioma.TabIndex = 18;
            this.lab_idioma.Text = "Language";
            // 
            // FormBAlb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 509);
            this.Controls.Add(this.lab_idioma);
            this.Controls.Add(this.cmb_Idioma);
            this.Controls.Add(this.nUpD_consulta);
            this.Controls.Add(this.cmb_GenMedi);
            this.Controls.Add(this.btn_Dell);
            this.Controls.Add(this.cmb_FiltTrac);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_AddDB);
            this.Controls.Add(this.btn_Cleat);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_Buscar);
            this.Controls.Add(this.dgv_Track);
            this.Controls.Add(this.dgv_Artist);
            this.Controls.Add(this.dgv_Album);
            this.Controls.Add(this.lab_Busc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBAlb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBAlb";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Track)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpD_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Album;
        public System.Windows.Forms.DataGridView dgv_Artist;
        public System.Windows.Forms.DataGridView dgv_Track;
        public System.Windows.Forms.TextBox tbx_Buscar;
        public System.Windows.Forms.RadioButton rb_Artist;
        public System.Windows.Forms.RadioButton rb_Album;
        public System.Windows.Forms.RadioButton rb_Track;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_Buscar;
        public System.Windows.Forms.Button btn_Cleat;
        public System.Windows.Forms.Button btn_AddDB;
        public System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.ComboBox cmb_FiltTrac;
        public System.Windows.Forms.Button btn_Dell;
        public System.Windows.Forms.ComboBox cmb_GenMedi;
        public System.Windows.Forms.NumericUpDown nUpD_consulta;
        public System.Windows.Forms.ComboBox cmb_Idioma;
        public System.Windows.Forms.Label lab_idioma;
        public System.Windows.Forms.Label lab_Busc;
    }
}