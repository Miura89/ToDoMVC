using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class TarefaModel
    {
        [Key]
        public int Trf_Id { get; set; }
        public string Trf_NomeUsuario { get; set; }
        public string Trf_Registro { get; set; }
        public string Trf_Tarefa { get; set; }
        public DateTime Trf_DataCriacao { get; set; }
        public DateTime Trf_DataExpiracao { get; set; }
    }
}
