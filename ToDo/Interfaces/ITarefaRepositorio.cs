using ToDo.Dtos;
using ToDo.Models;

namespace ToDo.Interfaces
{
    public interface ITarefaRepositorio
    {
        void Adicionar(TarefaModel tarefa);
        void Atualizar(int id, TarefaModel tarefa);
        List<TarefaModel> BuscarTodos();
        List<TarefaModel> FiltrarPorId();
    }
}
