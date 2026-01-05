using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkTaskList.Models;

namespace WorkTaskList.Services
{
    public class TaskService
    {
        private List<TaskItem> _tasks = new();
        private readonly string _filePath = "Data/tasks.json";

        public List<TaskItem> GetAll()
        {
            return _tasks;
        }

        public void Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return;

            _tasks.Add(new TaskItem
            {
                Title = title
            });

            Save();
        }

        public void Toggle(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return;

            task.IsCompleted = !task.IsCompleted;
            Save();
        }

        public void Delete(Guid id)
        {
            _tasks.RemoveAll(t => t.Id == id);
            Save();
        }

        public void Load()
        {
            if (!File.Exists(_filePath)) return;

            var json = File.ReadAllText(_filePath);
            _tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new();
        }

        private void Save()
        {
            Directory.CreateDirectory("Data");

            var json = JsonSerializer.Serialize(
                _tasks,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(_filePath, json);
        }
    }
}
