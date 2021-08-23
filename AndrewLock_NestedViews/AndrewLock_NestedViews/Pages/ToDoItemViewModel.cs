﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewLock_NestedViews.Pages
{
    public class ToDoItemViewModel
    {
        public int Id { get; }
        public string Title { get; }
        public bool IsComplete => Tasks.Count == 3;
        public List<string> Tasks { get; }
        public ToDoItemViewModel(int id, string title, params string[] tasks)
        {
            Id = id;
            Title = title;
            Tasks = new List<string>(tasks);
        }
    }
}
