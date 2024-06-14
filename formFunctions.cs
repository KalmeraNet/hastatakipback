using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
public static class FormFunctions
{
    public class FormRequest
    {
        public int Id { get; set; }
    }
    public class FormResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Tip { get; set; } = string.Empty;
        public int Price { get; set; } = 1;
        public string Date { get; set; } = string.Empty;
        public string Po { get; set; } = string.Empty;
        public bool Status { get; set; } = false;

    }

    public static async Task<Results<Ok<FormResult>, BadRequest>> GetServerForm([FromBody] FormRequest user)
    {
        await Task.Delay(100);


        var result = new FormResult
        {
            Id = 1,
            Name = "Lorem",
            Title = "Lorem ipsum",
            Tip = "Lorem ipsum",
            Price = 1,
            Date = "Lorem ipsum",
            Po = "Lorem ipsum",
            Status = false,
        };

        return TypedResults.Ok(result);
    }
}