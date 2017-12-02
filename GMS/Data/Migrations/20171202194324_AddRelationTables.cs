using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GMS.Data.Migrations
{
    public partial class AddRelationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Titles",
                table: "Titles");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Title",
                table: "Title",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    EntityTypeId = table.Column<int>(nullable: true),
                    IsSubscribedToNewsLetter = table.Column<bool>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false),
                    CountryOfBirthId = table.Column<int>(nullable: true),
                    CountryOfCitzenshipId = table.Column<int>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entity_Country_CountryOfBirthId",
                        column: x => x.CountryOfBirthId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entity_Country_CountryOfCitzenshipId",
                        column: x => x.CountryOfCitzenshipId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailSubType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DetailTypeId = table.Column<int>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailSubType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailSubType_DetailType_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityPhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    DetailTypeId = table.Column<int>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityPhones_DetailType_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityPhones_Entity_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityPhones_Entity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_DetailSubType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "DetailSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_Entity_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityAddresses_Entity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityEmailAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressTypeId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    EntityId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityEmailAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityEmailAddresses_DetailSubType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "DetailSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityEmailAddresses_Entity_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityEmailAddresses_Entity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    EntityId = table.Column<int>(nullable: true),
                    NameTypeId = table.Column<int>(nullable: true),
                    ResolvedName = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    TitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityName_Entity_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityName_DetailSubType_NameTypeId",
                        column: x => x.NameTypeId,
                        principalTable: "DetailSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityName_Entity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityName_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailSubType_DetailTypeId",
                table: "DetailSubType",
                column: "DetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_EntityTypeId",
                table: "Entity",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CountryOfBirthId",
                table: "Entity",
                column: "CountryOfBirthId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_CountryOfCitzenshipId",
                table: "Entity",
                column: "CountryOfCitzenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_AddressTypeId",
                table: "EntityAddresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_EntityId",
                table: "EntityAddresses",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAddresses_PersonId",
                table: "EntityAddresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityEmailAddresses_AddressTypeId",
                table: "EntityEmailAddresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityEmailAddresses_EntityId",
                table: "EntityEmailAddresses",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityEmailAddresses_PersonId",
                table: "EntityEmailAddresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityName_EntityId",
                table: "EntityName",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityName_NameTypeId",
                table: "EntityName",
                column: "NameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityName_PersonId",
                table: "EntityName",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityName_TitleId",
                table: "EntityName",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityPhones_DetailTypeId",
                table: "EntityPhones",
                column: "DetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityPhones_EntityId",
                table: "EntityPhones",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityPhones_PersonId",
                table: "EntityPhones",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityAddresses");

            migrationBuilder.DropTable(
                name: "EntityEmailAddresses");

            migrationBuilder.DropTable(
                name: "EntityName");

            migrationBuilder.DropTable(
                name: "EntityPhones");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "DetailSubType");

            migrationBuilder.DropTable(
                name: "Entity");

            migrationBuilder.DropTable(
                name: "DetailType");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Title",
                table: "Title");

            migrationBuilder.RenameTable(
                name: "Title",
                newName: "Titles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");
        }
    }
}
