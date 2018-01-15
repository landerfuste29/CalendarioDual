using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWScorpiaM15
{
    class Score
    {

        private String Name;
        private int Puntuacio;

        public Score(String Name, int Puntuacio)
        {
            this.setName(Name);
            this.setPuntuacio(Puntuacio);
        }
        public Score()
        {
        }


        public void setName(String Name)
        {
            this.Name = Name;
        }
        public void setPuntuacio(int Puntuacio)
        {
            this.Puntuacio = Puntuacio;
        }
        public String getName()
        {
            return Name;
        }
        public int getPuntuacio()
        {
            return Puntuacio;
        }


        /// <summary>
        /// Guarda les dades (nom+puntuacio) separades per una '#' en una linea del document.
        /// </summary>
        public void AddScoreInFile()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Score.txt";
            // string mydocpath = @"\Score.txt";
            // string mydocpath= Properties.Resources.PuntuacionsBomberman;
            string[] NewRow = { this.getName() + "#" + this.getPuntuacio() };
            if (File.Exists(mydocpath))
            {
                File.AppendAllLines(mydocpath, NewRow);
            }
            else
            {
                File.AppendAllLines(mydocpath, NewRow);
            }

        }



    }
}
