namespace ToDoApp.Models
{


    public static class ToDoItemRepository
    {
        private static List<TodoItem> TodoItems = new List<TodoItem>()
        {
            new TodoItem {  Id = 1, Name = "TodoItem1" },
            new TodoItem {  Id = 2, Name = "TodoItem2" },
            new TodoItem {  Id = 3, Name = "TodoItem3" },
            new TodoItem {  Id = 4, Name = "TodoItem4" },
            new TodoItem {  Id = 5, Name = "TodoItem5"},
            new TodoItem {  Id = 6, Name = "TodoItem6"},
            new TodoItem {  Id = 7, Name = "TodoItem7"},
            new TodoItem {  Id = 8, Name = "TodoItem8"},
            new TodoItem {  Id = 9, Name = "TodoItem9"},
            new TodoItem {  Id = 10, Name = "TodoItem10"},
            new TodoItem {  Id = 11, Name = "TodoItem11"},
            new TodoItem {  Id = 12, Name = "TodoItem12"},
            new TodoItem {  Id = 13, Name = "TodoItem13"},
        };

        public static void AddTodoItem(TodoItem TodoItem)
        {
            if (TodoItems.Count > 0)
            {
                var maxId = TodoItems.Max(s => s.Id);
                TodoItem.Id = maxId + 1;
                TodoItems.Add(TodoItem);
            }
            else
            {
                TodoItem.Id = 1;
                TodoItems.Add(TodoItem);
            }
          
        }

        public static List<TodoItem> GetItems()
        {
            var sortedItems = TodoItems.OrderBy(x => x.IsCompleted).ThenByDescending(x => x.Id).ToList();
            return sortedItems;
        }

       
        public static TodoItem? GetTodoItemById(int Id)
        {
            TodoItem? TodoItem = TodoItems.FirstOrDefault(s => s.Id == Id);

            if (TodoItem != null)
            {
                return new TodoItem
                {
                    Id = TodoItem.Id,
                    Name = TodoItem.Name,
                };
            }

            return null;
        }

        public static void UpdateTodoItem(int TodoItemId, TodoItem TodoItem)
        {
            if (TodoItemId != TodoItem.Id) return;

            var TodoItemToUpdate = TodoItems.FirstOrDefault(s => s.Id == TodoItemId);
            if (TodoItemToUpdate != null)
            {
                TodoItemToUpdate.Name = TodoItem.Name;
            }
        }

        public static void DeleteTodoItem(int TodoItemId)
        {
            var TodoItem = TodoItems.FirstOrDefault(s => s.Id == TodoItemId);
            if (TodoItem != null)
            {
                TodoItems.Remove(TodoItem);
            }
        }

        public static List<TodoItem> SearchTodoItems(string TodoItemFilter)
        {
            return TodoItems.Where(s => s.Name.Contains(TodoItemFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}


