using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDll
{
    public partial class frm_bodega : Form
    {
        string usuario = "";
        public frm_bodega(string user)
        {
            InitializeComponent();
            ///PARAMETROS///
usuario=user;
            string[] alias = { "Cod Producto", "Producto", "Proveedor", "Presentación", "Fecha Compra", "Unidades Minimas", "Bodega", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarComboConTabla("tbl_proveedor", "nombre");
            navegador1.asignarComboConLista(2, "Pequeña|Mediana|Grande|");
            navegador1.asignarComboConTabla("tbl_bodega", "nombre");
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_producto");
            navegador1.asignarNombreForm("Productos");
        }

        private void Frm_bodega_Load(object sender, EventArgs e)
        {
            ///SEGURIDAD
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
