using Microsoft.AspNetCore.Http.Features;
using TodoApi;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var db = new TodoContext();

app.MapGet("/todos", IResult () => TypedResults.Ok(db.Todos
    .Select(item => 
    new {
        id = item.Id, 
        name = item.Name, 
        isdone = item.IsDone
})));

app.MapGet("/todos/{id}", IResult (int id) => {
    var item = db.Todos
    .Find(id);
    
    if(item != null)
        return TypedResults.Ok(item);
    else
        return TypedResults.NotFound(new {});  
});

app.MapPost("/todos", IResult (string item_name) => {
    var item = db.Add(new TodoItem {Name = item_name, IsDone = false});
    db.SaveChanges();

    return TypedResults.Created($"/todos/{item.Entity.Id}", item.Entity.Id);
});

app.MapDelete("/todos/{id}", IResult (int id) =>
{
    var item = db.Todos.Find(id);
    if(item != null)
    {
        db.Todos.Remove(item);
        db.SaveChanges();
    }
    
    return TypedResults.NoContent();
});

app.Run();
