using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

public static class UserFunctions
{
    public class UserRequest
    {
        public string Id { get; set; } = string.Empty;

    }

    public class LoginRequest
    {
        public string Id { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class UserResult
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Initial { get; set; } = string.Empty;
    }


    private static async Task<UserResult> GetUser(string userId)
    {
        await Task.Delay(100);

        var result = new UserResult
        {
            Id = userId,
            FullName = "Andre Gözübüyükoğlu",
            Role = "Developer",
            Initial = "AG",
        };

        return result;
    }


    public static async Task<Results<Ok<UserResult>, BadRequest>> GetServerUser([FromBody] UserRequest user)
    {
        var result = await GetUser(user.Id ?? "");

        return TypedResults.Ok(result);
    }

    public static async Task<Results<Ok<UserResult>, BadRequest>> GetLogin([FromBody] LoginRequest loginRequest)
    {
        var result = await GetUser(loginRequest.Id ?? "");

        return TypedResults.Ok(result);
    }

}
