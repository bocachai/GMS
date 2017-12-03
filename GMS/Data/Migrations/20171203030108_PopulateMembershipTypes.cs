using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GMS.Data.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            string strInsert = "INSERT INTO MembershipType ";
            strInsert += "(Code, Description, DurationInMonths, SignUpFee, DiscountRate,";
            strInsert += "DateCreated, DateLastUpdated, UserCreated, UserLastUpdated) ";
            strInsert += "VALUES ('{0}', '{1}', {2}, {3}, {4},  ";
            string strDefaults = string.Format("'{0}', '{1}', 1, 1)", sqlFormattedDate, sqlFormattedDate);
            strInsert += strDefaults;
            migrationBuilder.Sql(string.Format(strInsert, "NM", "No active membership", 0, 0, 0 ));
            migrationBuilder.Sql(string.Format(strInsert, "Monthly", "Monthly", 1, 30, 0));
            migrationBuilder.Sql(string.Format(strInsert, "Annual", "Annual", 12, 300, 20));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
