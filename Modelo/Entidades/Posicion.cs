using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Posicion
    {
        private int idPosicion;
        private string nombrePosicion;

        public int IdPosicion { get => idPosicion; set => idPosicion = value; }
        public string NombrePosicion { get => nombrePosicion; set => nombrePosicion = value; }


    }
}
