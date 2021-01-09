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
    partial class frmResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResources));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolActualizar,
            this.toolPrint,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolActualizar
            // 
            this.toolActualizar.Image = global::uiGR2020.Properties.Resources.update16;
            this.toolActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolActualizar.Name = "toolActualizar";
            this.toolActualizar.Size = new System.Drawing.Size(79, 22);
            this.toolActualizar.Text = "Actualizar";
            this.toolActualizar.Click += new System.EventHandler(this.toolActualizar_Click);
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
            this.toolExportHtml});
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
            this.toolExportExcel.Size = new System.Drawing.Size(103, 22);
            this.toolExportExcel.Text = "Excel";
            this.toolExportExcel.Click += new System.EventHandler(this.toolExportExcel_Click);
            // 
            // toolExportWord
            // 
            this.toolExportWord.Enabled = false;
            this.toolExportWord.Image = global::uiGR2020.Properties.Resources.blue_document_word_text16;
            this.toolExportWord.Name = "toolExportWord";
            this.toolExportWord.Size = new System.Drawing.Size(103, 22);
            this.toolExportWord.Text = "Word";
            this.toolExportWord.Visible = false;
            // 
            // toolExportHtml
            // 
            this.toolExportHtml.Enabled = false;
            this.toolExportHtml.Image = global::uiGR2020.Properties.Resources.document_invoice16;
            this.toolExportHtml.Name = "toolExportHtml";
            this.toolExportHtml.Size = new System.Drawing.Size(103, 22);
            this.toolExportHtml.Text = "Html";
            this.toolExportHtml.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.tableLayoutPanel3.Controls.Add(this.lblPresupuesto, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pic1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(716, 29);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(38, 0);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(675, 29);
            this.lblPresupuesto.TabIndex = 7;
            this.lblPresupuesto.Text = "label1";
            this.lblPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic1
            // 
            this.pic1.BackgroundImage = global::uiGR2020.Properties.Resources.box;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(3, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(29, 23);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.olvColumn1);
            this.treeListView1.AllColumns.Add(this.olvColumn2);
            this.treeListView1.AllColumns.Add(this.olvColumn3);
            this.treeListView1.AllColumns.Add(this.olvColumn8);
            this.treeListView1.AllColumns.Add(this.olvColumn4);
            this.treeListView1.AllColumns.Add(this.olvColumn6);
            this.treeListView1.AllColumns.Add(this.olvColumn7);
            this.treeListView1.AllColumns.Add(this.olvColumn9);
            this.treeListView1.AllColumns.Add(this.olvColumn5);
            this.treeListView1.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn8,
            this.olvColumn4,
            this.olvColumn6,
            this.olvColumn7});
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.GridLines = true;
            this.treeListView1.HeaderWordWrap = true;
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(3, 63);
            this.treeListView1.MultiSelect = false;
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(716, 361);
            this.treeListView1.SmallImageList = this.imageList1;
            this.treeListView1.TabIndex = 1;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.treeListView1_FormatRow);
            this.treeListView1.SelectedIndexChanged += new System.EventHandler(this.treeListView1_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "nombre";
            this.olvColumn1.Hideable = false;
            this.olvColumn1.Text = "Nombre";
            this.olvColumn1.Width = 350;
            this.olvColumn1.WordWrap = true;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "consumo";
            this.olvColumn2.AspectToStringFormat = "{0:N2}";
            this.olvColumn2.Text = "Consumo";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Width = 90;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "unidad";
            this.olvColumn3.Text = "Unidad";
            this.olvColumn3.WordWrap = true;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "costoUnit";
            this.olvColumn8.AspectToStringFormat = "{0:c}";
            this.olvColumn8.Text = "Costo Unit.";
            this.olvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn8.Width = 90;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "consumoComercial";
            this.olvColumn4.AspectToStringFormat = "{0:N}";
            this.olvColumn4.Text = "Cantidad comercial";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.Width = 90;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "unidadComercial";
            this.olvColumn6.AspectToStringFormat = "";
            this.olvColumn6.Text = "Unidad comercial";
            this.olvColumn6.Width = 90;
            this.olvColumn6.WordWrap = true;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "costoTotal";
            this.olvColumn7.AspectToStringFormat = "{0:c}";
            this.olvColumn7.Text = "Costo Total";
            this.olvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn7.Width = 120;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "incidencia";
            this.olvColumn9.AspectToStringFormat = "";
            this.olvColumn9.DisplayIndex = 7;
            this.olvColumn9.IsVisible = false;
            this.olvColumn9.Text = "%";
            this.olvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "wbs";
            this.olvColumn5.DisplayIndex = 8;
            this.olvColumn5.IsVisible = false;
            this.olvColumn5.Text = "Wbs";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn5.Width = 50;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book16.png");
            this.imageList1.Images.SetKeyName(1, "folder16.png");
            this.imageList1.Images.SetKeyName(2, "box16.png");
            this.imageList1.Images.SetKeyName(3, "user16.png");
            this.imageList1.Images.SetKeyName(4, "cog16.png");
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // frmResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResources";
            this.Text = "frmResources";
            this.Load += new System.EventHandler(this.frmResources_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolPrint;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolExportExcel;
        private System.Windows.Forms.ToolStripMenuItem toolExportWord;
        private System.Windows.Forms.ToolStripMenuItem toolExportHtml;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripButton toolActualizar;
    }
}