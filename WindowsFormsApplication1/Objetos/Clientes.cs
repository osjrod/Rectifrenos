using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Objetos
{
    class Clientes
    {
        public class Cliente
        {
            public string id { get; set; }
            public string codigo_cliente { get; set; }
            public string nombre { get; set; }
            public string contacto { get; set; }
            public string correo { get; set; }
            public string direccion { get; set; }
            public string telefono_1 { get; set; }
            public string telefono_2 { get; set; }
            public string telefono_3 { get; set; }
            public string plazo_maximo { get; set; }
            public string credito_maximo { get; set; }
            public string observaciones { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class RootObject
        {
            public bool resultados { get; set; }
            public List<Cliente> clientes { get; set; }
        }
    }
}
