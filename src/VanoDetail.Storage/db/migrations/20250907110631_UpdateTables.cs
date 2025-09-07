using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanoDetail.Storage.db.migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_service_Appointments_AppointmentEntityId",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_AppointmentEntityId",
                table: "service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentEntityId",
                table: "service");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointment");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "appointment",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "appointment",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "TmBegin",
                table: "appointment",
                newName: "tm_begin");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "appointment",
                newName: "appointment_guid");

            migrationBuilder.RenameColumn(
                name: "DtAppointment",
                table: "appointment",
                newName: "dt_appointment");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "appointment",
                newName: "client_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "appointment",
                newName: "appointment_id");

            migrationBuilder.AddColumn<int>(
                name: "appointment_id",
                table: "service",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "appointment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "client_name",
                table: "appointment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointment",
                table: "appointment",
                column: "appointment_id");

            migrationBuilder.CreateIndex(
                name: "IX_service_appointment_id",
                table: "service",
                column: "appointment_id");

            migrationBuilder.AddForeignKey(
                name: "FK_service_appointment_appointment_id",
                table: "service",
                column: "appointment_id",
                principalTable: "appointment",
                principalColumn: "appointment_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_service_appointment_appointment_id",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_appointment_id",
                table: "service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointment",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "appointment_id",
                table: "service");

            migrationBuilder.RenameTable(
                name: "appointment",
                newName: "Appointments");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Appointments",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Appointments",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "tm_begin",
                table: "Appointments",
                newName: "TmBegin");

            migrationBuilder.RenameColumn(
                name: "dt_appointment",
                table: "Appointments",
                newName: "DtAppointment");

            migrationBuilder.RenameColumn(
                name: "client_name",
                table: "Appointments",
                newName: "ClientName");

            migrationBuilder.RenameColumn(
                name: "appointment_guid",
                table: "Appointments",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "Appointments",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentEntityId",
                table: "service",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_service_AppointmentEntityId",
                table: "service",
                column: "AppointmentEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_service_Appointments_AppointmentEntityId",
                table: "service",
                column: "AppointmentEntityId",
                principalTable: "Appointments",
                principalColumn: "Id");
        }
    }
}
