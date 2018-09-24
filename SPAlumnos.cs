using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WSAlumnos
{
    public class SPAlumnos
    {

      

        //metodo de login
        static private SqlConnection con;
        static private SqlCommand cmd;

        static private DataSet ds;
        static private SqlDataAdapter da;

        static private string conexion = datos.CadenaConexion();

        //SP PARA EL LOGIN
        public static int loginAlumno(string carnet, string clave)
        {

                      
            int resp = 0;
            using (SqlConnection cadena = con)
            {
                try
                {
                con = new SqlConnection(datos.CadenaConexion());
                con.Open();
                   
                    resp = 0;
                    cmd = new SqlCommand();
                    cmd.CommandText = "sp_loginAlumno";
                    cmd.Connection = con;
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add(new SqlParameter("@carnet", carnet));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    
                    resp = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }catch(Exception e) {
                    resp = 5;
                }
        }
            return resp;
        }

        //SP PARA EL PERFIL
        internal static DataSet mostrarPerfil(string carnet)
        {
            ds = new DataSet();
            da = new SqlDataAdapter();
            con = new SqlConnection(conexion);
            cmd = new SqlCommand();

            try
            {
                con.Open();
                cmd.CommandText = "sp_perfilAlumno";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@carnet", carnet));
                da.SelectCommand = cmd;
                da.Fill(ds);
                con.Close();
            }
            catch {
                //resp = -1
            }
            return ds;
        }
    }   
}

   
    
