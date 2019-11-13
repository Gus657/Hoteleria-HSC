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
	public partial class frm_CategoriaHabitacion : Form
	{
		string usuario = "";
		public frm_CategoriaHabitacion(string user)
		{
			InitializeComponent();
			usuario = user;
			string[] alias = { "Categoria", "Estado" };
			navegador1.asignarAlias(alias);
			navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("304");
            navegador1.asignarReporte("309");
            navegador1.asignarTabla("tbl_categorias_habitacion");
			navegador1.asignarNombreForm("Categorias Habitación");
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
