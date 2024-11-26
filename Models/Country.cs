using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    [Table("Country")] //SQL Database Table Name
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
    }
}