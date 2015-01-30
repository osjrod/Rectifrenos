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
        RestClient client = new RestClient();

        public Conexion()
        {
            client.BaseUrl = "http://rectifrenosdelnorte.com";
            client.Authenticator = new HttpBasicAuthenticator("admin", "admin");
        }

        public string httpGet(string recurso)
        {
            RestRequest request = new RestRequest(recurso, Method.GET);

            RestResponse response = client.Execute(request);
            return response.Content;
        }

        public string httpGet(string recurso, string id)
        {
            RestRequest request = new RestRequest(recurso + "/" + id, Method.GET);

            RestResponse response = client.Execute(request);
            return response.Content;
        }

        public string httpPost(string recurso, object objeto)
        {
            RestRequest request = new RestRequest(recurso, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(objeto);

            RestResponse response = client.Execute(request);
            return response.Content;

        }

        public string httpPut(string recurso, string id, object objeto)
        {
            RestRequest request = new RestRequest(recurso + "/" + id, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(objeto);

            RestResponse response = client.Execute(request);
            return response.Content;

        }

        public string httpDelete(string recurso, string id)
        {

            RestRequest request = new RestRequest(recurso + "/" + id, Method.DELETE);
            request.AddParameter("id", id);

            RestResponse response = client.Execute(request);
            return response.Content;
        }


    }
}
