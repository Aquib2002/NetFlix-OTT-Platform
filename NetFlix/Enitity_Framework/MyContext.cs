using NetFlix.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace NetFlix.Enitity_Framework
{
    public class MyContext : DbContext
    {
        public MyContext() : base("ConStr")
        {
            
        }

        public DbSet<Coustomer> CoustomersTbl { get; set; }

        public DbSet<MembersShipType> MembersShipTypesTbl { get; set; }



    }
}