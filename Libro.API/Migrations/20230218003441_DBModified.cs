using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libro.API.Migrations
{
    public partial class DBModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocumentTypes_TipoDocumentoId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "IsFiscal",
                table: "PersonDocuments");

            migrationBuilder.DropColumn(
                name: "IdPerson",
                table: "Agencies");

            migrationBuilder.RenameColumn(
                name: "TipoDocumentoId",
                table: "Documents",
                newName: "DocumentTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_TipoDocumentoId",
                table: "Documents",
                newName: "IX_Documents_DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId",
                principalTable: "DocumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocumentTypes_DocumentTypeId",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "DocumentTypeId",
                table: "Documents",
                newName: "TipoDocumentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                newName: "IX_Documents_TipoDocumentoId");

            migrationBuilder.AddColumn<bool>(
                name: "IsFiscal",
                table: "PersonDocuments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IdPerson",
                table: "Agencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocumentTypes_TipoDocumentoId",
                table: "Documents",
                column: "TipoDocumentoId",
                principalTable: "DocumentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
