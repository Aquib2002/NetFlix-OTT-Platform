using AutoMapper;
using NetFlix.Enitity_Framework;
using NetFlix.Models;
using NetFlix.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetFlix.Controllers.Api
{
    public class CoustomerController : ApiController
    {
        private readonly MyContext _context;

        public CoustomerController()
        {
            _context = new MyContext();
        }

        [HttpGet]
        public IEnumerable<Coustomer> coustomers()
        {
            var coustomer = _context.CoustomersTbl.Include(c =>c.membersShipType);

            return coustomer;
        }

        [HttpGet]
        public CoustomerDto coustomerDto(int id)
        {
            var coustomer = _context.CoustomersTbl.Include(c => c.membersShipType).SingleOrDefault(c=>c.Id==id);

            var coustomerDto = Mapper.Map<Coustomer, CoustomerDto>(coustomer);

            return coustomerDto;
        }


        [HttpPost]
        public CoustomerDto Create(CoustomerDto coustomerdto)
        {
            var coustomer = Mapper.Map<CoustomerDto, Coustomer>(coustomerdto);

             _context.CoustomersTbl.Add(coustomer);

            _context.SaveChanges();

            coustomerdto.Id = coustomer.Id;

            return coustomerdto;
        }


        [HttpPut]
        public void Edit(int id ,CoustomerDto coustomerdto)
        {
            var Coustomer = _context.CoustomersTbl.Find(id);

            Mapper.Map(coustomerdto, Coustomer);

            _context.SaveChanges();

        }

        [HttpDelete]
        public void Delete(int id)
        {
            var coustomer =_context.CoustomersTbl.Find(id);

            _context.CoustomersTbl.Remove(coustomer);

            _context.SaveChanges();
        }
    }
}
