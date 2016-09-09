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
    public partial class buscador : Form
    {
        public buscador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CampingEntities1 db = new CampingEntities1();

                var innerJoin = from u in db.Usuario
                                join r in db.Rol on u.id_rol equals r.id_rol
                                select new
                                {
                                    Usuario = u.username,
                                    Nombre = u.nombre + " " + u.apellido,
                                    Rol = r.tipo
                                };

                dataGridView1.DataSource = innerJoin.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void buscador_Load(object sender, EventArgs e)
        {

        }
    }
}
