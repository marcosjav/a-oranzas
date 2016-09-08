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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            panel1.Location = new Point((desktopSize.Width - panel1.Width) / 2, (desktopSize.Height - panel1.Height) / 2);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Start Tec ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.ingresar2;
            if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar el Usuario");
                txtuser.Focus();
            }
            else if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar la Contraseña");
                txtpass.Focus();
            }
            else
            {
                CampingEntities1 db = new CampingEntities1();
                Usuario u = null;
                try
                {
                    u = db.Usuario.Single(p => p.username.Equals(txtuser.Text.ToString()));
                    if (u == null)
                    {
                        MessageBox.Show("Usuario incorrecto");
                    }
                    else if (u.clave.Equals(txtpass.Text))
                    {
                        MessageBox.Show("Bienvenid" + (u.hombre?"o ":"a ") + u.nombre);
                        Program.usuario = u.nombre;
                        this.Hide();
                        MenuPrincipal fr = new MenuPrincipal();
                        fr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta");
                        txtpass.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.ingresar2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.ingresar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarse r = new Registrarse();
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invitado.InvPrincipal ip = new Invitado.InvPrincipal();
            ip.Show();
        }
    }
}
