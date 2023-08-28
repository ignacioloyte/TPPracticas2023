namespace SistemaVentas
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            btnUsuarios = new FontAwesome.Sharp.IconMenuItem();
            btnVentas = new FontAwesome.Sharp.IconMenuItem();
            btnCompras = new FontAwesome.Sharp.IconMenuItem();
            btnClientes = new FontAwesome.Sharp.IconMenuItem();
            btnProveedores = new FontAwesome.Sharp.IconMenuItem();
            btnReportes = new FontAwesome.Sharp.IconMenuItem();
            btnConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            btnAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            Contenedor = new Panel();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { btnUsuarios, btnVentas, btnCompras, btnClientes, btnProveedores, btnReportes, btnConfiguracion, btnAcercaDe });
            Menu.Location = new Point(0, 42);
            Menu.Name = "Menu";
            Menu.Size = new Size(824, 68);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = false;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 40;
            btnUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(80, 64);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnVentas
            // 
            btnVentas.AutoSize = false;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnVentas.IconColor = Color.Black;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 40;
            btnVentas.ImageScaling = ToolStripItemImageScaling.None;
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(80, 64);
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnCompras
            // 
            btnCompras.AutoSize = false;
            btnCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            btnCompras.IconColor = Color.Black;
            btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompras.IconSize = 40;
            btnCompras.ImageScaling = ToolStripItemImageScaling.None;
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(80, 64);
            btnCompras.Text = "Compras";
            btnCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnClientes
            // 
            btnClientes.AutoSize = false;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnClientes.IconColor = Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.IconSize = 40;
            btnClientes.ImageScaling = ToolStripItemImageScaling.None;
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(80, 64);
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnProveedores
            // 
            btnProveedores.AutoSize = false;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnProveedores.IconColor = Color.Black;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 40;
            btnProveedores.ImageScaling = ToolStripItemImageScaling.None;
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(105, 64);
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = false;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 40;
            btnReportes.ImageScaling = ToolStripItemImageScaling.None;
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(80, 64);
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.AutoSize = false;
            btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnConfiguracion.IconColor = Color.Black;
            btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracion.IconSize = 40;
            btnConfiguracion.ImageScaling = ToolStripItemImageScaling.None;
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(105, 64);
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.AutoSize = false;
            btnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnAcercaDe.IconColor = Color.Black;
            btnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAcercaDe.IconSize = 40;
            btnAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(80, 64);
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.DarkOrange;
            MenuTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MenuTitulo.ImageScalingSize = new Size(20, 20);
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(824, 42);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "SistemaVentas";
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 110);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(824, 254);
            Contenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 364);
            Controls.Add(Contenedor);
            Controls.Add(Menu);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu;
            Name = "Inicio";
            Text = "Form1";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem btnAcercaDe;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem btnUsuarios;
        private FontAwesome.Sharp.IconMenuItem btnVentas;
        private FontAwesome.Sharp.IconMenuItem btnCompras;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnProveedores;
        private FontAwesome.Sharp.IconMenuItem btnReportes;
        private FontAwesome.Sharp.IconMenuItem btnConfiguracion;
        private Panel Contenedor;
    }
}