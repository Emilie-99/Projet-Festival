﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalAPI.Migrations
{
    public partial class mmdel5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Festival",
                columns: table => new
                {
                    FestivalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Festival = table.Column<string>(nullable: false),
                    Lieu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festival", x => x.FestivalId);
                });

            migrationBuilder.CreateTable(
                name: "Festivalier",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Mot_de_passe = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    Code_postal = table.Column<int>(nullable: false),
                    Commune = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Date_de_naissance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivalier", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Gestionnaire",
                columns: table => new
                {
                    IdGestionnaire = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: true),
                    Mdp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestionnaire", x => x.IdGestionnaire);
                });

            migrationBuilder.CreateTable(
                name: "Organisateur",
                columns: table => new
                {
                    IdOrganisateur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: true),
                    Mot_de_passe = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FestivalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisateur", x => x.IdOrganisateur);
                    table.ForeignKey(
                        name: "FK_Organisateur_Festival_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "Festival",
                        principalColumn: "FestivalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organisateur_FestivalId",
                table: "Organisateur",
                column: "FestivalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Festivalier");

            migrationBuilder.DropTable(
                name: "Gestionnaire");

            migrationBuilder.DropTable(
                name: "Organisateur");

            migrationBuilder.DropTable(
                name: "Festival");
        }
    }
}
