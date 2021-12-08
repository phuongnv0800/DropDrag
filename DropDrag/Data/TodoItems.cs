using System.Collections.Generic;

namespace DropDrag.Data
{
    public class TodoItems
    {
        public List<TodoItem> TodoItemList { get; set; } = new List<TodoItem>(1);
        public int Category { get; set; }
    }
}
