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
    public partial class MenuPrincipalClientes : Form
    {
        //Valores por servicio
        const int vCamping = 100;
        const int vPosada = 200;
        const int vCabalgata = 100;
        const int vRestaurante = 20;
        const int vPaseoNautico = 150;
        int valorTotal;

        public MenuPrincipalClientes()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            //Centrar el Panel

            lblfecha.Text = DateTime.Now.ToShortDateString();
            lbluser.Text = "Usuario: " + Program.usuario;
            lblhora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            pAcerca.Visible = false;
            pMisServicios.Visible = false;
            pServicios.Visible = true;

            //tooltip de BOTONES DE OPCIONES
            toolTip1.SetToolTip(btnAcerca, "Acerca");
            toolTip1.SetToolTip(btnServicios, "Sevicios");
            toolTip1.SetToolTip(btnMisServ, "Mis Servicios");

            //comentario de precios en el contador de personas
            toolTip1.SetToolTip(contCamping, "$100 por carpa por dia");
            toolTip1.SetToolTip(contRestaurante, "$20 por acesso al restaurante por persona");
            toolTip1.SetToolTip(contPosada, "$200 por persona por dia");
            toolTip1.SetToolTip(contPaseoNautico, "$150 por paseo");
            toolTip1.SetToolTip(contCabalgata, "$100 por paseo");

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

        private void btnSevicios_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pMisServicios.Visible = false;
            pServicios.Visible = true;
            lblSeccion.Text = "Servicios";
        }

        private void btnMisServ_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pServicios.Visible = false;
            pMisServicios.Visible = true;
            lblSeccion.Text = "Mis Servicios";
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            pMisServicios.Visible = false;
            pServicios.Visible = false;
            pAcerca.Visible = true;
            lblSeccion.Text = "Acerca";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        //Checkeado o no checkeado - calculos de totales Panel Servicios
        private void cbCamping_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCamping.Checked)
            {
                contCamping.Enabled = true;
                contCamping.Value = 1;
            }
            else
            {
                contCamping.Enabled = false;
                contCamping.Value = 0;
            }
        }
        private void cbPosada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPosada.Checked)
            {
                contPosada.Enabled = true;
                contPosada.Value = 1;
            }
            else
            {
                contPosada.Enabled = false;
                contPosada.Value = 0;
            }

        }
        private void cbRestaurante_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRestaurante.Checked)
            {
                contRestaurante.Enabled = true;
                contRestaurante.Value = 1;
            }
            else
            {
                contRestaurante.Enabled = false;
                contRestaurante.Value = 0;
            }
        }
        private void cbCabalgatas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCabalgatas.Checked)
            {
                contCabalgata.Enabled = true;
                contCabalgata.Value = 1;
            }
            else
            {
                contCabalgata.Enabled = false;
                contCabalgata.Value = 0;
            }
        }
        private void cbPaseoNautico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPaseoNautico.Checked)
            {
                contPaseoNautico.Enabled = true;
                contPaseoNautico.Value = 1;
            }
            else
            {
                contPaseoNautico.Enabled = false;
                contPaseoNautico.Value = 0;
            }
        }
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            valorTotal += Convert.ToInt32(contCamping.Value.ToString(), 10) * vCamping;
            valorTotal += Convert.ToInt32(contCabalgata.Value.ToString(), 10) * vCabalgata;
            valorTotal += Convert.ToInt32(contPosada.Value.ToString(), 10) * vPosada;
            valorTotal += Convert.ToInt32(contPaseoNautico.Value.ToString(), 10) * vPaseoNautico;
            valorTotal += Convert.ToInt32(contRestaurante.Value.ToString(), 10) * vRestaurante;
            lblTotalPagar.Text = Convert.ToString(valorTotal, 10);
            valorTotal = 0;
        }


    }
}
