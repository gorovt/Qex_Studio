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
    partial class frmPrintPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPreview));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radModerno = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.checkListHeaderEveryPage = new System.Windows.Forms.CheckBox();
            this.checkShrink = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFooter = new System.Windows.Forms.TextBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUpdatePreview = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio50 = new System.Windows.Forms.RadioButton();
            this.radio75 = new System.Windows.Forms.RadioButton();
            this.radio100 = new System.Windows.Forms.RadioButton();
            this.radio150 = new System.Windows.Forms.RadioButton();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radModerno);
            this.groupBox1.Controls.Add(this.radSimple);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFontSize);
            this.groupBox1.Controls.Add(this.checkListHeaderEveryPage);
            this.groupBox1.Controls.Add(this.checkShrink);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // radModerno
            // 
            this.radModerno.AutoSize = true;
            this.radModerno.Location = new System.Drawing.Point(206, 73);
            this.radModerno.Name = "radModerno";
            this.radModerno.Size = new System.Drawing.Size(74, 19);
            this.radModerno.TabIndex = 5;
            this.radModerno.Text = "Diseño 2";
            this.radModerno.UseVisualStyleBackColor = true;
            this.radModerno.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // radSimple
            // 
            this.radSimple.AutoSize = true;
            this.radSimple.Checked = true;
            this.radSimple.Location = new System.Drawing.Point(24, 73);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(74, 19);
            this.radSimple.TabIndex = 4;
            this.radSimple.TabStop = true;
            this.radSimple.Text = "Diseño 1";
            this.radSimple.UseVisualStyleBackColor = true;
            this.radSimple.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamaño fuente";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(299, 20);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(39, 21);
            this.txtFontSize.TabIndex = 2;
            this.txtFontSize.Text = "10";
            this.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkListHeaderEveryPage
            // 
            this.checkListHeaderEveryPage.AutoSize = true;
            this.checkListHeaderEveryPage.Checked = true;
            this.checkListHeaderEveryPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkListHeaderEveryPage.Location = new System.Drawing.Point(24, 47);
            this.checkListHeaderEveryPage.Name = "checkListHeaderEveryPage";
            this.checkListHeaderEveryPage.Size = new System.Drawing.Size(227, 19);
            this.checkListHeaderEveryPage.TabIndex = 1;
            this.checkListHeaderEveryPage.Text = "Colocar encabezado en cada página";
            this.checkListHeaderEveryPage.UseVisualStyleBackColor = true;
            this.checkListHeaderEveryPage.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // checkShrink
            // 
            this.checkShrink.AutoSize = true;
            this.checkShrink.Checked = true;
            this.checkShrink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShrink.Location = new System.Drawing.Point(24, 22);
            this.checkShrink.Name = "checkShrink";
            this.checkShrink.Size = new System.Drawing.Size(113, 19);
            this.checkShrink.TabIndex = 0;
            this.checkShrink.Text = "Ajustar a la hoja";
            this.checkShrink.UseVisualStyleBackColor = true;
            this.checkShrink.CheckedChanged += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFooter);
            this.groupBox2.Controls.Add(this.txtHeader);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(392, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pié de página:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encabezado:";
            // 
            // txtFooter
            // 
            this.txtFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFooter.Location = new System.Drawing.Point(113, 47);
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(264, 21);
            this.txtFooter.TabIndex = 1;
            // 
            // txtHeader
            // 
            this.txtHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeader.Location = new System.Drawing.Point(113, 20);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(264, 21);
            this.txtHeader.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdatePreview,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUpdatePreview
            // 
            this.btnUpdatePreview.Image = global::uiGR2020.Properties.Resources.update16;
            this.btnUpdatePreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdatePreview.Name = "btnUpdatePreview";
            this.btnUpdatePreview.Size = new System.Drawing.Size(142, 22);
            this.btnUpdatePreview.Text = "Actualizar Vista Previa";
            this.btnUpdatePreview.Click += new System.EventHandler(this.UpdatePrintPreview);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::uiGR2020.Properties.Resources.printer16;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 22);
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.Controls.Add(this.btnOk, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 529);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(661, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Imprimir";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.printPreviewControl1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(778, 371);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(661, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(114, 365);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio50);
            this.groupBox3.Controls.Add(this.radio75);
            this.groupBox3.Controls.Add(this.radio100);
            this.groupBox3.Controls.Add(this.radio150);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(108, 144);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zoom";
            // 
            // radio50
            // 
            this.radio50.AutoSize = true;
            this.radio50.Checked = true;
            this.radio50.Location = new System.Drawing.Point(25, 95);
            this.radio50.Name = "radio50";
            this.radio50.Size = new System.Drawing.Size(50, 19);
            this.radio50.TabIndex = 3;
            this.radio50.TabStop = true;
            this.radio50.Text = "50%";
            this.radio50.UseVisualStyleBackColor = true;
            this.radio50.CheckedChanged += new System.EventHandler(this.radio50_CheckedChanged);
            // 
            // radio75
            // 
            this.radio75.AutoSize = true;
            this.radio75.Location = new System.Drawing.Point(25, 70);
            this.radio75.Name = "radio75";
            this.radio75.Size = new System.Drawing.Size(50, 19);
            this.radio75.TabIndex = 2;
            this.radio75.Text = "75%";
            this.radio75.UseVisualStyleBackColor = true;
            this.radio75.CheckedChanged += new System.EventHandler(this.radio75_CheckedChanged);
            // 
            // radio100
            // 
            this.radio100.AutoSize = true;
            this.radio100.Location = new System.Drawing.Point(25, 45);
            this.radio100.Name = "radio100";
            this.radio100.Size = new System.Drawing.Size(57, 19);
            this.radio100.TabIndex = 1;
            this.radio100.Text = "100%";
            this.radio100.UseVisualStyleBackColor = true;
            this.radio100.CheckedChanged += new System.EventHandler(this.radio100_CheckedChanged);
            // 
            // radio150
            // 
            this.radio150.AutoSize = true;
            this.radio150.Location = new System.Drawing.Point(25, 20);
            this.radio150.Name = "radio150";
            this.radio150.Size = new System.Drawing.Size(57, 19);
            this.radio150.TabIndex = 0;
            this.radio150.Text = "150%";
            this.radio150.UseVisualStyleBackColor = true;
            this.radio150.CheckedChanged += new System.EventHandler(this.radio150_CheckedChanged);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Columns = 2;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Document = this.listViewPrinter1;
            this.printPreviewControl1.Location = new System.Drawing.Point(3, 3);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(652, 365);
            this.printPreviewControl1.TabIndex = 1;
            this.printPreviewControl1.Zoom = 0.5D;
            // 
            // listViewPrinter1
            // 
            // 
            // 
            // 
            this.listViewPrinter1.CellFormat.CanWrap = true;
            this.listViewPrinter1.CellFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewPrinter1.Footer = "{1}\t\tPage #{0}";
            // 
            // 
            // 
            this.listViewPrinter1.FooterFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            // 
            // 
            // 
            this.listViewPrinter1.GroupHeaderFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            // 
            // 
            // 
            this.listViewPrinter1.HeaderFormat.Font = new System.Drawing.Font("Verdana", 24F);
            this.listViewPrinter1.IsListHeaderOnEachPage = false;
            this.listViewPrinter1.IsShrinkToFit = false;
            // 
            // 
            // 
            this.listViewPrinter1.ListHeaderFormat.CanWrap = true;
            this.listViewPrinter1.ListHeaderFormat.Font = new System.Drawing.Font("Verdana", 12F);
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista previa Impresión";
            this.Load += new System.EventHandler(this.frmPrintPreview_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.ListViewPrinter listViewPrinter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFooter;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.CheckBox checkShrink;
        private System.Windows.Forms.CheckBox checkListHeaderEveryPage;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUpdatePreview;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio50;
        private System.Windows.Forms.RadioButton radio75;
        private System.Windows.Forms.RadioButton radio100;
        private System.Windows.Forms.RadioButton radio150;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFontSize;
        private System.Windows.Forms.RadioButton radModerno;
        private System.Windows.Forms.RadioButton radSimple;
    }
}