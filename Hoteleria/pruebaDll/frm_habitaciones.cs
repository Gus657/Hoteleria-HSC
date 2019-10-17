﻿using System;
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
            string[] alias = {  "No. Habitacion", "Tipo Habitacion", "Categoria","Precio","Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarComboConTabla("tbl_tipo_habitacion", "KidTipoHabitacion");
            navegador1.asignarComboConTabla("tbl_categorias_habitacion", "KidCategoria");
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
    }
}