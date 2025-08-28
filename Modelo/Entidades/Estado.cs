using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Estado
    {
        private int idEstado;
        private string nombreEstado;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
    }
}
