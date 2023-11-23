using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFlix.Models.DTO
{
    public class CoustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Mandatory")]
        public string Name { get; set; }

        public string Address { get; set; }

        public MembersShipType membersShipType { get; set; }

        public int membersShipTypeId { get; set; }

        public bool IsActive { get; set; }
    }
}