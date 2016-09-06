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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcerca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnventas)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 48);
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
            this.lbluser.Size = new System.Drawing.Size(265, 28);
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
            this.lblfecha.Location = new System.Drawing.Point(604, 14);
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
            this.btnmin.Location = new System.Drawing.Point(725, 6);
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
            this.btncerrar.Location = new System.Drawing.Point(760, 6);
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
            this.panel3.Size = new System.Drawing.Size(793, 82);
            this.panel3.TabIndex = 2;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackgroundImage = global::Tutorial5.Properties.Resources.Acerca;
            this.btnAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcerca.Location = new System.Drawing.Point(700, 6);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(80, 70);
            this.btnAcerca.TabIndex = 9;
            this.btnAcerca.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAcerca, "Clientes");
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Tutorial5.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(27, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 70);
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.toolTip1.SetToolTip(this.btnHome, "Ventas");
            // 
            // btnproveedores
            // 
            this.btnproveedores.BackgroundImage = global::Tutorial5.Properties.Resources.proveedor;
            this.btnproveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproveedores.Location = new System.Drawing.Point(572, 0);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(100, 80);
            this.btnproveedores.TabIndex = 7;
            this.btnproveedores.TabStop = false;
            this.toolTip1.SetToolTip(this.btnproveedores, "Proveedores");
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            this.btnproveedores.MouseLeave += new System.EventHandler(this.btnproveedores_MouseLeave);
            this.btnproveedores.MouseHover += new System.EventHandler(this.btnproveedores_MouseHover);
            // 
            // btnclientes
            // 
            this.btnclientes.BackgroundImage = global::Tutorial5.Properties.Resources.clientes;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclientes.Location = new System.Drawing.Point(447, 6);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(80, 70);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.TabStop = false;
            this.toolTip1.SetToolTip(this.btnclientes, "Clientes");
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            this.btnclientes.MouseLeave += new System.EventHandler(this.btnclientes_MouseLeave);
            this.btnclientes.MouseHover += new System.EventHandler(this.btnclientes_MouseHover);
            // 
            // btncompras
            // 
            this.btncompras.BackgroundImage = global::Tutorial5.Properties.Resources.compras;
            this.btncompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncompras.Location = new System.Drawing.Point(326, 6);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(80, 70);
            this.btncompras.TabIndex = 5;
            this.btncompras.TabStop = false;
            this.toolTip1.SetToolTip(this.btncompras, "Compras");
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            this.btncompras.MouseLeave += new System.EventHandler(this.btncompras_MouseLeave);
            this.btncompras.MouseHover += new System.EventHandler(this.btncompras_MouseHover);
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
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            this.btnventas.MouseLeave += new System.EventHandler(this.btnventas_MouseLeave);
            this.btnventas.MouseHover += new System.EventHandler(this.btnventas_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Tutorial5.Properties.Resources.cabecera;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 105);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(789, 398);
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
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Tutorial5.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}