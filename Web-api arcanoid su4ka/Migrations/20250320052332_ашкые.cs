using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_api_arcanoid_su4ka.Migrations
{
    /// <inheritdoc />
    public partial class ашкые : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skinmodels",
                columns: table => new
                {
                    ID_Skin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_ball = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skinmodels", x => x.ID_Skin);
                });

            migrationBuilder.CreateTable(
                name: "Usermodels",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false),
                    ID_Skin_user = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usermodels", x => x.Id_user);
                });

            migrationBuilder.CreateTable(
                name: "Userskinmodel",
                columns: table => new
                {
                    ID_Svaz = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skind_id = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userskinmodel", x => x.ID_Svaz);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skinmodels");

            migrationBuilder.DropTable(
                name: "Usermodels");

            migrationBuilder.DropTable(
                name: "Userskinmodel");
        }
    }
}
