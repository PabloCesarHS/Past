using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleAppP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Probar());
            Console.ReadLine();
        }

        public static string GetPost()
        {
            string result = "";
            WebRequest oRequest = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
            oRequest.Method = "POST";
            oRequest.ContentType = "application/json;charset=UTF-8";

            using (var oWS = new StreamWriter(oRequest.GetRequestStream()))
            {
                string json = "{\"Nombre\":\"Juanito\"}";
                oWS.Write(json);
                oWS.Flush();
                oWS.Close();
            }

            WebResponse oResponse = oRequest.GetResponse();
            using (var oSR = new StreamReader(oResponse.GetResponseStream()))
            {
                result = oSR.ReadToEnd().Trim();
            }

            return result;
        }

        public class ClaBusInt_ConsultaDeuda
        {
            public string usuario;
            public string codigoInstitucion;
            public string canal;
            public string codigoAlumno;
            public string codigoConcepto;

            public ClaBusInt_ConsultaDeuda()
            {                
            }

            public ClaBusInt_ConsultaDeuda(string usuario, string codigoInstitucion, string canal, string codigoAlumno, string codigoConcepto)
            {
                this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
                this.codigoInstitucion = codigoInstitucion ?? throw new ArgumentNullException(nameof(codigoInstitucion));
                this.canal = canal ?? throw new ArgumentNullException(nameof(canal));
                this.codigoAlumno = codigoAlumno ?? throw new ArgumentNullException(nameof(codigoAlumno));
                this.codigoConcepto = codigoConcepto ?? throw new ArgumentNullException(nameof(codigoConcepto));
            }
        }


        public static ClaBusInt_ConsultaDeuda Probar()
        {
            ClaBusInt_ConsultaDeuda oConsultaDeuda = new ClaBusInt_ConsultaDeuda();
            try
            {
                Dictionary<string, Object> Parametros = new Dictionary<string, object>();
                Parametros.Add("usuario", "Juan");
                Parametros.Add("codigoinstitucion", "Carlos");
                Parametros.Add("canal", "Robert");
                Parametros.Add("codigoalumno", "Lomo");
                Parametros.Add("codigoconcepto", "4564651351654168468");

                String sParams = JsonConvert.SerializeObject(Parametros);

                //Byte[] byteParams = Encoding.UTF8.GetBytes(sParams);


                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_UrlConDeuda);
                //HttpWebRequest oRequest = (HttpWebRequest)WebRequest.Create("https://jsonplaceholder.typicode.com/posts");

                WebRequest oRequest = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
                //request.ContentType = "application/json";
                //request.Headers.Add("Authorization", "Bearer " + oAtutenticacion.access_token);
                oRequest.Method = "POST";
                //request.ContentLength = byteParams.Length;


                oRequest.ContentType = "application/json;charset=UTF-8";
                //request.Headers["Authorization"] = "Bearer " + oAtutenticacion.access_token;
                //request.ContentType = "application/json";

                using (var oWS = new StreamWriter(oRequest.GetRequestStream()))
                {
                    //string json = "{\"Nombre\":\"Juanito\"}";

                    //string json = "{\"usuario\":\"User\",\"codigoInstitucion\":\"User\",\"canal\":\"User\",\"codigoAlumno\":\"User\",\"codigoConcepto\":\"User\"}";
                    oWS.Write(sParams);
                    oWS.Flush();
                    oWS.Close();
                }

                WebResponse oResponse = oRequest.GetResponse();
                using (var oSR = new StreamReader(oResponse.GetResponseStream()))
                {
                    string result = oSR.ReadToEnd().Trim();
                    oConsultaDeuda = JsonConvert.DeserializeObject<ClaBusInt_ConsultaDeuda>(oSR.ReadToEnd());
                }               

            }
            catch (WebException ex)
            {
                using (Stream dataStream = ex.Response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
                    oConsultaDeuda = JsonConvert.DeserializeObject<ClaBusInt_ConsultaDeuda>(reader.ReadToEnd());
                }
            }

            return oConsultaDeuda;
        }

    }
}
