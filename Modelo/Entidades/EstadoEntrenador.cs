using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class EstadoEntrenador
    {
        private int idEstado;
        private string NombreEstado;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NombreEstado1 { get => NombreEstado; set => NombreEstado = value; }

        public static List<EstadoEntrenador> ObtenerEstados()
        {
            return new List<EstadoEntrenador>
            {
                new EstadoEntrenador { IdEstado = 1, NombreEstado = "Activo" },
                new EstadoEntrenador { IdEstado = 2, NombreEstado = "Inactivo" }
            };
        }
    }
}
