/*   Qex Studio License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2017-2021 Luciano Gorosito <lucianogorosito@hotmail.com>   *
*                                                                             *
*    This file is part of Qex Studio                                          *
*                                                                             *
*    Qex Studio is free software: you can redistribute it and/or modify       *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    Qex Studio is distributed in the hope that it will be useful,            *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/

namespace uiGR2020
{
    partial class frmTareaPresEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareaPresEditar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvConsumos = new System.Windows.Forms.DataGridView();
            this._imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this._tareapres_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recurso_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recurso_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._consumo_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recurso_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coeficiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaterialAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "box.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "cog.png");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 146);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 263);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvConsumos, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(766, 257);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // dgvConsumos
            // 
            this.dgvConsumos.AllowUserToAddRows = false;
            this.dgvConsumos.AllowUserToDeleteRows = false;
            this.dgvConsumos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumos.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsumos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvConsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._imagen,
            this._tareapres_id,
            this._recurso_id,
            this._recurso_nombre,
            this._consumo,
            this._consumo_unidad,
            this._recurso_precio,
            this._coeficiente,
            this._subtotal,
            this._categoria,
            this.Editar,
            this.Eliminar});
            this.dgvConsumos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsumos.Location = new System.Drawing.Point(3, 3);
            this.dgvConsumos.MultiSelect = false;
            this.dgvConsumos.Name = "dgvConsumos";
            this.dgvConsumos.ReadOnly = true;
            this.dgvConsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsumos.RowHeadersVisible = false;
            this.dgvConsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumos.Size = new System.Drawing.Size(760, 206);
            this.dgvConsumos.TabIndex = 9;
            this.dgvConsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumos_CellContentClick);
            this.dgvConsumos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvConsumos_CellFormatting);
            // 
            // _imagen
            // 
            this._imagen.HeaderText = "";
            this._imagen.Name = "_imagen";
            this._imagen.ReadOnly = true;
            this._imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._imagen.Width = 22;
            // 
            // _tareapres_id
            // 
            this._tareapres_id.DataPropertyName = "tareapres_id";
            this._tareapres_id.HeaderText = "tareapres_id";
            this._tareapres_id.Name = "_tareapres_id";
            this._tareapres_id.ReadOnly = true;
            this._tareapres_id.Visible = false;
            // 
            // _recurso_id
            // 
            this._recurso_id.DataPropertyName = "recurso_id";
            this._recurso_id.HeaderText = "recurso_id";
            this._recurso_id.Name = "_recurso_id";
            this._recurso_id.ReadOnly = true;
            this._recurso_id.Visible = false;
            // 
            // _recurso_nombre
            // 
            this._recurso_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._recurso_nombre.DataPropertyName = "recurso_nombre";
            this._recurso_nombre.HeaderText = "Nombre";
            this._recurso_nombre.Name = "_recurso_nombre";
            this._recurso_nombre.ReadOnly = true;
            // 
            // _consumo
            // 
            this._consumo.DataPropertyName = "consumo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this._consumo.DefaultCellStyle = dataGridViewCellStyle2;
            this._consumo.HeaderText = "Consumo";
            this._consumo.Name = "_consumo";
            this._consumo.ReadOnly = true;
            this._consumo.Width = 70;
            // 
            // _consumo_unidad
            // 
            this._consumo_unidad.DataPropertyName = "consumo_unidad";
            this._consumo_unidad.HeaderText = "Unidad";
            this._consumo_unidad.Name = "_consumo_unidad";
            this._consumo_unidad.ReadOnly = true;
            // 
            // _recurso_precio
            // 
            this._recurso_precio.DataPropertyName = "recurso_precio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this._recurso_precio.DefaultCellStyle = dataGridViewCellStyle3;
            this._recurso_precio.HeaderText = "Costo";
            this._recurso_precio.Name = "_recurso_precio";
            this._recurso_precio.ReadOnly = true;
            this._recurso_precio.Width = 70;
            // 
            // _coeficiente
            // 
            this._coeficiente.DataPropertyName = "coeficiente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this._coeficiente.DefaultCellStyle = dataGridViewCellStyle4;
            this._coeficiente.HeaderText = "Coef.";
            this._coeficiente.Name = "_coeficiente";
            this._coeficiente.ReadOnly = true;
            this._coeficiente.Width = 70;
            // 
            // _subtotal
            // 
            this._subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this._subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            this._subtotal.HeaderText = "SubTotal";
            this._subtotal.Name = "_subtotal";
            this._subtotal.ReadOnly = true;
            // 
            // _categoria
            // 
            this._categoria.DataPropertyName = "categoria";
            this._categoria.HeaderText = "Categoria";
            this._categoria.Name = "_categoria";
            this._categoria.ReadOnly = true;
            this._categoria.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 22;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnMaterialAgregar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 215);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(760, 39);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btnMaterialAgregar
            // 
            this.btnMaterialAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnMaterialAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaterialAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaterialAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMaterialAgregar.FlatAppearance.BorderSize = 2;
            this.btnMaterialAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnMaterialAgregar.Name = "btnMaterialAgregar";
            this.btnMaterialAgregar.Size = new System.Drawing.Size(169, 33);
            this.btnMaterialAgregar.TabIndex = 0;
            this.btnMaterialAgregar.Text = "Agregar Recurso";
            this.btnMaterialAgregar.UseVisualStyleBackColor = false;
            this.btnMaterialAgregar.Click += new System.EventHandler(this.btnMaterialAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 412);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 46);
            this.panel1.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(627, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(83, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnidad.Location = new System.Drawing.Point(548, 30);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(84, 21);
            this.txtUnidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(548, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrden
            // 
            this.txtOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrden.Location = new System.Drawing.Point(3, 30);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(74, 21);
            this.txtOrden.TabIndex = 0;
            this.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrden_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Orden";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsumo.Location = new System.Drawing.Point(428, 30);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(114, 21);
            this.txtConsumo.TabIndex = 2;
            this.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumo_KeyPress);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(428, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(778, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "  Recursos asignados";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(778, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "  Información General";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 64);
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.Controls.Add(this.txtOrden, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPrecio, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtConsumo, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtUnidad, 3, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(755, 55);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(638, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Costo Unit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(638, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(114, 21);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmTareaPresEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTareaPresEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Item";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvConsumos;
        private System.Windows.Forms.DataGridViewImageColumn _imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tareapres_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recurso_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recurso_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn _consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _consumo_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recurso_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coeficiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn _subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn _categoria;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnMaterialAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}