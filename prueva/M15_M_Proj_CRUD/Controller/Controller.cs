using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Model;
using System.Windows.Forms;
namespace Controller
{
    public class Controller
    {
        //Ivan Venteo Martin
        FormAddTrack fAdTrak = new FormAddTrack();
        FormADDArtist fAdArt = new FormADDArtist(); 
        FormAddAlb fAdAlb = new FormAddAlb();
        FormBAlb forAlb = new FormBAlb();
        ChinookEntities  db = new ChinookEntities();
        Artist arToUpd = null;
        Album alToUpd = null;
        Track trkToUpd = null;
        Boolean buscar = false;

        public void init()
        {
            iniListenerArtist();
            populateArtis();
            listenerGen();
            run();
        }

        public void iniListenerArtist()
        {
            forAlb.cmb_Idioma.SelectedIndex = 0;

            forAlb.dgv_Artist.SelectionChanged += artistSelectionChanged;
            forAlb.dgv_Album.SelectionChanged += albumSelectionChanged;

        }
        public void listenerGen()
        {
            forAlb.cmb_Idioma.SelectedIndexChanged += idiomaChange;
            forAlb.btn_Buscar.Click += iniListenerRad;
            forAlb.btn_Buscar.Click += searchRadBut;
            forAlb.btn_Cleat.Click += clearRadBut;
            forAlb.btn_Cleat.Click += searchRadBut;
            forAlb.rb_Track.CheckedChanged += mosComBox;
            forAlb.cmb_FiltTrac.SelectedValueChanged +=loadComBoxGM;
            forAlb.btn_AddDB.Click += listenerBtnAddRadCURD;
            forAlb.btn_Update.Click += listenerBtnUpdateRadCURD;
            forAlb.btn_Dell.Click += listenerBtnDellRadCURD;
        }
        public void iniListenerRad(object sender, EventArgs args)
        {
            forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged;
            forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged2;
            forAlb.dgv_Track.SelectionChanged -= trackSelectionChanged;
            forAlb.dgv_Artist.SelectionChanged -= artistSelectionChanged;

            if (forAlb.rb_Album.Checked)
            {
                forAlb.dgv_Album.SelectionChanged += albumSelectionChanged2;
            }
            else if (forAlb.rb_Track.Checked)
            {
                forAlb.dgv_Album.SelectionChanged += albumSelectionChanged2;
                forAlb.dgv_Track.SelectionChanged += trackSelectionChanged;
            }
            else
            {
                forAlb.dgv_Artist.SelectionChanged += artistSelectionChanged;
                forAlb.dgv_Album.SelectionChanged += albumSelectionChanged;
            }
        }
        public void run()
        {
            forAlb.Load += idiomaChange;
            Application.Run(forAlb);
        }


        //Metodos para el Idioma
        public void idiomaAdd()
        {
            try
            {
                if (forAlb.cmb_Idioma.SelectedItem.Equals("Español")) {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Add_Esp;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Add_Esp;
                    fAdTrak.btn_Add.Text = Properties.Resources.Add_Esp;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Esp;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Esp;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Esp;
                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Catalan")) {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Add_Cat;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Add_Cat;
                    fAdTrak.btn_Add.Text = Properties.Resources.Add_Cat;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Cat;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Cat;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Cat;
                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Ingles")) {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Add_Ing;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Add_Ing;
                    fAdTrak.btn_Add.Text = Properties.Resources.Add_Ing;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Ing;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Ing;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Ing;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        public void idiomaUpd()
        {
            try
            {
                if (forAlb.cmb_Idioma.SelectedItem.Equals("Español"))
                {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Upd_Esp;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Upd_Esp;
                    fAdTrak.btn_Add.Text = Properties.Resources.Upd_Esp;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Esp;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Esp;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Esp;
                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Catalan"))
                {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Upd_Cat;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Upd_Cat;
                    fAdTrak.btn_Add.Text = Properties.Resources.Upd_Cat;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Cat;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Cat;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Cat;

                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Ingles"))
                {
                    fAdArt.btn_AdArt.Text = Properties.Resources.Upd_Ing;
                    fAdAlb.btn_AddAl.Text = Properties.Resources.Upd_Ing;
                    fAdTrak.btn_Add.Text = Properties.Resources.Upd_Ing;

                    fAdArt.btn_Can.Text = Properties.Resources.Cancelar_Ing;
                    fAdAlb.btn_Canc.Text = Properties.Resources.Cancelar_Ing;
                    fAdTrak.btn_Cancelar.Text = Properties.Resources.Cancelar_Ing;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        public void idiomaExtraFormGeneri()
        {
           try
            {
                if (forAlb.cmb_Idioma.SelectedItem.Equals("Español"))
                {
                    fAdArt.lab_Nom.Text = Properties.Resources.Nom_Esp +" "+ Properties.Resources.Art_Esp;

                    fAdAlb.lab_Artis.Text = Properties.Resources.Art_Esp;
                    fAdAlb.lab_NomMasAlbum.Text = Properties.Resources.Nom_Esp + " " + Properties.Resources.Alb_Esp;

                    fAdTrak.lab_Nom.Text = Properties.Resources.Nom_Esp + " " + Properties.Resources.Tra_Esp;
                    fAdTrak.lab_Art.Text = Properties.Resources.Art_Esp;
                    fAdTrak.lab_Alb.Text = Properties.Resources.Alb_Esp;
                    fAdTrak.lab_Comp.Text = Properties.Resources.Comp_Esp;
                    fAdTrak.lab_Mili.Text = Properties.Resources.Mili_Esp;
                    fAdTrak.lab_MeTy.Text = Properties.Resources.MeTy_Esp;
                    fAdTrak.lab_Gen.Text = Properties.Resources.Gen_Esp;
                    fAdTrak.lab_UnPri.Text = Properties.Resources.UnPr_Esp;

                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Catalan"))
                {
                    fAdArt.lab_Nom.Text = Properties.Resources.Nom_Cat + " " + Properties.Resources.Art_Cat;

                    fAdAlb.lab_Artis.Text = Properties.Resources.Art_Cat;
                    fAdAlb.lab_NomMasAlbum.Text = Properties.Resources.Nom_Cat + " " + Properties.Resources.Alb_Cat;

                    fAdTrak.lab_Nom.Text = Properties.Resources.Nom_Cat + " " + Properties.Resources.Tra_Cat;
                    fAdTrak.lab_Art.Text = Properties.Resources.Art_Cat;
                    fAdTrak.lab_Alb.Text = Properties.Resources.Alb_Cat;
                    fAdTrak.lab_Comp.Text = Properties.Resources.Comp_Cat;
                    fAdTrak.lab_Mili.Text = Properties.Resources.Mili_Cat;
                    fAdTrak.lab_MeTy.Text = Properties.Resources.MeTy_Cat;
                    fAdTrak.lab_Gen.Text = Properties.Resources.Gen_Cat;
                    fAdTrak.lab_UnPri.Text = Properties.Resources.UnPr_Cat;

                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Ingles"))
                {
                    //fAdArt.btn_AdArt.Text = Properties.Resources.Upd_Ing;
                    fAdArt.lab_Nom.Text = Properties.Resources.Nom_Ing + " " + Properties.Resources.Art_Ing;

                    fAdAlb.lab_Artis.Text = Properties.Resources.Art_Ing;
                    fAdAlb.lab_NomMasAlbum.Text = Properties.Resources.Nom_Ing + " " + Properties.Resources.Alb_Ing;

                    fAdTrak.lab_Nom.Text = Properties.Resources.Nom_Ing + " " + Properties.Resources.Tra_Ing;
                    fAdTrak.lab_Art.Text = Properties.Resources.Art_Ing;
                    fAdTrak.lab_Alb.Text = Properties.Resources.Alb_Ing;
                    fAdTrak.lab_Comp.Text = Properties.Resources.Comp_Ing;
                    fAdTrak.lab_Mili.Text = Properties.Resources.Mili_Ing;
                    fAdTrak.lab_MeTy.Text = Properties.Resources.MeTy_Ing;
                    fAdTrak.lab_Gen.Text = Properties.Resources.Gen_Ing;
                    fAdTrak.lab_UnPri.Text = Properties.Resources.UnPr_Ing;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        public void idiomaChange(object sender, EventArgs args)
        {
            try
            {
                if (forAlb.cmb_Idioma.SelectedItem.Equals("Español"))
                {
                    forAlb.btn_AddDB.Text = Properties.Resources.Add_Esp;
                    forAlb.btn_Update.Text = Properties.Resources.Upd_Esp;
                    forAlb.btn_Dell.Text = Properties.Resources.Del_Esp;
                    forAlb.lab_idioma.Text = Properties.Resources.Idio_Esp + ":";
                    forAlb.lab_Busc.Text = Properties.Resources.Bus_Esp + ":";
                    forAlb.btn_Buscar.Text = Properties.Resources.Bus_Esp;
                    forAlb.btn_Cleat.Text = Properties.Resources.Clean_Esp;
                    forAlb.rb_Artist.Text = Properties.Resources.Art_Esp;
                    forAlb.rb_Album.Text = Properties.Resources.Alb_Ing;
                    forAlb.rb_Track.Text = Properties.Resources.Tra_Ing;
                    forAlb.rb_Album.Text = Properties.Resources.Alb_Esp;
                    forAlb.rb_Track.Text = Properties.Resources.Tra_Esp;
                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Catalan"))
                {
                    forAlb.btn_AddDB.Text = Properties.Resources.Add_Cat;
                    forAlb.btn_Update.Text = Properties.Resources.Upd_Cat;
                    forAlb.btn_Dell.Text = Properties.Resources.Del_Cat;
                    forAlb.lab_idioma.Text = Properties.Resources.Idio_Cat + ":";
                    forAlb.lab_Busc.Text = Properties.Resources.Bus_Cat + ":";
                    forAlb.btn_Buscar.Text = Properties.Resources.Bus_Cat;
                    forAlb.btn_Cleat.Text = Properties.Resources.Clean_Cat;
                    forAlb.rb_Artist.Text = Properties.Resources.Art_Cat;
                    forAlb.rb_Album.Text = Properties.Resources.Alb_Cat;
                    forAlb.rb_Track.Text = Properties.Resources.Tra_Cat;

                }
                else if (forAlb.cmb_Idioma.SelectedItem.Equals("Ingles"))
                {
                    forAlb.btn_AddDB.Text = Properties.Resources.Add_Ing;
                    forAlb.btn_Update.Text = Properties.Resources.Upd_Ing;
                    forAlb.btn_Dell.Text = Properties.Resources.Del_Ing;
                    forAlb.lab_idioma.Text = Properties.Resources.Idio_Ing + ":";
                    forAlb.lab_Busc.Text = Properties.Resources.Bus_Ing + ":";
                    forAlb.btn_Buscar.Text = Properties.Resources.Bus_Ing;
                    forAlb.btn_Cleat.Text = Properties.Resources.Clean_Ing;
                    forAlb.rb_Artist.Text = Properties.Resources.Art_Ing;
                    forAlb.rb_Album.Text = Properties.Resources.Alb_Ing;
                    forAlb.rb_Track.Text = Properties.Resources.Tra_Ing;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        //Boton Add Up Del
        public void listenerBtnAddRadCURD(object sender, EventArgs args)
        {
            try
            {
                idiomaAdd();
                idiomaExtraFormGeneri();
                if (forAlb.rb_Artist.Checked)
                {
                    fAdArt.Visible = true;
                    fAdArt.btn_AdArt.Click += addArtist;
                    fAdArt.btn_Can.Click += ocultfAdArt;
                }
                else if (forAlb.rb_Album.Checked)
                {
                    Artist_DTO arDTO_ToAddAl = artistGetSelected();
                    fAdAlb.Visible = true;
                    cargaCBArtist(fAdAlb.cbx_Artis);
                    fAdAlb.cbx_Artis.SelectedItem = arDTO_ToAddAl.name;
                    fAdAlb.btn_AddAl.Click += addAlbum;
                    fAdAlb.btn_Canc.Click += ocultfAdAl;
                }
                else if (forAlb.rb_Track.Checked)
                {
                    Track_DTO trkDTO_ToUpd = trackGetSelected();
                    trkToUpd = db.Tracks.Where(x => x.TrackId == trkDTO_ToUpd.TrackId).FirstOrDefault();

                    fAdTrak.cbx_MediaType.Items.Clear();
                    fAdTrak.cbx_Genere.Items.Clear();
                    fAdTrak.Visible = true;
                    cargaCBArtist(fAdTrak.cbx_Artis);
                    fAdTrak.cbx_Artis.SelectedItem = trkToUpd.Album.Artist.Name;
                    cargaCBAlbum2();
                    trkToUpd = null;
                    fAdTrak.cbx_Artis.SelectedIndexChanged += cargaCBAlbum;
                    foreach (Genre gen in db.Genres.ToList())
                    {
                        fAdTrak.cbx_Genere.Items.Add(gen.Name);
                    }
                    foreach (MediaType medTy in db.MediaTypes.ToList())
                    {
                        fAdTrak.cbx_MediaType.Items.Add(medTy.Name);
                    }
                    fAdTrak.btn_Add.Click +=addTrak;
                    fAdTrak.btn_Cancelar.Click +=ocultfAdTrak;


                }
                else { }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void listenerBtnUpdateRadCURD(object sender, EventArgs args)
        {
            try
            {
                idiomaUpd();
                idiomaExtraFormGeneri();
                if (forAlb.rb_Artist.Checked)
                {
                    Artist_DTO arDTO_ToUpd = artistGetSelected();
                    arToUpd = db.Artists.Where(x => x.ArtistId == arDTO_ToUpd.artistId).FirstOrDefault();
                    fAdArt.tb_AdArt.Text = arToUpd.Name;

                    fAdArt.Visible = true;
                    fAdArt.btn_AdArt.Click += updateArtist;
                    fAdArt.btn_Can.Click += ocultfAdArt;
                }
                else if (forAlb.rb_Album.Checked)
                {
                    Album_DTO alDTO_ToUpd = albumGetSelected();
                    alToUpd = db.Albums.Where(x => x.AlbumId == alDTO_ToUpd.AlbumId).FirstOrDefault();

                    fAdAlb.Visible = true;
                    cargaCBArtist(fAdAlb.cbx_Artis);
                    fAdAlb.cbx_Artis.SelectedItem = alToUpd.Artist.Name;
                    fAdAlb.tb_AdAlb.Text = alToUpd.Title;
                    fAdAlb.btn_AddAl.Click += updateAlbum;
                    fAdAlb.btn_Canc.Click += ocultfAdAl;
                }
                else if (forAlb.rb_Track.Checked)
                {
                    Track_DTO trkDTO_ToUpd = trackGetSelected();
                    trkToUpd = db.Tracks.Where(x => x.TrackId == trkDTO_ToUpd.TrackId).FirstOrDefault();

                    fAdTrak.cbx_MediaType.Items.Clear();
                    fAdTrak.cbx_Genere.Items.Clear();

                    fAdTrak.Visible = true;
                    cargaCBArtist(fAdTrak.cbx_Artis);
                    fAdTrak.txb_Name.Text = trkToUpd.Name;
                    fAdTrak.cbx_Artis.SelectedItem = trkToUpd.Album.Artist.Name;
                    cargaCBAlbum2();
                    fAdTrak.cbx_Artis.SelectedIndexChanged += cargaCBAlbum;
                    fAdTrak.txb_Compositor.Text = trkToUpd.Composer;
                    fAdTrak.nud_Milisegons.Value= (int) trkToUpd.Milliseconds;
                    fAdTrak.nud_Bytes.Value = Convert.ToInt32(trkToUpd.Bytes);
                    fAdTrak.nud_PreuUnit.Value = Convert.ToInt32(trkToUpd.UnitPrice);
                    foreach (Genre gen in db.Genres.ToList())
                    {
                        fAdTrak.cbx_Genere.Items.Add(gen.Name);
                    }
                    fAdTrak.cbx_Genere.SelectedItem = trkToUpd.Genre.Name;

                    foreach (MediaType medTy in db.MediaTypes.ToList())
                    {
                        fAdTrak.cbx_MediaType.Items.Add(medTy.Name);
                    }
                    fAdTrak.cbx_MediaType.SelectedItem = trkToUpd.MediaType.Name;

                    fAdTrak.btn_Add.Click += updateTrack;
                    fAdTrak.btn_Cancelar.Click += ocultfAdTrak;


                }
                else { }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void listenerBtnDellRadCURD(object sender, EventArgs args)
        {
            try
            {
                if (forAlb.rb_Artist.Checked)
                {
                    dellArt();
                    populateArtis();
                }
                else if (forAlb.rb_Album.Checked)
                {
                    dellAlb();
                }
                else if (forAlb.rb_Track.Checked)
                {
                    dellTrack();
                }
                else { }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        protected void addArtist(object sender, EventArgs args)
        {
            fAdArt.btn_AdArt.Click -= addArtist;
            Artist c = new Artist();
            c.Name = fAdArt.tb_AdArt.Text;
            db.Artists.Add(c);
            int n = trySaveAr();
            clearRadBut2();
            fAdArt.tb_AdArt.Text = "";
            fAdArt.Hide();
        }
        protected void addAlbum(object sender, EventArgs args)
        {
            fAdAlb.btn_AddAl.Click -= addAlbum;
            Album al = new Album();
            Artist arToAdd = db.Artists.Where(x => x.Name.Equals(fAdAlb.cbx_Artis.Text)).FirstOrDefault();

            al.Title = fAdAlb.tb_AdAlb.Text;
            al.ArtistId = arToAdd.ArtistId;
            db.Albums.Add(al);
            int n = trySaveAl();
            fAdAlb.cbx_Artis.SelectedItem = null;
            fAdAlb.tb_AdAlb.Text = "";
            fAdAlb.Hide();
            clearRadBut2();

        }
        protected void addTrak(object sender, EventArgs args)
        {

            fAdTrak.btn_Add.Click -= addTrak;
            Track tr = new Track();
            tr.Name = fAdTrak.txb_Name.Text;
            tr.Composer = fAdTrak.txb_Compositor.Text;
            tr.Milliseconds = (int)fAdTrak.nud_Milisegons.Value;
            tr.Bytes = (int)fAdTrak.nud_Bytes.Value;
            tr.UnitPrice = (int)fAdTrak.nud_PreuUnit.Value;
            tr.GenreId = (int)fAdTrak.cbx_Genere.SelectedIndex + 1;
            tr.MediaTypeId = (int)fAdTrak.cbx_MediaType.SelectedIndex + 1;
            tr.AlbumId = getAlbId();
            db.Tracks.Add(tr);
            int n = trySaveTra();
            fAdTrak.cbx_Genere.SelectedItem = null;
            fAdTrak.cbx_MediaType.SelectedItem = null;
            fAdTrak.cbx_Artis.SelectedItem = null;
            fAdTrak.txb_Name.Text = "";
            fAdTrak.txb_Compositor.Text = "";
            fAdTrak.nud_Milisegons.Value = 0;
            fAdTrak.nud_Bytes.Value = 0;
            fAdTrak.nud_PreuUnit.Value = 0;
            fAdTrak.Hide();
            clearRadBut2();
        }


        public void dellArt()
         {
            try
            {
                int i = Convert.ToInt32(forAlb.dgv_Artist.SelectedRows[0].Cells["ArtistId"].Value.ToString());
                 Artist art = db.Artists.Where(x => x.ArtistId == i).FirstOrDefault();
                 List<Album> alb = art.Albums.ToList();
                 foreach (Album al in alb)
                 {
                         foreach (Track t in al.Tracks.ToList())
                         {
                            foreach (PlaylistTrack plyT in t.PlaylistTracks.ToList())
                            {
                                db.PlaylistTracks.Remove(plyT);

                            }
                            foreach (InvoiceLine invL in t.InvoiceLines.ToList())
                            {
                                db.InvoiceLines.Remove(invL);
                            }

                             db.Tracks.Remove(t);
                     }

                     db.Albums.Remove(al);
                 }
                 db.Artists.Remove(art);
                 int n = trySaveAr();
                 clearRadBut2();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void dellAlb()
        {
            try
            {
                int i = Convert.ToInt32(forAlb.dgv_Album.SelectedRows[0].Cells["AlbumId"].Value.ToString());
                Album al = db.Albums.Where(x => x.AlbumId == i).FirstOrDefault();
                List<Track> alb = al.Tracks.ToList();
                foreach (Track t in alb)
                {
                    db.Tracks.Remove(t);
                }
                db.Albums.Remove(al);
                int n = trySaveAl();
                clearRadBut2();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void dellTrack()
        {
            try
            {
                int i = Convert.ToInt32(forAlb.dgv_Track.SelectedRows[0].Cells["TrackId"].Value.ToString());
                Track t = db.Tracks.Where(x => x.TrackId == i).FirstOrDefault();
                db.Tracks.Remove(t);
                int n = trySaveTra();
                clearRadBut2();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        protected void updateArtist(object sender, EventArgs args)
        {
            try
            {
                fAdArt.btn_AdArt.Click -= updateArtist;
                arToUpd.Name = fAdArt.tb_AdArt.Text;
                int n = trySaveAr();
                populateArtis();
                fAdArt.tb_AdArt.Text = "";
                fAdArt.Hide();
                clearRadBut2();
                arToUpd = null;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
        protected void updateAlbum(object sender, EventArgs args)
        {
            try
            {
                fAdAlb.btn_AddAl.Click -= updateAlbum;

                alToUpd.Title = fAdAlb.tb_AdAlb.Text;
                int n = trySaveAl();
                fAdAlb.cbx_Artis.SelectedItem = null;
                fAdAlb.tb_AdAlb.Text = "";
                clearRadBut2();
                fAdAlb.Hide();
                alToUpd = null;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
        protected void updateTrack(object sender, EventArgs args)
        {
            try
            {
                fAdTrak.btn_Add.Click -= updateTrack;

                trkToUpd.Name = fAdTrak.txb_Name.Text;
                trkToUpd.Composer = fAdTrak.txb_Compositor.Text;
                trkToUpd.Milliseconds = (int)fAdTrak.nud_Milisegons.Value;
                trkToUpd.Bytes = (int)fAdTrak.nud_Bytes.Value;
                trkToUpd.UnitPrice = (int)fAdTrak.nud_PreuUnit.Value;
                trkToUpd.GenreId = (int)fAdTrak.cbx_Genere.SelectedIndex + 1;
                trkToUpd.MediaTypeId = (int)fAdTrak.cbx_MediaType.SelectedIndex + 1;
                trkToUpd.AlbumId = getAlbId();
                int n = trySaveTra();
                fAdTrak.cbx_Genere.SelectedItem = null;
                fAdTrak.cbx_MediaType.SelectedItem = null;
                fAdTrak.cbx_Artis.SelectedItem = null;
                fAdTrak.txb_Name.Text = "";
                fAdTrak.txb_Compositor.Text = "";
                fAdTrak.nud_Milisegons.Value = 0;
                fAdTrak.nud_Bytes.Value = 0;
                fAdTrak.nud_PreuUnit.Value = 0;
                clearRadBut2();
                fAdTrak.Hide();
                trkToUpd = null;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }

        protected void ocultfAdArt(object sender, EventArgs args)
        {
            fAdArt.tb_AdArt.Text = "";
            arToUpd = null;
            fAdArt.Hide();
        }
        protected void ocultfAdAl(object sender, EventArgs args)
        {
            fAdAlb.cbx_Artis.SelectedItem = null;
            fAdAlb.tb_AdAlb.Text = "";
            alToUpd = null;
            fAdAlb.Hide();
        }
        protected void ocultfAdTrak(object sender, EventArgs args)
        {

            try
            {
                fAdTrak.cbx_Genere.SelectedItem = null;
                fAdTrak.cbx_MediaType.SelectedItem = null;
                fAdTrak.cbx_Artis.SelectedItem = null;
                fAdTrak.txb_Name.Text = "";
                fAdTrak.txb_Compositor.Text = "";
                fAdTrak.nud_Milisegons.Value = 0;
                fAdTrak.nud_Bytes.Value = 0;
                fAdTrak.nud_PreuUnit.Value = 0;
                trkToUpd = null;
                fAdTrak.Hide();

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }
        protected int getAlbId()
        {
            try
            {
                int alId = 0;

                var pr1AlbID = db.Albums.Where(x => x.Title.Equals(fAdTrak.cbx_Album.Text)).ToList().Select(x => x.AlbumId).ToList();
                foreach (int asdf in pr1AlbID)
                {
                    alId = asdf;
                }

                return alId;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }

        protected int trySaveTra()
        {
            try
            {
                db.SaveChanges();
                return (forAlb.dgv_Track.SelectedRows[0].Index);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }
        protected int trySaveAl()
        {
            try
            {
                db.SaveChanges();
                return (forAlb.dgv_Album.SelectedRows[0].Index);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }
        protected int trySaveAr()
        {
            try
            {
                db.SaveChanges();
                return (forAlb.dgv_Artist.SelectedRows[0].Index);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }

        //Buscar
        public void cargaCBArtist(ComboBox fCarCBArtist)
        {
            try
            {
                fCarCBArtist.Items.Clear();
                List<Artist_DTO> pr1 = db.Artists.ToList().Select(c => new Artist_DTO(c)).ToList();
                foreach (Artist_DTO pr in pr1)
                {
                    fCarCBArtist.Items.Add(pr.name);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void cargaCBAlbum(object sender, EventArgs args)
        {
            try
            {
                fAdTrak.cbx_Album.SelectedItem = null;
                fAdTrak.cbx_Album.Items.Clear();
              if(fAdTrak.cbx_Artis.SelectedItem != null) { 
                var arToMos = db.Artists.Where(x => x.Name.Equals(fAdTrak.cbx_Artis.SelectedItem.ToString())).ToList().Select(x => x.ArtistId).ToList();
                foreach (var arId in arToMos) {
                    List<Album_DTO> pr1 = db.Albums.Where(x => x.ArtistId.Equals(arId)).ToList().Select(x => new Album_DTO(x)).ToList();
                    foreach (Album_DTO pr in pr1)
                    {
                        fAdTrak.cbx_Album.Items.Add(pr.Title);
                    }
                }
              }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void cargaCBAlbum2()
        {
            try
            {
                fAdTrak.cbx_Album.SelectedItem = null;
                fAdTrak.cbx_Album.Items.Clear();
                if (fAdTrak.cbx_Artis.SelectedItem != null)
                {
                    var arToMos = db.Artists.Where(x => x.Name.Equals(fAdTrak.cbx_Artis.SelectedItem.ToString())).ToList().Select(x => x.ArtistId).ToList();
                    foreach (var arId in arToMos)
                    {
                        List<Album_DTO> pr1 = db.Albums.Where(x => x.ArtistId.Equals(arId)).ToList().Select(x => new Album_DTO(x)).ToList();
                        foreach (Album_DTO pr in pr1)
                        {
                            fAdTrak.cbx_Album.Items.Add(pr.Title);
                        }
                    }
                }
                fAdTrak.cbx_Album.SelectedItem = trkToUpd.Album.Title;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void mosComBox(object sender, EventArgs args)
        {
            if (forAlb.rb_Track.Checked)
            {
                forAlb.cmb_FiltTrac.Visible = true;
            } else {
                forAlb.cmb_FiltTrac.Visible = false;
                forAlb.cmb_FiltTrac.SelectedItem = null;
                forAlb.cmb_GenMedi.Visible = false;
                forAlb.cmb_GenMedi.SelectedItem = null;
                forAlb.tbx_Buscar.Enabled = true;
                forAlb.nUpD_consulta.Visible = false;
            }
        }
        public void loadComBoxGM(object sender, EventArgs args)
        {
            try
            {
                forAlb.cmb_GenMedi.SelectedItem = null;
                forAlb.nUpD_consulta.Value = 0;

                forAlb.cmb_GenMedi.Items.Clear();
                if (forAlb.cmb_FiltTrac.SelectedItem == "Genere")
                {
                        foreach (Genre gen in db.Genres.ToList())
                    {
                        forAlb.cmb_GenMedi.Items.Add(gen.Name);
                    }
                    forAlb.cmb_GenMedi.Visible = true;
                    forAlb.tbx_Buscar.Enabled = false;
                    forAlb.nUpD_consulta.Visible = false;
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == "MediaType") {
                    foreach (MediaType medTy in db.MediaTypes.ToList())
                    {
                        forAlb.cmb_GenMedi.Items.Add(medTy.Name);
                    }
                    forAlb.cmb_GenMedi.Visible = true;
                    forAlb.tbx_Buscar.Enabled = false;
                    forAlb.nUpD_consulta.Visible = false;
                } else if (forAlb.cmb_FiltTrac.SelectedItem == "Bytes" ||
                            forAlb.cmb_FiltTrac.SelectedItem == "Mil·liseconds")
                {
                    forAlb.cmb_GenMedi.Visible = false;
                    forAlb.tbx_Buscar.Enabled = false;
                    forAlb.nUpD_consulta.DecimalPlaces = 0;
                    forAlb.nUpD_consulta.Visible = true;

                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == "Preu unitari")
                {
                    forAlb.cmb_GenMedi.Visible = false;
                    forAlb.tbx_Buscar.Enabled = false;
                    forAlb.nUpD_consulta.DecimalPlaces = 2;
                    forAlb.nUpD_consulta.Visible = true;

                }

                else
                {
                    forAlb.cmb_GenMedi.Visible = false;
                    forAlb.tbx_Buscar.Enabled = true;
                    forAlb.nUpD_consulta.Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void buscarArtisr(String consulta)
        {
            try
            {
                forAlb.dgv_Artist.DataSource = db.Artists.Where(x => x.Name.Contains(consulta)).ToList().Select(x => new Artist_DTO(x)).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void buscarAlb(String consulta)
        {
            try
            {
                forAlb.dgv_Album.DataSource = db.Albums.Where(x => x.Title.Contains(consulta)).ToList().Select(x => new Album_DTO(x)).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void buscarTrakPorNombre(String consulta)
        {
            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.Name.Contains(consulta)).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        public void buscarTrakPorComp(String consulta)
        {
            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.Composer.Contains(consulta)).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected void buscarTrakPorMediaType(int consulta)
        {

            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.MediaTypeId==consulta).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        protected void buscarTrakPorGenere(int consulta)
        {

            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.GenreId == consulta).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        protected void buscarTrakPorBytes(int consulta)
        {

            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.Bytes == consulta).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        protected void buscarTrakPorMils(int consulta)
        {

            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.Milliseconds == consulta).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        protected void buscarTrakPorUntPri(decimal consulta)
        {

            try
            {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.UnitPrice == consulta).ToList().Select(x => new Track_DTO(x)).ToList();
                forAlb.dgv_Track.Columns[0].Visible = false;
                forAlb.dgv_Track.Columns[2].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }

        }
        public void clearRadBut(object sender, EventArgs args)
        {
            forAlb.rb_Artist.Checked = false;
            forAlb.rb_Album.Checked = false;
            forAlb.rb_Track.Checked = false;
            forAlb.tbx_Buscar.Text = "";
        }
        public void clearRadBut2()
        {
            forAlb.rb_Artist.Checked = false;
            forAlb.rb_Album.Checked = false;
            forAlb.rb_Track.Checked = false;
            forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged;
            forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged2;
            forAlb.dgv_Track.SelectionChanged -= trackSelectionChanged;
            forAlb.dgv_Artist.SelectionChanged -= artistSelectionChanged;
            forAlb.dgv_Artist.SelectionChanged += artistSelectionChanged;
            forAlb.dgv_Album.SelectionChanged += albumSelectionChanged;

            populateArtis();
        }
        public void searchRadBut(object sender, EventArgs args)
        {
            try
            {
                buscar = true;
                if (forAlb.rb_Artist.Checked)
                {
                    buscarArtisr(forAlb.tbx_Buscar.Text);

                }else 
                if (forAlb.rb_Album.Checked)
                {
                    buscarAlb(forAlb.tbx_Buscar.Text);

                }else 
                if (forAlb.rb_Track.Checked)
                {

                if (forAlb.cmb_FiltTrac.SelectedItem == ("Nom")) {
                    buscarTrakPorNombre(forAlb.tbx_Buscar.Text);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("Compositor")) {
                    buscarTrakPorComp(forAlb.tbx_Buscar.Text);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("Bytes")) {
                    buscarTrakPorBytes((int)forAlb.nUpD_consulta.Value);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("Mil·liseconds")) {
                    buscarTrakPorMils((int)forAlb.nUpD_consulta.Value);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("Preu unitari")) {
                    buscarTrakPorUntPri(forAlb.nUpD_consulta.Value);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("Genere")) {
                    buscarTrakPorGenere(forAlb.cmb_GenMedi.SelectedIndex + 1);
                }
                else if (forAlb.cmb_FiltTrac.SelectedItem == ("MediaType")) {
                    buscarTrakPorMediaType(forAlb.cmb_GenMedi.SelectedIndex + 1);
                }
                else
                {

                    if (forAlb.cmb_Idioma.SelectedItem.Equals("Español"))
                    {
                        MessageBox.Show(Properties.Resources.MenErrBus_Esp);
                    }
                    else if (forAlb.cmb_Idioma.SelectedItem.Equals("Catalan"))
                    {
                        MessageBox.Show(Properties.Resources.MenErrBus_Cat);
                    }
                    else if (forAlb.cmb_Idioma.SelectedItem.Equals("Ingles"))
                    {
                        MessageBox.Show(Properties.Resources.MenErrBus_Ing);
                    }
                }
                } else
                {
                    forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged;
                    forAlb.dgv_Album.SelectionChanged -= albumSelectionChanged2;
                    forAlb.dgv_Track.SelectionChanged -= trackSelectionChanged;
                    forAlb.dgv_Artist.SelectionChanged -= artistSelectionChanged;
                    forAlb.dgv_Artist.SelectionChanged += artistSelectionChanged;
                    forAlb.dgv_Album.SelectionChanged += albumSelectionChanged;

                    populateArtis();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }

        //Cargar DGV
        protected void artistSelectionChanged(object sender, EventArgs args)
        {
            Artist_DTO ar;
            ar = artistGetSelected();
            if (forAlb.rb_Album.Checked || forAlb.rb_Track.Checked) { }else
            if((ar) != null)
            {
                albumPopulate(ar);
            }
            else {
            }
        }       
        public void populateArtis()
        {
                forAlb.dgv_Artist.DataSource = db.Artists.ToList().Select(c => new Artist_DTO(c)).ToList();
                forAlb.dgv_Artist.Columns[0].Visible = false;
        }
        public void populateArtis2(Album_DTO al)
        {
                forAlb.dgv_Artist.DataSource = db.Artists.Where(x => x.ArtistId == al.ArtistId).ToList().Select(x => new Artist_DTO(x)).ToList();
                forAlb.dgv_Artist.Columns[0].Visible = false;
        }
        protected Artist_DTO artistGetSelected()
        {
            if (forAlb.dgv_Artist.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (Artist_DTO.ContactoDTOFromRow(forAlb.dgv_Artist.SelectedRows[0].Cells));
            }
        }
        protected void albumSelectionChanged(object sender, EventArgs args)
        {

            Album_DTO al;
            al = albumGetSelected();
            if ((al) != null )
            {
                trackPopulate(al);
            }
            else
            {
            }
           
        }
        protected void albumSelectionChanged2(object sender, EventArgs args)
        {

            Album_DTO al;
            al = albumGetSelected();
            if ((al) != null && forAlb.rb_Track.Checked) {
                populateArtis2(al);
            }
            else if ((al) != null)
            {
                trackPopulate(al);
                populateArtis2(al);
            }
            else
            {
            }

        }
        protected void albumPopulate(Artist_DTO ar)
        {
            try
            {
                
                forAlb.dgv_Album.DataSource = db.Albums.Where(x => x.ArtistId == ar.artistId).ToList().Select(x => new Album_DTO(x)).ToList();
                forAlb.dgv_Album.Columns[0].Visible = false;
                forAlb.dgv_Album.Columns[2].Visible = false;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected void albumPopulate2(Track_DTO tr)
        {
            try
            {

              forAlb.dgv_Album.DataSource = db.Albums.Where(al => al.AlbumId == tr.AlbumId).ToList().Select(al => new Album_DTO(al)).ToList();
               // forAlb.dgv_Album.Columns[0].Visible = false;
               // forAlb.dgv_Album.Columns[2].Visible = false;
              
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected Album_DTO albumGetSelected()
        {
            if (forAlb.dgv_Album.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (Album_DTO.ContactoDTOFromRow(forAlb.dgv_Album.SelectedRows[0].Cells));
            }
        }
        protected void trackSelectionChanged(object sender, EventArgs args)
        {

            Track_DTO tr;
            tr = trackGetSelected();

            if ((tr) != null )
            {
                albumPopulate2(tr);
            }
            else
            {
            }
        }
        protected void trackPopulate(Album_DTO al)
        {
            try
            {
                if (al != null) {
                forAlb.dgv_Track.DataSource = db.Tracks.Where(x => x.AlbumId == al.AlbumId).ToList().Select(x => new Track_DTO(x)).ToList();
                    forAlb.dgv_Track.Columns[0].Visible = false;
                    forAlb.dgv_Track.Columns[2].Visible = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: \n" + e.ToString());
            }
        }
        protected Track_DTO trackGetSelected()
        {
            if (forAlb.dgv_Track.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (Track_DTO.ContactoDTOFromRow(forAlb.dgv_Track.SelectedRows[0].Cells));
            }
        }


    }
}
