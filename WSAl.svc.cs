using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSAlumnos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    // SEGUNDO CAMBIO NOMBRES WS Y IWS Y CREO METODO
    
    public class WSAl : IWSAl
    {

        //Referencia LOGIN
        public int loginAlumno(string carnet, string clave)
        {
            //RETORNO EL SP
            return SPAlumnos.loginAlumno(carnet, clave);
        }

        //Referencia PERFIL
        public System.Data.DataSet mostrarPerfil(string carnet)
        {
            //RETORNO EL SP
            return SPAlumnos.mostrarPerfil(carnet);
        }
    }
}
