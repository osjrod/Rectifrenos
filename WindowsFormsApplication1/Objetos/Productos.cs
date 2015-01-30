using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Objetos
{
    class Productos
    {

        public class Producto
        {
            public string id { get; set; }
            public string codigo_producto { get; set; }
            public string descripcion { get; set; }
            public int stock { get; set; }
            public int cantidad_minima { get; set; }
            public decimal precio_compra { get; set; }
            public decimal precio_venta { get; set; }
            public string proveedor_id { get; set; }
            public string codigo_pedido { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class RootObject
        {
            public bool resultados { get; set; }
            public List<Producto> productos { get; set; }
        }

        public class RootObject2
        {
            public bool resultados { get; set; }
            public Producto producto { get; set; }
        }
    }
}
