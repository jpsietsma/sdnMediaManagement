//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDNMediaModels.StoredProcedure
{
    using System;
    
    public partial class GetAllShows_Result
    {
        public int pk_ShowID { get; set; }
        public string ShowName { get; set; }
        public string ShowDriveLetter { get; set; }
        public string ShowHomePath { get; set; }
        public int ShowNumSeasons { get; set; }
        public int ShowNumEpisodes { get; set; }
        public string ShowAlbumArtPath { get; set; }
        public int IsEnabled { get; set; }
        public string TvdbID { get; set; }
        public string ImdbID { get; set; }
        public Nullable<int> fk_MediaType { get; set; }
    }
}
