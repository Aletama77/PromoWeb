using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public decimal Precio { get; set; }
        public String UrlImagen { get; set; }
        public Categoria Categoria { get; set; }
        public int Id { get; set; }

        public string UrlImagen2 { get; set; }
        public string UrlImagen3 { get; set; }


        public Articulo()
        {
            Categoria = new Categoria();
        }
    }
}
