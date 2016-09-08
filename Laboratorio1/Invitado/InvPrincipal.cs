using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5.Invitado
{
    public partial class InvPrincipal : Form
    {
        public InvPrincipal()
        {
            InitializeComponent();
        }

        //Venta de Inicio - Galeria de fotos
        static int contIm;
        private void InvPrincipal_Load(object sender, EventArgs e)
        {
            //galeria
            pbGaleria.BackgroundImage = Properties.Resources.hosteria_noche;
            lblGaleria.Text = "El complejo  de ecoturístico Añoranzas Chaqueñas abrió sus puertas el día 17 junio de 2005, siempre con el objetivo de lograr el propósito de ofrecer el mejor servicio y calidad posible para quien decida descansar y tomar un respiro sano, dejando volar sus sueños y añorando  el aroma del río, dentro de un ambiente rústico, acogedor, sano y totalmente familia.";
            contIm = 7;
            lblPosicion.Text = "Inicio";
            pHome.Visible = true;
            pTarifas.Visible = false;
            pQSomos.Visible = false;
            pAcerca.Visible = false;
            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
            toolTip1.SetToolTip(btnAcerca,"Acerca");
            toolTip1.SetToolTip(btnQSomos, "Quienes somos");
            toolTip1.SetToolTip(btnHome, "Inicio");
            toolTip1.SetToolTip(btnTarifas, "Tarifas");
        }

        //mover imagenes hacia adelante
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (contIm > 0 && contIm < 8)
            {
                if (contIm == 1)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.camping;
                    lblGaleria.Text = "Camping: Cuenta con parcelas definidas para carpas, es un bosque donde puedes acampar, sanitarios, servicios de electricidad, agua caliente y acceso a la pileta de natación, restaurante, museo, área de juegos y cancha de futbol.";
                }
                if (contIm == 2)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.restaurant;
                    lblGaleria.Text = "Restaurante: Ofrece los platos más representativos de la cocina chaqueña rescatando el sabor de la comida de las abuelas, que lo identifica dentro de uno de los mejores en esta especialidad. El restaurante además cuenta con una espectacular área de juegos. También tiene cancha de fútbol y amplio lugar para estacionar.";
                }
                if (contIm == 3)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.posada;
                    lblGaleria.Text = "Posada: Está diseñada como una antigua casa de campo, donde se destaca su decoración sencilla y cálida. Cuenta con: Una amplia galería con vista al parque y una cómoda sala de estar con televisión satelital, sillones, almohadones y servicio de WiFi. Un amplio y confortable quincho para disfrutar de las tardes al aire libre. Habitaciones dobles y triples con baño privado, agua caliente, aire acondicionado y ropa de cama. Pileta de natación.";
                }
                if (contIm == 4)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.museo;
                    lblGaleria.Text = "Museo: El complejo cuenta con un amplio espacio en el que se encuentran esculturas coleccionadas por Don Javier a lo largo de los años, entre tantas cosas que allí se encuentran.";
                }
                if (contIm == 5)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.Cabalgata;
                    lblGaleria.Text = "Cabalgata: Se recorre distintos senderos, se charla sobre cuidado ambiental, se hace reconocimiento de huellas, identificación de la flora y fauna del lugar. Se cuenta con guías especialmente capacitados, y caballos adiestrados para este recorrido.";
                }
                if (contIm == 6)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.paseoNautico;
                    lblGaleria.Text = "Paseo Náutico: Este servicio ofrece la posibilidad de conocer el Paraná. Esta embarcación supera ampliamente las necesidades para este servicio, otorgando la confiabilidad que se requiere y mucho más. El acompañamiento de un guía especializado asegura la correcta interpretación de todo lo que esta excusión tiene para mostrar.";
                }
                if (contIm == 7)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.hosteria_noche;
                    lblGaleria.Text = "El complejo  de ecoturístico Añoranzas Chaqueñas abrió sus puertas el día 17 junio de 2005, siempre con el objetivo de lograr el propósito de ofrecer el mejor servicio y calidad posible para quien decida descansar y tomar un respiro sano, dejando volar sus sueños y añorando  el aroma del río, dentro de un ambiente rústico, acogedor, sano y totalmente familia.";
                    contIm = 0;
                }
            }
            contIm++;
        }

        //mover imagenes hacia atras
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (contIm > 0 && contIm < 8)
            {
                if (contIm == 1)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.camping;
                    lblGaleria.Text = "Camping: Cuenta con parcelas definidas para carpas, es un bosque donde puedes acampar, sanitarios, servicios de electricidad, agua caliente y acceso a la pileta de natación, restaurante, museo, área de juegos y cancha de futbol.";
                    contIm = 8;
                }
                if (contIm == 2)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.restaurant;
                    lblGaleria.Text = "Restaurante: Ofrece los platos más representativos de la cocina chaqueña rescatando el sabor de la comida de las abuelas, que lo identifica dentro de uno de los mejores en esta especialidad. El restaurante además cuenta con una espectacular área de juegos. También tiene cancha de fútbol y amplio lugar para estacionar.";
                }
                if (contIm == 3)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.posada;
                    lblGaleria.Text = "Posada: Está diseñada como una antigua casa de campo, donde se destaca su decoración sencilla y cálida. Cuenta con: Una amplia galería con vista al parque y una cómoda sala de estar con televisión satelital, sillones, almohadones y servicio de WiFi. Un amplio y confortable quincho para disfrutar de las tardes al aire libre. Habitaciones dobles y triples con baño privado, agua caliente, aire acondicionado y ropa de cama. Pileta de natación.";
                }
                if (contIm == 4)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.museo;
                    lblGaleria.Text = "Museo: El complejo cuenta con un amplio espacio en el que se encuentran esculturas coleccionadas por Don Javier a lo largo de los años, entre tantas cosas que allí se encuentran.";
                }
                if (contIm == 5)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.Cabalgata;
                    lblGaleria.Text = "Cabalgata: Se recorre distintos senderos, se charla sobre cuidado ambiental, se hace reconocimiento de huellas, identificación de la flora y fauna del lugar. Se cuenta con guías especialmente capacitados, y caballos adiestrados para este recorrido.";
                }
                if (contIm == 6)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.paseoNautico;
                    lblGaleria.Text = "Paseo Náutico: Este servicio ofrece la posibilidad de conocer el Paraná. Esta embarcación supera ampliamente las necesidades para este servicio, otorgando la confiabilidad que se requiere y mucho más. El acompañamiento de un guía especializado asegura la correcta interpretación de todo lo que esta excusión tiene para mostrar.";
                }
                if (contIm == 7)
                {
                    pbGaleria.BackgroundImage = Properties.Resources.hosteria_noche;
                    lblGaleria.Text = "El complejo  de ecoturístico Añoranzas Chaqueñas abrió sus puertas el día 17 junio de 2005, siempre con el objetivo de lograr el propósito de ofrecer el mejor servicio y calidad posible para quien decida descansar y tomar un respiro sano, dejando volar sus sueños y añorando  el aroma del río, dentro de un ambiente rústico, acogedor, sano y totalmente familia.";
                }
            }
            contIm--;

        }

        //Al selecionar Inicio
        private void btnHome_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pTarifas.Visible = false;
            pQSomos.Visible = false;
            pHome.Visible = true;
            lblPosicion.Text = "Inicio";
        }

        //Al selecionar tarifas
        private void btnTarifas_Click(object sender, EventArgs e)
        {
            pAcerca.Visible = false;
            pHome.Visible = false;
            pQSomos.Visible = false;
            pTarifas.Visible = true;
            lblPosicion.Text = "Tarifas";
            lblTarifa.Text = "Las tarifas de nuestros servicios son las siguientes: \n\bCamping: El camping tiene un valor de $50 por carpa y la cantidad maxima de carpas que puede estar es de 20 carpas.\n\bEl restaurante: Si bien los precios varian constante mente, el servicio que se le brinda es de Excelente Calidad y a un precio muy accesible.\n\bPosada: La posada tiene un valor de $200 por persona diariamente, este espacio se destaca por su decoración sencilla y cálida.\n\bCabalgata: Las cabalgatas tienen un costo de $100 por recorrido, con una duración de 1hs. Los horarios son por la mañana(desde las 08:00hs hasta las 12:00hs) y por la tarde(desde las 14:00hs hasta las 17:00hs). \n\bPaseo Nautico: Los Paseos Nauticos tienen un costo de $150 por el recorrido atravez del parana, con una duración de 1hs. Los horarios son por la mañana(desde las 08:00hs hasta las 12:00hs) y por la tarde(desde las 14:00hs hasta las 17:00hs). \n\bProveedurias: Lugar donde se puede proveer de mercaderia fresca a los mejores precios del mercado. \n\bServicios Gratuitos: Otros servicio como Museo, Guia de Pesca, Largadero de Lanchas, Parrillas y Pesca son servicios gratuitos sin ningun costo adicional.";
        }

        //Al selecionar Quienes Somos
        private void btnQSomos_Click(object sender, EventArgs e)
        {
            lblPosicion.Text = "Quienes Somos";
            lblQSomos.Text = "El complejo  de ecoturístico Añoranzas Chaqueñas abrió sus puertas el día 17 junio de 2005, gracias al sueño de don Javier Leandro y su esposa Ana Cecilia, de abrir un camping y restaurante en “Villa Tranquila”, la cual era su quinta de descanso familiar, para albergar a los pescadores. Ese sueño bastó para que surgiera lo que hoy se conoce como Complejo EcoTurístico Añoranzas Chaqueñas.\n\n El Turismo ecológico o ecoturismo es una nueva tendencia del Turismo Alternativo diferente al Turismo tradicional. Es un enfoque para las actividades turísticas en el cual se privilegia la sostenibilidad, la preservación, la apreciación del medio (tanto natural como cultural) que acoge y sensibiliza a los viajantes.";
            pAcerca.Visible = false;
            pHome.Visible = false;
            pTarifas.Visible = false;
            pQSomos.Visible = true;
        }

        //Al selecionar AcercaDe
        private void btnAcerca_Click(object sender, EventArgs e)
        {
            lblPosicion.Text = "Acerca";
            pHome.Visible = false;
            pTarifas.Visible = false;
            pQSomos.Visible = false;
            pAcerca.Visible = true;
        }

        //Cerrar Form
        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere salir del modo Invitado", "◄ AVISO | xCode ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Show();
            }
        }

        //Minimizar
        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
