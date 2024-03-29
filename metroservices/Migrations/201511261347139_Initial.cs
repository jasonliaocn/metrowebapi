namespace metroservices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "GEO.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                        Lat = c.Double(nullable: false),
                        Lng = c.Double(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("GEO.Tags");
        }
    }
}
