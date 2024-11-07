using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_mismo_enano_comunista_3_XDDDDDDDDDDD
{
    //creacion de la clase categoria con sus atributos
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        //es una funcion que permite devolver solo el paramtro del nombre para mostrar en
        //el data grid view del form principal, nada mas que eso
        public override string ToString()
        {
            return this.Nombre;
        }
    }

    //funcion de la clase producto que tiene una herencia de catagoria
    //de esta menera se pueden enlazar categoria y producto sin mucho esfuerzo
    public class Producto
    {
        public int id { get; set; }
        public decimal precio { get; set; }
        public string descripcion { get; set; }
        public Categoria Categoria { get; set; }

        public Producto(int id, decimal precio, string descripcion, Categoria categoria)
        {
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
            this.Categoria = categoria;
        }
    }

    //son las dos listas, la de productos y la de categorias
    //porque en dos statics distintos?
    //no se
    //no lo pense antes, pero ya es tarde para cambiarlo
    public static class RepositorioGlobal
    {
        public static List<Producto> repositorio = new List<Producto>();
    }

    public static class RepositorioCategorias
    {
        public static List<Categoria> categorias = new List<Categoria>();
    }

}
