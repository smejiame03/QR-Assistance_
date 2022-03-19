using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace QR_Assistence
{
    public class ClsConexion
    {
        public SqlConnection abrir_conexion()
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                SqlCommand cmm = new SqlCommand();
                cnn.ConnectionString = "data source=DESKTOP-DH1F4J6\\SQLEXPRESS;database=QRAssistence; Trusted_Connection=True";
                cnn.Open();
                return cnn;
            }

            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}