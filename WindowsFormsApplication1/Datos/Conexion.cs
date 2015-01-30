using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class AccesoWebService
    {
        public string ObtenerDatos(string url)
        {
            string sURL;
            sURL = "http://rectifrenosdelnorte.com/"+url;
            WebRequest wrGETURL;

            ICredentials credenciales = new NetworkCredential("admin", "admin");

            wrGETURL = WebRequest.Create(sURL);

            wrGETURL.Credentials = credenciales;

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string json = objReader.ReadToEnd().Substring(2);

            return json;
        }

        public string InsertarDatos(string url, NameValueCollection parametros)
        {
            string uriString = "http://rectifrenosdelnorte.com/"+url;

            WebClient myWebClient = new WebClient();

            ICredentials credenciales = new NetworkCredential("admin", "admin");

            myWebClient.Credentials = credenciales;

            NameValueCollection myNameValueCollection = parametros;

            byte[] responseArray =
            myWebClient.UploadValues(uriString, "POST", myNameValueCollection);

            return Encoding.ASCII.GetString(responseArray);
        }
    }
}
