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
    public partial class frm_Habitaciones : Form
    {
        string usuario = "";
        public frm_Habitaciones(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = {"No. Habitacion", "Tipo Habitacion", "Categoria","Precio","Estado", "Disponibilidad"};
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("302");
            navegador1.asignarReporte("309");
            navegador1.asignarComboConTabla("tbl_tipo_habitacion", "KidTipoHabitacion",0);
            navegador1.asignarComboConTabla("tbl_categorias_habitacion", "KidCategoria",0);
            navegador1.asignarTabla("tbl_habitaciones");
            navegador1.asignarNombreForm("Habitaciones");
        }

        private void Frm_habitaciones_Load(object sender, EventArgs e)
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
