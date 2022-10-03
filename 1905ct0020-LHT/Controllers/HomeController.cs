using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using _1905ct0020_LHT.Models;

namespace _1905ct0020_LHT.Controllers
{
    public class HomeController : Controller
    {
        qltintucEntities db = new qltintucEntities();
        public ActionResult Index()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult sao()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult anchoi()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult Dep()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult giaitri()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult khampha()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult tamsu()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult thethao()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult tintuc()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult tuvi()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult chitiet(int id)
        {
            tbl_baiviet bv = db.tbl_baiviet.FirstOrDefault(x => x.id_baiviet == id);

            return View(bv);
        }

        public ActionResult Header()
        {
            return PartialView("_Header");
        }

        public ActionResult Footer()
        {
            return PartialView("_Footer");
        }
    }
}