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

                var d = db.Usuario.ToList();
                Usuario u = new Usuario();

                //Dim x = From n in Table1 _
                var x = from n in d select new { Nombre = n.nombre, Apellido = n.apellido };
                //Select n.FirstName, n.LastName, N.Department
                //DataGridView1.DataSource = x
                var employee = db.Usuario.Where(em => true).Select(em => new { em.nombre, em.correo }).ToList();
                    //where(x => x.EMAIL == givenInfo || x.USER_NAME == givenInfo)
                    //.Select(x => new { x.EMAIL, x.ID });

                dataGridView1.DataSource = employee;
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
