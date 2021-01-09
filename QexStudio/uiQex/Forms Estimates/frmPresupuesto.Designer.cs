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
    partial class frmPresupuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.mnuItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBtnCopiarConsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBtnPegarConsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewItem = new System.Windows.Forms.ToolStripButton();
            this.btnFromCatalog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.btnSelectNone = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteChecked = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeGrupos = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.wbs = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._orden = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nombre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAutoWBS = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tipGrupo = new System.Windows.Forms.ToolTip(this.components);
            this.tipMateriales = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuRubros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRubroNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRubroRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRubroEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubropres_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this._wbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.mnuItems.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeGrupos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuRubros.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImage,
            this.lblStatus,
            this.progressBar,
            this.lblAvance});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblImage
            // 
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(350, 17);
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 540);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvItems, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 534);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Imagen,
            this.id,
            this.orden,
            this.ColumnaNombre,
            this.consumo,
            this.Unidad,
            this.rubropres_id,
            this.Editar,
            this.Eliminar,
            this._wbs});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvItems.Location = new System.Drawing.Point(3, 60);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.ContextMenuStrip = this.mnuItems;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(508, 436);
            this.dgvItems.TabIndex = 5;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            this.dgvItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItems_CellFormatting);
            this.dgvItems.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseDown);
            // 
            // mnuItems
            // 
            this.mnuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBtnCopiarConsumos,
            this.mnuBtnPegarConsumos});
            this.mnuItems.Name = "mnuItems";
            this.mnuItems.Size = new System.Drawing.Size(170, 48);
            // 
            // mnuBtnCopiarConsumos
            // 
            this.mnuBtnCopiarConsumos.Image = global::uiGR2020.Properties.Resources.page_white_copy;
            this.mnuBtnCopiarConsumos.Name = "mnuBtnCopiarConsumos";
            this.mnuBtnCopiarConsumos.Size = new System.Drawing.Size(169, 22);
            this.mnuBtnCopiarConsumos.Text = "Copiar Consumos";
            this.mnuBtnCopiarConsumos.Click += new System.EventHandler(this.mnuBtnCopiarConsumos_Click);
            // 
            // mnuBtnPegarConsumos
            // 
            this.mnuBtnPegarConsumos.Image = global::uiGR2020.Properties.Resources.page_white_paste;
            this.mnuBtnPegarConsumos.Name = "mnuBtnPegarConsumos";
            this.mnuBtnPegarConsumos.Size = new System.Drawing.Size(169, 22);
            this.mnuBtnPegarConsumos.Text = "Pegar Consumos";
            this.mnuBtnPegarConsumos.Click += new System.EventHandler(this.mnuBtnPegarConsumos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewItem,
            this.btnFromCatalog,
            this.toolStripSeparator2,
            this.btnSelectAll,
            this.btnSelectNone,
            this.btnDeleteChecked});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(514, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewItem
            // 
            this.btnNewItem.Image = global::uiGR2020.Properties.Resources.calendar_add16;
            this.btnNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(78, 22);
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.Click += new System.EventHandler(this.btnItemNuevo_Click);
            // 
            // btnFromCatalog
            // 
            this.btnFromCatalog.Image = global::uiGR2020.Properties.Resources.application_view_list16;
            this.btnFromCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFromCatalog.Name = "btnFromCatalog";
            this.btnFromCatalog.Size = new System.Drawing.Size(99, 22);
            this.btnFromCatalog.Text = "From Catalog";
            this.btnFromCatalog.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::uiGR2020.Properties.Resources.check_boxes_series16;
            this.btnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 22);
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Image = global::uiGR2020.Properties.Resources.check_box_uncheck16;
            this.btnSelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(90, 22);
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnDeleteChecked
            // 
            this.btnDeleteChecked.Image = global::uiGR2020.Properties.Resources.calendar_delete16;
            this.btnDeleteChecked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteChecked.Name = "btnDeleteChecked";
            this.btnDeleteChecked.Size = new System.Drawing.Size(109, 22);
            this.btnDeleteChecked.Text = "Delete Checked";
            this.btnDeleteChecked.Click += new System.EventHandler(this.btnDeleteChecked_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "  Item List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.treeGrupos, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.toolStrip2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 534);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // treeGrupos
            // 
            this.treeGrupos.AllColumns.Add(this.olvColumn1);
            this.treeGrupos.AllColumns.Add(this.wbs);
            this.treeGrupos.AllColumns.Add(this._orden);
            this.treeGrupos.AllColumns.Add(this.nombre);
            this.treeGrupos.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.treeGrupos.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.treeGrupos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this._orden,
            this.nombre});
            this.treeGrupos.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeGrupos.FullRowSelect = true;
            this.treeGrupos.Location = new System.Drawing.Point(3, 58);
            this.treeGrupos.MultiSelect = false;
            this.treeGrupos.Name = "treeGrupos";
            this.treeGrupos.ShowGroups = false;
            this.treeGrupos.Size = new System.Drawing.Size(268, 438);
            this.treeGrupos.SmallImageList = this.imageList1;
            this.treeGrupos.TabIndex = 5;
            this.treeGrupos.UseCompatibleStateImageBehavior = false;
            this.treeGrupos.View = System.Windows.Forms.View.Details;
            this.treeGrupos.VirtualMode = true;
            this.treeGrupos.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(this.treeGrupos_CellEditFinished);
            this.treeGrupos.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.treeGrupos_CellClick);
            this.treeGrupos.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.treeGrupos_CellRightClick);
            this.treeGrupos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.treeGrupos_ItemSelectionChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "";
            // 
            // wbs
            // 
            this.wbs.AspectName = "wbs";
            this.wbs.DisplayIndex = 2;
            this.wbs.IsVisible = false;
            this.wbs.Text = "WBS";
            // 
            // _orden
            // 
            this._orden.AspectName = "orden";
            this._orden.Text = "Order";
            this._orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.AspectName = "nombre";
            this.nombre.FillsFreeSpace = true;
            this.nombre.Text = "Nombre";
            this.nombre.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book16.png");
            this.imageList1.Images.SetKeyName(1, "folder16.png");
            this.imageList1.Images.SetKeyName(2, "calendar16.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.btnAutoWBS});
            this.toolStrip2.Location = new System.Drawing.Point(0, 30);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(274, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::uiGR2020.Properties.Resources.folder_add16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "New Group";
            this.toolStripButton1.Click += new System.EventHandler(this.mnuRubroNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAutoWBS
            // 
            this.btnAutoWBS.Image = global::uiGR2020.Properties.Resources.text_list_numbers16;
            this.btnAutoWBS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutoWBS.Name = "btnAutoWBS";
            this.btnAutoWBS.Size = new System.Drawing.Size(77, 22);
            this.btnAutoWBS.Text = "AutoWBS";
            this.btnAutoWBS.Click += new System.EventHandler(this.btnAutoWBS_Click);
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
            this.label2.Size = new System.Drawing.Size(274, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "  Group List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.Controls.Add(this.lblPresupuesto, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(794, 29);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(40, 6);
            this.lblPresupuesto.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(711, 23);
            this.lblPresupuesto.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(757, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::uiGR2020.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mnuRubros
            // 
            this.mnuRubros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRubroNew,
            this.mnuRubroRename,
            this.toolStripSeparator1,
            this.mnuRubroEliminar});
            this.mnuRubros.Name = "mnuRubros";
            this.mnuRubros.Size = new System.Drawing.Size(146, 76);
            // 
            // mnuRubroNew
            // 
            this.mnuRubroNew.Image = global::uiGR2020.Properties.Resources.folder_add16;
            this.mnuRubroNew.Name = "mnuRubroNew";
            this.mnuRubroNew.Size = new System.Drawing.Size(145, 22);
            this.mnuRubroNew.Text = "Nuevo Grupo";
            this.mnuRubroNew.Click += new System.EventHandler(this.mnuRubroNew_Click);
            // 
            // mnuRubroRename
            // 
            this.mnuRubroRename.Image = global::uiGR2020.Properties.Resources.folder_edit16;
            this.mnuRubroRename.Name = "mnuRubroRename";
            this.mnuRubroRename.Size = new System.Drawing.Size(145, 22);
            this.mnuRubroRename.Text = "Renombrar";
            this.mnuRubroRename.Click += new System.EventHandler(this.mnuRubroRename_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuRubroEliminar
            // 
            this.mnuRubroEliminar.Image = global::uiGR2020.Properties.Resources.folder_delete16;
            this.mnuRubroEliminar.Name = "mnuRubroEliminar";
            this.mnuRubroEliminar.Size = new System.Drawing.Size(145, 22);
            this.mnuRubroEliminar.Text = "Eliminar";
            this.mnuRubroEliminar.Click += new System.EventHandler(this.mnuRubroEliminar_Click);
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Width = 25;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // orden
            // 
            this.orden.DataPropertyName = "orden";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orden.DefaultCellStyle = dataGridViewCellStyle6;
            this.orden.HeaderText = "Order";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Width = 50;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaNombre.DataPropertyName = "nombre";
            this.ColumnaNombre.HeaderText = "Name";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.consumo.DefaultCellStyle = dataGridViewCellStyle7;
            this.consumo.HeaderText = "Quantity";
            this.consumo.Name = "consumo";
            this.consumo.ReadOnly = true;
            this.consumo.Width = 85;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "unidad";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Unidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.Unidad.HeaderText = "Unit";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rubropres_id
            // 
            this.rubropres_id.DataPropertyName = "rubropres_id";
            this.rubropres_id.HeaderText = "RubroPres_Id";
            this.rubropres_id.Name = "rubropres_id";
            this.rubropres_id.ReadOnly = true;
            this.rubropres_id.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.ToolTipText = "Abrir Item";
            this.Editar.Width = 22;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar Item";
            this.Eliminar.Width = 22;
            // 
            // _wbs
            // 
            this._wbs.DataPropertyName = "Wbs";
            this._wbs.HeaderText = "Wbs";
            this._wbs.Name = "_wbs";
            this._wbs.ReadOnly = true;
            this._wbs.Visible = false;
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresupuesto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.mnuItems.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeGrupos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuRubros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolTip tipGrupo;
        private System.Windows.Forms.ToolTip tipMateriales;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblAvance;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip mnuItems;
        private System.Windows.Forms.ToolStripMenuItem mnuBtnCopiarConsumos;
        private System.Windows.Forms.ToolStripMenuItem mnuBtnPegarConsumos;
        private System.Windows.Forms.ContextMenuStrip mnuRubros;
        private System.Windows.Forms.ToolStripMenuItem mnuRubroNew;
        private System.Windows.Forms.ToolStripMenuItem mnuRubroRename;
        private System.Windows.Forms.ToolStripStatusLabel lblImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuRubroEliminar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelectAll;
        private System.Windows.Forms.ToolStripButton btnSelectNone;
        private System.Windows.Forms.ToolStripButton btnDeleteChecked;
        private BrightIdeasSoftware.TreeListView treeGrupos;
        private BrightIdeasSoftware.OLVColumn nombre;
        private BrightIdeasSoftware.OLVColumn wbs;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn _orden;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAutoWBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnNewItem;
        private System.Windows.Forms.ToolStripButton btnFromCatalog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubropres_id;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _wbs;
    }
}