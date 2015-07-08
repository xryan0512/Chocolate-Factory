using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Factory
{
    class dbFChocolate: DbContext
    {
        public DbSet<PersonProfile> user_profile { get; set; }
        public DbSet<Money> PayChocolates { get; set; }
    }
}
