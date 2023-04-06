using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESG.Migrations
{
    public partial class AddEsgToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ESGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SusESG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MsciESG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FtseESG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssESG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SapESG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwCompanyRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESGs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ESGs");
        }
    }
}
