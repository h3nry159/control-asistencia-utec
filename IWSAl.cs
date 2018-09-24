using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WSAlumnos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSAl
    {

        //LOGIN
        [OperationContract, WebGet(UriTemplate="loginAlumno/{carnet}/{clave}", ResponseFormat =WebMessageFormat.Json)]
        int loginAlumno(string carnet, string clave);


        //MOSTRAR PERFIL
        [OperationContract, WebGet(UriTemplate = "mostrarPerfil/{carnet}", ResponseFormat = WebMessageFormat.Json)]
        DataSet mostrarPerfil(string carnet);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.



}
