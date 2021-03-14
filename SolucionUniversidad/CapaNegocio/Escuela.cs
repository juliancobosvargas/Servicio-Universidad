﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso:  CapaDatos
using CapaDatos;

namespace CapaNegocio
{
    public class Escuela : Interfaces.IEscuela
    {
        //declaro objeto de capa datos
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del Pros. Almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool Actualizar(string codEscuela, string escuela)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", codEscuela, escuela);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar(string codEscuela, string escuela)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", codEscuela, escuela);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEscuela", texto, criterio);
        }

        public bool Eliminar(string codEscuela)
        {
            // Traes la fila con el resultado CodError y el Mensaje
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", codEscuela);
            // Obtengo el CodError y Mensaje de fila
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            // Llamar al PA y traer los datos de la tabla escuela a un buffer de memoria
            return datos.TraerDataSet("spListarEscuela");
        }
    }
}
