namespace Alquiler.Persistence.Shared.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005DataAnnotationsForCustomers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "GovermentBusinessId", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Customers", "PBX", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "OfficePhoneAlt", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "MobilePhoneMain", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "MobilePhoneAlt", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "Website", c => c.String(maxLength: 200));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Customers", "Comments", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Comments", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Website", c => c.String());
            AlterColumn("dbo.Customers", "MobilePhoneAlt", c => c.String());
            AlterColumn("dbo.Customers", "MobilePhoneMain", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "OfficePhoneAlt", c => c.String());
            AlterColumn("dbo.Customers", "PBX", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "GovermentBusinessId", c => c.String(nullable: false));
        }
    }
}
