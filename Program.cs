var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", p =>
    {
        p.AllowAnyOrigin()
       .AllowAnyHeader()
       .AllowAnyOrigin()
       .AllowAnyOrigin()
       .Build();
    });
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
// app.UseHttpsRedirection();
app.MapGet("/v1/getServerUserX", () => "Test");


app.MapPost("/v1/getServerUser", UserFunctions.GetServerUser)
.WithName("GetServerUser")
.WithOpenApi();

app.MapPost("/v1/getLoginUser", UserFunctions.GetLogin)
.WithName("GetLoginUser")
.WithOpenApi();

app.MapPost("/v1/getServerProject", ProjectFunctions.GetServerProject)
.WithName("GetServerProject")
.WithOpenApi();

app.MapPost("/v1/getServerLocation", LocationFunctions.GetServerLocation)
.WithName("GetServerLocation")
.WithOpenApi();

app.MapPost("/v1/getServerForms", FormsFunctions.GetServerForms)
.WithName("GetServerForms")
.WithOpenApi();

app.MapPost("/v1/getServerList", ListFunctions.GetServerList)
.WithName("GetServerList")
.WithOpenApi();

app.MapPost("/v1/getServerForm", FormFunctions.GetServerForm)
.WithName("GetServerForm")
.WithOpenApi();



app.Run();