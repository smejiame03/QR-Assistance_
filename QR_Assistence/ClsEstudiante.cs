using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace QR_Assistence
{
    public class ClsEstudiante
    {
        ClsConexion objconexion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        public DataSet consultar_estudiante(string pID_Estudiante)
        {
            try
            {
                cmd.Connection = objconexion.abrir_conexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_estudiante";
                cmd.Parameters.Add("@pID_Estudiante", pID_Estudiante);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }

            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }

        public bool guardar_estudiante (string pID_Estudiante, string pNombre_Estudiante, string pApellido_Estudiante, string pCorreo_Estudiante, string pClave_Estudiante, string pPrograma_Estudiante)
        {
            try
            {
                cmd.Connection = objconexion.abrir_conexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_estudiante";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@pID_Estudiante", pID_Estudiante);
                cmd.Parameters.Add("@pNombre_Estudiante", pNombre_Estudiante);
                cmd.Parameters.Add("@pApellido_Estudiante", pApellido_Estudiante);
                cmd.Parameters.Add("@pCorreo_Estudiante", pCorreo_Estudiante);
                cmd.Parameters.Add("@pClave_Estudiante", pClave_Estudiante);
                cmd.Parameters.Add("@pPrograma_Estudiante", pPrograma_Estudiante);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
            

    }
       
}