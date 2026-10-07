using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Pages.Todos
{
    public class DeleteModel : PageModel
    {
        private readonly ITodoStore _store;

        public DeleteModel(ITodoStore store)
        {
            _store = store;
        }

        public Todo? Todo { get; private set; }
        public IActionResult OnGet(Guid id)
        {
            Todo = _store.Get(id);
            if (Todo is null)
            {
                TempData["ErrorMessage"] = $"Todo with id {id} not found.";
                return RedirectToPage("/Todos/Index");
            }

            return Page();
        }
        public IActionResult OnPost(Guid id)
        {
            var ok = _store.Delete(id);
            if (!ok)
            {
                TempData["ErrorMessage"] = $"Todo with id {id} not found.";
                return RedirectToPage("/Todos/Index");
            }
            TempData["Message"] = $"Todo '{id}' deleted successfully.";
            return RedirectToPage("/Todos/Index");
        }
    }
}
