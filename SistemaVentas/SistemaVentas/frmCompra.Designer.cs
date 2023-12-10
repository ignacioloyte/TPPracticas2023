namespace CapaPresentacion
{
    partial class frmCompra
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
            label9 = new Label();
            lblRegistrar = new Label();
            gbInfo = new GroupBox();
            txtFecha = new TextBox();
            cbDoc = new ComboBox();
            lblDoc = new Label();
            label1 = new Label();
            txtNombreProveedor = new ComboBox();
            label2 = new Label();
            txtDocProveedor = new ComboBox();
            label3 = new Label();
            gbInfoProveedor = new GroupBox();
            txtIdProveedor = new TextBox();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            gbInfoProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            label7 = new Label();
            txtPrecioVenta = new TextBox();
            label6 = new Label();
            txtPrecioCompra = new TextBox();
            label5 = new Label();
            txtProducto = new TextBox();
            txtIdProducto = new TextBox();
            txtCodProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            lblCodProducto = new Label();
            dgvData = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            label8 = new Label();
            btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            gbInfo.SuspendLayout();
            gbInfoProveedor.SuspendLayout();
            gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(150, 5);
            label9.Name = "label9";
            label9.Padding = new Padding(8, 8, 8, 8);
            label9.Size = new Size(956, 670);
            label9.TabIndex = 22;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(168, 19);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(200, 31);
            lblRegistrar.TabIndex = 23;
            lblRegistrar.Text = "Registrar Compra";
            // 
            // gbInfo
            // 
            gbInfo.BackColor = Color.White;
            gbInfo.Controls.Add(txtFecha);
            gbInfo.Controls.Add(cbDoc);
            gbInfo.Controls.Add(lblDoc);
            gbInfo.Controls.Add(label1);
            gbInfo.Location = new Point(179, 68);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(409, 109);
            gbInfo.TabIndex = 24;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Compra";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(18, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(156, 27);
            txtFecha.TabIndex = 35;
            // 
            // cbDoc
            // 
            cbDoc.Enabled = false;
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(182, 60);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(206, 28);
            cbDoc.TabIndex = 3;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(182, 37);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(124, 20);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.FormattingEnabled = true;
            txtNombreProveedor.Location = new Point(251, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(233, 28);
            txtNombreProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 37);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Razón Social:";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.FormattingEnabled = true;
            txtDocProveedor.Location = new Point(15, 59);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(178, 28);
            txtDocProveedor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 36);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 0;
            label3.Text = "Número Documento:";
            // 
            // gbInfoProveedor
            // 
            gbInfoProveedor.BackColor = Color.White;
            gbInfoProveedor.Controls.Add(txtIdProveedor);
            gbInfoProveedor.Controls.Add(btnBuscarProveedor);
            gbInfoProveedor.Controls.Add(txtNombreProveedor);
            gbInfoProveedor.Controls.Add(label2);
            gbInfoProveedor.Controls.Add(txtDocProveedor);
            gbInfoProveedor.Controls.Add(label3);
            gbInfoProveedor.Location = new Point(603, 68);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Size = new Size(491, 109);
            gbInfoProveedor.TabIndex = 25;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Proveedor";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(437, 25);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(47, 27);
            txtIdProveedor.TabIndex = 26;
            txtIdProveedor.Visible = false;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.Cursor = Cursors.Hand;
            btnBuscarProveedor.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.White;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.Black;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 27;
            btnBuscarProveedor.Location = new Point(199, 59);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(46, 29);
            btnBuscarProveedor.TabIndex = 27;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // gbInfoProducto
            // 
            gbInfoProducto.BackColor = Color.White;
            gbInfoProducto.Controls.Add(txtCantidad);
            gbInfoProducto.Controls.Add(label7);
            gbInfoProducto.Controls.Add(txtPrecioVenta);
            gbInfoProducto.Controls.Add(label6);
            gbInfoProducto.Controls.Add(txtPrecioCompra);
            gbInfoProducto.Controls.Add(label5);
            gbInfoProducto.Controls.Add(txtProducto);
            gbInfoProducto.Controls.Add(txtIdProducto);
            gbInfoProducto.Controls.Add(txtCodProducto);
            gbInfoProducto.Controls.Add(btnBuscarProducto);
            gbInfoProducto.Controls.Add(label4);
            gbInfoProducto.Controls.Add(lblCodProducto);
            gbInfoProducto.Location = new Point(179, 184);
            gbInfoProducto.Name = "gbInfoProducto";
            gbInfoProducto.Size = new Size(807, 109);
            gbInfoProducto.TabIndex = 28;
            gbInfoProducto.TabStop = false;
            gbInfoProducto.Text = "Información Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(699, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(91, 27);
            txtCantidad.TabIndex = 29;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(699, 36);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 34;
            label7.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(583, 59);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(110, 27);
            txtPrecioVenta.TabIndex = 33;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 35);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 32;
            label6.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(463, 59);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(110, 27);
            txtPrecioCompra.TabIndex = 31;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 36);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 30;
            label5.Text = "Precio Compra:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(251, 60);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(206, 27);
            txtProducto.TabIndex = 29;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(142, 29);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(47, 27);
            txtIdProducto.TabIndex = 28;
            txtIdProducto.Visible = false;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(18, 61);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(175, 27);
            txtCodProducto.TabIndex = 28;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.White;
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.Black;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 27;
            btnBuscarProducto.Location = new Point(199, 59);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(46, 29);
            btnBuscarProducto.TabIndex = 27;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 37);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Producto:";
            // 
            // lblCodProducto
            // 
            lblCodProducto.AutoSize = true;
            lblCodProducto.Location = new Point(15, 36);
            lblCodProducto.Name = "lblCodProducto";
            lblCodProducto.Size = new Size(106, 20);
            lblCodProducto.TabIndex = 0;
            lblCodProducto.Text = "Cód. Producto:";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Productos, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(179, 300);
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
            dgvData.Size = new Size(807, 341);
            dgvData.TabIndex = 35;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            IdProducto.Width = 125;
            // 
            // Productos
            // 
            Productos.HeaderText = "Productos";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            Productos.ReadOnly = true;
            Productos.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 180;
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
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = DataGridViewTriState.True;
            btnEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEliminar.Width = 30;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton1.IconColor = Color.OrangeRed;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(993, 196);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(102, 97);
            iconButton1.TabIndex = 36;
            iconButton1.Text = "Agregar";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(995, 548);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(99, 27);
            txtTotalPagar.TabIndex = 36;
            txtTotalPagar.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(995, 524);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 35;
            label8.Text = "Total a Pagar:";
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrarCompra.IconColor = Color.OrangeRed;
            btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCompra.IconSize = 25;
            btnRegistrarCompra.Location = new Point(995, 585);
            btnRegistrarCompra.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(102, 52);
            btnRegistrarCompra.TabIndex = 37;
            btnRegistrarCompra.Text = "Registrar";
            btnRegistrarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 787);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(txtTotalPagar);
            Controls.Add(label8);
            Controls.Add(iconButton1);
            Controls.Add(dgvData);
            Controls.Add(gbInfoProducto);
            Controls.Add(gbInfoProveedor);
            Controls.Add(gbInfo);
            Controls.Add(lblRegistrar);
            Controls.Add(label9);
            Name = "frmCompra";
            Text = "Form1";
            Load += frmRegistrarCompra_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbInfoProveedor.ResumeLayout(false);
            gbInfoProveedor.PerformLayout();
            gbInfoProducto.ResumeLayout(false);
            gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label lblRegistrar;
        private GroupBox gbInfo;
        private Label label1;
        private ComboBox cbDoc;
        private Label lblDoc;
        private ComboBox txtNombreProveedor;
        private Label label2;
        private ComboBox txtDocProveedor;
        private Label label3;
        private GroupBox gbInfoProveedor;
        private TextBox txtIdProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private GroupBox gbInfoProducto;
        private TextBox txtCodProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label label4;
        private Label lblCodProducto;
        private NumericUpDown txtCantidad;
        private Label label7;
        private TextBox txtPrecioVenta;
        private Label label6;
        private TextBox txtPrecioCompra;
        private Label label5;
        private TextBox txtProducto;
        private TextBox txtIdProducto;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btnEliminar;
        private TextBox txtTotalPagar;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnRegistrarCompra;
        private TextBox txtFecha;
    }
}