using System;
using System.Text.Json;
using tareas;

HttpClient cliente = new HttpClient();
string url= "https://jsonplaceholder.typicode.com/todos/";
HttpResponseMessage response = await cliente.GetAsync(url);
response.EnsureSuccessStatusCode();
 
string responseBody = await response.Content.ReadAsStringAsync();
List<Tareas> listaTareas = JsonSerializer.Deserialize<List<Tareas>>(responseBody);
Console.WriteLine("TAREAS PENDIENTE\n");
foreach (var tarea in listaTareas.FindAll(t => !t.Completado))
{
    Console.WriteLine($"\n[ID: {tarea.Id}] {tarea.Titulo} - PENDIENTE");
}
Console.WriteLine("TAREAS REALIZADAS\n");
foreach (var tarea in listaTareas.FindAll(t => t.Completado))
{
    Console.WriteLine($"\n[ID: {tarea.Id}] {tarea.Titulo} - REALIZADAS");
}
string archivoJson = JsonSerializer.Serialize(listaTareas, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("tareas.json", archivoJson);
Console.WriteLine("\nArchivo 'tareas.json' guardado correctamente.");

