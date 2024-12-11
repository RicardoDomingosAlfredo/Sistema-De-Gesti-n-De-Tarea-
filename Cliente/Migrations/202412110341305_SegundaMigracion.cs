namespace Cliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegundaMigracion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tareas", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Tareas", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tareas", "Description", c => c.String());
            AlterColumn("dbo.Tareas", "Title", c => c.String());
        }
    }
}
