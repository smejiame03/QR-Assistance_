using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QR_Assistence
{
    public partial class FrmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BtnRegistroDocente0_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEstudiante.aspx");
        }

        protected void BtnRegistroDocente_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroDocente.aspx");
        }
    }
}