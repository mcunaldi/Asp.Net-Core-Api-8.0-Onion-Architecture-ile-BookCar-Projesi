using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_RentACarProcess2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcess_Customer_CustomerID",
                table: "RentACarProcess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess");

            migrationBuilder.RenameTable(
                name: "RentACarProcess",
                newName: "RentACarProcesses");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CustomerID",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcess_CarID",
                table: "RentACarProcesses",
                newName: "IX_RentACarProcesses_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses",
                column: "RentACarProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Cars_CarID",
                table: "RentACarProcesses",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcesses_Customer_CustomerID",
                table: "RentACarProcesses",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Cars_CarID",
                table: "RentACarProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProcesses_Customer_CustomerID",
                table: "RentACarProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProcesses",
                table: "RentACarProcesses");

            migrationBuilder.RenameTable(
                name: "RentACarProcesses",
                newName: "RentACarProcess");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_CustomerID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProcesses_CarID",
                table: "RentACarProcess",
                newName: "IX_RentACarProcess_CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProcess",
                table: "RentACarProcess",
                column: "RentACarProcessID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Cars_CarID",
                table: "RentACarProcess",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProcess_Customer_CustomerID",
                table: "RentACarProcess",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
