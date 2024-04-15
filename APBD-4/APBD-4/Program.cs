using APBD_4.Animals;
using APBD_4.Visits;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

app.MapGet("/animals", () => DataBase.Animals);

app.MapGet("/animals/{id}", (int id) =>
{
    var animal = DataBase.Animals.FirstOrDefault(a => a.Id == id);
    return animal is null ? Results.NotFound() : Results.Ok(animal);
});

app.MapPost("/animals", (Animal animal) =>
{
    animal.Id = DataBase.Animals.Count + 1;
    DataBase.Animals.Add(animal);
    return Results.Created($"/animals/{animal.Id}", animal);
});

app.MapPut("/animals/{id}", (int id, Animal updatedAnimal) =>
{
    var animal = DataBase.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) 
        return Results.NotFound();

    animal.Name = updatedAnimal.Name;
    animal.Category = updatedAnimal.Category;
    animal.Weight = updatedAnimal.Weight;
    animal.FurColor = updatedAnimal.FurColor;

    return Results.Ok(animal);
});

app.MapDelete("/animals/{id}", (int id) =>
{
    var animal = DataBase.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) return Results.NotFound();

    DataBase.Animals.Remove(animal);
    return Results.Ok();
});

app.MapGet("/visits", () => DataBase.Visits);

app.MapPost("/visits", (Visit visit) =>
{
    visit.Id = DataBase.Visits.Count + 1;
    DataBase.Visits.Add(visit);
    return Results.Created($"/visits/{visit.Id}", visit);
});

app.Run();
