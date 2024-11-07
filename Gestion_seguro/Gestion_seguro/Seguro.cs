using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_seguro
{
    public class Seguro
    {
        public int Id { get; set; }
        public decimal PrecioMensual { get; set; }
        public decimal SumaAsegurada { get; set; }
        public string Descripcion { get; set; }

        public Seguro(int id, decimal precioMensual, decimal sumaAsegurada, string descripcion)
        {
            Id = id;
            PrecioMensual = precioMensual;
            SumaAsegurada = sumaAsegurada;
            Descripcion = descripcion;
        }
    }

    public class TodoRiesgo : Seguro
    {
        public decimal ValorFranquicia { get; set; }

        public TodoRiesgo(int id, decimal precioMensual, decimal sumaAsegurada, string descripcion)
            : base(id, precioMensual, sumaAsegurada, descripcion)
        {
            ValorFranquicia = CalcularValorFranquicia(sumaAsegurada);
        }

        private decimal CalcularValorFranquicia(decimal sumaAsegurada)
        {
            return sumaAsegurada * 0.15M + sumaAsegurada;
        }
    }

    public class Terceros : Seguro
    {
        public Terceros(int id, decimal precioMensual, decimal sumaAsegurada, string descripcion)
            : base(id, precioMensual, sumaAsegurada, descripcion)
        {
            SumaAsegurada = CalcularSumaAsegurada(sumaAsegurada);
        }

        private decimal CalcularSumaAsegurada(decimal sumaAsegurada)
        {
            return sumaAsegurada * 0.80M;
        }
    }

    public static class RepositorioGlobal
    {
        public static List<Seguro> repositorio = new List<Seguro>();
    }

}
