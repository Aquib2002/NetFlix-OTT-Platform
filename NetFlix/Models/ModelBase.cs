using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlix.Models
{
    public abstract class ModelBase
    {
        public ModelBase()
        {
            this.IsActive = true;
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
    }

}