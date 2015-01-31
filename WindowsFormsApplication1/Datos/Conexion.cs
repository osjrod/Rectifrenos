using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Datos
{
    class Conexion
    {
        static private Conexion singleton = null;
        static private RestClient cliente = new RestClient();

        private Conexion()
        {
            cliente.BaseUrl = "http://rectifrenosdelnorte.com";
            cliente.Authenticator = new HttpBasicAuthenticator("admin", "admin");
        }

        static public Conexion getSingleton()
        {
            if (singleton == null) {
                singleton = new Conexion();
            }

            return singleton;
        }


        static public string httpGet(string recurso)
        {
            RestRequest request = new RestRequest(recurso, Method.GET);

            RestResponse response = cliente.Execute(request);
            return response.Content;
        }

        static public string httpGet(string recurso, string id)
        {
            RestRequest request = new RestRequest(recurso + "/" + id, Method.GET);

            RestResponse response = cliente.Execute(request);
            return response.Content;
        }

        static public string httpPost(string recurso, object objeto)
        {
            RestRequest request = new RestRequest(recurso, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(objeto);

            RestResponse response = cliente.Execute(request);
            return response.Content;

        }

        static public string httpPut(string recurso, string id, object objeto)
        {
            RestRequest request = new RestRequest(recurso + "/" + id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(objeto);

            RestResponse response = cliente.Execute(request);
            return response.Content;

        }

        static public string httpDelete(string recurso, string id)
        {

            RestRequest request = new RestRequest(recurso + "/" + id, Method.DELETE);
            request.AddParameter("id", id);

            RestResponse response = cliente.Execute(request);
            return response.Content;
        }


    }
}
