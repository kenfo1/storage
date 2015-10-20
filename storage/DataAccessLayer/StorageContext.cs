using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace storage.DataAccessLayer {
    public class StorageContext : DbContext {

        public DbSet<Models.Product> Products { get; set; }

        public StorageContext():base("DefaultConnection") {
        }
    }
}