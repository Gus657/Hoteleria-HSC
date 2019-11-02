using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;


namespace Hoteleria
{
    public partial class frm_mdi : Form
    {
        
        private int childFormNumber = 0;
        string sIdUsuario;

        public frm_mdi()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
            string AsRuta;
            string AsIndice;
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      
      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SEGURIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
            sIdUsuario = login.obtenerNombreUsuario();
            lbl_id_usuario.Text = sIdUsuario;
        }

        private void BODEGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

		private void TipoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_TipoHabitacion nuevo = new frm_TipoHabitacion(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void MANTENIMIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void CategoríaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_CategoriaHabitacion nuevo = new frm_CategoriaHabitacion(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}


		private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Servicios nuevo = new frm_Servicios(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void AreasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Areas nuevo = new frm_Areas(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void ComandasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Comandas nuevo = new frm_Comandas(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void SalonesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Salones nuevo = new frm_Salones(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void MenusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Menus nuevo = new frm_Menus(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void MesasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Mesas nuevo = new frm_Mesas(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

		private void TiendasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Tiendas nuevo = new frm_Tiendas(sIdUsuario);
			nuevo.MdiParent = this;
			nuevo.Show();
		}

        private void HabitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Habitaciones nuevo = new frm_Habitaciones(sIdUsuario);
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void SEGURIDADToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(sIdUsuario);
            seguridad.lbl_nombreUsuario.Text = sIdUsuario;
            seguridad.ShowDialog();
        }

		private void MantenimientoAyudasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CapaDeDiseno.Ayudas formayuda = new CapaDeDiseno.Ayudas();
			formayuda.Show();

		}

        private void MDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, " Página web ayuda/ayuda.chm", "Menúboletos.html");//Abre el menu de ayuda HTML
        }
    }
}
