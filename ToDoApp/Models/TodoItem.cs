﻿namespace ToDoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsCompleted { get => _isCompleted; 
            set {

                _isCompleted = value;
                if (value)
                {
                    DateCompleted = DateTime.Now;
                }
            
            } }
        public DateTime DateCompleted { get; set; }

        private bool _isCompleted;

    }
}
