using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Album_DTO
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }

        public Album_DTO(int AlbumId, string Title, int ArtistId)
        {
            this.AlbumId = AlbumId;
            this.Title = Title;
            this.ArtistId = ArtistId;
        }

        public Album_DTO(Album Al)
        {
            this.AlbumId = Al.AlbumId;
            this.Title = Al.Title;
            this.ArtistId = Al.ArtistId;
        }

        public static Album_DTO ContactoDTOFromRow(DataGridViewCellCollection row)
        {
            return new Album_DTO((int)row["AlbumId"].Value, (string)row["Title"].Value, (int)row["ArtistId"].Value);

        }


    }
}
