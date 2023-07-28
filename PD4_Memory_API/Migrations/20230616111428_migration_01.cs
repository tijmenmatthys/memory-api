using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PD4_Memory_API.Migrations
{
    /// <inheritdoc />
    public partial class migration_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Animal",
            //    columns: table => new
            //    {
            //        AnimalId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CutenessRating = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Animal", x => x.AnimalId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CombinationFound",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ImageId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CombinationFound", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Image",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
            //        Theme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Extention = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
            //        IsBack = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Image", x => x.Id);
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Animal");

            //migrationBuilder.DropTable(
            //    name: "CombinationFound");

            //migrationBuilder.DropTable(
            //    name: "Image");
        }
    }
}
