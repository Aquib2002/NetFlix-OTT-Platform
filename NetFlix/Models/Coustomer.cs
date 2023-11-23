using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NetFlix.Models
{
    public class Coustomer : ModelBase
    {
       

        [Required(ErrorMessage ="Name Is Mandatory")]
        public string Name { get; set; }

        public string Address { get; set; }
        
        public MembersShipType membersShipType { get; set; }


        [ForeignKey("membersShipType")]
        public int membersShipTypeId { get; set; }


       

    }
}