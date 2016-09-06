using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 ancho = (this.Width - panel3.Width) / 2;
            panel3.Location = new Point(ancho, panel3.Location.Y);
            lblfecha.Text = DateTime.Now.ToShortDateString();
            lbluser.Text = "Usuario: "+ Program.usuario;
            lblhora.Text = DateTime.Now.ToLongTimeString();


        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Ventas frm = new Ventas();
            frm.ShowDialog();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            
            Compras frm = new Compras();
            frm.ShowDialog();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {

            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
        }

        private void btnventas_MouseHover(object sender, EventArgs e)
        {
            //btnventas.Size = new Size(75,70);
            btnventas.BackgroundImageLayout = ImageLayout.Stretch;
            btnventas.BackgroundImage = Properties.Resources.ventas2;
        }

        private void btnventas_MouseLeave(object sender, EventArgs e)
        {
            //btnventas.Size = new Size(70, 65);
            btnventas.BackgroundImageLayout = ImageLayout.Zoom;
            btnventas.BackgroundImage = Properties.Resources.ventas;
        }

        private void btncompras_MouseHover(object sender, EventArgs e)
        {
            btncompras.BackgroundImageLayout = ImageLayout.Stretch;
            btncompras.BackgroundImage = Properties.Resources.compras2;
          //  btncompras.Size = new Size(80, 70);
        }

        private void btncompras_MouseLeave(object sender, EventArgs e)
        {
          //  btncompras.Size = new Size(70, 65);
            btncompras.BackgroundImageLayout = ImageLayout.Zoom;
            btncompras.BackgroundImage = Properties.Resources.compras;
        }

        private void btnclientes_MouseHover(object sender, EventArgs e)
        {
            btnclientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnclientes.BackgroundImage = Properties.Resources.clientes2;
        }

        private void btnclientes_MouseLeave(object sender, EventArgs e)
        {
            btnclientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnclientes.BackgroundImage = Properties.Resources.clientes;
        }

        private void btnproveedores_MouseHover(object sender, EventArgs e)
        {
            btnproveedores.BackgroundImageLayout = ImageLayout.Stretch;
            btnproveedores.BackgroundImage = Properties.Resources.proveedor2;
        }

        private void btnproveedores_MouseLeave(object sender, EventArgs e)
        {
            btnproveedores.BackgroundImageLayout = ImageLayout.Zoom;
            btnproveedores.BackgroundImage = Properties.Resources.proveedor;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | xCode ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
