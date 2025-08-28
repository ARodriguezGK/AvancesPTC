using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Lugar
    {
        private int idLugar;
        private string nombreLugar;
        private string direccion;

        public int IdLugar { get => idLugar; set => idLugar = value; }
        public string NombreLugar { get => nombreLugar; set => nombreLugar = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}
