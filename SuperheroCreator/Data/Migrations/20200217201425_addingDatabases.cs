using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class addingDatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimarySuperHeroAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SecondarySuperHeroAbility",
                table: "Superheroes");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryAbilityId",
                table: "Superheroes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryAbilityId",
                table: "Superheroes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PrimaryAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryAbilities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Superheroes_PrimaryAbilityId",
                table: "Superheroes",
                column: "PrimaryAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Superheroes_SecondaryAbilityId",
                table: "Superheroes",
                column: "SecondaryAbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Superheroes_PrimaryAbilities_PrimaryAbilityId",
                table: "Superheroes",
                column: "PrimaryAbilityId",
                principalTable: "PrimaryAbilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Superheroes_SecondaryAbilities_SecondaryAbilityId",
                table: "Superheroes",
                column: "SecondaryAbilityId",
                principalTable: "SecondaryAbilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Superheroes_PrimaryAbilities_PrimaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Superheroes_SecondaryAbilities_SecondaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropTable(
                name: "PrimaryAbilities");

            migrationBuilder.DropTable(
                name: "SecondaryAbilities");

            migrationBuilder.DropIndex(
                name: "IX_Superheroes_PrimaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropIndex(
                name: "IX_Superheroes_SecondaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "PrimaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbilityId",
                table: "Superheroes");

            migrationBuilder.AddColumn<string>(
                name: "PrimarySuperHeroAbility",
                table: "Superheroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondarySuperHeroAbility",
                table: "Superheroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
