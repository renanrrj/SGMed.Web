using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGMed.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientefkID",
                table: "Tb_Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresafkID",
                table: "Tb_Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientefkID",
                table: "Tb_Empresa");

            migrationBuilder.DropColumn(
                name: "EmpresafkID",
                table: "Tb_Cliente");
        }
    }
}
