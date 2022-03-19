using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QR_Assistence
{
    public partial class RegistroDocente : System.Web.UI.Page
    {
        ClsDocente objDocente = new ClsDocente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtApellidosDocente.Text.Trim() == "" || TxtClaveDocente.Text.Trim() == "" || TxtAsignaturaDocente.Text.Trim() == "" || TxtIDDocente.Text.Trim() == "" || TxtNombreDocente.Text.Trim() == "" || TxtCorreoDocente.Text.Trim() == "")
            {
                LblMensaje.Text = "Todos los datos son necesarios";
            }
            else
            {
                DataSet ds = new DataSet();
                ds = objDocente.consultar_docente(TxtIDDocente.Text);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "";
                    if (objDocente.guardar_docente(TxtIDDocente.Text, TxtNombreDocente.Text, TxtApellidosDocente.Text, TxtCorreoDocente.Text, TxtClaveDocente.Text, TxtAsignaturaDocente.Text))
                    {
                        LblMensaje.Text = "Registro Exitoso";
                        TxtApellidosDocente.Text = "";
                        TxtClaveDocente.Text = "";
                        TxtCorreoDocente.Text = "";
                        TxtIDDocente.Text = "";
                        TxtNombreDocente.Text = "";
                        TxtAsignaturaDocente.Text = "";
                    }
                    else
                    {
                        LblMensaje.Text = "Error, Docente no guardado";
                    }
                }
                else
                {
                    LblMensaje.Text = "El docente ya se encuentra registrado";
                    TxtApellidosDocente.Text = "";
                    TxtClaveDocente.Text = "";
                    TxtCorreoDocente.Text = "";
                    TxtIDDocente.Text = "";
                    TxtNombreDocente.Text = "";
                    TxtAsignaturaDocente.Text = "";
                }
            }
        }
        protected void TxtNombreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmInicio.aspx");
        }
    }
}
