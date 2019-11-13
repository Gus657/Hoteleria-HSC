namespace Hoteleria
{
    partial class HSC_MesaLibOc
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.gbox_habitacion = new System.Windows.Forms.GroupBox();
            this.lb_detalles = new System.Windows.Forms.Label();
            this.gbox_habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Procesar Mesa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Asignar Mesa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(0, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(773, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "Liberar Mesa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lb_fecha.Location = new System.Drawing.Point(389, 110);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(57, 25);
            this.lb_fecha.TabIndex = 12;
            this.lb_fecha.Text = "Area";
            // 
            // gbox_habitacion
            // 
            this.gbox_habitacion.BackColor = System.Drawing.SystemColors.Window;
            this.gbox_habitacion.Controls.Add(this.lb_detalles);
            this.gbox_habitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_habitacion.Location = new System.Drawing.Point(54, 110);
            this.gbox_habitacion.Name = "gbox_habitacion";
            this.gbox_habitacion.Size = new System.Drawing.Size(282, 145);
            this.gbox_habitacion.TabIndex = 13;
            this.gbox_habitacion.TabStop = false;
            this.gbox_habitacion.Text = "Detalles de la Mesa";
            // 
            // lb_detalles
            // 
            this.lb_detalles.AutoSize = true;
            this.lb_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalles.Location = new System.Drawing.Point(37, 41);
            this.lb_detalles.Name = "lb_detalles";
            this.lb_detalles.Size = new System.Drawing.Size(110, 20);
            this.lb_detalles.TabIndex = 3;
            this.lb_detalles.Text = "Detalles Mesa";
            // 
            // HSC_MesaLibOc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.gbox_habitacion);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HSC_MesaLibOc";
            this.Text = "Procesar Mesa";
            this.Load += new System.EventHandler(this.HSC_MesaLibOc_Load);
            this.gbox_habitacion.ResumeLayout(false);
            this.gbox_habitacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.GroupBox gbox_habitacion;
        private System.Windows.Forms.Label lb_detalles;
    }
}