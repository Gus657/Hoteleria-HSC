﻿namespace Hoteleria
{
	partial class frm_Menus
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.navegador1 = new CapaDeDiseno.Navegador();
			this.SuspendLayout();
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.White;
			this.navegador1.Location = new System.Drawing.Point(-3, 1);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1178, 657);
			this.navegador1.TabIndex = 0;
			// 
			// frn_menus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1174, 661);
			this.Controls.Add(this.navegador1);
			this.Name = "frn_menus";
			this.Text = "frn_menus";
			this.Load += new System.EventHandler(this.Frm_TipoHabitacion_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CapaDeDiseno.Navegador navegador1;
	}
}