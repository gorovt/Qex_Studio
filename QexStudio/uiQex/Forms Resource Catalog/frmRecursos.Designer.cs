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
    partial class frmRecursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tipGrupo = new System.Windows.Forms.ToolTip(this.components);
            this.tipMateriales = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.lblRecursos = new System.Windows.Forms.Label();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.mnuGrupos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGrupoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrupoDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNewGroup = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.mnuRecursos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnResourceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResourceDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResourceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRecursoIsUsed = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarRecurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnSelectNone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteChecked = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.workDelete = new System.ComponentModel.BackgroundWorker();
            this.workGrupoDelete = new System.ComponentModel.BackgroundWorker();
            this._Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this._Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this._Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.mnuGrupos.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.mnuRecursos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "box.png");
            this.imageList1.Images.SetKeyName(2, "user.png");
            this.imageList1.Images.SetKeyName(3, "cog.png");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 690);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel7.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblPresupuesto, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1251, 35);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1202, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(54, 7);
            this.lblPresupuesto.Margin = new System.Windows.Forms.Padding(7, 7, 4, 0);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(1140, 28);
            this.lblPresupuesto.TabIndex = 4;
            this.lblPresupuesto.Text = "Catálogo de Recursos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::uiGR2020.Properties.Resources.box;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 27);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel6.Controls.Add(this.lblGrupos, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblRecursos, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.pgbProgreso, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 657);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1251, 29);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lblGrupos
            // 
            this.lblGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrupos.Location = new System.Drawing.Point(951, 2);
            this.lblGrupos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(99, 25);
            this.lblGrupos.TabIndex = 0;
            this.lblGrupos.Text = "Grupos: xx";
            this.lblGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecursos
            // 
            this.lblRecursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecursos.Location = new System.Drawing.Point(1060, 2);
            this.lblRecursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecursos.Name = "lblRecursos";
            this.lblRecursos.Size = new System.Drawing.Size(185, 25);
            this.lblRecursos.TabIndex = 1;
            this.lblRecursos.Text = "Recursos: xx";
            this.lblRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgreso.Location = new System.Drawing.Point(749, 6);
            this.pgbProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(192, 17);
            this.pgbProgreso.Step = 1;
            this.pgbProgreso.TabIndex = 2;
            this.pgbProgreso.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(6, 2);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(733, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Estado:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(7, 49);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.splitContainer1.Panel2MinSize = 450;
            this.splitContainer1.Size = new System.Drawing.Size(1245, 598);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.SplitterWidth = 13;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvGrupos, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.toolStrip2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(319, 586);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.ColumnHeadersVisible = false;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Id,
            this._Editar,
            this._Imagen,
            this._Nombre,
            this._Eliminar});
            this.dgvGrupos.ContextMenuStrip = this.mnuGrupos;
            this.dgvGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrupos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrupos.Location = new System.Drawing.Point(4, 72);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrupos.MultiSelect = false;
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.RowHeadersWidth = 51;
            this.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupos.Size = new System.Drawing.Size(311, 510);
            this.dgvGrupos.TabIndex = 3;
            this.dgvGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellContentClick);
            this.dgvGrupos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrupos_CellFormatting);
            this.dgvGrupos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrupos_CellMouseDown);
            this.dgvGrupos.SelectionChanged += new System.EventHandler(this.dgvGrupos_SelectionChanged);
            // 
            // mnuGrupos
            // 
            this.mnuGrupos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGrupos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrupoEdit,
            this.mnuGrupoDelete});
            this.mnuGrupos.Name = "mnuGrupos";
            this.mnuGrupos.Size = new System.Drawing.Size(137, 56);
            // 
            // mnuGrupoEdit
            // 
            this.mnuGrupoEdit.Image = global::uiGR2020.Properties.Resources.pencil16;
            this.mnuGrupoEdit.Name = "mnuGrupoEdit";
            this.mnuGrupoEdit.Size = new System.Drawing.Size(136, 26);
            this.mnuGrupoEdit.Text = "Editar";
            this.mnuGrupoEdit.Click += new System.EventHandler(this.mnuGrupoEdit_Click);
            // 
            // mnuGrupoDelete
            // 
            this.mnuGrupoDelete.Image = global::uiGR2020.Properties.Resources.delete16;
            this.mnuGrupoDelete.Name = "mnuGrupoDelete";
            this.mnuGrupoDelete.Size = new System.Drawing.Size(136, 26);
            this.mnuGrupoDelete.Text = "Eliminar";
            this.mnuGrupoDelete.Click += new System.EventHandler(this.mnuGrupoDelete_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "  Lista de Grupos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewGroup});
            this.toolStrip2.Location = new System.Drawing.Point(0, 37);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(319, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Image = global::uiGR2020.Properties.Resources.folder_add16;
            this.btnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(121, 24);
            this.btnNewGroup.Text = "Nuevo Grupo";
            this.btnNewGroup.Click += new System.EventHandler(this.btnGrupoNuevo_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvRecursos, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(885, 586);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvRecursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRecursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Id,
            this.Editar,
            this.Imagen,
            this.ColumnaNombre,
            this.Categoria,
            this.Column4,
            this.Unidad,
            this.Actualizado,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Eliminar});
            this.dgvRecursos.ContextMenuStrip = this.mnuRecursos;
            this.dgvRecursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecursos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRecursos.Location = new System.Drawing.Point(4, 72);
            this.dgvRecursos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecursos.RowHeadersVisible = false;
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(877, 467);
            this.dgvRecursos.TabIndex = 5;
            this.dgvRecursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecursos_CellContentClick);
            this.dgvRecursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecursos_CellDoubleClick);
            this.dgvRecursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecursos_CellFormatting);
            this.dgvRecursos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecursos_CellMouseDown);
            // 
            // mnuRecursos
            // 
            this.mnuRecursos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRecursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResourceEdit,
            this.btnResourceDuplicate,
            this.btnResourceDelete,
            this.toolStripSeparator3,
            this.btnRecursoIsUsed});
            this.mnuRecursos.Name = "mnuRecursos";
            this.mnuRecursos.Size = new System.Drawing.Size(216, 114);
            // 
            // btnResourceEdit
            // 
            this.btnResourceEdit.Image = global::uiGR2020.Properties.Resources.pencil16;
            this.btnResourceEdit.Name = "btnResourceEdit";
            this.btnResourceEdit.Size = new System.Drawing.Size(215, 26);
            this.btnResourceEdit.Text = "Editar";
            this.btnResourceEdit.Click += new System.EventHandler(this.btnResourceEdit_Click);
            // 
            // btnResourceDuplicate
            // 
            this.btnResourceDuplicate.Image = global::uiGR2020.Properties.Resources.page_white_copy;
            this.btnResourceDuplicate.Name = "btnResourceDuplicate";
            this.btnResourceDuplicate.Size = new System.Drawing.Size(215, 26);
            this.btnResourceDuplicate.Text = "Duplicar";
            this.btnResourceDuplicate.Click += new System.EventHandler(this.btnResourceDuplicate_Click);
            // 
            // btnResourceDelete
            // 
            this.btnResourceDelete.Image = global::uiGR2020.Properties.Resources.delete16;
            this.btnResourceDelete.Name = "btnResourceDelete";
            this.btnResourceDelete.Size = new System.Drawing.Size(215, 26);
            this.btnResourceDelete.Text = "Eliminar";
            this.btnResourceDelete.Click += new System.EventHandler(this.btnResourceDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // btnRecursoIsUsed
            // 
            this.btnRecursoIsUsed.Image = global::uiGR2020.Properties.Resources.report_magnify16;
            this.btnRecursoIsUsed.Name = "btnRecursoIsUsed";
            this.btnRecursoIsUsed.Size = new System.Drawing.Size(215, 26);
            this.btnRecursoIsUsed.Text = "¿Está siendo usado?";
            this.btnRecursoIsUsed.Click += new System.EventHandler(this.btnRecursoIsUsed_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarRecurso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 43);
            this.panel1.TabIndex = 4;
            // 
            // txtBuscarRecurso
            // 
            this.txtBuscarRecurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarRecurso.Location = new System.Drawing.Point(109, 7);
            this.txtBuscarRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRecurso.Name = "txtBuscarRecurso";
            this.txtBuscarRecurso.Size = new System.Drawing.Size(771, 26);
            this.txtBuscarRecurso.TabIndex = 1;
            this.txtBuscarRecurso.TextChanged += new System.EventHandler(this.txtBuscarRecurso_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnSelectAll,
            this.btnSelectNone,
            this.toolStripSeparator2,
            this.btnDeleteChecked});
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::uiGR2020.Properties.Resources.add_package;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(132, 28);
            this.toolStripButton1.Text = "Nuevo Recurso";
            this.toolStripButton1.Click += new System.EventHandler(this.btnRecursoNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::uiGR2020.Properties.Resources.check_boxes_series16;
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(145, 28);
            this.btnSelectAll.Text = "Seleccionar todo";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Image = global::uiGR2020.Properties.Resources.check_box_uncheck16;
            this.btnSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(167, 28);
            this.btnSelectNone.Text = "Seleccionar ninguno";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDeleteChecked
            // 
            this.btnDeleteChecked.Image = global::uiGR2020.Properties.Resources.delete_package16;
            this.btnDeleteChecked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteChecked.Name = "btnDeleteChecked";
            this.btnDeleteChecked.Size = new System.Drawing.Size(178, 28);
            this.btnDeleteChecked.Text = "Eliminar seleccionado";
            this.btnDeleteChecked.Click += new System.EventHandler(this.btnDeleteChecked_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(885, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "  Lista de Recursos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workDelete
            // 
            this.workDelete.WorkerReportsProgress = true;
            this.workDelete.WorkerSupportsCancellation = true;
            this.workDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workDelete_DoWork);
            this.workDelete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workDelete_ProgressChanged);
            this.workDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workDelete_RunWorkerCompleted);
            // 
            // workGrupoDelete
            // 
            this.workGrupoDelete.WorkerReportsProgress = true;
            this.workGrupoDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workGrupoDelete_DoWork);
            this.workGrupoDelete.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workGrupoDelete_ProgressChanged);
            this.workGrupoDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workGrupoDelete_RunWorkerCompleted);
            // 
            // _Id
            // 
            this._Id.DataPropertyName = "id";
            this._Id.HeaderText = "Id";
            this._Id.MinimumWidth = 6;
            this._Id.Name = "_Id";
            this._Id.ReadOnly = true;
            this._Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Id.Visible = false;
            this._Id.Width = 125;
            // 
            // _Editar
            // 
            this._Editar.HeaderText = "";
            this._Editar.MinimumWidth = 6;
            this._Editar.Name = "_Editar";
            this._Editar.ReadOnly = true;
            this._Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Editar.Width = 22;
            // 
            // _Imagen
            // 
            this._Imagen.HeaderText = "";
            this._Imagen.MinimumWidth = 6;
            this._Imagen.Name = "_Imagen";
            this._Imagen.ReadOnly = true;
            this._Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Imagen.Width = 25;
            // 
            // _Nombre
            // 
            this._Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._Nombre.DataPropertyName = "nombre";
            this._Nombre.HeaderText = "Nombre";
            this._Nombre.MinimumWidth = 6;
            this._Nombre.Name = "_Nombre";
            this._Nombre.ReadOnly = true;
            this._Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _Eliminar
            // 
            this._Eliminar.FillWeight = 90F;
            this._Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._Eliminar.HeaderText = "";
            this._Eliminar.MinimumWidth = 6;
            this._Eliminar.Name = "_Eliminar";
            this._Eliminar.ReadOnly = true;
            this._Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._Eliminar.Width = 22;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 25;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 22;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "";
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 30;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaNombre.DataPropertyName = "nombre";
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.Visible = false;
            this.Categoria.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "precio";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "unidad";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 6;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unidad.Width = 125;
            // 
            // Actualizado
            // 
            this.Actualizado.DataPropertyName = "ultima_actualizacion";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Actualizado.DefaultCellStyle = dataGridViewCellStyle4;
            this.Actualizado.HeaderText = "Actualizado";
            this.Actualizado.MinimumWidth = 6;
            this.Actualizado.Name = "Actualizado";
            this.Actualizado.ReadOnly = true;
            this.Actualizado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Actualizado.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "proveedor_id";
            this.Column7.HeaderText = "ProveedorId";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "venta_cantidad";
            this.Column8.HeaderText = "Cantidad Venta";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "venta_unidad";
            this.Column9.HeaderText = "Unidad Venta";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "precio_venta";
            this.Column10.HeaderText = "Precio Venta";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "grupo_id";
            this.Column11.HeaderText = "GrupoId";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "codigo_comercial";
            this.Column12.HeaderText = "Codigo comercial";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "nombre_comercial";
            this.Column13.HeaderText = "Nombre Comercial";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 22;
            // 
            // frmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.mnuGrupos.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.mnuRecursos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip tipGrupo;
        private System.Windows.Forms.ToolTip tipMateriales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarRecurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip mnuRecursos;
        private System.Windows.Forms.ToolStripMenuItem btnRecursoIsUsed;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripButton btnSelectNone;
        private System.Windows.Forms.ToolStripButton btnDeleteChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Label lblRecursos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNewGroup;
        private System.Windows.Forms.ToolStripMenuItem btnResourceDuplicate;
        private System.Windows.Forms.ToolStripMenuItem btnResourceEdit;
        private System.Windows.Forms.ToolStripMenuItem btnResourceDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip mnuGrupos;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoDelete;
        private System.Windows.Forms.ProgressBar pgbProgreso;
        private System.ComponentModel.BackgroundWorker workDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker workGrupoDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Id;
        private System.Windows.Forms.DataGridViewButtonColumn _Editar;
        private System.Windows.Forms.DataGridViewImageColumn _Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn _Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actualizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}