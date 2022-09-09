using System;
namespace VetEnCasa.App.Dominio
{
    public class VisitaDomi
    {
        public int Id {get;set;}
      /// Cada uno de los atributos de la clase VisitaDomi
        public DateTime FechaVisita{get;set;}
        
        public Double Temperatura{get;set;}

        public int FreRespiratoria{get;set;}

        public int FreCardiaca{get;set;}
        
        public Boolean EstadoAnimo{get;set;}
        
    }
}