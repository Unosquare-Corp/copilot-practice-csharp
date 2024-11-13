// Services/ItemService.cs

using CopilotDemo.Models;

namespace CopilotDemo.Services
{
    public class ItemService : IItemService
    {
        private readonly List<Item> _items = new();

        // TODO: Implement methods for IItemService interface.
        // Instructions:
        // 1. Use Copilot to generate implementations for GetAll, GetById, Add, Update, and Delete methods.
        // 2. Ensure the methods are correctly implemented.

        // Code to be generated by Copilot:

        // public IEnumerable<Item> GetAll() { /* ... */ }
        // public Item GetById(int id) { /* ... */ }
        // public void Add(Item item) { /* ... */ }
        // public void Update(Item item) { /* ... */ }
        // public void Delete(int id) { /* ... */ }

        // TODO: The 'Add' method is poorly written and needs refactoring.
        // Instructions:
        // 1. The current 'Add' method does not check for duplicates and has poor error handling.
        // 2. Use Copilot to refactor the 'Add' method to:
        //    - Check if an item with the same Id already exists.
        //    - Throw an exception if it does.
        //    - Make the code more readable, efficient, and defensive.
        // 3. Follow the step-by-step instructions below.

        // Poorly written 'Add' method:

        /*
        public void Add(Item item)
        {
            _items.Add(item);
        }
        */

        // Instructions for refactoring:
        // 1. Select the 'Add' method code.
        // 2. Write a comment above it: '// TODO: Refactor this method to be defensive and efficient.'
        // 3. Place your cursor inside the method body.
        // 4. Start typing 'if (' and observe Copilot's suggestions.
        // 5. Use Copilot to help you write code that checks for duplicates and handles errors appropriately.

        // Example of refactored 'Add' method to be generated by Copilot:

        /*
        public void Add(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (_items.Any(i => i.Id == item.Id))
            {
                throw new ArgumentException("An item with the same Id already exists.");
            }

            _items.Add(item);
        }
        */
    }
}
