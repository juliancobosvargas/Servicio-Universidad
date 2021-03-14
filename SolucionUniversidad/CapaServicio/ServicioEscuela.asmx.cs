using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//hago uso de CapaNegocio
using CapaNegocio;
//para manejar los buffers de memoria
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de ServicioEscuela
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioEscuela : System.Web.Services.WebService
    {

        [WebMethod(Description ="Listar Escuela")]
        public DataSet Listar()
        {
            //Crear un objeto de la clase Escuela
            Escuela escuela = new Escuela();
            return escuela.Listar();
        }

        [WebMethod(Description = "Actualizar Escuela")]
        public string[] Actualizar(string codEscuela, string laEscuela)
        {
            //Crear un objeto de la clase Escuela
            Escuela escuela = new Escuela();
            string[] arreglo = {
                (escuela.Actualizar(codEscuela, laEscuela)).ToString(),
                escuela.Mensaje
            };
            return arreglo;
        }

        [WebMethod(Description = "Agregar Escuela")]
        public string[] Agregar(string codEscuela, string laEscuela)
        {
            //Crear un objeto de la clase Escuela
            Escuela escuela = new Escuela();
            string[] arreglo = {
                (escuela.Agregar(codEscuela, laEscuela)).ToString(),
                escuela.Mensaje
            };
            return arreglo;
        }

        [WebMethod(Description = "Buscar Escuela")]
        public DataSet Buscar(string texto, string criterio)
        {
            //Crear un objeto de la clase Escuela
            Escuela escuela = new Escuela();
            return escuela.Buscar(texto, criterio);
        }

        [WebMethod(Description = "Eliminar Escuela")]
        public String[] Eliminar(string codEscuela)
        {
            //Crear un objeto de la clase Escuela
            Escuela escuela = new Escuela();
            string[] arreglo = {
                (escuela.Eliminar(codEscuela)).ToString(),
                escuela.Mensaje
            };
            return arreglo;
        }
    }
}
