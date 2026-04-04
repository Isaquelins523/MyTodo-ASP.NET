using System.ComponentModel.DataAnnotations;

namespace MeuTodo.ViewModels
{
    public class CreateTodoViewModels
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Title { get; set; }
    }
}
