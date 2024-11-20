using System;

namespace PantallasSalidas.Modelo
{
   internal class Estudiante
   {
      public string CIF {  get; set; }
      public string Nombres { get; set; }
      public string Apellidos { get; set; }
      public string Carrera { get; set; }
      public string Email {get; set; }
      public DateTime FechaNac {get; set; }

      public Estudiante(string cIF, string nombres, string apellidos, string carrera, string email, DateTime fechaNac)
      {
         CIF = cIF;
         Nombres = nombres;
         Apellidos = apellidos;
         Carrera = carrera;
         Email = email;
         FechaNac = fechaNac;
      }
   }
}
