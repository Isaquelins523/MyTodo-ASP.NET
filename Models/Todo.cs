namespace MeuTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
