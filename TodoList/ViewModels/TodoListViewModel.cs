using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TodoList.Models;
using Xamarin.Forms;

namespace TodoList.ViewModels
{
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("Todo 1", true));
        }
        public string NewTodoInputValue { get; set; }
        public ICommand AddTodoCommand => new Command(AddTodoItem);

        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = string.Empty;
        }
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);

        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }
    }
}
