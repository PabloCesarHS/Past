using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ASPNetWebAppP1
{
    public class cPrincipal
    {
        public static string GetPost()
        {
            string result = "";
            WebRequest oRequest = WebRequest.Create("https://jsonplaceholder.typicode.com/post");
            oRequest.Method = "POST";
            oRequest.ContentType = "application/json;charset=UTF-8";

            using (var oWS=new StreamWriter(oRequest.GetRequestStream()))
            {
                string json = "{\"Nombre\":\"Juanito\"}";
                oWS.Write(json);
                oWS.Flush();
                oWS.Close();
            }

            WebResponse oResponse = oRequest.GetResponse();
            using (var oSR=new StreamReader(oResponse.GetResponseStream()))
            {
                result = oSR.ReadToEnd().Trim();
            }
            
            return result;
        }
    }
}