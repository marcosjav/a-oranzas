namespace Tutorial5.Invitado
{
    partial class InvPrincipal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAcerca = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnQSomos = new System.Windows.Forms.PictureBox();
            this.btnTarifas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pHome = new System.Windows.Forms.Panel();
            this.fplTextInicio = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGaleria = new System.Windows.Forms.Label();
            this.pbGaleria = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnAvanzar = new System.Windows.Forms.PictureBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pTarifas = new System.Windows.Forms.Panel();
            this.fplTexTarifa = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.pAcerca = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pQSomos = new System.Windows.Forms.Panel();
            this.fplTextoqSom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQSomos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcerca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQSomos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarifas)).BeginInit();
            this.panel1.SuspendLayout();
            this.pHome.SuspendLayout();
            this.fplTextInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvanzar)).BeginInit();
            this.pTarifas.SuspendLayout();
            this.fplTexTarifa.SuspendLayout();
            this.pAcerca.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pQSomos.SuspendLayout();
            this.fplTextoqSom.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnAcerca);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.btnQSomos);
            this.panel3.Controls.Add(this.btnTarifas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 105);
            this.panel3.TabIndex = 2;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackgroundImage = global::Tutorial5.Properties.Resources.Acerca;
            this.btnAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcerca.Location = new System.Drawing.Point(779, 19);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(80, 70);
            this.btnAcerca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAcerca.TabIndex = 9;
            this.btnAcerca.TabStop = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Tutorial5.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(56, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 70);
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnQSomos
            // 
            this.btnQSomos.BackgroundImage = global::Tutorial5.Properties.Resources.clientes;
            this.btnQSomos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQSomos.Location = new System.Drawing.Point(538, 19);
            this.btnQSomos.Name = "btnQSomos";
            this.btnQSomos.Size = new System.Drawing.Size(80, 70);
            this.btnQSomos.TabIndex = 6;
            this.btnQSomos.TabStop = false;
            this.btnQSomos.Click += new System.EventHandler(this.btnQSomos_Click);
            // 
            // btnTarifas
            // 
            this.btnTarifas.BackgroundImage = global::Tutorial5.Properties.Resources.ventas;
            this.btnTarifas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTarifas.Location = new System.Drawing.Point(297, 19);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(80, 70);
            this.btnTarifas.TabIndex = 4;
            this.btnTarifas.TabStop = false;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
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
            this.panel1.TabIndex = 3;
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
            this.lbluser.Text = "Invitado";
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
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.Transparent;
            this.pHome.Controls.Add(this.fplTextInicio);
            this.pHome.Controls.Add(this.pbGaleria);
            this.pHome.Controls.Add(this.btnVolver);
            this.pHome.Controls.Add(this.btnAvanzar);
            this.pHome.Location = new System.Drawing.Point(0, 90);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(900, 349);
            this.pHome.TabIndex = 4;
            this.pHome.Visible = false;
            // 
            // fplTextInicio
            // 
            this.fplTextInicio.Controls.Add(this.lblGaleria);
            this.fplTextInicio.Location = new System.Drawing.Point(459, 9);
            this.fplTextInicio.Name = "fplTextInicio";
            this.fplTextInicio.Size = new System.Drawing.Size(395, 325);
            this.fplTextInicio.TabIndex = 5;
            // 
            // lblGaleria
            // 
            this.lblGaleria.AutoSize = true;
            this.lblGaleria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGaleria.Font = new System.Drawing.Font("FuturaRoundW01-MediumObl", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGaleria.ForeColor = System.Drawing.Color.White;
            this.lblGaleria.Location = new System.Drawing.Point(3, 0);
            this.lblGaleria.Name = "lblGaleria";
            this.lblGaleria.Size = new System.Drawing.Size(66, 26);
            this.lblGaleria.TabIndex = 1;
            this.lblGaleria.Text = "label1";
            this.lblGaleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbGaleria
            // 
            this.pbGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGaleria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGaleria.Location = new System.Drawing.Point(43, 9);
            this.pbGaleria.Name = "pbGaleria";
            this.pbGaleria.Size = new System.Drawing.Size(391, 325);
            this.pbGaleria.TabIndex = 0;
            this.pbGaleria.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::Tutorial5.Properties.Resources.flechaAlreves;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Location = new System.Drawing.Point(6, 157);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 30);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvanzar.BackgroundImage = global::Tutorial5.Properties.Resources.ingresar;
            this.btnAvanzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvanzar.Location = new System.Drawing.Point(861, 157);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(32, 30);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.TabStop = false;
            this.btnAvanzar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPosicion.Location = new System.Drawing.Point(40, 59);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(365, 28);
            this.lblPosicion.TabIndex = 3;
            this.lblPosicion.Text = "Posicion Ventana";
            this.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pTarifas
            // 
            this.pTarifas.BackColor = System.Drawing.Color.Transparent;
            this.pTarifas.Controls.Add(this.fplTexTarifa);
            this.pTarifas.Location = new System.Drawing.Point(0, 90);
            this.pTarifas.Name = "pTarifas";
            this.pTarifas.Size = new System.Drawing.Size(900, 349);
            this.pTarifas.TabIndex = 8;
            this.pTarifas.Visible = false;
            // 
            // fplTexTarifa
            // 
            this.fplTexTarifa.Controls.Add(this.lblTarifa);
            this.fplTexTarifa.Location = new System.Drawing.Point(44, 9);
            this.fplTexTarifa.Name = "fplTexTarifa";
            this.fplTexTarifa.Size = new System.Drawing.Size(792, 325);
            this.fplTexTarifa.TabIndex = 5;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarifa.Font = new System.Drawing.Font("FuturaRoundW01-MediumObl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.ForeColor = System.Drawing.Color.White;
            this.lblTarifa.Location = new System.Drawing.Point(3, 0);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(54, 21);
            this.lblTarifa.TabIndex = 1;
            this.lblTarifa.Text = "label1";
            this.lblTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pAcerca
            // 
            this.pAcerca.BackColor = System.Drawing.Color.Transparent;
            this.pAcerca.Controls.Add(this.panel4);
            this.pAcerca.Location = new System.Drawing.Point(0, 87);
            this.pAcerca.Name = "pAcerca";
            this.pAcerca.Size = new System.Drawing.Size(900, 349);
            this.pAcerca.TabIndex = 9;
            this.pAcerca.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(51, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 301);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nuñez Osvaldo      osvaldito-25@hotmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(374, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "© xCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desarrolladores: Vazquez Marcos    mjv87ster@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Añoranzas Chaqueñas v2.0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Tutorial5.Properties.Resources.xcode;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(224, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(361, 150);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pQSomos
            // 
            this.pQSomos.BackColor = System.Drawing.Color.Transparent;
            this.pQSomos.Controls.Add(this.fplTextoqSom);
            this.pQSomos.Location = new System.Drawing.Point(0, 90);
            this.pQSomos.Name = "pQSomos";
            this.pQSomos.Size = new System.Drawing.Size(900, 349);
            this.pQSomos.TabIndex = 9;
            this.pQSomos.Visible = false;
            // 
            // fplTextoqSom
            // 
            this.fplTextoqSom.Controls.Add(this.lblQSomos);
            this.fplTextoqSom.Location = new System.Drawing.Point(30, 21);
            this.fplTextoqSom.Name = "fplTextoqSom";
            this.fplTextoqSom.Size = new System.Drawing.Size(829, 325);
            this.fplTextoqSom.TabIndex = 5;
            // 
            // lblQSomos
            // 
            this.lblQSomos.AutoSize = true;
            this.lblQSomos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQSomos.Font = new System.Drawing.Font("FuturaRoundW01-MediumObl", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQSomos.ForeColor = System.Drawing.Color.White;
            this.lblQSomos.Location = new System.Drawing.Point(3, 0);
            this.lblQSomos.Name = "lblQSomos";
            this.lblQSomos.Size = new System.Drawing.Size(54, 21);
            this.lblQSomos.TabIndex = 1;
            this.lblQSomos.Text = "label1";
            this.lblQSomos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InvPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tutorial5.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pHome);
            this.Controls.Add(this.pQSomos);
            this.Controls.Add(this.pAcerca);
            this.Controls.Add(this.pTarifas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvPrincipal";
            this.Load += new System.EventHandler(this.InvPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAcerca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQSomos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTarifas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.fplTextInicio.ResumeLayout(false);
            this.fplTextInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvanzar)).EndInit();
            this.pTarifas.ResumeLayout(false);
            this.fplTexTarifa.ResumeLayout(false);
            this.fplTexTarifa.PerformLayout();
            this.pAcerca.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pQSomos.ResumeLayout(false);
            this.fplTextoqSom.ResumeLayout(false);
            this.fplTextoqSom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnAcerca;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnQSomos;
        private System.Windows.Forms.PictureBox btnTarifas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.PictureBox pbGaleria;
        private System.Windows.Forms.PictureBox btnAvanzar;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Panel pTarifas;
        private System.Windows.Forms.Panel pQSomos;
        private System.Windows.Forms.FlowLayoutPanel fplTexTarifa;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.FlowLayoutPanel fplTextInicio;
        private System.Windows.Forms.Label lblGaleria;
        private System.Windows.Forms.FlowLayoutPanel fplTextoqSom;
        private System.Windows.Forms.Label lblQSomos;
        private System.Windows.Forms.Panel pAcerca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}