using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Catalogo
    {
        private int id;

        public string imagen;
        
        public decimal Precio;

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }

        public Marca Marc = new Marca();
        
        public Categoria Cat = new Categoria();
    }
    public class Marca
    {
        public int idMarca;
        public string NombreMarca;

    }
    public class Categoria
    {
        protecte
    }
}

