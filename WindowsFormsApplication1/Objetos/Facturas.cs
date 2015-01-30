using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Objetos
{
    class Facturas
    {
        public class DetalleFactura
        {
            public string id { get; set; }
            public string descripcion { get; set; }
            public string cantidad { get; set; }
            public string subtotal { get; set; }
        }

        public class DetalleFactura2
        {
            public string id { get; set; }
            public string factura_id { get; set; }
            public string producto_id { get; set; }
            public string cantidad { get; set; }
            public string subtotal { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class Factura
        {
            public string id { get; set; }
            public string numero_factura { get; set; }
            public string fecha { get; set; }
            public string cliente_id { get; set; }
            public string tipo_factura { get; set; }
            public string forma_pago { get; set; }
            public string descuento { get; set; }
            public string subtotal { get; set; }
            public string total { get; set; }
            public string plazo_maximo { get; set; }
            public string observaciones { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public List<DetalleFactura> detalleFactura { get; set; }
            public List<DetalleFactura2> detalle_factura { get; set; }
        }

        public class RootObject
        {
            public bool resultados { get; set; }
            public List<Factura> facturas { get; set; }
        }
    }
}
