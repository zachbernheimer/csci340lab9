using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeUniversity.Migrations
{
    /// <inheritdoc />
    public partial class ConcurrencyFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ConcurrencyToken",
                table: "Departments",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldRowVersion: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ConcurrencyToken",
                table: "Departments",
                type: "BLOB",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");
        }
    }
}
