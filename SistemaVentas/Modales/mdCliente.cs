﻿using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdCliente : Form
    {
        public Cliente _Cliente { get; set; }

        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;

            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                if (item.Estado)
                    dgvData.Rows.Add(new object[] { item.Documento, item.NombreCompleto });

            }

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow == 0 && iColum > 0)
            {
                _Cliente = new Cliente()
                {
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgvData.Rows[iRow].Cells["NombreCompleto"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            {
                string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();

                if (dgvData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvData.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                        }
                        else { row.Visible = false; }
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }

        }
    }
}
