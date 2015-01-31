using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Datos;
using WindowsFormsApplication1.Objetos;

namespace WindowsFormsApplication1.Logica
{
    class lFacturas
    {
       
        public oFacturas.Factura factura(string id)
        {
            string json = Conexion.httpGet("facturas", id);
            json = json.Substring(3);

            oFacturas.Factura factura = JsonConvert.DeserializeObject<oFacturas.Factura>(json);

            return factura;
        }

        public oFacturas.Facturas facturas()
        {

            string json = Conexion.httpGet("facturas");
            json = json.Substring(3);

            var facturas = JsonConvert.DeserializeObject<oFacturas.Facturas>(json);

            return facturas;
        }

        public string postFactura(string numero_factura, string fecha, string cliente_id, string tipo_factura, string forma_pago, string descuento, string subtotal, string total, string plazo_maximo, string observaciones, List<oFacturas.DetalleFactura> detalleFactura)
        {

            oFacturas.Factura factura = new oFacturas.Factura
            {
                numero_factura = numero_factura,
                fecha = fecha,
                cliente_id = cliente_id,
                tipo_factura = tipo_factura,
                forma_pago = forma_pago,
                descuento = descuento,
                subtotal = subtotal,
                total = total,
                plazo_maximo = plazo_maximo,
                observaciones = observaciones,
                detalleFactura = detalleFactura
            };

            string mensaje = Conexion.httpPost("facturas", factura);

            return mensaje;
        }

        public string putfactura(string id, string numero_factura, string fecha, string cliente_id, string tipo_factura, string forma_pago, string descuento, string subtotal, string total, string plazo_maximo, string observaciones, List<oFacturas.DetalleFactura> detalleFactura)
        {

            oFacturas.Factura factura = new oFacturas.Factura
            {
                numero_factura = numero_factura,
                fecha = fecha,
                cliente_id = cliente_id,
                tipo_factura = tipo_factura,
                forma_pago = forma_pago,
                descuento = descuento,
                subtotal = subtotal,
                total = total,
                plazo_maximo = plazo_maximo,
                observaciones = observaciones,
                detalleFactura = detalleFactura
            };

            string mensaje = Conexion.httpPut("facturas", id, factura);

            return mensaje;
        }

        public string deleteFactura(string id)
        {
            string mensaje = Conexion.httpDelete("facturas", id);

            return mensaje;
        }
    }
}
