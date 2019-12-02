namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "pidevds.conge",
                c => new
                    {
                        idConge = c.Int(nullable: false, identity: true),
                        dateDeb = c.DateTime(precision: 0),
                        dateFin = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, unicode: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idConge)
                .ForeignKey("pidevds.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "pidevds.user",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        Firstname = c.String(maxLength: 255, unicode: false),
                        Lastname = c.String(maxLength: 255, unicode: false),
                        email = c.String(maxLength: 255, unicode: false),
                        isActiv = c.Boolean(storeType: "bit"),
                        password = c.String(maxLength: 255, unicode: false),
                        role = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "pidevds.contrat",
                c => new
                    {
                        idContrat = c.Int(nullable: false, identity: true),
                        dateDebut = c.DateTime(storeType: "date"),
                        salaire = c.Single(nullable: false),
                        typeContrat = c.String(maxLength: 255, unicode: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idContrat)
                .ForeignKey("pidevds.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "pidevds.evaluation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateEval = c.DateTime(precision: 0),
                        MoyenneNote = c.Double(),
                        critere = c.String(maxLength: 255, unicode: false),
                        name = c.String(maxLength: 255, unicode: false),
                        notation = c.String(maxLength: 255, unicode: false),
                        noteA = c.Int(),
                        noteB = c.Int(),
                        typeEval = c.String(maxLength: 255, unicode: false),
                        employe_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("pidevds.user", t => t.employe_idUser)
                .Index(t => t.employe_idUser);
            
            CreateTable(
                "pidevds.formation",
                c => new
                    {
                        idFormation = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 255, unicode: false),
                        categories = c.String(maxLength: 255, unicode: false),
                        date = c.DateTime(precision: 0),
                        niveau_in = c.Int(nullable: false),
                        niveau_out = c.Int(nullable: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        nomFormateur = c.String(maxLength: 255, unicode: false),
                        type = c.Int(),
                    })
                .PrimaryKey(t => t.idFormation);
            
            CreateTable(
                "dbo.formation_user",
                c => new
                    {
                        users_idUser = c.Int(nullable: false),
                        Formation_idFormation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.users_idUser, t.Formation_idFormation })
                .ForeignKey("pidevds.user", t => t.users_idUser, cascadeDelete: true)
                .ForeignKey("pidevds.formation", t => t.Formation_idFormation, cascadeDelete: true)
                .Index(t => t.users_idUser)
                .Index(t => t.Formation_idFormation);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.formation_user", "Formation_idFormation", "pidevds.formation");
            DropForeignKey("dbo.formation_user", "users_idUser", "pidevds.user");
            DropForeignKey("pidevds.evaluation", "employe_idUser", "pidevds.user");
            DropForeignKey("pidevds.contrat", "user_idUser", "pidevds.user");
            DropForeignKey("pidevds.conge", "user_idUser", "pidevds.user");
            DropIndex("dbo.formation_user", new[] { "Formation_idFormation" });
            DropIndex("dbo.formation_user", new[] { "users_idUser" });
            DropIndex("pidevds.evaluation", new[] { "employe_idUser" });
            DropIndex("pidevds.contrat", new[] { "user_idUser" });
            DropIndex("pidevds.conge", new[] { "user_idUser" });
            DropTable("dbo.formation_user");
            DropTable("pidevds.formation");
            DropTable("pidevds.evaluation");
            DropTable("pidevds.contrat");
            DropTable("pidevds.user");
            DropTable("pidevds.conge");
        }
    }
}
