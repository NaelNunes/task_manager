using task_manager.Data;
using task_manager.Models;
using Microsoft.EntityFrameworkCore;
using Task = task_manager.Models.Task;

namespace task_manager.Services
{
    public class TaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Task>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Task?> GetByIdAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return null;
            }

            return task;
        }

        public async Task<Task?> CreateAsync(Task task)
        {
            if (task == null)
            {
                return null;
            }
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<bool> UpdateAsync(int id, Task update)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null) return false;

            task = update;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null) return false;

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
