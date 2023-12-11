namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            txtMontoTotal = new TextBox();
            dgvData = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            txtNombreProveedor = new TextBox();
            txtNroDoc = new TextBox();
            txtNroDocCliente = new TextBox();
            txtNombreCliente = new Label();
            label7 = new Label();
            label5 = new Label();
            gbInfoProveedor = new GroupBox();
            txtTipoDocumento = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtFecha = new TextBox();
            lblDoc = new Label();
            gbInfo = new GroupBox();
            label3 = new Label();
            btnLimpiarCompra = new FontAwesome.Sharp.IconButton();
            txtBusquedaDoc = new TextBox();
            label2 = new Label();
            btnBuscarDoc = new FontAwesome.Sharp.IconButton();
            lblRegistrar = new Label();
            label1 = new Label();
            txtMontoPago = new TextBox();
            label6 = new Label();
            txtMontoCambio = new TextBox();
            label8 = new Label();
            btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            gbInfoProveedor.SuspendLayout();
            gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(135, 731);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(117, 27);
            txtMontoTotal.TabIndex = 51;
            txtMontoTotal.Text = "0";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Subtotal });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(40, 378);
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
            dgvData.Size = new Size(743, 341);
            dgvData.TabIndex = 53;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio ";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 150;
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
            // txtNombreProveedor
            // 
            txtNombreProveedor.Enabled = false;
            txtNombreProveedor.Location = new Point(182, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(403, 27);
            txtNombreProveedor.TabIndex = 38;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(620, 60);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(107, 27);
            txtNroDoc.TabIndex = 37;
            // 
            // txtNroDocCliente
            // 
            txtNroDocCliente.Enabled = false;
            txtNroDocCliente.Location = new Point(18, 60);
            txtNroDocCliente.Name = "txtNroDocCliente";
            txtNroDocCliente.Size = new Size(156, 27);
            txtNroDocCliente.TabIndex = 35;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.AutoSize = true;
            txtNombreCliente.Location = new Point(182, 35);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(117, 20);
            txtNombreCliente.TabIndex = 2;
            txtNombreCliente.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 33);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 0;
            label7.Text = "Número Documento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 735);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 49;
            label5.Text = "Monto Total: ";
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(txtNroDoc);
            gbInfoProveedor.Controls.Add(txtNroDocCliente);
            gbInfoProveedor.Controls.Add(txtNombreCliente);
            gbInfoProveedor.Controls.Add(label7);
            gbInfoProveedor.Location = new Point(40, 259);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(743, 109);
            gbInfoProveedor.TabIndex = 52;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Cliente";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.Location = new Point(182, 60);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(206, 27);
            txtTipoDocumento.TabIndex = 38;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(395, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 27);
            txtUsuario.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 35);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 36;
            label4.Text = "Usuario:";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(18, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(156, 27);
            txtFecha.TabIndex = 35;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(182, 36);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(124, 20);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
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
            gbInfo.Location = new Point(40, 144);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(743, 109);
            gbInfo.TabIndex = 50;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
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
            btnLimpiarCompra.Location = new Point(446, 92);
            btnLimpiarCompra.Name = "btnLimpiarCompra";
            btnLimpiarCompra.Size = new Size(88, 32);
            btnLimpiarCompra.TabIndex = 48;
            btnLimpiarCompra.Text = "Limpiar";
            btnLimpiarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarCompra.UseVisualStyleBackColor = false;
            btnLimpiarCompra.Click += btnLimpiarCompra_Click;
            // 
            // txtBusquedaDoc
            // 
            txtBusquedaDoc.Location = new Point(188, 94);
            txtBusquedaDoc.Name = "txtBusquedaDoc";
            txtBusquedaDoc.Size = new Size(156, 27);
            txtBusquedaDoc.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 46;
            label2.Text = "Número Documento: ";
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
            btnBuscarDoc.Location = new Point(351, 92);
            btnBuscarDoc.Name = "btnBuscarDoc";
            btnBuscarDoc.Size = new Size(88, 32);
            btnBuscarDoc.TabIndex = 45;
            btnBuscarDoc.Text = "Buscar ";
            btnBuscarDoc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarDoc.UseVisualStyleBackColor = false;
            btnBuscarDoc.Click += btnBuscarDoc_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(40, 36);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(189, 31);
            lblRegistrar.TabIndex = 44;
            lblRegistrar.Text = "Detalle de Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(773, 803);
            label1.TabIndex = 43;
            // 
            // txtMontoPago
            // 
            txtMontoPago.Location = new Point(366, 731);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(117, 27);
            txtMontoPago.TabIndex = 56;
            txtMontoPago.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 735);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 55;
            label6.Text = "Monto Pago: ";
            // 
            // txtMontoCambio
            // 
            txtMontoCambio.Location = new Point(621, 732);
            txtMontoCambio.Name = "txtMontoCambio";
            txtMontoCambio.Size = new Size(117, 27);
            txtMontoCambio.TabIndex = 58;
            txtMontoCambio.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 735);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 57;
            label8.Text = "Monto Cambio: ";
            // 
            // btnDescargarPdf
            // 
            btnDescargarPdf.BackColor = Color.White;
            btnDescargarPdf.Cursor = Cursors.Hand;
            btnDescargarPdf.FlatAppearance.BorderColor = Color.Black;
            btnDescargarPdf.FlatStyle = FlatStyle.Flat;
            btnDescargarPdf.ForeColor = Color.Black;
            btnDescargarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnDescargarPdf.IconColor = Color.Black;
            btnDescargarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargarPdf.IconSize = 15;
            btnDescargarPdf.Location = new Point(617, 777);
            btnDescargarPdf.Name = "btnDescargarPdf";
            btnDescargarPdf.Size = new Size(166, 33);
            btnDescargarPdf.TabIndex = 59;
            btnDescargarPdf.Text = "Descargar PDF";
            btnDescargarPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDescargarPdf.UseVisualStyleBackColor = false;
            btnDescargarPdf.Click += btnDescargarPdf_Click;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 856);
            Controls.Add(btnDescargarPdf);
            Controls.Add(txtMontoCambio);
            Controls.Add(label8);
            Controls.Add(txtMontoPago);
            Controls.Add(label6);
            Controls.Add(txtMontoTotal);
            Controls.Add(dgvData);
            Controls.Add(label5);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfo);
            Controls.Add(btnLimpiarCompra);
            Controls.Add(txtBusquedaDoc);
            Controls.Add(label2);
            Controls.Add(btnBuscarDoc);
            Controls.Add(lblRegistrar);
            Controls.Add(label1);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMontoTotal;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private TextBox txtNombreProveedor;
        private TextBox txtNroDoc;
        private TextBox txtNroDocCliente;
        private Label txtNombreCliente;
        private Label label7;
        private Label label5;
        private GroupBox gbInfoProveedor;
        private TextBox txtTipoDocumento;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtFecha;
        private Label lblDoc;
        private GroupBox gbInfo;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnLimpiarCompra;
        private TextBox txtBusquedaDoc;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscarDoc;
        private Label lblRegistrar;
        private Label label1;
        private TextBox txtMontoPago;
        private Label label6;
        private TextBox txtMontoCambio;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
    }
}