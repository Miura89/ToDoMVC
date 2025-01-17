using Dapper;
using System.Data;
using ToDo.Data;
using ToDo.Dtos;
using ToDo.Interfaces;
using ToDo.Models;

namespace ToDo.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly IDbConnection _context;

        public TarefaRepositorio(IDbConnection context)
        {
            _context = context;
        }

        public void Adicionar(TarefaModel tarefa)
        {
            var sql = @"INSERT INTO Tarefas(Trf_Id, Trf_Registro, Trf_NomeUsuario, Trf_Tarefa, Trf_DataCriacao, Trf_DataExpiracao)
                        VALUES(@Id, @Registro, @NomeUsuario, @Tarefa, @DataCriacao, @DataExpiracao)";
            var entidade = _context.Execute(sql, new
            {
                Id = GeradorId(),
                Registro = "P" + GeradorRegistro().ToString(),
                NomeUsuario = tarefa.Trf_NomeUsuario,
                Tarefa = tarefa.Trf_Tarefa,
                DataCriacao = DateTime.Now,
                DataExpiracao = tarefa.Trf_DataExpiracao
            });
        }
        public void Atualizar(int id, TarefaModel tarefa)
        {
            var sql = @"UPDATE tarefas 
                        SET trf_nomeusuario = @NomeUsuario,
                            trf_tarefa = @Tarefa, 
                            trf_dataexpiracao = @DataExpiracao
                        WHERE trf_id = @Id";
            int linhasAfetadas = _context.Execute(sql, new
            {
                Id = id,
                NomeUsuario = tarefa.Trf_NomeUsuario,
                Tarefa = tarefa.Trf_Tarefa,
                DataExpiracao = tarefa.Trf_DataExpiracao
            });
            if( linhasAfetadas < 0 )
            {
                throw new Exception("Nenhuma tarefa foi encontrada com o ID fornecido");
            }
        }

        public List<TarefaModel> BuscarTodos()
        {
            var sql = @"SELECT *
                        FROM tarefas";
            var entidades = _context.Query<TarefaModel>(sql).ToList();
            return entidades;
        }
        public List<TarefaModel> FiltrarPorId()
        {
            var sql = @"SELECT *
                        FROM tarefas
                        Order by trf_id";
            var entidades = _context.Query<TarefaModel>(sql).ToList();
            return entidades;
        }
        private static int GeradorId()
        {
            Random rdn = new();
            return rdn.Next(0, 9999);
        }
        private static string GeradorRegistro()
        {
            Random rdn = new();
            return rdn.Next(0, 9999).ToString();
        }
    }
}
