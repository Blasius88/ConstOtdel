namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_first_migratin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.String(),
                        Provider = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hardwares",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ID_Supplier_Name = c.Int(nullable: false),
                        Supplier_Name = c.String(),
                        Hardware_Name = c.String(),
                        Description = c.String(),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Suppliers_Hadware",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers_Hadware");
            DropTable("dbo.Hardwares");
            DropTable("dbo.Accessories");
        }
    }
}
