namespace CapaPresentacion
{
    partial class frmUsuario
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNroDoc = new TextBox();
            txtNUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtConfClave = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cbRol = new ComboBox();
            cbEstado = new ComboBox();
            label8 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnLimpiarForm = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtId = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblBuscar = new Label();
            cbBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBusqueda = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtNombreCompleto = new TextBox();
            label10 = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label11 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtIndice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 694);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(18, 174);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Nro. Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(21, 298);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(24, 355);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(21, 113);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombre de usuario:";
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(19, 197);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(204, 27);
            txtNroDoc.TabIndex = 5;
            // 
            // txtNUsuario
            // 
            txtNUsuario.Location = new Point(21, 137);
            txtNUsuario.Name = "txtNUsuario";
            txtNUsuario.Size = new Size(201, 27);
            txtNUsuario.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 321);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(24, 378);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(201, 27);
            txtClave.TabIndex = 8;
            // 
            // txtConfClave
            // 
            txtConfClave.Location = new Point(26, 437);
            txtConfClave.Name = "txtConfClave";
            txtConfClave.PasswordChar = '*';
            txtConfClave.Size = new Size(199, 27);
            txtConfClave.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(26, 414);
            label7.Name = "label7";
            label7.Size = new Size(154, 20);
            label7.TabIndex = 11;
            label7.Text = "Confirmar contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(27, 474);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 13;
            label6.Text = "Rol:";
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(29, 497);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(196, 28);
            cbRol.TabIndex = 14;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(31, 557);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(194, 28);
            cbEstado.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(31, 534);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Estado:";
            label8.Click += label8_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new Point(133, 640);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(31, 605);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(196, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar/Editar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiarForm
            // 
            btnLimpiarForm.BackColor = SystemColors.Highlight;
            btnLimpiarForm.Cursor = Cursors.Hand;
            btnLimpiarForm.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarForm.FlatStyle = FlatStyle.Flat;
            btnLimpiarForm.ForeColor = Color.White;
            btnLimpiarForm.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarForm.IconColor = Color.White;
            btnLimpiarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarForm.IconSize = 20;
            btnLimpiarForm.Location = new Point(33, 640);
            btnLimpiarForm.Name = "btnLimpiarForm";
            btnLimpiarForm.Size = new Size(94, 29);
            btnLimpiarForm.TabIndex = 19;
            btnLimpiarForm.Text = "Limpiar";
            btnLimpiarForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarForm.UseMnemonic = false;
            btnLimpiarForm.UseVisualStyleBackColor = false;
            btnLimpiarForm.Click += btnLimpiarForm_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, NombreUsuario, Documento, NombreCompleto, Email, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(292, 94);
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
            dgvData.Size = new Size(945, 641);
            dgvData.TabIndex = 20;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellFormatting += dgvData_CellFormatting;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "Nombre Usuario";
            NombreUsuario.MinimumWidth = 6;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 125;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Contraseña";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(292, 35);
            label9.Name = "label9";
            label9.Padding = new Padding(8);
            label9.Size = new Size(945, 49);
            label9.TabIndex = 21;
            label9.Text = "Lista Usuario:";
            // 
            // txtId
            // 
            txtId.Location = new Point(183, 83);
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 27);
            txtId.TabIndex = 22;
            txtId.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.White;
            lblBuscar.Location = new Point(624, 50);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 20);
            lblBuscar.TabIndex = 23;
            lblBuscar.Text = "Buscar por:";
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(712, 47);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(196, 28);
            cbBusqueda.TabIndex = 24;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(914, 47);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(201, 27);
            txtBusqueda.TabIndex = 25;
            // 
            // btnBusqueda
            // 
            btnBusqueda.BackColor = Color.White;
            btnBusqueda.Cursor = Cursors.Hand;
            btnBusqueda.FlatAppearance.BorderColor = Color.Black;
            btnBusqueda.FlatStyle = FlatStyle.Flat;
            btnBusqueda.ForeColor = Color.White;
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBusqueda.IconColor = Color.Black;
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBusqueda.IconSize = 27;
            btnBusqueda.Location = new Point(1121, 45);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(49, 29);
            btnBusqueda.TabIndex = 26;
            btnBusqueda.UseVisualStyleBackColor = false;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 27;
            btnLimpiar.Location = new Point(1177, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(44, 29);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(22, 258);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(201, 27);
            txtNombreCompleto.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(18, 235);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 28;
            label10.Text = "Nombre completo:";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox1.Cursor = Cursors.Cross;
            iconPictureBox1.ForeColor = Color.DarkOrange;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPictureBox1.IconColor = Color.DarkOrange;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(21, 23);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 30;
            iconPictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(64, 28);
            label11.Name = "label11";
            label11.Size = new Size(113, 32);
            label11.TabIndex = 31;
            label11.Text = "Usuarios";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(381, 753);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 29);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtIndice
            // 
            txtIndice.Location = new Point(133, 83);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(40, 27);
            txtIndice.TabIndex = 33;
            txtIndice.Text = "-1";
            txtIndice.TextChanged += txtIndice_TextChanged;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1570, 694);
            Controls.Add(txtIndice);
            Controls.Add(iconButton1);
            Controls.Add(label11);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label10);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBusqueda);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(lblBuscar);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(dgvData);
            Controls.Add(btnLimpiarForm);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(cbEstado);
            Controls.Add(label8);
            Controls.Add(cbRol);
            Controls.Add(label6);
            Controls.Add(txtConfClave);
            Controls.Add(label7);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNUsuario);
            Controls.Add(txtNroDoc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNroDoc;
        private TextBox txtNUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtConfClave;
        private Label label7;
        private Label label6;
        private ComboBox cbRol;
        private ComboBox cbEstado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiarForm;
        private DataGridView dgvData;
        private Label label9;
        private TextBox txtId;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblBuscar;
        private ComboBox cbBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtNombreCompleto;
        private Label label10;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtIndice;
    }
}