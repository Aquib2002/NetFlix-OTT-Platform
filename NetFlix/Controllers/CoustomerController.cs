using NetFlix.Enitity_Framework;
using NetFlix.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFlix.Controllers
{
    public class CoustomerController : BaseController
    {
        private readonly MyContext _context;
        public CoustomerController(MyContext context)
        {
            _context = context; 
        }


        public ActionResult List()
        {
            var CoustomersinDb = _context.CoustomersTbl.Include(c =>c.membersShipType).Where(c =>c.IsActive==true);
            return View(CoustomersinDb);
        }

        public ActionResult Create()
        {
            ViewBag.Membershiptypeid = _context.MembersShipTypesTbl;

            var coustomer = new Coustomer();

            return View("CoustomerForm");
        }

        public ActionResult Edit(int id)
        {
            var coustomerinDB = _context.CoustomersTbl.Find(id);

            ViewBag.Membershiptypeid = _context.MembersShipTypesTbl;

            return View("CoustomerForm",coustomerinDB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEdit(Coustomer Model)
        {
            if(ModelState.IsValid)
            {
                if (Model.Id == 0)
                {
                    Model.CreatedOn = DateTime.Now;

                    Model.CreatedBy = GetCurrentUserName();
                    _context.CoustomersTbl.Add(Model);

                }
                else
                {
                    var id = Model.Id;

                    var coustomerindb = _context.CoustomersTbl.Find(id);

                    TryUpdateModel(coustomerindb);

                    Model.UpdatedBy = GetCurrentUserName();

                    Model.UpdatedOn = DateTime.Now;


                    // _context.Entry(Model).State = EntityState.Modified;
                }

                _context.SaveChanges();

                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Membershiptypeid = _context.MembersShipTypesTbl;

                return View("CoustomerForm", Model);
            }

        }

        public ActionResult Delete(int id)
        {
            var CoustomerinDb = _context.CoustomersTbl.Find(id);

            return View(CoustomerinDb);
        }


        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            var Coustomerindb = _context.CoustomersTbl.Find(id);

            Coustomerindb.IsActive = false;

            Coustomerindb.DeletedOn = DateTime.Now;

            Coustomerindb.DeletedBy = GetCurrentUserName();

            _context.SaveChanges();

            return RedirectToAction("List");
        }

        public ActionResult Details (int id)
        {
            var coustomer = _context.CoustomersTbl.Include(c =>c.membersShipType).SingleOrDefault(c => c.Id == id);

            return View(coustomer);
        }
    }
}