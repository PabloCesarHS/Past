using ProyectPingPC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectPingPC
{
    public partial class frmListaPing : Form
    {
        public frmListaPing()
        {
            InitializeComponent();
        }

        // https://docs.microsoft.com/en-us/dotnet/api/system.net.networkinformation.ping?view=net-5.0
        // https://www.c-sharpcorner.com/blogs/ping-a-machine-using-c-sharp1
        // https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-ping-a-host
        // https://stackoverflow.com/questions/3689728/ping-a-hostname-on-the-network


        // https://stackoverflow.com/questions/43224721/copy-from-excel-to-datagridview-c-sharp
        // https://www.codeproject.com/Articles/36850/DataGridView-Copy-and-Paste
        // https://social.msdn.microsoft.com/Forums/windows/en-US/4f700537-6d23-4a1c-94db-0f6e555849cc/excel-to-datagridview-copy-issue?forum=winformsdatacontrols

        //LISA GENERAL DE RESPUESTA
        List<cResultado> vuListaRespuesta = new List<cResultado>();
        List<cClaseMaquina> vuListaMaquina_Ent = new List<cClaseMaquina>();

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
            Type TipoClase = typeof(T);
            var Propiedades = TipoClase.GetProperties();

            _DataTable.TableName = typeof(T).FullName;
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

        public string IsEmptyNull(Object Valor)
        {
            return Valor?.ToString() ?? string.Empty;
        }

        #endregion TRANSFORMACION Y RECOLECCION DE DATOS        


        private void Motodo(object sender, EventArgs e)
        {
            string s = Clipboard.GetText();

            string[] lines = s.Replace("\n", "").Split('\r');

            dgvListaDatos.Rows.Add(lines.Length - 1);
            string[] fields;
            int row = 0;
            int col = 0;

            foreach (string item in lines)
            {
                fields = item.Split('\t');
                foreach (string f in fields)
                {
                    Console.WriteLine(f);
                    dgvListaDatos[col, row].Value = f;
                    col++;
                }
                row++;
                col = 0;
            }
        }

        private void btnCopiarLista_Click(object sender, EventArgs e)
        {
            var oTabla = GetListCopyMemory();
            try
            {
                vuListaMaquina_Ent = DataTableAList<cClaseMaquina>(oTabla);
                dgvListaDatos.DataSource = vuListaMaquina_Ent.ToList();
                tbxListaDatos.Text = "Datos Exitosamente convertidos a Clase: ClaseMaquina";
                tbxListaDatos.ForeColor = Color.Green;
                dgvListaDatos.DataSource = oTabla;
            }
            catch (Exception ex)
            {
                dgvListaDatos.DataSource = oTabla;
                //vuEstadoLista = "C3";
                tbxListaDatos.Text = "Error al convertir Datos a List<Class> :" + ex.Message;
                tbxListaDatos.ForeColor = Color.Red;
            }
        }

        //public void pingHost(string hostName, int pingCount)
        //{
        //    if (pingCount == 0)
        //    {
        //        pingCount = 43200;
        //    }
        //    Console.WriteLine("Host, Response Time, Status, Time ");
        //    String fileName = String.Format(@"tping-{0}-{1}-{2}-{3}.csv", DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        //    for (int i = 0; i < pingCount; i++)
        //    {
        //        Ping ping = new Ping();
        //        StreamWriter processedData = new StreamWriter(@fileName, true);
        //        try
        //        {
        //            PingReply pingReply = ping.Send(hostName);

        //            processedData.WriteLine("{0}, " + "{1}, " + "{2}, " + DateTime.Now.TimeOfDay, hostName, pingReply.RoundtripTime, pingReply.Status);
        //            processedData.Close();
        //            Console.WriteLine("{0}, " + "{1}, " + "{2}, " + DateTime.Now.TimeOfDay, hostName, pingReply.RoundtripTime, pingReply.Status);

        //        }
        //        catch (System.Net.NetworkInformation.PingException)
        //        {
        //            processedData.WriteLine("{0}, " + "{1}, " + "{2}, " + DateTime.Now.TimeOfDay, hostName, 0, "Network Error");
        //            Console.WriteLine("{0}, " + "{1}, " + "{2}, " + DateTime.Now.TimeOfDay, hostName, 0, "Network Error");
        //            processedData.Close();
        //            //Console.WriteLine(Ex);
        //            //Environment.Exit(0);
        //        }
        //        Thread.Sleep(2000);
        //    }
        //    Console.WriteLine("\n" + "tping complete - {0} pings logged in {1}", pingCount, fileName);
        //}

        //public void PingHost(string _Direccion, int numeroTestes)
        //{
        //    bool pingou = true;
        //    Ping pinger = new Ping();
        //    try
        //    {
        //        for (int i = 0; i < numeroTestes; i++)
        //        {
        //            if (!pingou)
        //                break;
        //            PingReply reply = pinger.Send(_Direccion);
        //            pingou = reply.Status == IPStatus.Success;
        //        }
        //    }
        //    catch (PingException)
        //    {
        //        pingou = false;
        //    }
        //}

        //public bool CanPing(string address)
        //{
        //    Ping ping = new Ping();

        //    try
        //    {
        //        PingReply reply = ping.Send(address);
        //        if (reply == null) return false;

        //        if (reply.Status == IPStatus.Success)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (PingException)
        //    {
        //        return false;
        //    }
        //}

        public async Task<cResultado> EjecutarPing(string _Direccion)
        {
            cResultado oResultado = new cResultado().PorDefecto();
            Ping ping = new Ping();

            try
            {
                PingReply reply = ping.Send(_Direccion);
                if (reply == null)
                    return oResultado;

                if (reply.Status == IPStatus.Success)
                {
                    oResultado.Estado = true;
                    oResultado.Concepto = _Direccion;
                    oResultado.Respuesta = "On-Line";
                    return oResultado;
                }
                else
                {
                    oResultado.Estado = false;
                    oResultado.Concepto = _Direccion;
                    oResultado.Respuesta = "Off-Line";
                    return oResultado;
                }
            }
            catch (PingException)
            {
                oResultado.Estado = false;
                oResultado.Concepto = _Direccion;
                oResultado.Respuesta = "Error";
                return oResultado;
            }
        }

        private async void btnCorrerPrueba_Click(object sender, EventArgs e)
        {
            //Listar clase por defecto
            vuListaRespuesta = CrearListasRespuesta();
            dgvListaResultados.DataSource = vuListaRespuesta;
            //editar estados terminados
            await PruebaDeMetodos();
            // editar valores totales
            dgvListaResultados.DataSource = vuListaRespuesta;
            tbxListaResultados.Text = "Proceso completado";
            tbxListaResultados.ForeColor = Color.Green;
        }

        private List<cResultado> CrearListasRespuesta()
        {
            List<cResultado> vuListaRespuesta = new List<cResultado>();

            int NroFila = 0;

            foreach (cClaseMaquina Fila in vuListaMaquina_Ent)
            {
                vuListaRespuesta.Add(new cResultado
                {
                    Nro = NroFila,
                    FechaHoraIni = DateTime.Now
                });
                NroFila++;
            }
            return vuListaRespuesta;
        }

        async void EjecutarConsulta(int NroFila, string _Direccion)
        {
            var oResultado = await EjecutarPing(_Direccion);

            //vuListaRespuesta.Add(oResultado);
            //List<cResultado> vuListaRespuesta = new List<cResultado>();
            //var index = vuListaRespuesta.FindIndex(c => c.Nro == NroFila);
            vuListaRespuesta[NroFila].FechaHoraIni = oResultado.FechaHoraIni;
            vuListaRespuesta[NroFila].FechaHoraFin = oResultado.FechaHoraFin;
            vuListaRespuesta[NroFila].Duracion = oResultado.Duracion;
            vuListaRespuesta[NroFila].Estado = oResultado.Estado;
            vuListaRespuesta[NroFila].Respuesta = oResultado.Respuesta;

            dgvListaResultados.DataSource = vuListaRespuesta;
        }


        public async Task PruebaDeMetodos()
        {
            int NroFila = 0;

            foreach (cClaseMaquina Fila in vuListaMaquina_Ent)
            {
                EjecutarConsulta(NroFila, Fila.Nombre);
                NroFila++;
            }
        }
    }
}
