using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GMS.Data.Migrations
{
    public partial class AddMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId",
                table: "Entity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DiscountRate = table.Column<byte>(nullable: false),
                    DurationInMonths = table.Column<byte>(nullable: false),
                    SignUpFee = table.Column<short>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false),
                    UserLastUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entity_MembershipTypeId",
                table: "Entity",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity_MembershipType_MembershipTypeId",
                table: "Entity",
                column: "MembershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entity_MembershipType_MembershipTypeId",
                table: "Entity");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_Entity_MembershipTypeId",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Entity");
        }
    }
}
