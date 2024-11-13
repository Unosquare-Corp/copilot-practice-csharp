// Services/CategoryService.cs

using CopilotDemo.Models;

namespace CopilotDemo.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly List<Category> _categories = new();

        // TODO: Implement methods for ICategoryService interface.
        // Instructions:
        // 1. Use Copilot to generate implementations for GetAll, GetById, Add, Update, and Delete methods.
        // 2. Ensure the methods are correctly implemented and defensive.

        // Code to be generated by Copilot:

        // public IEnumerable<Category> GetAll() { /* ... */ }
        // public Category GetById(int id) { /* ... */ }
        // public void Add(Category category) { /* ... */ }
        // public void Update(Category category) { /* ... */ }
        // public void Delete(int id) { /* ... */ }

        // TODO: Ensure the 'Add' method checks for duplicates and handles null inputs.
        // Follow similar steps as in ItemService's 'Add' method.
    }
}