using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using RestSharp;
using Newtonsoft.Json;
using WindowsFormsApplication1.Datos;
using WindowsFormsApplication1.Objetos;

namespace WindowsFormsApplication1.Logica
{
    class lProveedores
    {

        public oProveedores.Proveedor proveedor(string id)
        {
            string json = Conexion.httpGet("proveedores", id);
            json = json.Substring(3);

            oProveedores.Proveedor proveedor = JsonConvert.DeserializeObject<oProveedores.Proveedor>(json);

            return proveedor;
        }

        public oProveedores.Proveedores proveedores()
        {

            string json = Conexion.httpGet("proveedores");
            json = json.Substring(3);

            var proveedores = JsonConvert.DeserializeObject<oProveedores.Proveedores>(json);
 
            return proveedores;
        }

        public string postProveedor(string codigo_proveedor, string nombre, string correo, string contacto, string telefono_1, string telefono_2,string telefono_3) {
           
            oProveedores.Proveedor proveedor = new oProveedores.Proveedor{  codigo_proveedor = codigo_proveedor,
                                                                            nombre = nombre,
                                                                            correo = correo,
                                                                            contacto = contacto,
                                                                            telefono_1 = telefono_1,
                                                                            telefono_2 = telefono_2,
                                                                            telefono_3 = telefono_3
                                                                            };

            string mensaje = Conexion.httpPost("proveedores", proveedor);

            return mensaje;
        }

        public string putProveedor(string id, string codigo_proveedor, string nombre, string correo, string contacto, string telefono_1, string telefono_2, string telefono_3)
        {

            oProveedores.Proveedor proveedor = new oProveedores.Proveedor
            {
                codigo_proveedor = codigo_proveedor,
                nombre = nombre,
                correo = correo,
                contacto = contacto,
                telefono_1 = telefono_1,
                telefono_2 = telefono_2,
                telefono_3 = telefono_3,
                updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            string mensaje = Conexion.httpPut("proveedores", id, proveedor);

            return mensaje;
        }

        public string deleteProveedor(string id)
        {
            string mensaje = Conexion.httpDelete("proveedores", id);

            return mensaje;
        }

    }
}
