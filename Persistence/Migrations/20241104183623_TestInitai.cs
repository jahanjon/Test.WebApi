using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TestInitai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductAdTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrintKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrintKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    CopyCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPrice = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsCalculatePrice = table.Column<bool>(type: "bit", nullable: false),
                    MaxPage = table.Column<float>(type: "real", nullable: false),
                    MinPage = table.Column<float>(type: "real", nullable: false),
                    MinWidth = table.Column<float>(type: "real", nullable: false),
                    MaxWidth = table.Column<float>(type: "real", nullable: false),
                    MinLength = table.Column<float>(type: "real", nullable: false),
                    MaxLength = table.Column<float>(type: "real", nullable: false),
                    PrintMargin = table.Column<float>(type: "real", nullable: false),
                    IsCheckFile = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AdTypeId = table.Column<int>(type: "int", nullable: false),
                    IsIsolated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdts_ProductAdTypes_AdTypeId",
                        column: x => x.AdTypeId,
                        principalTable: "ProductAdTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductAdts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDelivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDelivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDelivers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductJeIds",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    JeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductJeIds", x => new { x.ProductId, x.JeId });
                    table.ForeignKey(
                        name: "FK_ProductJeIds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIsolated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAdtPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAdtId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdtPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAdtPrices_ProductAdts_ProductAdtId",
                        column: x => x.ProductAdtId,
                        principalTable: "ProductAdts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterialAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductMaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterialAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMaterialAttributes_ProductMaterials_ProductMaterialId",
                        column: x => x.ProductMaterialId,
                        principalTable: "ProductMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDeliverSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    ProductDeliverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDeliverSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDeliverSizes_ProductDelivers_ProductDeliverId",
                        column: x => x.ProductDeliverId,
                        principalTable: "ProductDelivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductDeliverSizes_ProductSizes_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdtPrices_ProductAdtId",
                table: "ProductAdtPrices",
                column: "ProductAdtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdts_AdTypeId",
                table: "ProductAdts",
                column: "AdTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdts_ProductId",
                table: "ProductAdts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDelivers_ProductId",
                table: "ProductDelivers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSizes_ProductDeliverId",
                table: "ProductDeliverSizes",
                column: "ProductDeliverId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliverSizes_ProductSizeId",
                table: "ProductDeliverSizes",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterialAttributes_ProductMaterialId",
                table: "ProductMaterialAttributes",
                column: "ProductMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_ProductId",
                table: "ProductMaterials",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAdtPrices");

            migrationBuilder.DropTable(
                name: "ProductDeliverSizes");

            migrationBuilder.DropTable(
                name: "ProductJeIds");

            migrationBuilder.DropTable(
                name: "ProductMaterialAttributes");

            migrationBuilder.DropTable(
                name: "ProductPrintKinds");

            migrationBuilder.DropTable(
                name: "ProductAdts");

            migrationBuilder.DropTable(
                name: "ProductDelivers");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.DropTable(
                name: "ProductAdTypes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
