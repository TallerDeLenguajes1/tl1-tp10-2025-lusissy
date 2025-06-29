using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace espaciousuario
{
    public class Geo
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }

    public class Direccion
    {
        [JsonPropertyName("street")]
        public string Calle { get; set; }  
        [JsonPropertyName("suite")]
        public string Departamento { get; set; } 
        [JsonPropertyName("city")]
        public string Ciudad { get; set; }
        [JsonPropertyName("zipcode")]       
        public string Codigo { get; set; }
        [JsonPropertyName("geo")] 
        public Geo Geo { get; set; }
    }

    public class Empresa
    {
        [JsonPropertyName("name")]
        public string Nombre { get; set; }  
        [JsonPropertyName("catchPhrase")]     
        public string Eslogan { get; set; }      
        [JsonPropertyName("bs")] 
        public string Rubro { get; set; }        
    }

    public class Usuarios
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Nombre { get; set; }       
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("email")]
        public string Mail { get; set; }   
        [JsonPropertyName("address")]      
        public Direccion Domicilio { get; set; }
        [JsonPropertyName("phone")]  
        public string Telefono { get; set; }
        [JsonPropertyName("website")]     
        public string SitioWeb { get; set; }   
         [JsonPropertyName("company")]  
        public Empresa Company { get; set; }
    }
}

/*  {
    "id": 1,
    "name": "Leanne Graham",
    "username": "Bret",
    "email": "Sincere@april.biz",
    "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }
    },
    "phone": "1-770-736-8031 x56442",
    "website": "hildegard.org",
    "company": {
      "name": "Romaguera-Crona",
      "catchPhrase": "Multi-layered client-server neural-net",
      "bs": "harness real-time e-markets"
    }
  },*/