
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPruebasBus.Clases;

namespace WFPruebasBus
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Lista de VARIABLES UNIVERSALES
        string vuEstadoLista = "V0";
        //ListaN1
        List<cClientes> vuListaClientes = new List<cClientes>();

        #region TRANSFORMACION Y RECOLECCION DE DATOS

        //copiar lista de memoria
        public DataTable GetListCopyMemory()
        {
            DataTable oTabla = new DataTable();

            //CAPTURRA LISTA DE MEMORIA
            string s = Clipboard.GetText();
            string[] Lista = s.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //VERIFICAR PRIMERA COLUMNA
            bool EsPrimero = true;

            foreach (string Linea in Lista)
            {
                //SEPARARA DATOS DE LINEA
                string[] Celdas = Linea.Split('\t');

                //VERIFICAR PRIMERA FILA
                if (EsPrimero)
                {
                    foreach (string value in Celdas)
                    {
                        oTabla.Columns.Add(value);
                    }
                    // cambiar valor de variable
                    EsPrimero = false;
                }
                else
                {
                    DataRow NuevaFila = oTabla.NewRow();
                    NuevaFila.ItemArray = Celdas;
                    oTabla.Rows.Add(NuevaFila);
                }
            }
            return oTabla;
        }

        //Convertir DATABLE A LIST
        private static List<T> DataTableAList<T>(DataTable _DataTable)
        {
            //Primera parte
            Type TipoClase = typeof(cClientes);
            var Propiedades = TipoClase.GetProperties();

            _DataTable.TableName = typeof(cClientes).FullName;
            Dictionary<string, object> ListaColumnas = new Dictionary<string, object>();
            //Agregar a lista las columnas
            foreach (PropertyInfo info in Propiedades)
            {
                ListaColumnas.Add(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType);
            }
            //Modificar el nombre de las columnas
            foreach (DataColumn Columna in _DataTable.Columns)
            {
                _DataTable.Columns[Columna.Ordinal].ColumnName = ListaColumnas.ElementAt(Columna.Ordinal).Key;
            }
            //segunda parte
            List<T> ListaClases = new List<T>();
            foreach (DataRow Fila in _DataTable.Rows)
            {
                T item = ObtenerFila<T>(Fila);
                ListaClases.Add(item);
            }
            return ListaClases;
        }

        //Convertir fila a Clase
        private static T ObtenerFila<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn Columna in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == Columna.ColumnName)
                        pro.SetValue(obj, dr[Columna.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        #endregion TRANSFORMACION Y RECOLECCION DE DATOS

        private void btnCopiarLista_Click(object sender, EventArgs e)
        {
            var oTabla = GetListCopyMemory();
            try
            {
                vuListaClientes = DataTableAList<cClientes>(oTabla);
                dgvListaDatos.DataSource = vuListaClientes.ToList();

                vuEstadoLista = "C1";

                tbxListaDatos.Text = "Datos Exitosamente convertidos a Clase";
                tbxListaDatos.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                dgvListaDatos.DataSource = oTabla;

                vuEstadoLista = "C2";

                tbxListaDatos.Text = "Error al convertir Datos a List<Class> :" + ex.Message;
                tbxListaDatos.ForeColor = Color.Red;                
            }
             
        }

        #region METODOS DE CONSULTA


        //public static async Task<ClaBusInt_ConsultaDeuda> P()
        //{
        //    ClaBusInt_ConsultaDeuda oConsultaDeuda = new ClaBusInt_ConsultaDeuda();
        //    try
        //    {
        //        Dictionary<string, Object> Parametros = new Dictionary<string, object>();
        //        Parametros.Add("usuario", "Juan");
        //        Parametros.Add("codigoinstitucion", "Carlos");
        //        Parametros.Add("canal", "Robert");
        //        Parametros.Add("codigoalumno", "Lomo");
        //        Parametros.Add("codigoconcepto", "4564651351654168468");

        //        String sParams = JsonConvert.SerializeObject(Parametros);

        //        //Byte[] byteParams = Encoding.UTF8.GetBytes(sParams);


        //        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_UrlConDeuda);
        //        //HttpWebRequest oRequest = (HttpWebRequest)WebRequest.Create("https://jsonplaceholder.typicode.com/posts");

        //        WebRequest oRequest = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
        //        //request.ContentType = "application/json";
        //        //request.Headers.Add("Authorization", "Bearer " + oAtutenticacion.access_token);
        //        oRequest.Method = "POST";
        //        //request.ContentLength = byteParams.Length;


        //        oRequest.ContentType = "application/json;charset=UTF-8";
        //        //request.Headers["Authorization"] = "Bearer " + oAtutenticacion.access_token;
        //        //request.ContentType = "application/json";





        //        using (var oWS = new StreamWriter(oRequest.GetRequestStream()))
        //        {
        //            //string json = "{\"Nombre\":\"Juanito\"}";

        //            //string json = "{\"usuario\":\"User\",\"codigoInstitucion\":\"User\",\"canal\":\"User\",\"codigoAlumno\":\"User\",\"codigoConcepto\":\"User\"}";
        //            oWS.Write(sParams);
        //            oWS.Flush();
        //            oWS.Close();
        //        }

        //        WebResponse oResponse = await oRequest.GetResponseAsync();
        //        using (var oSR = new StreamReader(oResponse.GetResponseStream()))
        //        {
        //            string result = oSR.ReadToEnd().Trim();
        //            oConsultaDeuda = JsonConvert.DeserializeObject<ClaBusInt_ConsultaDeuda>(oSR.ReadToEnd());
        //        }

        //    }
        //    catch (WebException ex)
        //    {
        //        using (Stream dataStream = ex.Response.GetResponseStream())
        //        {
        //            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
        //            oConsultaDeuda = JsonConvert.DeserializeObject<ClaBusInt_ConsultaDeuda>(reader.ReadToEnd());
        //        }
        //    }

        //    return oConsultaDeuda;
        //}

        //public static async Task<IEnumerable<ClaBusInt_ConsultaDeuda>> GetExternalLoginProviders()
        //{
        //    WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/posts");
        //    request.Method = "POST";
        //    request.ContentType = "application/json;charset=UTF-8";

        //    try
        //    {
        //        Dictionary<string, Object> Parametros = new Dictionary<string, object>();
        //        Parametros.Add("usuario", "Juan");
        //        Parametros.Add("codigoinstitucion", "Carlos");
        //        Parametros.Add("canal", "Robert");
        //        Parametros.Add("codigoalumno", "Lomo");
        //        Parametros.Add("codigoconcepto", "4564651351654168468");

        //        String sParams = JsonConvert.SerializeObject(Parametros);

        //        WebResponse response = await request.GetResponseAsync();
        //        using (var oWS = new StreamWriter(response.GetResponseStream()))
        //        {
        //            //string json = "{\"Nombre\":\"Juanito\"}";

        //            //string json = "{\"usuario\":\"User\",\"codigoInstitucion\":\"User\",\"canal\":\"User\",\"codigoAlumno\":\"User\",\"codigoConcepto\":\"User\"}";
        //            oWS.Write(sParams);
        //            oWS.Flush();
        //            oWS.Close();
        //        }

        //        HttpWebResponse httpResponse = (HttpWebResponse)response;
        //        string result;

        //        using (Stream responseStream = httpResponse.GetResponseStream())
        //        {
        //            result = new StreamReader(responseStream).ReadToEnd();
        //        }

        //        List<ClaBusInt_ConsultaDeuda> models = JsonConvert.DeserializeObject<List<ClaBusInt_ConsultaDeuda>>(result);
        //        return models;
        //    }
        //    catch (SecurityException)
        //    {
        //        throw;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new InvalidOperationException("Unable to get login providers", ex);
        //    }
        //}

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




        #endregion FIN METODOS CONSULTA

        private async void btnCorrerPrueba_Click(object sender, EventArgs e)
        {
            var FF = await Prueba4();
        }
    }
}
