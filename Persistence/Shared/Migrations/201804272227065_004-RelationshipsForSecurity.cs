namespace Alquiler.Persistence.Shared.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004RelationshipsForSecurity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRols", "Rol_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.UserLogins", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRols", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRols", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserClaims", "UserId");
            CreateIndex("dbo.UserLogins", "UserId");
            CreateIndex("dbo.UserRols", "UserId");
            CreateIndex("dbo.UserRols", "Rol_Id");
            AddForeignKey("dbo.UserClaims", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserLogins", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRols", "Rol_Id", "dbo.Rols", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRols", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRols", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRols", "Rol_Id", "dbo.Rols");
            DropForeignKey("dbo.UserLogins", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserClaims", "UserId", "dbo.Users");
            DropIndex("dbo.UserRols", new[] { "Rol_Id" });
            DropIndex("dbo.UserRols", new[] { "UserId" });
            DropIndex("dbo.UserLogins", new[] { "UserId" });
            DropIndex("dbo.UserClaims", new[] { "UserId" });
            AlterColumn("dbo.UserRols", "RoleId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserRols", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.UserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.UserRols", "Rol_Id");
        }
    }
}
