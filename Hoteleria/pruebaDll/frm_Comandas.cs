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
	public partial class frm_Comandas : Form
	{
		string usuario = "";
		public frm_Comandas(string user)
		{
			InitializeComponent();
			usuario = user;
			string[] alias = { "Cod Comanda", "Cod Servicio",  "Estado" };
			navegador1.asignarAlias(alias);
			navegador1.asignarSalida(this);
			navegador1.asignarColorFondo(Color.LightBlue);
			navegador1.asignarColorFuente(Color.BlueViolet);
			navegador1.asignarComboConTabla("tbl_servicios", "KidServicio");
			navegador1.asignarAyuda("1");
			navegador1.asignarTabla("tbl_comandas");
			navegador1.asignarNombreForm("Comandas");
		}

		private void Frm_TipoHabitacion_Load(object sender, EventArgs e)
		{
			string aplicacionActiva = "1";
			navegador1.ObtenerIdUsuario(usuario);
			navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
			navegador1.ObtenerIdAplicacion(aplicacionActiva);
		}
	}
}
