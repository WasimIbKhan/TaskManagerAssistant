using TaskManagerAssistant.Client.Models;

namespace TaskManagerAssistant.Client;

public class TaskClient
{
    private static readonly List<TaskItem> tasks = new List<TaskItem>()
    {
        new TaskItem { Id = 1, Title = "Study Group", Description = "Discuss ideas about life, society, state, and the universe", DueDate = DateTime.Parse("2023-04-02 10:15"), IsCompleted = false },
        new TaskItem { Id = 2, Title = "Activity with Friends", Description = "Hang out with friends", DueDate = DateTime.Parse("2023-04-02 13:15"), IsCompleted = false },
        new TaskItem { Id = 3, Title = "Read Book", Description = "Read book about problem solving", DueDate = DateTime.Parse("2023-04-02 22:00"), IsCompleted = false },
        new TaskItem { Id = 4, Title = "Freelance Work", Description = "Freelance work from 12:00 to 20:00", DueDate = DateTime.Parse("2023-04-03 12:00"), IsCompleted = false },
        new TaskItem { Id = 5, Title = "Read History Book", Description = "Read book about history", DueDate = DateTime.Parse("2023-04-03 21:00"), IsCompleted = false },
        new TaskItem { Id = 6, Title = "Gym", Description = "Workout session", DueDate = DateTime.Parse("2023-04-03 22:30"), IsCompleted = false },
        new TaskItem { Id = 7, Title = "Freelance Work", Description = "Freelance work from 12:00 to 19:00", DueDate = DateTime.Parse("2023-04-04 12:00"), IsCompleted = false },
        new TaskItem { Id = 8, Title = "Study Group", Description = "Discuss ideas about life, society, state, and the universe", DueDate = DateTime.Parse("2023-04-04 19:00"), IsCompleted = false },
        new TaskItem { Id = 9, Title = "Read Economy Book", Description = "Read book on economy", DueDate = DateTime.Parse("2023-04-04 23:00"), IsCompleted = false },
        new TaskItem { Id = 10, Title = "Freelance Work - Programming", Description = "Freelance working-programming", DueDate = DateTime.Parse("2023-04-05 09:00"), IsCompleted = false },
        new TaskItem { Id = 11, Title = "Football with Brothers", Description = "Football in the community", DueDate = DateTime.Parse("2023-04-05 17:00"), IsCompleted = false },
        new TaskItem { Id = 12, Title = "Gym", Description = "Workout session", DueDate = DateTime.Parse("2023-04-05 22:30"), IsCompleted = false },
        new TaskItem { Id = 13, Title = "Freelance Work", Description = "Freelance work", DueDate = DateTime.Parse("2023-04-06 12:00"), IsCompleted = false },
        new TaskItem { Id = 14, Title = "Public Speaking Group", Description = "Public speaking group and round table discussion", DueDate = DateTime.Parse("2023-04-06 20:00"), IsCompleted = false },
        new TaskItem { Id = 15, Title = "Reading", Description = "Read book on Quran or philosophy", DueDate = DateTime.Parse("2023-04-06 23:00"), IsCompleted = false },
        new TaskItem { Id = 16, Title = "Jummah Prayer", Description = "Jummah prayer", DueDate = DateTime.Parse("2023-04-07 11:45"), IsCompleted = false },
        new TaskItem { Id = 17, Title = "Side-Hustle/Project", Description = "Creating an AI learning platform", DueDate = DateTime.Parse("2023-04-07 13:00"), IsCompleted = false },
        new TaskItem { Id = 18, Title = "Gym", Description = "Workout session", DueDate = DateTime.Parse("2023-04-07 22:00"), IsCompleted = false },
        new TaskItem { Id = 19, Title = "Personal Project", Description = "Upskill for work", DueDate = DateTime.Parse("2023-04-08 12:00"), IsCompleted = false },
        new TaskItem { Id = 20, Title = "Reading", Description = "Read political book", DueDate = DateTime.Parse("2023-04-08 12:00"), IsCompleted = false }
    };

    public static int GetNextTaskId()
    {
        return tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1;
    }

    public static TaskItem[] GetTasks()
    {
        return tasks.ToArray();
    }

    public static TaskItem GetTask(int id)
    {
        return tasks.Find(t => t.Id == id);
    }

    public static void AddTask(TaskItem task)
    {
        tasks.Add(task);
    }

    public static void UpdateTask(TaskItem task)
    {
        var index = tasks.FindIndex(t => t.Id == task.Id);
        tasks[index] = task;
    }

    public static void DeleteTask(int id)
    {
        var index = tasks.FindIndex(t => t.Id == id);
        tasks.RemoveAt(index);
    }
}
