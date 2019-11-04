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
	public partial class frm_Tiendas : Form
	{
		string usuario = "";
		public frm_Tiendas(string user)
		{
			InitializeComponent();
			usuario = user;
			string[] alias = { "Cod Tienda", "Area", "Descripción", "Estado" };
			navegador1.asignarAlias(alias);
			navegador1.asignarSalida(this);
			Color Hotel = Color.FromArgb(171, 166, 191);
			navegador1.asignarColorFondo(Hotel);
			navegador1.asignarColorFuente(Color.Black);
			navegador1.asignarComboConTabla("tbl_areas", "nombre", 1);
			navegador1.asignarAyuda("7");
			navegador1.asignarTabla("tbl_tiendas");
			navegador1.asignarNombreForm("Tiendas");
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
