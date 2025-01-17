using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoNomes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tarefa",
                table: "Tarefas",
                newName: "Trf_Tarefa");

            migrationBuilder.RenameColumn(
                name: "RegistroUsuario",
                table: "Tarefas",
                newName: "Trf_Registro");

            migrationBuilder.RenameColumn(
                name: "Registro",
                table: "Tarefas",
                newName: "Trf_NomeUsuario");

            migrationBuilder.RenameColumn(
                name: "DataExpiracao",
                table: "Tarefas",
                newName: "Trf_DataExpiracao");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Tarefas",
                newName: "Trf_DataCriacao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tarefas",
                newName: "Trf_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trf_Tarefa",
                table: "Tarefas",
                newName: "Tarefa");

            migrationBuilder.RenameColumn(
                name: "Trf_Registro",
                table: "Tarefas",
                newName: "RegistroUsuario");

            migrationBuilder.RenameColumn(
                name: "Trf_NomeUsuario",
                table: "Tarefas",
                newName: "Registro");

            migrationBuilder.RenameColumn(
                name: "Trf_DataExpiracao",
                table: "Tarefas",
                newName: "DataExpiracao");

            migrationBuilder.RenameColumn(
                name: "Trf_DataCriacao",
                table: "Tarefas",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "Trf_Id",
                table: "Tarefas",
                newName: "Id");
        }
    }
}
