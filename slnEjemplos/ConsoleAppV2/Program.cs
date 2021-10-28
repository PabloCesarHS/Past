using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppV2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Res = Probar2();
            var Res2 = GetExternalLoginProviders();
            //var Res4 = await Prueba4();


            Console.ReadLine();
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

        public async Task<bool> Prueba4()
        {
            List<ClaBusInt_ConsultaDeuda> models = new List<ClaBusInt_ConsultaDeuda>();

            Dictionary<string, Object> Parametros = new Dictionary<string, object>();
            Parametros.Add("usuario", "Juan");
            Parametros.Add("codigoinstitucion", "Carlos");
            Parametros.Add("canal", "Robert");
            Parametros.Add("codigoalumno", "Lomo");
            Parametros.Add("codigoconcepto", "4564651351654168468");

            String sParams = JsonConvert.SerializeObject(Parametros);

            //HttpWebRequest request = new HttpWebRequest(new Uri(String.Format("{0}api/Account/Register", Constants.BaseAddress)));
            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
            request.Method = "POST";
            request.ContentType = "application/json";

            byte[] bytes = Encoding.UTF8.GetBytes(sParams);
            using (Stream stream = await request.GetRequestStreamAsync())
            {
                stream.Write(bytes, 0, bytes.Length);
            }

            try
            {
                //await request.GetResponseAsync();

                WebResponse response = await request.GetResponseAsync();
                HttpWebResponse httpResponse = (HttpWebResponse)response;
                string result;

                using (Stream responseStream = httpResponse.GetResponseStream())
                {
                    result = new StreamReader(responseStream).ReadToEnd();
                    Console.WriteLine(result);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task RegisterExternal(string username)
        {
            //string uri = String.Format("{0}/api/Account/RegisterExternal", BaseUri);

            //RegisterExternalBindingModel model = new RegisterExternalBindingModel
            //{
            //    UserName = username
            //};
            //HttpWebRequest request = new HttpWebRequest(new Uri(uri));

            //request.ContentType = "application/json";
            //request.Accept = "application/json";
            //request.Headers.Add("Authorization", String.Format("Bearer {0}", AccessToken));
            //request.Method = "POST";

            //string postJson = JsonConvert.SerializeObject(model);
            //byte[] bytes = Encoding.UTF8.GetBytes(postJson);
            //using (Stream requestStream = await request.GetRequestStreamAsync())
            //{
            //    requestStream.Write(bytes, 0, bytes.Length);
            //}

            //try
            //{
            //    WebResponse response = await request.GetResponseAsync();
            //    HttpWebResponse httpResponse = (HttpWebResponse)response;
            //    string result;

            //    using (Stream responseStream = httpResponse.GetResponseStream())
            //    {
            //        result = new StreamReader(responseStream).ReadToEnd();
            //        Console.WriteLine(result);
            //    }
            //}
            //catch (SecurityException)
            //{
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    throw new InvalidOperationException("Unable to register user", ex);
            //}
        }


        public static async Task<ClaBusInt_ConsultaDeuda> Probar2()
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

                WebResponse oResponse = await oRequest.GetResponseAsync();
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

        public static async Task<IEnumerable<ClaBusInt_ConsultaDeuda>> GetExternalLoginProviders()
        {
            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            
            try
            {
                List<ClaBusInt_ConsultaDeuda> models = new List<ClaBusInt_ConsultaDeuda>();

                Dictionary<string, Object> Parametros = new Dictionary<string, object>();
                Parametros.Add("usuario", "Juan");
                Parametros.Add("codigoinstitucion", "Carlos");
                Parametros.Add("canal", "Robert");
                Parametros.Add("codigoalumno", "Lomo");
                Parametros.Add("codigoconcepto", "4564651351654168468");

                String sParams = JsonConvert.SerializeObject(Parametros);


                using (var responser = await request.GetResponseAsync())
                {
                    using (var oWS = new StreamWriter(responser.GetResponseStream()))
                    {
                        oWS.Write(sParams);
                        oWS.Flush();
                        oWS.Close();
                    }

                    string responseString = await new StreamReader(responser.GetResponseStream()).ReadToEndAsync();

                    models = JsonConvert.DeserializeObject<List<ClaBusInt_ConsultaDeuda>>(responseString);
                }
                
                return models;
            }
            catch (SecurityException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Unable to get login providers", ex);
            }
        }
    }
}
