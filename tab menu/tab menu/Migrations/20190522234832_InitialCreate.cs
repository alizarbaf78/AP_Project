using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tab_menu.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "changs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CHNameMaster = table.Column<string>(nullable: true),
                    CHLastNameMaster = table.Column<string>(nullable: true),
                    CHNameUser = table.Column<string>(nullable: true),
                    CHLastNameUser = table.Column<string>(nullable: true),
                    CHCodePosti = table.Column<string>(nullable: true),
                    AddProduct = table.Column<bool>(nullable: false),
                    CHProduct = table.Column<bool>(nullable: false),
                    IsRrgister = table.Column<bool>(nullable: false),
                    IsMaster = table.Column<bool>(nullable: false),
                    CHNameProduct = table.Column<string>(nullable: true),
                    CHColor = table.Column<string>(nullable: true),
                    CHWeight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_changs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "masters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    PhonNumber = table.Column<string>(nullable: true),
                    changID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_masters_changs_changID",
                        column: x => x.changID,
                        principalTable: "changs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    AdvisePlass = table.Column<bool>(nullable: false),
                    Weight = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    changID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_products_changs_changID",
                        column: x => x.changID,
                        principalTable: "changs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    PhonNumber = table.Column<string>(nullable: true),
                    BoughtProdect = table.Column<string>(nullable: true),
                    CodePosti = table.Column<string>(nullable: true),
                    GradeForProduct = table.Column<int>(nullable: false),
                    changID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_users_changs_changID",
                        column: x => x.changID,
                        principalTable: "changs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_masters_changID",
                table: "masters",
                column: "changID");

            migrationBuilder.CreateIndex(
                name: "IX_products_changID",
                table: "products",
                column: "changID");

            migrationBuilder.CreateIndex(
                name: "IX_users_changID",
                table: "users",
                column: "changID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "masters");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "changs");
        }
    }
}
