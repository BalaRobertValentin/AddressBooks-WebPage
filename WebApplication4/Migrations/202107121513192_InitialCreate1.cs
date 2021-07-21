namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressBooks", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AddressBooks", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AddressBooks", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.AddressBooks", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.AddressBooks", "City", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AddressBooks", "State", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AddressBooks", "Country", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.AddressBooks", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.AddressBooks", "Email", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddressBooks", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.AddressBooks", "PostalCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.AddressBooks", "Country", c => c.String(maxLength: 20));
            AlterColumn("dbo.AddressBooks", "State", c => c.String(maxLength: 20));
            AlterColumn("dbo.AddressBooks", "City", c => c.String(maxLength: 20));
            AlterColumn("dbo.AddressBooks", "Address", c => c.String(maxLength: 50));
            AlterColumn("dbo.AddressBooks", "PhoneNumber", c => c.String(maxLength: 15));
            AlterColumn("dbo.AddressBooks", "LastName", c => c.String(maxLength: 20));
            AlterColumn("dbo.AddressBooks", "FirstName", c => c.String(maxLength: 20));
        }
    }
}
