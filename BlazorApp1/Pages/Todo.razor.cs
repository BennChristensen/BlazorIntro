using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class Todo
    {
        public List<TodoItem> Todos { get; } = new List<TodoItem>();
        public string NewTodo { get; set; }

        public void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(NewTodo))
            {
                Todos.Add(new TodoItem { IsCompleted = false, Title = NewTodo });
                NewTodo = "";
            }
        }

    }
}
