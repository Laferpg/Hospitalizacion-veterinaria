using System;
namespace VetEnCasa.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
      /// Cada uno de los atributos de la clase Mascota
        public string Nombre{get;set;}
        
        public Sexo Sexo{get;set;}
        
        public string Raza{get;set;}
        
        public DateTime FechaNacimiento{get;set;}
        
    }
}