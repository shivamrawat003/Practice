using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Contxt :DbContext
    {
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<STATE> States { get; set; }
    }
}