// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using espaciousuario;

Console.WriteLine("Hello, World!");
HttpClient cliente = new HttpClient();
string url ="https://jsonplaceholder.typicode.com/users";
HttpResponseMessage response = await cliente.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
List<Usuarios> listaUsuario = JsonSerializer.Deserialize<List<Usuarios>>(responseBody);

for (int i = 0; i < 5; i++)
{
   System.Console.WriteLine($"Cliente[{i+1}]");
    System.Console.WriteLine($"Nombre: {listaUsuario[i].Nombre}\n Correo:{listaUsuario[i].Mail}\n Domicilio:{listaUsuario[i].Domicilio.Calle}\n");

   
}