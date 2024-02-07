using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        DbMyPortfolioEntities db=new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblFeature.ToList();
            return View(values);
        }
    }
}