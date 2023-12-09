namespace CapaPresentacion
{
    partial class frmRegistrarCompra
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label9.Location = new Point(131, 4);
            label9.Name = "label9";
            label9.Padding = new Padding(7, 6, 7, 6);
            label9.Size = new Size(837, 480);
            label9.TabIndex = 22;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(147, 14);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(168, 25);
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
            gbInfo.Location = new Point(157, 51);
            gbInfo.Margin = new Padding(3, 2, 3, 2);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 2, 3, 2);
            gbInfo.Size = new Size(358, 82);
            gbInfo.TabIndex = 24;
            gbInfo.TabStop = false;
            gbInfo.Text = "Información Compra";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(16, 45);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(137, 23);
            txtFecha.TabIndex = 35;
            // 
            // cbDoc
            // 
            cbDoc.FormattingEnabled = true;
            cbDoc.Location = new Point(159, 45);
            cbDoc.Margin = new Padding(3, 2, 3, 2);
            cbDoc.Name = "cbDoc";
            cbDoc.Size = new Size(181, 23);
            cbDoc.TabIndex = 3;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(159, 28);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(99, 15);
            lblDoc.TabIndex = 2;
            lblDoc.Text = "Tipo Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.FormattingEnabled = true;
            txtNombreProveedor.Location = new Point(220, 45);
            txtNombreProveedor.Margin = new Padding(3, 2, 3, 2);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(204, 23);
            txtNombreProveedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 28);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Razón Social:";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.FormattingEnabled = true;
            txtDocProveedor.Location = new Point(13, 44);
            txtDocProveedor.Margin = new Padding(3, 2, 3, 2);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(156, 23);
            txtDocProveedor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 27);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
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
            gbInfoProveedor.Location = new Point(528, 51);
            gbInfoProveedor.Margin = new Padding(3, 2, 3, 2);
            gbInfoProveedor.Name = "gbInfoProveedor";
            gbInfoProveedor.Padding = new Padding(3, 2, 3, 2);
            gbInfoProveedor.Size = new Size(430, 82);
            gbInfoProveedor.TabIndex = 25;
            gbInfoProveedor.TabStop = false;
            gbInfoProveedor.Text = "Información Proveedor";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(382, 19);
            txtIdProveedor.Margin = new Padding(3, 2, 3, 2);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(42, 23);
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
            btnBuscarProveedor.Location = new Point(174, 44);
            btnBuscarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(40, 22);
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
            gbInfoProducto.Location = new Point(157, 138);
            gbInfoProducto.Margin = new Padding(3, 2, 3, 2);
            gbInfoProducto.Name = "gbInfoProducto";
            gbInfoProducto.Padding = new Padding(3, 2, 3, 2);
            gbInfoProducto.Size = new Size(706, 82);
            gbInfoProducto.TabIndex = 28;
            gbInfoProducto.TabStop = false;
            gbInfoProducto.Text = "Información Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(612, 44);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(80, 23);
            txtCantidad.TabIndex = 29;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(612, 27);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 34;
            label7.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(510, 44);
            txtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(97, 23);
            txtPrecioVenta.TabIndex = 33;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 26);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 32;
            label6.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(405, 44);
            txtPrecioCompra.Margin = new Padding(3, 2, 3, 2);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(97, 23);
            txtPrecioCompra.TabIndex = 31;
            txtPrecioCompra.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 27);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 30;
            label5.Text = "Precio Compra:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(220, 45);
            txtProducto.Margin = new Padding(3, 2, 3, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(181, 23);
            txtProducto.TabIndex = 29;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(124, 22);
            txtIdProducto.Margin = new Padding(3, 2, 3, 2);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(42, 23);
            txtIdProducto.TabIndex = 28;
            txtIdProducto.Visible = false;
            // 
            // txtCodProducto
            // 
            txtCodProducto.Location = new Point(16, 46);
            txtCodProducto.Margin = new Padding(3, 2, 3, 2);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(154, 23);
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
            btnBuscarProducto.Location = new Point(174, 44);
            btnBuscarProducto.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(40, 22);
            btnBuscarProducto.TabIndex = 27;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 28);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Producto:";
            // 
            // lblCodProducto
            // 
            lblCodProducto.AutoSize = true;
            lblCodProducto.Location = new Point(13, 27);
            lblCodProducto.Name = "lblCodProducto";
            lblCodProducto.Size = new Size(87, 15);
            lblCodProducto.TabIndex = 0;
            lblCodProducto.Text = "Cód. Producto:";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Productos, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(157, 225);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(706, 256);
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
            iconButton1.Location = new Point(869, 147);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(89, 73);
            iconButton1.TabIndex = 36;
            iconButton1.Text = "Agregar";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(871, 411);
            txtTotalPagar.Margin = new Padding(3, 2, 3, 2);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(87, 23);
            txtTotalPagar.TabIndex = 36;
            txtTotalPagar.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(871, 393);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 35;
            label8.Text = "Total a Pagar:";
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrarCompra.IconColor = Color.OrangeRed;
            btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCompra.IconSize = 25;
            btnRegistrarCompra.Location = new Point(871, 439);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(89, 39);
            btnRegistrarCompra.TabIndex = 37;
            btnRegistrarCompra.Text = "Registrar";
            btnRegistrarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarCompra.UseVisualStyleBackColor = true;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // frmRegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 493);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistrarCompra";
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