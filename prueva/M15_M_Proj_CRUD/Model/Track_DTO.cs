using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Track_DTO
    {
        public int TrackId { get; set; }

        public string Name { get; set; }
        public int AlbumId { get; set; }
        public string MediaTypeId { get; set; }
        public string GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public Nullable<int> Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        public Track_DTO(int TrackId,string Name, int AlbumId, string MediaTypeId, string GenreId, string Composer, int Milliseconds, int Bytes, decimal UnitPrice)
        {
            this.TrackId = TrackId;
            this.Name = Name;
            this.AlbumId = AlbumId;
            this.MediaTypeId = MediaTypeId;
            this.GenreId = GenreId;
            this.Composer = Composer;
            this.Milliseconds = Milliseconds;
            this.Bytes = Bytes;
            this.UnitPrice = UnitPrice;
        }
        public Track_DTO(Track t)
        {
            this.TrackId = t.TrackId;
            this.Name = t.Name;
          //  if (t.AlbumId != null) {
                this.AlbumId = (int)t.AlbumId;
           // }
            this.MediaTypeId = t.MediaType.Name;
            this.GenreId = t.Genre.Name;
            this.Composer = t.Composer;
            this.Milliseconds = t.Milliseconds;
            this.Bytes = t.Bytes;
            this.UnitPrice = t.UnitPrice;
        }

        
        public static Track_DTO ContactoDTOFromRow(DataGridViewCellCollection row)
        {
            return new Track_DTO((int)row["TrackId"].Value, (string)row["Name"].Value, (int)row["AlbumId"].Value,  (string)row["MediaTypeId"].Value, 
                (string)row["GenreId"].Value, (string)row["Composer"].Value, 
                (int)row["Milliseconds"].Value, (int)row["Bytes"].Value, (decimal)row["UnitPrice"].Value);

        }

    }
}
