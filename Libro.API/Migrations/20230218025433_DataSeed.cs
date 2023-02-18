using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libro.API.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateRegistered", "Description", "Latitud", "Longitud", "Reference", "Status", "Ubigeo" },
                values: new object[] { 1, new DateTime(2023, 2, 17, 21, 54, 30, 709, DateTimeKind.Local).AddTicks(6566), "Calle Alberto Arispe 131", 0m, 0m, "A media cuadra del óvalo", true, "010101" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateRegistered", "Description", "Latitud", "Longitud", "Reference", "Status", "Ubigeo" },
                values: new object[] { 2, new DateTime(2023, 2, 17, 21, 54, 30, 709, DateTimeKind.Local).AddTicks(6569), "Calle Las fresias", 0m, 0m, "A media cuadra de la comisaria", true, "010102" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateRegistered", "Description", "Latitud", "Longitud", "Reference", "Status", "Ubigeo" },
                values: new object[] { 3, new DateTime(2023, 2, 17, 21, 54, 30, 709, DateTimeKind.Local).AddTicks(6571), "Av. Paz Soldán 203", 0m, 0m, "A un costado del Hospital de la mujer", true, "010101" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateRegistered", "Description", "Latitud", "Longitud", "Reference", "Status", "Ubigeo" },
                values: new object[] { 4, new DateTime(2023, 2, 17, 21, 54, 30, 709, DateTimeKind.Local).AddTicks(6572), "Av. Independencia 304", 0m, 0m, "Intersección con la calle Victor Lira", true, "010102" });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Personal" });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Comercial" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "Genre", "LastName", "Name" },
                values: new object[] { 1, new DateTime(1995, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 'M', "Palomino", "Jean" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "Genre", "LastName", "Name" },
                values: new object[] { 2, new DateTime(2007, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 'F', "Palomino", "Melissa" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "Genre", "LastName", "Name" },
                values: new object[] { 3, new DateTime(1995, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 'M', "Quispe", "Edson" });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "AgencyType", "Name", "PersonId", "Status" },
                values: new object[] { 1, 0, "La Joya", 1, true });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "Id", "AgencyType", "Name", "PersonId", "Status" },
                values: new object[] { 2, 1, "Independencia", 2, true });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Acronym", "DocumentTypeId", "HasSerie", "Name", "SunatCode" },
                values: new object[] { 1, "DNI", 1, false, "Documento Nacional de Identidad", "01" });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Acronym", "DocumentTypeId", "HasSerie", "Name", "SunatCode" },
                values: new object[] { 2, "RUC", 1, false, "Registro Unico del Contribuyente", "02" });

            migrationBuilder.InsertData(
                table: "PersonAddresses",
                columns: new[] { "Id", "AddressId", "IsFiscal", "PersonId" },
                values: new object[] { 1, 1, true, 1 });

            migrationBuilder.InsertData(
                table: "PersonAddresses",
                columns: new[] { "Id", "AddressId", "IsFiscal", "PersonId" },
                values: new object[] { 2, 2, false, 2 });

            migrationBuilder.InsertData(
                table: "AgencyAddresses",
                columns: new[] { "Id", "AddressId", "AgencyId", "Current" },
                values: new object[] { 1, 3, 1, true });

            migrationBuilder.InsertData(
                table: "AgencyAddresses",
                columns: new[] { "Id", "AddressId", "AgencyId", "Current" },
                values: new object[] { 2, 4, 2, false });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "AgencyId", "ClaimedAmount", "Description", "PersonId", "Request", "Response" },
                values: new object[] { 1, 1, 120m, "La mercadería llegó rota", 3, "Reparación de la mercadería", "" });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "AgencyId", "ClaimedAmount", "Description", "PersonId", "Request", "Response" },
                values: new object[] { 2, 2, 40m, "El envío se realizó desde Arequipa hacia la joya, la mercadería aún no llega", 3, "Devolución del dinero invertido en el traslado", "" });

            migrationBuilder.InsertData(
                table: "PersonDocuments",
                columns: new[] { "Id", "DocumentId", "Number", "PersonId", "Serie" },
                values: new object[] { 1, 1, "71942776", 1, "" });

            migrationBuilder.InsertData(
                table: "PersonDocuments",
                columns: new[] { "Id", "DocumentId", "Number", "PersonId", "Serie" },
                values: new object[] { 2, 1, "81748596", 2, "" });

            migrationBuilder.InsertData(
                table: "PersonDocuments",
                columns: new[] { "Id", "DocumentId", "Number", "PersonId", "Serie" },
                values: new object[] { 3, 1, "71942774", 3, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgencyAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AgencyAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonDocuments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonDocuments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonDocuments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DocumentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
