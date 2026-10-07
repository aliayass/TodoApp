using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Pages.Todos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Todo Todo { get; set; } = new();
        private readonly ITodoStore _store;

        public EditModel(ITodoStore store)
        {
            _store = store;
        }

        public IActionResult OnGet(Guid id)
        {
            var item = _store.Get(id);
            if(item is null)
            {
                TempData["ErrorMessage"] = $"Todo with id {id} not found.";
                return RedirectToPage("/Todos/Index");
            }
            Todo = new Todo
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                Priority = item.Priority,
                DueDate = item.DueDate,
                IsDone = item.IsDone
            };
            return Page();

        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var ok = _store.Update(Todo);
            if (!ok)
            {
                TempData["ErrorMessage"] = $"Todo with id {Todo.Id} not found.";
                return RedirectToPage("/Todos/Index");
            }
            TempData["Message"] = $"Todo '{Todo.Title}' updated successfully.";
            return RedirectToPage("/Todos/Index");
        }
    }
}
