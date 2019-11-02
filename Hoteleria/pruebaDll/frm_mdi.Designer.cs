namespace Hoteleria
{
    partial class frm_mdi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bODEGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERRAMINENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEGURIDADToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAyudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_id_usuario = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.mANTENIMIENTOSToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.hERRAMINENTASToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // mANTENIMIENTOSToolStripMenuItem
            // 
            this.mANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bODEGAToolStripMenuItem,
            this.restauranteToolStripMenuItem});
            this.mANTENIMIENTOSToolStripMenuItem.Name = "mANTENIMIENTOSToolStripMenuItem";
            this.mANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mANTENIMIENTOSToolStripMenuItem.Text = "MANTENIMIENTOS";
            this.mANTENIMIENTOSToolStripMenuItem.Click += new System.EventHandler(this.MANTENIMIENTOSToolStripMenuItem_Click);
            // 
            // bODEGAToolStripMenuItem
            // 
            this.bODEGAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.areasToolStripMenuItem,
            this.salonesToolStripMenuItem});
            this.bODEGAToolStripMenuItem.Name = "bODEGAToolStripMenuItem";
            this.bODEGAToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bODEGAToolStripMenuItem.Text = "Hotel";
            this.bODEGAToolStripMenuItem.Click += new System.EventHandler(this.BODEGAToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem1,
            this.tipoHabitacionToolStripMenuItem,
            this.categoríaToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // habitacionesToolStripMenuItem1
            // 
            this.habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            this.habitacionesToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.habitacionesToolStripMenuItem1.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem1.Click += new System.EventHandler(this.HabitacionesToolStripMenuItem1_Click);
            // 
            // tipoHabitacionToolStripMenuItem
            // 
            this.tipoHabitacionToolStripMenuItem.Name = "tipoHabitacionToolStripMenuItem";
            this.tipoHabitacionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.tipoHabitacionToolStripMenuItem.Text = "Tipo";
            this.tipoHabitacionToolStripMenuItem.Click += new System.EventHandler(this.TipoHabitacionToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.CategoríaToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandasToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.ServiciosToolStripMenuItem_Click);
            // 
            // comandasToolStripMenuItem
            // 
            this.comandasToolStripMenuItem.Name = "comandasToolStripMenuItem";
            this.comandasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.comandasToolStripMenuItem.Text = "Comandas";
            this.comandasToolStripMenuItem.Click += new System.EventHandler(this.ComandasToolStripMenuItem_Click);
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.areasToolStripMenuItem.Text = "Areas";
            this.areasToolStripMenuItem.Click += new System.EventHandler(this.AreasToolStripMenuItem_Click);
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.SalonesToolStripMenuItem_Click);
            // 
            // restauranteToolStripMenuItem
            // 
            this.restauranteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesasToolStripMenuItem,
            this.menusToolStripMenuItem,
            this.tiendasToolStripMenuItem});
            this.restauranteToolStripMenuItem.Name = "restauranteToolStripMenuItem";
            this.restauranteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.restauranteToolStripMenuItem.Text = "Restaurante";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.MesasToolStripMenuItem_Click);
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.menusToolStripMenuItem.Text = "Menus";
            this.menusToolStripMenuItem.Click += new System.EventHandler(this.MenusToolStripMenuItem_Click);
            // 
            // tiendasToolStripMenuItem
            // 
            this.tiendasToolStripMenuItem.Name = "tiendasToolStripMenuItem";
            this.tiendasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tiendasToolStripMenuItem.Text = "Tiendas";
            this.tiendasToolStripMenuItem.Click += new System.EventHandler(this.TiendasToolStripMenuItem_Click);
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // hERRAMINENTASToolStripMenuItem
            // 
            this.hERRAMINENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEGURIDADToolStripMenuItem1});
            this.hERRAMINENTASToolStripMenuItem.Name = "hERRAMINENTASToolStripMenuItem";
            this.hERRAMINENTASToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.hERRAMINENTASToolStripMenuItem.Text = "HERRAMINENTAS";
            // 
            // sEGURIDADToolStripMenuItem1
            // 
            this.sEGURIDADToolStripMenuItem1.Name = "sEGURIDADToolStripMenuItem1";
            this.sEGURIDADToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sEGURIDADToolStripMenuItem1.Text = "SEGURIDAD";
            this.sEGURIDADToolStripMenuItem1.Click += new System.EventHandler(this.SEGURIDADToolStripMenuItem1_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDIToolStripMenuItem,
            this.mantenimientoAyudasToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mDIToolStripMenuItem.Text = "MDI";
            this.mDIToolStripMenuItem.Click += new System.EventHandler(this.MDIToolStripMenuItem_Click);
            // 
            // mantenimientoAyudasToolStripMenuItem
            // 
            this.mantenimientoAyudasToolStripMenuItem.Name = "mantenimientoAyudasToolStripMenuItem";
            this.mantenimientoAyudasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mantenimientoAyudasToolStripMenuItem.Text = "Mantenimiento Ayudas";
            this.mantenimientoAyudasToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoAyudasToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 594);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // lbl_id_usuario
            // 
            this.lbl_id_usuario.AutoSize = true;
            this.lbl_id_usuario.Location = new System.Drawing.Point(535, 9);
            this.lbl_id_usuario.Name = "lbl_id_usuario";
            this.lbl_id_usuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_usuario.TabIndex = 4;
            this.lbl_id_usuario.Text = "label1";
            // 
            // frm_mdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 616);
            this.Controls.Add(this.lbl_id_usuario);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_mdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bODEGAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tipoHabitacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restauranteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiendasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comandasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERRAMINENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.Label lbl_id_usuario;
        private System.Windows.Forms.ToolStripMenuItem sEGURIDADToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mantenimientoAyudasToolStripMenuItem;
	}
}



