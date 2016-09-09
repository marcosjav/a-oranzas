namespace Tutorial5
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAcerca = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnproveedores = new System.Windows.Forms.PictureBox();
            this.btnclientes = new System.Windows.Forms.PictureBox();
            this.btncompras = new System.Windows.Forms.PictureBox();
            this.btnventas = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pServicios = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaServicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.contPaseoNautico = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.contCabalgata = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.contRestaurante = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.contPosada = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.contCamping = new System.Windows.Forms.NumericUpDown();
            this.cbPaseoNautico = new System.Windows.Forms.CheckBox();
            this.cbCabalgatas = new System.Windows.Forms.CheckBox();
            this.cbRestaurante = new System.Windows.Forms.CheckBox();
            this.cbPosada = new System.Windows.Forms.CheckBox();
            this.cbCamping = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcerca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnventas)).BeginInit();
            this.panel2.SuspendLayout();
            this.pServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contPaseoNautico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contCabalgata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contRestaurante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contPosada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contCamping)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Tutorial5.Properties.Resources.pie;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Controls.Add(this.lbluser);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.btnmin);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblhora.Location = new System.Drawing.Point(12, 14);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(98, 20);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "22:02:00";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.Window;
            this.lbluser.Location = new System.Drawing.Point(267, 11);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(365, 28);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "Usuario: Osvaldo";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblfecha.Location = new System.Drawing.Point(704, 14);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(115, 25);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "28/10/2014";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.Maroon;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(825, 6);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(36, 36);
            this.btnmin.TabIndex = 1;
            this.btnmin.Text = "--";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Maroon;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.Location = new System.Drawing.Point(860, 6);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 36);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnAcerca);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.btnproveedores);
            this.panel3.Controls.Add(this.btnclientes);
            this.panel3.Controls.Add(this.btncompras);
            this.panel3.Controls.Add(this.btnventas);
            this.panel3.Location = new System.Drawing.Point(3, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 82);
            this.panel3.TabIndex = 2;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackgroundImage = global::Tutorial5.Properties.Resources.Acerca;
            this.btnAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcerca.Location = new System.Drawing.Point(792, 6);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(80, 70);
            this.btnAcerca.TabIndex = 9;
            this.btnAcerca.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAcerca, "Clientes");
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Tutorial5.Properties.Resources.servicios;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(27, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 70);
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHome, "Ventas");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnproveedores
            // 
            this.btnproveedores.BackgroundImage = global::Tutorial5.Properties.Resources.informes;
            this.btnproveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproveedores.Location = new System.Drawing.Point(653, 6);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(80, 70);
            this.btnproveedores.TabIndex = 7;
            this.btnproveedores.TabStop = false;
            this.toolTip1.SetToolTip(this.btnproveedores, "Proveedores");
            // 
            // btnclientes
            // 
            this.btnclientes.BackgroundImage = global::Tutorial5.Properties.Resources.clientes;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclientes.Location = new System.Drawing.Point(499, 6);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(80, 70);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.TabStop = false;
            this.toolTip1.SetToolTip(this.btnclientes, "Clientes");
            // 
            // btncompras
            // 
            this.btncompras.BackgroundImage = global::Tutorial5.Properties.Resources.compras;
            this.btncompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncompras.Location = new System.Drawing.Point(340, 6);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(80, 70);
            this.btncompras.TabIndex = 5;
            this.btncompras.TabStop = false;
            this.toolTip1.SetToolTip(this.btncompras, "Compras");
            // 
            // btnventas
            // 
            this.btnventas.BackgroundImage = global::Tutorial5.Properties.Resources.ventas;
            this.btnventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnventas.Location = new System.Drawing.Point(187, 6);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(80, 70);
            this.btnventas.TabIndex = 4;
            this.btnventas.TabStop = false;
            this.toolTip1.SetToolTip(this.btnventas, "Ventas");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tutorial5.Properties.Resources.cabecera;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 105);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(839, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pServicios
            // 
            this.pServicios.BackColor = System.Drawing.Color.Transparent;
            this.pServicios.Controls.Add(this.btnCalcularTotal);
            this.pServicios.Controls.Add(this.label9);
            this.pServicios.Controls.Add(this.rbCredito);
            this.pServicios.Controls.Add(this.rbDebito);
            this.pServicios.Controls.Add(this.rbEfectivo);
            this.pServicios.Controls.Add(this.btnPagar);
            this.pServicios.Controls.Add(this.lblTotalPagar);
            this.pServicios.Controls.Add(this.label7);
            this.pServicios.Controls.Add(this.label6);
            this.pServicios.Controls.Add(this.dtFechaServicio);
            this.pServicios.Controls.Add(this.label5);
            this.pServicios.Controls.Add(this.contPaseoNautico);
            this.pServicios.Controls.Add(this.label4);
            this.pServicios.Controls.Add(this.contCabalgata);
            this.pServicios.Controls.Add(this.label3);
            this.pServicios.Controls.Add(this.contRestaurante);
            this.pServicios.Controls.Add(this.label2);
            this.pServicios.Controls.Add(this.contPosada);
            this.pServicios.Controls.Add(this.label1);
            this.pServicios.Controls.Add(this.contCamping);
            this.pServicios.Controls.Add(this.cbPaseoNautico);
            this.pServicios.Controls.Add(this.cbCabalgatas);
            this.pServicios.Controls.Add(this.cbRestaurante);
            this.pServicios.Controls.Add(this.cbPosada);
            this.pServicios.Controls.Add(this.cbCamping);
            this.pServicios.Location = new System.Drawing.Point(3, 48);
            this.pServicios.Name = "pServicios";
            this.pServicios.Size = new System.Drawing.Size(897, 402);
            this.pServicios.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(668, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fecha de Servicios";
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.ForeColor = System.Drawing.Color.White;
            this.rbCredito.Location = new System.Drawing.Point(716, 274);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(76, 20);
            this.rbCredito.TabIndex = 22;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebito.ForeColor = System.Drawing.Color.White;
            this.rbDebito.Location = new System.Drawing.Point(801, 274);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(72, 20);
            this.rbDebito.TabIndex = 21;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Debito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.ForeColor = System.Drawing.Color.White;
            this.rbEfectivo.Location = new System.Drawing.Point(625, 274);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(82, 20);
            this.rbEfectivo.TabIndex = 20;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(653, 324);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(200, 64);
            this.btnPagar.TabIndex = 19;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lblTotalPagar.Location = new System.Drawing.Point(808, 193);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(27, 29);
            this.lblTotalPagar.TabIndex = 18;
            this.lblTotalPagar.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(780, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(604, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total a Pagar";
            // 
            // dtFechaServicio
            // 
            this.dtFechaServicio.Location = new System.Drawing.Point(653, 47);
            this.dtFechaServicio.Name = "dtFechaServicio";
            this.dtFechaServicio.Size = new System.Drawing.Size(200, 20);
            this.dtFechaServicio.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad de Personas";
            // 
            // contPaseoNautico
            // 
            this.contPaseoNautico.Enabled = false;
            this.contPaseoNautico.Location = new System.Drawing.Point(520, 348);
            this.contPaseoNautico.Name = "contPaseoNautico";
            this.contPaseoNautico.Size = new System.Drawing.Size(32, 20);
            this.contPaseoNautico.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(328, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad de Personas";
            // 
            // contCabalgata
            // 
            this.contCabalgata.Enabled = false;
            this.contCabalgata.Location = new System.Drawing.Point(520, 273);
            this.contCabalgata.Name = "contCabalgata";
            this.contCabalgata.Size = new System.Drawing.Size(32, 20);
            this.contCabalgata.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(328, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de Personas";
            // 
            // contRestaurante
            // 
            this.contRestaurante.Enabled = false;
            this.contRestaurante.Location = new System.Drawing.Point(520, 198);
            this.contRestaurante.Name = "contRestaurante";
            this.contRestaurante.Size = new System.Drawing.Size(32, 20);
            this.contRestaurante.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Personas";
            // 
            // contPosada
            // 
            this.contPosada.Enabled = false;
            this.contPosada.Location = new System.Drawing.Point(520, 123);
            this.contPosada.Name = "contPosada";
            this.contPosada.Size = new System.Drawing.Size(32, 20);
            this.contPosada.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de Carpas";
            // 
            // contCamping
            // 
            this.contCamping.Enabled = false;
            this.contCamping.Location = new System.Drawing.Point(520, 48);
            this.contCamping.Name = "contCamping";
            this.contCamping.Size = new System.Drawing.Size(32, 20);
            this.contCamping.TabIndex = 5;
            // 
            // cbPaseoNautico
            // 
            this.cbPaseoNautico.AutoSize = true;
            this.cbPaseoNautico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaseoNautico.ForeColor = System.Drawing.Color.White;
            this.cbPaseoNautico.Location = new System.Drawing.Point(27, 343);
            this.cbPaseoNautico.Name = "cbPaseoNautico";
            this.cbPaseoNautico.Size = new System.Drawing.Size(184, 29);
            this.cbPaseoNautico.TabIndex = 4;
            this.cbPaseoNautico.Text = "Paseo Nautico";
            this.cbPaseoNautico.UseVisualStyleBackColor = true;
            this.cbPaseoNautico.CheckedChanged += new System.EventHandler(this.cbPaseoNautico_CheckedChanged);
            // 
            // cbCabalgatas
            // 
            this.cbCabalgatas.AutoSize = true;
            this.cbCabalgatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCabalgatas.ForeColor = System.Drawing.Color.White;
            this.cbCabalgatas.Location = new System.Drawing.Point(27, 268);
            this.cbCabalgatas.Name = "cbCabalgatas";
            this.cbCabalgatas.Size = new System.Drawing.Size(150, 29);
            this.cbCabalgatas.TabIndex = 3;
            this.cbCabalgatas.Text = "Cabalgatas";
            this.cbCabalgatas.UseVisualStyleBackColor = true;
            this.cbCabalgatas.CheckedChanged += new System.EventHandler(this.cbCabalgatas_CheckedChanged);
            // 
            // cbRestaurante
            // 
            this.cbRestaurante.AutoSize = true;
            this.cbRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestaurante.ForeColor = System.Drawing.Color.White;
            this.cbRestaurante.Location = new System.Drawing.Point(27, 193);
            this.cbRestaurante.Name = "cbRestaurante";
            this.cbRestaurante.Size = new System.Drawing.Size(159, 29);
            this.cbRestaurante.TabIndex = 2;
            this.cbRestaurante.Text = "Restaurante";
            this.cbRestaurante.UseVisualStyleBackColor = true;
            this.cbRestaurante.CheckedChanged += new System.EventHandler(this.cbRestaurante_CheckedChanged);
            // 
            // cbPosada
            // 
            this.cbPosada.AutoSize = true;
            this.cbPosada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosada.ForeColor = System.Drawing.Color.White;
            this.cbPosada.Location = new System.Drawing.Point(27, 118);
            this.cbPosada.Name = "cbPosada";
            this.cbPosada.Size = new System.Drawing.Size(110, 29);
            this.cbPosada.TabIndex = 1;
            this.cbPosada.Text = "Posada";
            this.cbPosada.UseVisualStyleBackColor = true;
            this.cbPosada.CheckedChanged += new System.EventHandler(this.cbPosada_CheckedChanged);
            // 
            // cbCamping
            // 
            this.cbCamping.AutoSize = true;
            this.cbCamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamping.ForeColor = System.Drawing.Color.White;
            this.cbCamping.Location = new System.Drawing.Point(27, 43);
            this.cbCamping.Name = "cbCamping";
            this.cbCamping.Size = new System.Drawing.Size(123, 29);
            this.cbCamping.TabIndex = 0;
            this.cbCamping.Text = "Camping";
            this.cbCamping.UseVisualStyleBackColor = true;
            this.cbCamping.CheckedChanged += new System.EventHandler(this.cbCamping_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Location = new System.Drawing.Point(653, 99);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(200, 64);
            this.btnCalcularTotal.TabIndex = 24;
            this.btnCalcularTotal.Text = "CALCULAR";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Tutorial5.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pServicios);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAcerca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnproveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnventas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pServicios.ResumeLayout(false);
            this.pServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contPaseoNautico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contCabalgata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contRestaurante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contPosada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contCamping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnventas;
        private System.Windows.Forms.PictureBox btncompras;
        private System.Windows.Forms.PictureBox btnproveedores;
        private System.Windows.Forms.PictureBox btnclientes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnAcerca;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pServicios;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown contPaseoNautico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown contCabalgata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown contRestaurante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown contPosada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown contCamping;
        private System.Windows.Forms.CheckBox cbPaseoNautico;
        private System.Windows.Forms.CheckBox cbCabalgatas;
        private System.Windows.Forms.CheckBox cbRestaurante;
        private System.Windows.Forms.CheckBox cbPosada;
        private System.Windows.Forms.CheckBox cbCamping;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCalcularTotal;
    }
}