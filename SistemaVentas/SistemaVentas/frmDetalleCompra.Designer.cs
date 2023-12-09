namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            lblRegistrar = new Label();
            btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            txtBusquedaDoc = new TextBox();
            label2 = new Label();
            btnLimpiarCompra = new FontAwesome.Sharp.IconButton();
            gbInfo = new GroupBox();
            txtTipoDocumento = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            lblDoc = new Label();
            label3 = new Label();
            gbInfoProveedor = new GroupBox();
            txtNombreProveedor = new TextBox();
            txtNroDoc = new TextBox();
            txtNroDocProveedor = new TextBox();
            txtRazonSocial = new Label();
            label7 = new Label();
            dgvData = new DataGridView();
            txtMontoTotal = new TextBox();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            gbInfo.SuspendLayout();
            gbInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(42, 23);
            label1.Name = "label1";
            label1.Size = new Size(676, 565);
            label1.TabIndex = 0;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(57, 37);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(176, 25);
            lblRegistrar.TabIndex = 24;
            lblRegistrar.Text = "Detalle de Compra";
            // 
            // btnBuscarDoc
            // 
            btnBuscarDoc.BackColor = Color.White;
            btnBuscarDoc.Cursor = Cursors.Hand;
            btnBuscarDoc.FlatAppearance.BorderColor = Color.Black;
            btnBuscarDoc.FlatStyle = FlatStyle.Flat;
            btnBuscarDoc.ForeColor = Color.Black;
            btnBuscarDoc.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDoc.IconColor = Color.Black;
            btnBuscarDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarDoc.IconSize = 15;
            btnBuscarDoc.Location = new Point(329, 79);
            btnBuscarDoc.Margin = new Padding(3, 2, 3, 2);
            btnBuscarDoc.Name = "btnBuscarDoc";
            btnBuscarDoc.Size = new Size(77, 24);
            btnBuscarDoc.TabIndex = 29;
            btnBuscarDoc.Text = "Buscar ";
            btnBuscarDoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarDoc.UseVisualStyleBackColor = false;
            btnBuscarDoc.Click += btnBuscarDoc_Click;
            // 
            // txtBusquedaDoc
            // 
            txtBusquedaDoc.Location = new Point(186, 80);
            txtBusquedaDoc.Margin = new Padding(3, 2, 3, 2);
            txtBusquedaDoc.Name = "txtBusquedaDoc";
            txtBusquedaDoc.Size = new Size(137, 23);
            txtBusquedaDoc.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 81);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 36;
            label2.Text = "Número Documento: ";
            // 
            // btnLimpiarCompra
            // 
            btnLimpiarCompra.BackColor = Color.White;
            btnLimpiarCompra.Cursor = Cursors.Hand;
            btnLimpiarCompra.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarCompra.FlatStyle = FlatStyle.Flat;
            btnLimpiarCompra.ForeColor = Color.Black;
            btnLimpiarCompra.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarCompra.IconColor = Color.Black;
            btnLimpiarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarCompra.IconSize = 15;
            btnLimpiarCompra.Location = new Point(412, 79);
            btnLimpiarCompra.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarCompra.Name = "btnLimpiarCompra";
            btnLimpiarCompra.Size = new Size(77, 24);
            btnLimpiarCompra.TabIndex = 38;
            btnLimpiarCompra.Text = "Limpiar";
            btnLimpiarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarCompra.UseVisualStyleBackColor = false;
            // 
            // gbInfo
            // 
            gbInfo.BackColor = Color.White;
            gbInfo.Controls.Add(txtTipoDocumento);
            gbInfo.Controls.Add(txtUsuario);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(txtFecha);
            gbInfo.Controls.Add(lblDoc);
            gbInfo.Controls.Add(label3);
            gbInfo.Location = new Point(57, 118);
            gbInfo.Margin = new Padding(3, 2, 3, 2);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 2, 3, 2);
            gbInfo.Size = new Size(650, 82);
            gbInfo.TabIndex = 39;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Compra";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(159, 45);
            txtTipoDocumento.Margin = new Padding(3, 2, 3, 2);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(181, 23);
            txtTipoDocumento.TabIndex = 38;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(346, 45);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(184, 23);
            txtUsuario.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 26);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 36;
            label4.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(16, 45);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(137, 23);
            txtFecha.TabIndex = 35;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(159, 27);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(99, 15);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 26);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(txtNroDoc);
            gbInfoProveedor.Controls.Add(txtNroDocProveedor);
            gbInfoProveedor.Controls.Add(txtRazonSocial);
            gbInfoProveedor.Controls.Add(label7);
            gbInfoProveedor.Location = new Point(57, 204);
            gbInfoProveedor.Margin = new Padding(3, 2, 3, 2);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Padding = new Padding(3, 2, 3, 2);
            gbInfoProveedor.Size = new Size(650, 82);
            gbInfoProveedor.TabIndex = 40;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Proveedor";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(159, 45);
            txtNombreProveedor.Margin = new Padding(3, 2, 3, 2);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(181, 23);
            txtNombreProveedor.TabIndex = 38;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(346, 45);
            txtNroDoc.Margin = new Padding(3, 2, 3, 2);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(184, 23);
            txtNroDoc.TabIndex = 37;
            // 
            // txtNroDocProveedor
            // 
            txtNroDocProveedor.Location = new Point(16, 45);
            txtNroDocProveedor.Margin = new Padding(3, 2, 3, 2);
            txtNroDocProveedor.Name = "txtNroDocProveedor";
            txtNroDocProveedor.Size = new Size(137, 23);
            txtNroDocProveedor.TabIndex = 35;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.AutoSize = true;
            txtRazonSocial.Location = new Point(159, 26);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(76, 15);
            txtRazonSocial.TabIndex = 2;
            txtRazonSocial.Text = "Razon Social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 25);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 0;
            label7.Text = "Número Documento:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, Subtotal });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(57, 293);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(650, 256);
            dgvData.TabIndex = 41;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(140, 558);
            txtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(137, 23);
            txtMontoTotal.TabIndex = 40;
            txtMontoTotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 561);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 39;
            label5.Text = "Monto Total: ";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(562, 556);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(145, 25);
            iconButton1.TabIndex = 42;
            iconButton1.Text = "Descargar PDF";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 125;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 597);
            Controls.Add(iconButton1);
            Controls.Add(txtMontoTotal);
            Controls.Add(label5);
            Controls.Add(dgvData);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfo);
            Controls.Add(btnLimpiarCompra);
            Controls.Add(txtBusquedaDoc);
            Controls.Add(label2);
            Controls.Add(btnBuscarDoc);
            Controls.Add(lblRegistrar);
            Controls.Add(label1);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRegistrar;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private TextBox txtBusquedaDoc;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnLimpiarCompra;
        private GroupBox gbInfo;
        private TextBox txtTipoDocumento;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtFecha;
        private Label lblDoc;
        private Label label3;
        private GroupBox gbInfoProveedor;
        private TextBox txtNombreProveedor;
        private TextBox txtNroDoc;
        private TextBox txtNroDocProveedor;
        private Label txtRazonSocial;
        private Label label7;
        private DataGridView dgvData;
        private TextBox txtMontoTotal;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}