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
    public partial class MenuPrincipalEmpAdmin : Form
    {
        //Valores por servicio
        const int vCamping = 100;
        const int vPosada = 200;
        const int vCabalgata = 100;
        const int vRestaurante = 20;
        const int vPaseoNautico = 150;
        int valorTotal;

        public MenuPrincipalEmpAdmin()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pListado.Visible = false;
            pInformes.Visible = false;
            pAdminUsr.Visible = false;
            pFacturar.Visible = true;
            lblSeccion.Text = "Facturación";
            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pListado.Visible = false;
            pInformes.Visible = false;
            pAdminUsr.Visible = false;
            pFacturar.Visible = true;
            lblSeccion.Text = "Facturación";
        }

        private void btnAdminUsr_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pListado.Visible = false;
            pInformes.Visible = false;
            pAdminUsr.Visible = true;
            pFacturar.Visible = false;
            lblSeccion.Text = "Administrador de Usuarios";
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pListado.Visible = true;
            pInformes.Visible = false;
            pAdminUsr.Visible = false;
            pFacturar.Visible = false;
            lblSeccion.Text = "Listados";
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pListado.Visible = false;
            pInformes.Visible = true;
            pAdminUsr.Visible = false;
            pFacturar.Visible = false;
            lblSeccion.Text = "Informes Diarios";
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = true;
            pListado.Visible = false;
            pInformes.Visible = false;
            pAdminUsr.Visible = false;
            pFacturar.Visible = false;
            lblSeccion.Text = "Acerca";
        }
    }
}
