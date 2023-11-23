using NetFlix.Enitity_Framework;
using NetFlix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFlix.Controllers
{
    public class MemberShipTypeController : BaseController
    {
        private readonly MyContext _context;

        public MemberShipTypeController(MyContext context)
        {
            _context = context;
        }

        public ActionResult list()
        {
            var MemberShip = _context.MembersShipTypesTbl.Where(m => m.IsActive == true).ToList();

            return View(MemberShip);
        }

        public ActionResult Create()
        {
            var memberShipType = new MembersShipType();
            return View();
        }

        public ActionResult Edit(int id)
        {
            var memberondb = _context.MembersShipTypesTbl.Find(id);

            return View("Create", memberondb);
        }

        [HttpPost]
        public ActionResult CreateEdit(MembersShipType model) 
        {
            if (model.Id == 0)
            {
                _context.MembersShipTypesTbl.Add(model);
                model.CreatedOn = DateTime.Now;
                model.CreatedBy = GetCurrentUserName();

            }
            else
            {
                var id = model.Id;

                var memeberInDb = _context.MembersShipTypesTbl.Find(id);

                model.UpdatedOn = DateTime.Now;
                model.UpdatedBy = GetCurrentUserName();

                TryUpdateModel(memeberInDb);
            }

            _context.SaveChanges();

            return RedirectToAction ("List");
        }



        public ActionResult Delete(int id)
        {
            var memberondb = _context.MembersShipTypesTbl.Find(id);

            return View(memberondb);
        }

        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            var memberInDb = _context.MembersShipTypesTbl.Find(id);

            memberInDb.IsActive = false;

            memberInDb.DeletedOn = DateTime.Now;

            memberInDb.DeletedBy = GetCurrentUserName();

            _context.SaveChanges();

            return RedirectToAction("List");
        }

    }
}