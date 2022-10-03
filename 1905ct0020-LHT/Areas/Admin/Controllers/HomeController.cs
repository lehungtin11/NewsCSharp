using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using _1905ct0020_LHT.Models;


namespace _1905ct0020_LHT.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        qltintucEntities db = new qltintucEntities();
        public ActionResult Index()
        {
            List<tbl_baiviet> lst = db.tbl_baiviet.ToList();
            return View(lst);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_baiviet bv, HttpPostedFileBase uploadhinh)
        {
            db.tbl_baiviet.Add(bv);
            db.SaveChanges();
            if (uploadhinh != null && uploadhinh.ContentLength > 0)
            {
                int id = int.Parse(db.tbl_baiviet.ToList().Last().id_baiviet.ToString());

                string _FileName = "";
                int index = uploadhinh.FileName.IndexOf('.');
                _FileName = "bv" + id.ToString() + "." + uploadhinh.FileName.Substring(index + 1);
                string _path = Path.Combine(Server.MapPath("~/img"), _FileName);
                uploadhinh.SaveAs(_path);

                tbl_baiviet unv = db.tbl_baiviet.FirstOrDefault(x => x.id_baiviet == id);
                unv.hinhanh = _FileName;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult edit(int id)
        {
            tbl_baiviet bv = db.tbl_baiviet.FirstOrDefault(x => x.id_baiviet == id);

            return View(bv);
        }
        [HttpPost]
        public ActionResult edit(tbl_baiviet bv, HttpPostedFileBase uploadhinh)
        {
            tbl_baiviet unv = db.tbl_baiviet.FirstOrDefault(g => g.id_baiviet == bv.id_baiviet);
            unv.tenbaiviet = bv.tenbaiviet;
            unv.mabaiviet = bv.mabaiviet;
            unv.noidung = bv.noidung;
            unv.tomtat = bv.tomtat;
            unv.id_danhmuc = bv.id_danhmuc;
            unv.ngay = bv.ngay;

            if (uploadhinh != null && uploadhinh.ContentLength > 0)
            {
                int id = bv.id_baiviet;

                string _FileName = "";
                int index = uploadhinh.FileName.IndexOf('.');
                _FileName = "bv" + id.ToString() + "." + uploadhinh.FileName.Substring(index + 1);
                string _path = Path.Combine(Server.MapPath("~/img"), _FileName);
                uploadhinh.SaveAs(_path);
                unv.hinhanh = _FileName;
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult delete(int id)
        {
            tbl_baiviet bv = db.tbl_baiviet.FirstOrDefault(x => x.id_baiviet == id);
            db.tbl_baiviet.Remove(bv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}