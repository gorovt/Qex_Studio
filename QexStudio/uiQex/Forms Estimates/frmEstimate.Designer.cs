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
    partial class frmEstimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstimate));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLevel1 = new System.Windows.Forms.ToolStripButton();
            this.btnLevel2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolAutoWbs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportPresXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReadXml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpciones = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvOrden = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mnuGrupos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGrupoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrupoDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrupoMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGrupoNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertItemFromCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.work = new System.ComponentModel.BackgroundWorker();
            this.mnuItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemCopyFromCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyResource = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPasteResource = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.mnuGrupos.SuspendLayout();
            this.mnuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeListView1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLevel1,
            this.btnLevel2,
            this.toolStripSeparator1,
            this.btnActualizar,
            this.toolAutoWbs,
            this.toolStripSeparator5,
            this.toolPrint,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.btnOpciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLevel1
            // 
            this.btnLevel1.Image = global::uiGR2020.Properties.Resources.chevron;
            this.btnLevel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(63, 22);
            this.btnLevel1.Text = "Nivel 1";
            this.btnLevel1.ToolTipText = "Muestra el Nivel 1 de Items";
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Image = global::uiGR2020.Properties.Resources.chevron_expand;
            this.btnLevel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(100, 22);
            this.btnLevel2.Text = "Expandir todo";
            this.btnLevel2.ToolTipText = "Muestra todos los niveles de Items";
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::uiGR2020.Properties.Resources.update16;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolAutoWbs
            // 
            this.toolAutoWbs.Image = global::uiGR2020.Properties.Resources.text_list_numbers16;
            this.toolAutoWbs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAutoWbs.Name = "toolAutoWbs";
            this.toolAutoWbs.Size = new System.Drawing.Size(80, 22);
            this.toolAutoWbs.Text = "Auto WBS";
            this.toolAutoWbs.Click += new System.EventHandler(this.toolAutoWbs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolPrint
            // 
            this.toolPrint.Image = global::uiGR2020.Properties.Resources.printer16;
            this.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.Size = new System.Drawing.Size(73, 22);
            this.toolPrint.Text = "Imprimir";
            this.toolPrint.Click += new System.EventHandler(this.toolPrint_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExportExcel,
            this.toolExportWord,
            this.toolExportHtml,
            this.toolExportProject,
            this.toolExportPresXml,
            this.toolReadXml});
            this.toolStripDropDownButton1.Image = global::uiGR2020.Properties.Resources.book__arrow16;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripDropDownButton1.Text = "Exportar...";
            // 
            // toolExportExcel
            // 
            this.toolExportExcel.Image = global::uiGR2020.Properties.Resources.table_excel16;
            this.toolExportExcel.Name = "toolExportExcel";
            this.toolExportExcel.Size = new System.Drawing.Size(163, 22);
            this.toolExportExcel.Text = "Excel";
            this.toolExportExcel.Click += new System.EventHandler(this.toolExportExcel_Click);
            // 
            // toolExportWord
            // 
            this.toolExportWord.Enabled = false;
            this.toolExportWord.Image = global::uiGR2020.Properties.Resources.blue_document_word_text16;
            this.toolExportWord.Name = "toolExportWord";
            this.toolExportWord.Size = new System.Drawing.Size(163, 22);
            this.toolExportWord.Text = "Word";
            this.toolExportWord.Visible = false;
            // 
            // toolExportHtml
            // 
            this.toolExportHtml.Enabled = false;
            this.toolExportHtml.Image = global::uiGR2020.Properties.Resources.document_invoice16;
            this.toolExportHtml.Name = "toolExportHtml";
            this.toolExportHtml.Size = new System.Drawing.Size(163, 22);
            this.toolExportHtml.Text = "Html";
            this.toolExportHtml.Visible = false;
            // 
            // toolExportProject
            // 
            this.toolExportProject.Image = global::uiGR2020.Properties.Resources.document_epub16;
            this.toolExportProject.Name = "toolExportProject";
            this.toolExportProject.Size = new System.Drawing.Size(163, 22);
            this.toolExportProject.Text = "MS Project Xml";
            this.toolExportProject.Click += new System.EventHandler(this.toolExportProject_Click);
            // 
            // toolExportPresXml
            // 
            this.toolExportPresXml.Image = global::uiGR2020.Properties.Resources.book;
            this.toolExportPresXml.Name = "toolExportPresXml";
            this.toolExportPresXml.Size = new System.Drawing.Size(163, 22);
            this.toolExportPresXml.Text = "Presupuesto Xml";
            this.toolExportPresXml.Visible = false;
            this.toolExportPresXml.Click += new System.EventHandler(this.toolExportPresXml_Click);
            // 
            // toolReadXml
            // 
            this.toolReadXml.Name = "toolReadXml";
            this.toolReadXml.Size = new System.Drawing.Size(163, 22);
            this.toolReadXml.Text = "Read Xml";
            this.toolReadXml.Visible = false;
            this.toolReadXml.Click += new System.EventHandler(this.toolReadXml_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Image = global::uiGR2020.Properties.Resources.setting_tools16;
            this.btnOpciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(104, 22);
            this.btnOpciones.Text = "Coef Resumen";
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.pgbProgress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 430);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(716, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pgbProgress
            // 
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgress.Location = new System.Drawing.Point(468, 3);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(173, 18);
            this.pgbProgress.TabIndex = 3;
            this.pgbProgress.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(459, 24);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pic1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblPresupuesto, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(716, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // pic1
            // 
            this.pic1.BackgroundImage = global::uiGR2020.Properties.Resources.book;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(3, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(29, 23);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(38, 0);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(675, 29);
            this.lblPresupuesto.TabIndex = 6;
            this.lblPresupuesto.Text = "label1";
            this.lblPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.olvColumn1);
            this.treeListView1.AllColumns.Add(this.olvColumn5);
            this.treeListView1.AllColumns.Add(this.olvColumn2);
            this.treeListView1.AllColumns.Add(this.olvColumn3);
            this.treeListView1.AllColumns.Add(this.olvColumn4);
            this.treeListView1.AllColumns.Add(this.olvColumn6);
            this.treeListView1.AllColumns.Add(this.olvColumn9);
            this.treeListView1.AllColumns.Add(this.olvColumn7);
            this.treeListView1.AllColumns.Add(this.olvOrden);
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn5,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn6,
            this.olvColumn9,
            this.olvOrden});
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.GridLines = true;
            this.treeListView1.HideSelection = false;
            this.treeListView1.LargeImageList = this.imageList1;
            this.treeListView1.Location = new System.Drawing.Point(3, 63);
            this.treeListView1.MultiSelect = false;
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = false;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(716, 361);
            this.treeListView1.SmallImageList = this.imageList1;
            this.treeListView1.TabIndex = 1;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.treeListView1_CellRightClick);
            this.treeListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.treeListView1_FormatCell);
            this.treeListView1.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.treeListView1_FormatRow);
            this.treeListView1.ItemActivate += new System.EventHandler(this.treeListView1_ItemActivate);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "nombre";
            this.olvColumn1.Hideable = false;
            this.olvColumn1.Text = "Nombre";
            this.olvColumn1.Width = 350;
            this.olvColumn1.WordWrap = true;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "wbs";
            this.olvColumn5.Text = "Wbs";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn5.Width = 50;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "consumo";
            this.olvColumn2.AspectToStringFormat = "{0:N}";
            this.olvColumn2.Text = "Cantidad";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Width = 90;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "unidad";
            this.olvColumn3.Text = "Unidad";
            this.olvColumn3.WordWrap = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "costoUnitario";
            this.olvColumn4.AspectToStringFormat = "{0:c}";
            this.olvColumn4.Text = "Costo Unit.";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.Width = 90;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "costoTotal";
            this.olvColumn6.AspectToStringFormat = "{0:c}";
            this.olvColumn6.Text = "Costo Total";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn6.Width = 120;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "precioVenta";
            this.olvColumn9.AspectToStringFormat = "{0:c}";
            this.olvColumn9.Text = "Precio Venta";
            this.olvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn9.Width = 120;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "incidencia";
            this.olvColumn7.AspectToStringFormat = "{0:n}";
            this.olvColumn7.DisplayIndex = 8;
            this.olvColumn7.IsVisible = false;
            this.olvColumn7.Text = "%";
            this.olvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvOrden
            // 
            this.olvOrden.AspectName = "orden";
            this.olvOrden.Text = "Orden";
            this.olvOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book16.png");
            this.imageList1.Images.SetKeyName(1, "folder16.png");
            this.imageList1.Images.SetKeyName(2, "calendar16.png");
            this.imageList1.Images.SetKeyName(3, "calendar16-grey.png");
            // 
            // mnuGrupos
            // 
            this.mnuGrupos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGrupoEdit,
            this.mnuGrupoDelete,
            this.mnuGrupoMove,
            this.toolStripSeparator2,
            this.mnuGrupoNew,
            this.mnuItemNew,
            this.mnuInsertItemFromCatalog});
            this.mnuGrupos.Name = "mnuGrupos";
            this.mnuGrupos.Size = new System.Drawing.Size(231, 142);
            // 
            // mnuGrupoEdit
            // 
            this.mnuGrupoEdit.Image = global::uiGR2020.Properties.Resources.pencil16;
            this.mnuGrupoEdit.Name = "mnuGrupoEdit";
            this.mnuGrupoEdit.Size = new System.Drawing.Size(230, 22);
            this.mnuGrupoEdit.Text = "Editar Elemento";
            this.mnuGrupoEdit.ToolTipText = "Edita el Elemento seleccionado";
            this.mnuGrupoEdit.Click += new System.EventHandler(this.mnuGrupoEdit_Click);
            // 
            // mnuGrupoDelete
            // 
            this.mnuGrupoDelete.Image = global::uiGR2020.Properties.Resources.delete16;
            this.mnuGrupoDelete.Name = "mnuGrupoDelete";
            this.mnuGrupoDelete.Size = new System.Drawing.Size(230, 22);
            this.mnuGrupoDelete.Text = "Eliminar Elemento";
            this.mnuGrupoDelete.ToolTipText = "Elimina el Elemento seleccionado";
            this.mnuGrupoDelete.Click += new System.EventHandler(this.mnuGrupoDelete_Click);
            // 
            // mnuGrupoMove
            // 
            this.mnuGrupoMove.Image = global::uiGR2020.Properties.Resources.update16;
            this.mnuGrupoMove.Name = "mnuGrupoMove";
            this.mnuGrupoMove.Size = new System.Drawing.Size(230, 22);
            this.mnuGrupoMove.Text = "Mover Elemento";
            this.mnuGrupoMove.ToolTipText = "Mueve el Elemento seleccionado a otro Grupo";
            this.mnuGrupoMove.Click += new System.EventHandler(this.mnuGrupoMove_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // mnuGrupoNew
            // 
            this.mnuGrupoNew.Image = global::uiGR2020.Properties.Resources.folder_add16;
            this.mnuGrupoNew.Name = "mnuGrupoNew";
            this.mnuGrupoNew.Size = new System.Drawing.Size(230, 22);
            this.mnuGrupoNew.Text = "Nuevo Grupo";
            this.mnuGrupoNew.ToolTipText = "Crea un Nuevo Grupo";
            this.mnuGrupoNew.Click += new System.EventHandler(this.mnuGrupoNew_Click);
            // 
            // mnuItemNew
            // 
            this.mnuItemNew.Image = global::uiGR2020.Properties.Resources.calendar_add16;
            this.mnuItemNew.Name = "mnuItemNew";
            this.mnuItemNew.Size = new System.Drawing.Size(230, 22);
            this.mnuItemNew.Text = "Nuevo Item";
            this.mnuItemNew.ToolTipText = "Crea un nuevo Item de Presupuesto en el Grupo seleccionado";
            this.mnuItemNew.Click += new System.EventHandler(this.mnuItemNew_Click);
            // 
            // mnuInsertItemFromCatalog
            // 
            this.mnuInsertItemFromCatalog.Image = global::uiGR2020.Properties.Resources.application_view_list16;
            this.mnuInsertItemFromCatalog.Name = "mnuInsertItemFromCatalog";
            this.mnuInsertItemFromCatalog.Size = new System.Drawing.Size(230, 22);
            this.mnuInsertItemFromCatalog.Text = "Insertar Items desde Catálogo";
            this.mnuInsertItemFromCatalog.ToolTipText = "Permite seleccionar Items desde el Catálogo de Items. Los Items seleccionados se " +
    "agregan al Grupo seleccionado";
            this.mnuInsertItemFromCatalog.Click += new System.EventHandler(this.mnuInsertItemFromCatalog_Click);
            // 
            // work
            // 
            this.work.WorkerReportsProgress = true;
            this.work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.work_DoWork);
            this.work.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.work_ProgressChanged);
            this.work.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.work_RunWorkerCompleted);
            // 
            // mnuItems
            // 
            this.mnuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemEdit,
            this.mnuItemDelete,
            this.mnuItemMove,
            this.toolStripSeparator3,
            this.mnuItemCopyFromCatalog,
            this.mnuCopyResource,
            this.mnuPasteResource});
            this.mnuItems.Name = "mnuItems";
            this.mnuItems.Size = new System.Drawing.Size(249, 142);
            // 
            // mnuItemEdit
            // 
            this.mnuItemEdit.Image = global::uiGR2020.Properties.Resources.pencil16;
            this.mnuItemEdit.Name = "mnuItemEdit";
            this.mnuItemEdit.Size = new System.Drawing.Size(248, 22);
            this.mnuItemEdit.Text = "Editar Elemento";
            this.mnuItemEdit.ToolTipText = "Edita el elemento seleccionado";
            this.mnuItemEdit.Click += new System.EventHandler(this.mnuItemEdit_Click);
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Image = global::uiGR2020.Properties.Resources.delete16;
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.Size = new System.Drawing.Size(248, 22);
            this.mnuItemDelete.Text = "Eliminar Elemento";
            this.mnuItemDelete.ToolTipText = "Elimina el elemento seleccionado";
            this.mnuItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // mnuItemMove
            // 
            this.mnuItemMove.Image = global::uiGR2020.Properties.Resources.update16;
            this.mnuItemMove.Name = "mnuItemMove";
            this.mnuItemMove.Size = new System.Drawing.Size(248, 22);
            this.mnuItemMove.Text = "Mover Elemento";
            this.mnuItemMove.ToolTipText = "Mueve el Elemento seleccionado a otro Grupo";
            this.mnuItemMove.Click += new System.EventHandler(this.mnuItemMove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(245, 6);
            // 
            // mnuItemCopyFromCatalog
            // 
            this.mnuItemCopyFromCatalog.Image = global::uiGR2020.Properties.Resources.application_view_list16;
            this.mnuItemCopyFromCatalog.Name = "mnuItemCopyFromCatalog";
            this.mnuItemCopyFromCatalog.Size = new System.Drawing.Size(248, 22);
            this.mnuItemCopyFromCatalog.Text = "Insertar Recursos desde Catálogo";
            this.mnuItemCopyFromCatalog.ToolTipText = "Permite copiar los consumos de cualquier Item del Catálogo de Items. Luego esos R" +
    "ecursos copiados pueden pegarse en cualquier Item del Presupuesto";
            this.mnuItemCopyFromCatalog.Click += new System.EventHandler(this.mnuItemCopyFromCatalog_Click);
            // 
            // mnuCopyResource
            // 
            this.mnuCopyResource.Image = global::uiGR2020.Properties.Resources.page_white_copy;
            this.mnuCopyResource.Name = "mnuCopyResource";
            this.mnuCopyResource.Size = new System.Drawing.Size(248, 22);
            this.mnuCopyResource.Text = "Copiar Recursos";
            this.mnuCopyResource.ToolTipText = "Copia los Recursos del Item seleccionado al portapapeles";
            this.mnuCopyResource.Click += new System.EventHandler(this.mnuCopyResource_Click);
            // 
            // mnuPasteResource
            // 
            this.mnuPasteResource.Image = global::uiGR2020.Properties.Resources.page_white_paste;
            this.mnuPasteResource.Name = "mnuPasteResource";
            this.mnuPasteResource.Size = new System.Drawing.Size(248, 22);
            this.mnuPasteResource.Text = "Pegar Recursos";
            this.mnuPasteResource.ToolTipText = "Pega los Recursos del portapapeles en el Item seleccionado";
            this.mnuPasteResource.Click += new System.EventHandler(this.mnuPasteResource_Click);
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstimate";
            this.Text = "frmEstimate";
            this.Load += new System.EventHandler(this.frmEstimate_Load);
            this.Shown += new System.EventHandler(this.frmEstimate_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.mnuGrupos.ResumeLayout(false);
            this.mnuItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker work;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.ContextMenuStrip mnuGrupos;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoNew;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuItemNew;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertItemFromCatalog;
        private System.Windows.Forms.ContextMenuStrip mnuItems;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyResource;
        private System.Windows.Forms.ToolStripMenuItem mnuPasteResource;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAutoWbs;
        private System.Windows.Forms.ToolStripButton toolPrint;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolExportExcel;
        private System.Windows.Forms.ToolStripMenuItem toolExportWord;
        private System.Windows.Forms.ToolStripMenuItem toolExportHtml;
        private System.Windows.Forms.ToolStripMenuItem toolExportProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem toolReadXml;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoMove;
        private System.Windows.Forms.ToolStripMenuItem mnuItemMove;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCopyFromCatalog;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOpciones;
        private System.Windows.Forms.ToolStripButton btnLevel1;
        private System.Windows.Forms.ToolStripButton btnLevel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.Label lblStatus;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvOrden;
        private System.Windows.Forms.ToolStripMenuItem toolExportPresXml;
    }
}