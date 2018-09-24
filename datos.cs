using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSAlumnos
{
    public static class datos
    {
        //cadena de conexcion 
        public static string cadena = "Data Source=QUEVEDO\\SQLEXPRESS;Initial Catalog=AsistenciaUtec;user id = sa; pwd=1234;Integrated Security=True";
                                       
        public static string CadenaConexion()
        {
            return datos.cadena;
        }
    }
}