using System;

namespace SDNMediaModels.StoredProcedure
{    
    
    public partial class GetOrphanSortItems_Result
    {
        public int pk_MediaID { get; set; }
        public string filePath { get; set; }
        public string fileName { get; set; }
        public int hasBeenSanitized { get; set; }
        public string fileNameSanitized { get; set; }
        public int hasBeenProcessed { get; set; }
        public System.DateTime fileModified { get; set; }
        public System.DateTime fileAdded { get; set; }
        public int fk_fileMediaTypeID { get; set; }
        public int fk_automationStatus { get; set; }
        public string finalizedFilePath { get; set; }
        public string finalizedFileName { get; set; }
        public string finalizedShowName { get; set; }
        public string finalizedShowSeason { get; set; }
        public string finalizedShowEpisode { get; set; }
        public int hasBeenFinalized { get; set; }
        public int hasBeenDistributed { get; set; }
        public int dlFileExists { get; set; }
        public int finalizedStatus { get; set; }
        public string fk_torrentID { get; set; }
        public string TorrentName { get; set; }
        public Nullable<System.DateTime> DownloadFinished { get; set; }
        public Nullable<System.DateTime> DownloadStarted { get; set; }
        public string TorrentStatus { get; set; }
        public string TorrentPath { get; set; }
        public Nullable<int> DownloadDuration { get; set; }
    }
}
