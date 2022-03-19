using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QR_Assistence
{
    public partial class RegistroEstudiante : System.Web.UI.Page
    {
        ClsEstudiante objEstudiante = new ClsEstudiante();

        protected void TxtNombreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtApellidosEstudiante.Text.Trim() == "" || TxtClaveEstudiante.Text.Trim() == "" || TxtProgramaEstudiante.Text.Trim() == "" || TxtIDEstudiante.Text.Trim() == "" || TxtNombreEstudiante.Text.Trim() == "" || TxtCorreoEstudiante.Text.Trim() == "")
            {
                LblMensaje.Text = "Todos los datos son necesarios";
            }
            else
            {
                DataSet ds = new DataSet();
                ds = objEstudiante.consultar_estudiante(TxtIDEstudiante.Text);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "";
                    if (objEstudiante.guardar_estudiante(TxtIDEstudiante.Text, TxtNombreEstudiante.Text, TxtApellidosEstudiante.Text, TxtCorreoEstudiante.Text, TxtClaveEstudiante.Text, TxtProgramaEstudiante.Text))
                    {
                        LblMensaje.Text = "Registro Exitoso";
                        TxtApellidosEstudiante.Text = "";
                        TxtClaveEstudiante.Text = "";
                        TxtCorreoEstudiante.Text = "";
                        TxtIDEstudiante.Text = "";
                        TxtNombreEstudiante.Text = "";
                        TxtProgramaEstudiante.Text = "";
                    }
                    else
                    {
                        LblMensaje.Text = "Error, Estudiante no guardado";
                    }
                }
                else
                {
                    LblMensaje.Text = "El estudiante ya se encuentra registrado";
                    TxtApellidosEstudiante.Text = "";
                    TxtClaveEstudiante.Text = "";
                    TxtCorreoEstudiante.Text = "";
                    TxtIDEstudiante.Text = "";
                    TxtNombreEstudiante.Text = "";
                    TxtProgramaEstudiante.Text = "";
                }
            }
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmInicio.aspx");
        }
    }
}