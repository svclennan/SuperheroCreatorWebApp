using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class removeForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Superheroes_PrimaryAbilities_PrimaryAbilityId",
                table: "Superheroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Superheroes_SecondaryAbilities_SecondaryAbilityId",
                table: "Superheroes");

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
                name: "PrimaryAbility",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryAbility",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbility",
                table: "Superheroes");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryAbilityId",
                table: "Superheroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryAbilityId",
                table: "Superheroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
