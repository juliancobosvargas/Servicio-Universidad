using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Buffer de memoria
using System.Data;

namespace CapaNegocio.Interfaces
{
    interface IEscuela
    {
        //Declara metodos para una Clase (Herencia y Polomorfismo)
        DataSet Listar();
        bool Agregar(string codEscuela, string escuela);
        bool Eliminar(string codEscuela);
        bool Actualizar(string codEscuela, string escuela);
        DataSet Buscar(string texto, string criterio);

    }
}
