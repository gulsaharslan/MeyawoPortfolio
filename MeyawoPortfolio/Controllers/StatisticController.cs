using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.v1 = db.TblCategory.Count();
            ViewBag.v2 = db.TblProject.Count();
            ViewBag.v3 = db.TblContact.Count();
            ViewBag.v4 = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.v5 = db.TblContact.Where(x => x.Isread == false).Count();
            ViewBag.v6 = db.LastProjectName().FirstOrDefault();
            ViewBag.v7 = db.TblTestimonial.Count();
            ViewBag.v8 = db.TblService.Count();

            return View();
        }
    }
}