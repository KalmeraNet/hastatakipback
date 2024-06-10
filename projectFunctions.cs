using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

public static class ProjectFunctions
{
    public class ProjectRequest
    {
        public string UserId { get; set; } = string.Empty;
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }

    public static async Task<Results<Ok<Project[]>, BadRequest>> GetServerProject([FromBody] ProjectRequest user)
    {
        await Task.Delay(100);

        var result = new Project[] {
            new Project{
                Id = 1,
                Name = "EX9536-4388",
                Title = "Phase 3b",
            },
            new Project{
                Id = 2,
                Name = "NN1436-4481",
                Title = "Phase 3a",
            },
            new Project{
                Id = 3,
                Name = "NN1535-4591",
                Title = "Phase 3a",
            },
        };

        return TypedResults.Ok(result);
    }
}
