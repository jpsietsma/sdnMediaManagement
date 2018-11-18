﻿using MediaMaintenanceLibrary;
using MediaMaintenanceLibrary.Apis;
using SDNMediaModels.Api;
using SDNMediaModels.Api.YIFY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize]
    public class DownloadsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Eztv(int? id)
        {
            List<EztvResult> downloads = new List<EztvResult>();

            if (!id.HasValue)
            {
                downloads = EztvApiLibrary.GetEztvDownloads();
            }
            else
            {
                int.TryParse(id.ToString(), out int results);
                downloads = EztvApiLibrary.GetEztvDownloads(pageResults: results);
            }
            

            return View(downloads.OrderBy(show => show.imdb_id));

        }

        public ActionResult Yify(int? id)
        {
            List<YIFYMovieResult> downloads = new List<YIFYMovieResult>();

            if (!id.HasValue)
            {
                downloads = YifyApiLibrary.GetYIFYMovies();
            }

            return View(downloads);
        }


    }
}