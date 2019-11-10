namespace Hoteleria
{
    partial class ProcesarCheckIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.lb_detalles = new System.Windows.Forms.Label();
            this.gbox_habitacion = new System.Windows.Forms.GroupBox();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.lb_precio = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigoCI = new System.Windows.Forms.TextBox();
            this.gbox_habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procesar Habitación";
            // 
            // lb_detalles
            // 
            this.lb_detalles.AutoSize = true;
            this.lb_detalles.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalles.Location = new System.Drawing.Point(37, 41);
            this.lb_detalles.Name = "lb_detalles";
            this.lb_detalles.Size = new System.Drawing.Size(139, 23);
            this.lb_detalles.TabIndex = 3;
            this.lb_detalles.Text = "Detalles Habitación";
            // 
            // gbox_habitacion
            // 
            this.gbox_habitacion.BackColor = System.Drawing.SystemColors.Window;
            this.gbox_habitacion.Controls.Add(this.lb_detalles);
            this.gbox_habitacion.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_habitacion.Location = new System.Drawing.Point(56, 81);
            this.gbox_habitacion.Name = "gbox_habitacion";
            this.gbox_habitacion.Size = new System.Drawing.Size(282, 145);
            this.gbox_habitacion.TabIndex = 4;
            this.gbox_habitacion.TabStop = false;
            this.gbox_habitacion.Text = "Detalles de la Habitación";
            // 
            // cb_clientes
            // 
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(382, 122);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(370, 21);
            this.cb_clientes.TabIndex = 5;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("HP Simplified", 15.75F);
            this.lb_cliente.Location = new System.Drawing.Point(377, 81);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(178, 28);
            this.lb_cliente.TabIndex = 6;
            this.lb_cliente.Text = "Seleccionar Cliente:";
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Font = new System.Drawing.Font("HP Simplified", 15.75F);
            this.lb_precio.Location = new System.Drawing.Point(423, 198);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(92, 28);
            this.lb_precio.TabIndex = 7;
            this.lb_precio.Text = "Precio:  Q";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("HP Simplified", 15.75F);
            this.lb_fecha.Location = new System.Drawing.Point(423, 159);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(67, 28);
            this.lb_fecha.TabIndex = 8;
            this.lb_fecha.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 15.75F);
            this.label1.Location = new System.Drawing.Point(51, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código de Check-In:";
            // 
            // txt_codigoCI
            // 
            this.txt_codigoCI.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoCI.Location = new System.Drawing.Point(235, 297);
            this.txt_codigoCI.Name = "txt_codigoCI";
            this.txt_codigoCI.Size = new System.Drawing.Size(100, 29);
            this.txt_codigoCI.TabIndex = 11;
            // 
            // ProcesarCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_codigoCI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.lb_precio);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.cb_clientes);
            this.Controls.Add(this.gbox_habitacion);
            this.Controls.Add(this.label2);
            this.Name = "ProcesarCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar CheckIn";
            this.Load += new System.EventHandler(this.ProcesarCheckIn_Load);
            this.gbox_habitacion.ResumeLayout(false);
            this.gbox_habitacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_detalles;
        private System.Windows.Forms.GroupBox gbox_habitacion;
        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigoCI;
    }
}