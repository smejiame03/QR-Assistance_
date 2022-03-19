using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QR_Assistence
{
    public class ClsDocente
    {
        ClsConexion objconexion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        public DataSet consultar_docente(string pID_Docente)
        {
            try
            {
                cmd.Connection = objconexion.abrir_conexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_docente";
                cmd.Parameters.Add("@pID_Docente", pID_Docente);
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

        public bool guardar_docente(string pID_Docente, string pNombre_Docente, string pApellidos_Docente, string pCorreo_Docente, string pClave_Docente, string pAsignaturaDictada_Docente)
        {
            try
            {
                cmd.Connection = objconexion.abrir_conexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_docente";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@pID_Docente", pID_Docente);
                cmd.Parameters.Add("@pNombre_Docente", pNombre_Docente);
                cmd.Parameters.Add("@pApellidos_Docente", pApellidos_Docente);
                cmd.Parameters.Add("@pCorreo_Docente", pCorreo_Docente);
                cmd.Parameters.Add("@pClave_Docente", pClave_Docente);
                cmd.Parameters.Add("@pAsignaturaDictada_Docente", pAsignaturaDictada_Docente);
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
