using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AmCart.ProductModule.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    GUID = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnDate = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedOnDate = table.Column<DateTimeOffset>(nullable: false),
                    CreatedByUserID = table.Column<int>(nullable: false),
                    ModifiedByUserID = table.Column<int>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PolicyTypeID = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    ProductCode = table.Column<string>(maxLength: 50, nullable: false),
                    IRDACode = table.Column<string>(maxLength: 50, nullable: false),
                    ProposalIssueDaysLimit = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
