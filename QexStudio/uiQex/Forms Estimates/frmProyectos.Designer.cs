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
    partial class frmProyectos3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyectos3));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProyectoNuevo = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this._Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this._Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPresNuevo = new System.Windows.Forms.Button();
            this.dgvPresupuestos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tipGrupo = new System.Windows.Forms.ToolTip(this.components);
            this.tipMateriales = new System.Windows.Forms.ToolTip(this.components);
            this.icono = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.indirectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coef_resumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyecto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.op_decimales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubropres_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieneHijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pres_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar,
            this.lblAvance});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(450, 17);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 16);
            this.progressBar.Step = 1;
            // 
            // lblAvance
            // 
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(35, 17);
            this.lblAvance.Text = "100%";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 486);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(264, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpetas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgvProyectos, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 450);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnProyectoNuevo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 35);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnProyectoNuevo
            // 
            this.btnProyectoNuevo.BackColor = System.Drawing.Color.Silver;
            this.btnProyectoNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProyectoNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProyectoNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnProyectoNuevo.FlatAppearance.BorderSize = 2;
            this.btnProyectoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectoNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnProyectoNuevo.Name = "btnProyectoNuevo";
            this.btnProyectoNuevo.Size = new System.Drawing.Size(124, 29);
            this.btnProyectoNuevo.TabIndex = 0;
            this.btnProyectoNuevo.Text = "Nueva Carpeta";
            this.tipGrupo.SetToolTip(this.btnProyectoNuevo, "Crear nuevo Proyecto");
            this.btnProyectoNuevo.UseVisualStyleBackColor = false;
            this.btnProyectoNuevo.Click += new System.EventHandler(this.btnProyectoNuevo_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvProyectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProyectos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProyectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._Imagen,
            this._Nombre,
            this._ubicacion,
            this._propietario,
            this._Editar,
            this._Eliminar});
            this.dgvProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProyectos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProyectos.Location = new System.Drawing.Point(3, 3);
            this.dgvProyectos.MultiSelect = false;
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProyectos.RowHeadersVisible = false;
            this.dgvProyectos.RowTemplate.Height = 30;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(248, 409);
            this.dgvProyectos.TabIndex = 3;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
            this.dgvProyectos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProyectos_CellFormatting);
            this.dgvProyectos.SelectionChanged += new System.EventHandler(this.dgvProyectos_SelectionChanged);
            // 
            // _id
            // 
            this._id.DataPropertyName = "id";
            this._id.HeaderText = "Id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._id.Visible = false;
            // 
            // _Imagen
            // 
            this._Imagen.HeaderText = "";
            this._Imagen.Name = "_Imagen";
            this._Imagen.ReadOnly = true;
            this._Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Imagen.Width = 30;
            // 
            // _Nombre
            // 
            this._Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._Nombre.DataPropertyName = "Nombre";
            this._Nombre.HeaderText = "Nombre";
            this._Nombre.Name = "_Nombre";
            this._Nombre.ReadOnly = true;
            this._Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _ubicacion
            // 
            this._ubicacion.DataPropertyName = "ubicacion";
            this._ubicacion.HeaderText = "Ubicacion";
            this._ubicacion.Name = "_ubicacion";
            this._ubicacion.ReadOnly = true;
            this._ubicacion.Visible = false;
            // 
            // _propietario
            // 
            this._propietario.DataPropertyName = "propietario";
            this._propietario.HeaderText = "Propietario";
            this._propietario.Name = "_propietario";
            this._propietario.ReadOnly = true;
            this._propietario.Visible = false;
            // 
            // _Editar
            // 
            this._Editar.HeaderText = "";
            this._Editar.Name = "_Editar";
            this._Editar.ReadOnly = true;
            this._Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Editar.ToolTipText = "Editar Rubro";
            this._Editar.Width = 30;
            // 
            // _Eliminar
            // 
            this._Eliminar.FillWeight = 90F;
            this._Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._Eliminar.HeaderText = "";
            this._Eliminar.Name = "_Eliminar";
            this._Eliminar.ReadOnly = true;
            this._Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Eliminar.ToolTipText = "Eliminar Rubro";
            this._Eliminar.Width = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(279, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(500, 476);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Presupuestos";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dgvPresupuestos, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(490, 450);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnPresNuevo, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(490, 35);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // btnPresNuevo
            // 
            this.btnPresNuevo.BackColor = System.Drawing.Color.Silver;
            this.btnPresNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPresNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPresNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPresNuevo.FlatAppearance.BorderSize = 2;
            this.btnPresNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnPresNuevo.Name = "btnPresNuevo";
            this.btnPresNuevo.Size = new System.Drawing.Size(155, 29);
            this.btnPresNuevo.TabIndex = 0;
            this.btnPresNuevo.Text = "Nuevo Presupuesto";
            this.tipMateriales.SetToolTip(this.btnPresNuevo, "Crear nuevo Presupuesto");
            this.btnPresNuevo.UseVisualStyleBackColor = false;
            this.btnPresNuevo.Click += new System.EventHandler(this.btnPresNuevo_Click);
            // 
            // dgvPresupuestos
            // 
            this.dgvPresupuestos.AllowUserToAddRows = false;
            this.dgvPresupuestos.AllowUserToDeleteRows = false;
            this.dgvPresupuestos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvPresupuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPresupuestos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPresupuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPresupuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPresupuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icono,
            this.id,
            this.ColumnaNombre,
            this.Imagen,
            this.indirectos,
            this.generales,
            this.coef_resumen,
            this.proyecto_id,
            this.Editar,
            this.Eliminar,
            this.op_decimales,
            this.categoria,
            this.wbs,
            this.consumo,
            this.unidad,
            this.costoUnitario,
            this.costoTotal,
            this.precioVenta,
            this.rubropres_Id,
            this.orden,
            this.tieneHijos,
            this.pres_id});
            this.dgvPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresupuestos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPresupuestos.Location = new System.Drawing.Point(3, 3);
            this.dgvPresupuestos.MultiSelect = false;
            this.dgvPresupuestos.Name = "dgvPresupuestos";
            this.dgvPresupuestos.ReadOnly = true;
            this.dgvPresupuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPresupuestos.RowHeadersVisible = false;
            this.dgvPresupuestos.RowTemplate.Height = 30;
            this.dgvPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuestos.Size = new System.Drawing.Size(484, 409);
            this.dgvPresupuestos.TabIndex = 5;
            this.dgvPresupuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPres_CellContentClick);
            this.dgvPresupuestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPres_CellDoubleClick);
            this.dgvPresupuestos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPres_CellFormatting);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "book.png");
            // 
            // icono
            // 
            this.icono.HeaderText = "";
            this.icono.Name = "icono";
            this.icono.ReadOnly = true;
            this.icono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.icono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.icono.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaNombre.DataPropertyName = "nombre";
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Visible = false;
            this.Imagen.Width = 128;
            // 
            // indirectos
            // 
            this.indirectos.DataPropertyName = "indirectos";
            this.indirectos.HeaderText = "Indirectos";
            this.indirectos.Name = "indirectos";
            this.indirectos.ReadOnly = true;
            this.indirectos.Visible = false;
            // 
            // generales
            // 
            this.generales.DataPropertyName = "generales";
            this.generales.HeaderText = "Generales";
            this.generales.Name = "generales";
            this.generales.ReadOnly = true;
            this.generales.Visible = false;
            // 
            // coef_resumen
            // 
            this.coef_resumen.DataPropertyName = "coef_resumen";
            this.coef_resumen.HeaderText = "Coef_resumen";
            this.coef_resumen.Name = "coef_resumen";
            this.coef_resumen.ReadOnly = true;
            this.coef_resumen.Visible = false;
            // 
            // proyecto_id
            // 
            this.proyecto_id.DataPropertyName = "proyecto_id";
            this.proyecto_id.HeaderText = "Proyecto_id";
            this.proyecto_id.Name = "proyecto_id";
            this.proyecto_id.ReadOnly = true;
            this.proyecto_id.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.ToolTipText = "Abrir Item";
            this.Editar.Width = 30;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar Item";
            this.Eliminar.Width = 30;
            // 
            // op_decimales
            // 
            this.op_decimales.DataPropertyName = "op_decimales";
            this.op_decimales.HeaderText = "Decimales";
            this.op_decimales.Name = "op_decimales";
            this.op_decimales.ReadOnly = true;
            this.op_decimales.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // wbs
            // 
            this.wbs.DataPropertyName = "wbs";
            this.wbs.HeaderText = "Wbs";
            this.wbs.Name = "wbs";
            this.wbs.ReadOnly = true;
            this.wbs.Visible = false;
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            this.consumo.HeaderText = "Consumo";
            this.consumo.Name = "consumo";
            this.consumo.ReadOnly = true;
            this.consumo.Visible = false;
            // 
            // unidad
            // 
            this.unidad.DataPropertyName = "unidad";
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Visible = false;
            // 
            // costoUnitario
            // 
            this.costoUnitario.DataPropertyName = "costoUnitario";
            this.costoUnitario.HeaderText = "costoUnitario";
            this.costoUnitario.Name = "costoUnitario";
            this.costoUnitario.ReadOnly = true;
            this.costoUnitario.Visible = false;
            // 
            // costoTotal
            // 
            this.costoTotal.DataPropertyName = "costoTotal";
            this.costoTotal.HeaderText = "CostoTotal";
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            this.costoTotal.Visible = false;
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "precioVenta";
            this.precioVenta.HeaderText = "PrecioVenta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            // 
            // rubropres_Id
            // 
            this.rubropres_Id.DataPropertyName = "rubropres_Id";
            this.rubropres_Id.HeaderText = "rubropres_Id";
            this.rubropres_Id.Name = "rubropres_Id";
            this.rubropres_Id.ReadOnly = true;
            this.rubropres_Id.Visible = false;
            // 
            // orden
            // 
            this.orden.DataPropertyName = "orden";
            this.orden.HeaderText = "orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Visible = false;
            // 
            // tieneHijos
            // 
            this.tieneHijos.DataPropertyName = "tieneHijos";
            this.tieneHijos.HeaderText = "tieneHijos";
            this.tieneHijos.Name = "tieneHijos";
            this.tieneHijos.ReadOnly = true;
            this.tieneHijos.Visible = false;
            // 
            // pres_id
            // 
            this.pres_id.DataPropertyName = "pres_id";
            this.pres_id.HeaderText = "pres_id";
            this.pres_id.Name = "pres_id";
            this.pres_id.ReadOnly = true;
            this.pres_id.Visible = false;
            // 
            // frmProyectos3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProyectos3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Presupuestos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnPresNuevo;
        private System.Windows.Forms.ToolTip tipGrupo;
        private System.Windows.Forms.ToolTip tipMateriales;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblAvance;
        private System.Windows.Forms.DataGridView dgvPresupuestos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnProyectoNuevo;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewImageColumn _Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _propietario;
        private System.Windows.Forms.DataGridViewButtonColumn _Editar;
        private System.Windows.Forms.DataGridViewButtonColumn _Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn icono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn generales;
        private System.Windows.Forms.DataGridViewTextBoxColumn coef_resumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyecto_id;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_decimales;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn wbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubropres_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieneHijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pres_id;
    }
}