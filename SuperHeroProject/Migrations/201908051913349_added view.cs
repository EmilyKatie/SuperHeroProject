namespace SuperHeroProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperHeroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        alterEgo = c.String(),
                        firstAbility = c.String(),
                        secondAbility = c.String(),
                        catchphrase = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SuperHeroes");
        }
    }
}
