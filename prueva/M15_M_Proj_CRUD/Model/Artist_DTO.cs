using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Artist_DTO
    {

        public int artistId { get; set; }
        public string name { get; set; }




        public Artist_DTO(int artistId, string name)
        {
            this.artistId = artistId;
            this.name = name;

        }
        public Artist_DTO(string name)
        {
            this.name = name;

        }
        public Artist_DTO(Artist nomArtist)
        {
            this.artistId = nomArtist.ArtistId;
            this.name = nomArtist.Name;
        }
        public static Artist_DTO ContactoDTOFromRow(DataGridViewCellCollection row)
        {
            return new Artist_DTO((int)row["ArtistId"].Value, (string)row["Name"].Value);
           // return new Artist_DTO((string)row["Name"].Value);

        }


    }
}
