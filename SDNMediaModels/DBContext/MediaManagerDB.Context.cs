﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using SDNMediaModels.Api;
using SDNMediaModels.Account;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using SDNMediaModels.List;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using SDNMediaModels.StoredProcedure;
using SDNMediaModels.Movies;

namespace SDNMediaModels.DBContext
{
    
    public partial class MediaManagerDB : DbContext
    {
        public MediaManagerDB()
            : base("name=MediaManagerDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApiToken> ApiTokens { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<DownloadQueue> DownloadQueues { get; set; }
        public virtual DbSet<FileMoveHistory> FileMoveHistories { get; set; }
        public virtual DbSet<list_AutomationActions> list_AutomationActions { get; set; }
        public virtual DbSet<list_AutomationPriority> list_AutomationPriority { get; set; }
        public virtual DbSet<list_AutomationStatuses> list_AutomationStatuses { get; set; }
        public virtual DbSet<list_MediaDrives> list_MediaDrives { get; set; }
        public virtual DbSet<list_MediaTypes> list_MediaTypes { get; set; }
        public virtual DbSet<list_MovieGenres> list_MovieGenres { get; set; }
        public virtual DbSet<list_permissionLevels> list_permissionLevels { get; set; }
        public virtual DbSet<list_TaskTypes> list_TaskTypes { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<PlaybackHistory> PlaybackHistories { get; set; }
        public virtual DbSet<ProcessQueue> ProcessQueues { get; set; }
        public virtual DbSet<sortItem> sortItems { get; set; }
        public virtual DbSet<TaskQueue> TaskQueues { get; set; }
        public virtual DbSet<TelevisionEpisode> TelevisionEpisodes { get; set; }
        public virtual DbSet<TelevisionSeason> TelevisionSeasons { get; set; }
        public virtual DbSet<TelevisionShow> TelevisionShows { get; set; }
        public virtual DbSet<UserRequest> UserRequests { get; set; }
    
        public virtual int ActivateEpisode(Nullable<int> episodeID)
        {
            var episodeIDParameter = episodeID.HasValue ?
                new ObjectParameter("episodeID", episodeID) :
                new ObjectParameter("episodeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateEpisode", episodeIDParameter);
        }
    
        public virtual int ActivateSeason(Nullable<int> seasonID)
        {
            var seasonIDParameter = seasonID.HasValue ?
                new ObjectParameter("seasonID", seasonID) :
                new ObjectParameter("seasonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateSeason", seasonIDParameter);
        }
    
        public virtual int ActivateShow(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateShow", showIDParameter);
        }
    
        public virtual ObjectResult<string> BuildEpisodeStreamingUrl(string fileName, string showName, string showFile, string showSeason)
        {
            var fileNameParameter = fileName != null ?
                new ObjectParameter("fileName", fileName) :
                new ObjectParameter("fileName", typeof(string));
    
            var showNameParameter = showName != null ?
                new ObjectParameter("showName", showName) :
                new ObjectParameter("showName", typeof(string));
    
            var showFileParameter = showFile != null ?
                new ObjectParameter("showFile", showFile) :
                new ObjectParameter("showFile", typeof(string));
    
            var showSeasonParameter = showSeason != null ?
                new ObjectParameter("showSeason", showSeason) :
                new ObjectParameter("showSeason", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("BuildEpisodeStreamingUrl", fileNameParameter, showNameParameter, showFileParameter, showSeasonParameter);
        }
    
        public virtual ObjectResult<GetAllShows_Result> GetAllShows()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllShows_Result>("GetAllShows");
        }
    
        public virtual ObjectResult<GetDailyDownloads_Result> GetDailyDownloads()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDailyDownloads_Result>("GetDailyDownloads");
        }
    
        public virtual ObjectResult<string> GetDisplayDuration(Nullable<int> mins)
        {
            var minsParameter = mins.HasValue ?
                new ObjectParameter("mins", mins) :
                new ObjectParameter("mins", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDisplayDuration", minsParameter);
        }
    
        public virtual ObjectResult<GetMovies_Result> GetMovies()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMovies_Result>("GetMovies");
        }
    
        public virtual ObjectResult<GetOrphanSortItems_Result> GetOrphanSortItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrphanSortItems_Result>("GetOrphanSortItems");
        }
    
        public virtual ObjectResult<GetShowEpisodes_Result> GetShowEpisodes(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowEpisodes_Result>("GetShowEpisodes", showIDParameter);
        }
    
        public virtual ObjectResult<GetShowEpisodesBySeason_Result> GetShowEpisodesBySeason(Nullable<int> seasonID)
        {
            var seasonIDParameter = seasonID.HasValue ?
                new ObjectParameter("seasonID", seasonID) :
                new ObjectParameter("seasonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowEpisodesBySeason_Result>("GetShowEpisodesBySeason", seasonIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetShowIdByName(string showName, Nullable<int> showID)
        {
            var showNameParameter = showName != null ?
                new ObjectParameter("ShowName", showName) :
                new ObjectParameter("ShowName", typeof(string));
    
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("ShowID", showID) :
                new ObjectParameter("ShowID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetShowIdByName", showNameParameter, showIDParameter);
        }
    
        public virtual ObjectResult<GetShowSeasons_Result> GetShowSeasons(Nullable<int> showID)
        {
            var showIDParameter = showID.HasValue ?
                new ObjectParameter("showID", showID) :
                new ObjectParameter("showID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetShowSeasons_Result>("GetShowSeasons", showIDParameter);
        }
    
        public virtual ObjectResult<GetSortItems_Result> GetSortItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSortItems_Result>("GetSortItems");
        }
    
        public virtual ObjectResult<GetUsers_Result> GetUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsers_Result>("GetUsers");
        }
    }
}