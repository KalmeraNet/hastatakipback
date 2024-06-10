using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
public static class ListFunctions
{
    public class ListRequest
    {
        public string UserId { get; set; } = string.Empty;
    }
    public class ListResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Tip { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int CostType { get; set; }
    }


    public static async Task<Results<Ok<ListResult[]>, BadRequest>> GetServerList([FromBody] ListRequest user)
    {
        await Task.Delay(100);

        var result = new ListResult[]
        {
           new ListResult{
             Id = 0,
            Name = "Lorem",
            Title = "Lorem ipsum",
            Tip = "Lorem ipsum",
            Price = "Lorem ipsum",
            Date = "Lorem ipsum",
            CostType = 200,
            },
           new ListResult{
            Id = 1,
            Name = "Lorem",
            Title = "Lorem ipsum",
            Tip = "Lorem ipsum",
            Price = "Lorem ipsum",
            Date = "Lorem ipsum",
            CostType = 100,
            }
        };

        return TypedResults.Ok(result);
    }
}