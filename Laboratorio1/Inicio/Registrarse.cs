﻿using System;
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
    public partial class Registrarse : Form
    {
        ToolTip tt; //M

        public Registrarse()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            tt = new ToolTip(); //M
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void llDatosCuenta_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void llDatosCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                tt.IsBalloon = true;
                tt.ToolTipIcon = ToolTipIcon.Info;
                tt.ToolTipTitle = "Nombre de usuario";
                tt.Show(string.Empty, llDatosCuenta, 0);
                tt.Show("Ingresá acá el nombre con el que vas a iniciar sesión.\nSolo letras y números, sin espacios.", llDatosCuenta, 3500);
         
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TimeSpan ts = System.DateTime.Today - dpFecNac.Value;
            int years = ts.Days / 365;
            if( tbNombres.TextLength <1 || tbApellidos.TextLength < 1 || tbUsername.TextLength <1 || 
                tbPass.TextLength < 6 || !tbPass.Text.Equals(tbPassConf.Text) ||
                tbEmail.TextLength < 1 || years < 18)
            {   // EN REALIDAD ESTE HICE A LAS APURADAS, TENDRÍAMMOS QUE SEPARAR CADA CASO E INFORMAR PORQUEÉ NO SE PUEDE
                MessageBox.Show("Error putito");
            }
            else  /// ésto es en el caso de que todo esté bien
            {   /// unhandled acveptioon,  excepción no atenddia (el delay me está reventando jajaç)
                CampingEntities1 db = new CampingEntities1();

                try         ///  falta hacer que se cierre la ventana. cargá esto así trabajo desde acá porque hice modificaciónes hoy pero las meto en este
                {
                    var q = db.Usuario.Where(p => p.username.Equals(tbUsername.Text));
                    if (q.Count()>0)
                        MessageBox.Show("El nombre de usuario ya existe");
                    else
                    {
                        Usuario u = new Usuario
                        {
                            apellido = tbApellidos.Text,
                            nombre = tbNombres.Text,
                            username = tbUsername.Text,
                            clave = tbPass.Text,
                            correo = tbEmail.Text,
                            hombre = rbMasculino.Checked,
                            nacimiento = dpFecNac.Value,
                            direccion = tbDireccion.Text,
                            id_rol = Rol.USUARIO
                        };
                        db.Usuario.Add(u);
                        db.SaveChanges();
                        MessageBox.Show("Listo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

