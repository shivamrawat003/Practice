using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    [Table("STATE")]
    public class STATE
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public bool? STATUS { get; set; }
        public int? COUNTRY_ID { get; set; }
    }
}