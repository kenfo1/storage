namespace storage.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<storage.DataAccessLayer.StorageContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(storage.DataAccessLayer.StorageContext context) {
            context.Products.AddOrUpdate(
             p => p.Name,
             new Product { Name = "ProduktX", Price = 12.50m, Category = "Spel", Shelf="A1", Count=12, URLlink="browsa.se/wp-content/uploads/2013/11/DagensBilder2013112155.jpg", Description="adslkfjads sdafa" },
             new Product { Name = "Carrera", Price = 1240000, Category = "Bilar", Shelf="Garage-45", URLlink="www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Count=1, Description="Chefens ägodelar" },
             new Product { Name = "YProdukt", Price = 121.99m, Category = "Böcker", Shelf="B3", Count=121, URLlink="www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Description="dfsg d adslkfjads sdafa" },
             new Product { Name = "Carrera X", Price = 1799000, Category = "Bilar", Shelf="Garage-85", Count=1, URLlink="www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Description="Kanske inte min" },
             new Product { Name = "Datormud", Price = 121.99m, Category = "Electronics", Shelf="B3", Count=121, URLlink="www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Description="dfsg d adslkfjads sdafa" },
             new Product { Name = "Datormud", Price = 121.99m, Category = "Electronics", Shelf = "B3", Count = 121, URLlink = "www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Description = "dfsg d adslkfjads sdafa" },
             new Product { Name = "BProdukt", Price = 21.99m, Category = "Böcker", Shelf="B3", Count=0, URLlink="www.smelink.se/ElemImage/smelink-tipsar-bilder-hemsida-3(1)_900.jpg", Description="Produkten skall inte tas in igen" }
           );
        }
    }
}
