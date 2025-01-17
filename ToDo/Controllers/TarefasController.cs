using Microsoft.AspNetCore.Mvc;
using ToDo.Dtos;
using ToDo.Interfaces;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TarefasController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefasController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        public IActionResult Index()
        {
            List<TarefaModel> tarefas = _tarefaRepositorio.BuscarTodos();
            return View(tarefas);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(TarefaModel tarefa)
        {
            _tarefaRepositorio.Adicionar(tarefa);
            return RedirectToAction("Index");
        }
        [HttpPut]
        public IActionResult Editar(int id, TarefaModel tarefa)
        {
            _tarefaRepositorio.Atualizar(id, tarefa);
            return RedirectToAction("Index");
        }
    }
}
