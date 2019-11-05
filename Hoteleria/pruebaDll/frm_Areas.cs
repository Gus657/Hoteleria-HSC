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
	public partial class frm_Areas : Form
	{
		string usuario = "";
		public frm_Areas(string user)
		{
			InitializeComponent();
			usuario = user;
            string[] alias = { "Cod Area", "Nombre Area", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(171, 166, 191);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("9");
            navegador1.asignarTabla("tbl_areas");
            navegador1.asignarNombreForm("Areas");
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
