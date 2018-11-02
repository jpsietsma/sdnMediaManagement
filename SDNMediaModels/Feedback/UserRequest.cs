//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDNMediaModels.Feedback
{
    using SDNMediaModels.Account;
    using SDNMediaModels.List;
    using SDNMediaModels.Television;
    using System;
    using System.Collections.Generic;
    
    public partial class UserRequest : IUserRequest
    {
        public int pk_RequestID { get; set; }
        public Nullable<int> RequestType { get; set; }
        public Nullable<int> RequestSubtype { get; set; }
        public string ExistingSeries { get; set; }
        public string RequestQuery { get; set; }
        public string RequestShow { get; set; }
        public string RequestSeason { get; set; }
        public string RequestEpisode { get; set; }
        public string RequestMovie { get; set; }
        public string RequestMovieYear { get; set; }
        public string RequestMovieGenre { get; set; }
        public Nullable<int> RequestCompleted { get; set; }
        public Nullable<int> fk_ShowID { get; set; }
        public Nullable<int> fk_EpisodeID { get; set; }
        public Nullable<int> fk_SeasonID { get; set; }
        public string fk_UserID { get; set; }
        public Nullable<int> fk_AutomationStatus { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual list_AutomationStatuses list_AutomationStatuses { get; set; }
        public virtual ITelevisionEpisode ITelevisionEpisode { get; set; }
        public virtual ITelevisionSeason ITelevisionSeason { get; set; }
        public virtual ITelevisionShow ITelevisionShow { get; set; }
    }
}
