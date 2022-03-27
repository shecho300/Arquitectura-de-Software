using System;

namespace Actividad3
{
    public class User
    {
        public DateTime Date { get; set; }

        public int Edad { get; set; }

        public int Puntos => 32 + (int)(Edad / 0.5556);

        public string Nombre { get; set; }
    }
}
