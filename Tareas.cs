using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tareas
{
    public class Tareas
    {
         [JsonPropertyName("userId")]
        public int UserId{ get; set;}
         [JsonPropertyName("id")]
        public int Id{ get; set;}
         [JsonPropertyName("title")]
        public string Titulo{ get; set;}
         [JsonPropertyName("completed")]
        public bool Completado{ get; set;}
    }
}
/*"userId": 1,
    "id": 1,
    "title": "delectus aut autem",
    "completed": false*/