using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
public static class FormsFunctions
{
    public class FormsRequest
    {
        public int Id { get; set; }
    }
    public class FormsResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }



    public static async Task<Results<Ok<FormsResult>, BadRequest>> GetServerForms([FromBody] FormsRequest user)
    {
        await Task.Delay(100);

        var result = new FormsResult
        {
            Id = 1,
            Name = "Lorem ",
            Title = "Developer",
        };

        return TypedResults.Ok(result);
    }
}