namespace storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UppdateWithPicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "URLlink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "URLlink");
        }
    }
}
