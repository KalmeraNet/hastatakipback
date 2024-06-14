using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
public static class LocationFunctions
{
    public class LocationRequest
    {
        public int Id { get; set; }

    }
    public class LocationResult
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

    }


    public static async Task<Results<Ok<LocationResult[]>, BadRequest>> GetServerLocation([FromBody] LocationRequest user)
    {
        await Task.Delay(100);

        var result = new LocationResult[]{
       new LocationResult {
            Id = 1,
            Name = "Ege University School of Medicine",
            Title = "Cardiology Department",

        },
       new LocationResult {
            Id = 2,
            Name = "Istanbul University Cerrahpasa",
            Title = "Medical Faculty",

        },
       new LocationResult {
            Id = 3,
            Name = "Aydin Adnan Menderes University",
            Title = "Nephrology",

        },
       new LocationResult {
            Id = 4,
            Name = "Eskisehir Osmangazi University",
            Title = "Cardio",

        },
    };
        return TypedResults.Ok(result);
    }
}