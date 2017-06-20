namespace _7DaysProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEmployee", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.tblEmployee", "Lastname", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblEmployee", "Lastname", c => c.String());
            AlterColumn("dbo.tblEmployee", "Firstname", c => c.String());
        }
    }
}
