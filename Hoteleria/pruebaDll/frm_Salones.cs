using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
	public partial class frm_Salones : Form
	{
		string usuario = "";
		public frm_Salones(string user)
		{
			InitializeComponent();
			usuario = user;
			string[] alias = { "Cod Servicio", "Cod Area", "Nombre", "Estado" };
			navegador1.asignarAlias(alias);
			navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("305");
			navegador1.asignarTabla("tbl_salones");
			navegador1.asignarNombreForm("Salones");
		}

		private void Frm_TipoHabitacion_Load(object sender, EventArgs e)
		{
			string aplicacionActiva = "1";
			navegador1.ObtenerIdUsuario(usuario);
			navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
			navegador1.ObtenerIdAplicacion(aplicacionActiva);
		}

        private void Navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
