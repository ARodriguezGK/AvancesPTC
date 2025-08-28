using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Horario
    {
        private int idHorario;
        private DateTime fecha;
        private DateTime horaInicio;

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }

        public static DataTable MostrarHorario()
        {
            try { 
                // Aquí puedes implementar la lógica para obtener los datos de la base de datos
                DataTable dt = new DataTable();
                dt.Columns.Add("IdHorario", typeof(int));
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns.Add("HoraInicio", typeof(DateTime));
                // Ejemplo de datos
                dt.Rows.Add(1, DateTime.Now.Date, DateTime.Now);
                dt.Rows.Add(2, DateTime.Now.Date.AddDays(1), DateTime.Now.AddHours(1));
                return dt;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al obtener los horarios: " + ex.Message);
            }
        }
    }
}
