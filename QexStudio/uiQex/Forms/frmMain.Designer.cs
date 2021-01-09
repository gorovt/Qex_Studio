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
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Presupuesto", 1, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Recursos", 1, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Flujo de Trabajo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.tabEstimates = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanelItems = new System.Windows.Forms.RibbonPanel();
            this.tabItems = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.tabResources = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.orbNew = new System.Windows.Forms.RibbonButton();
            this.orbOpen = new System.Windows.Forms.RibbonButton();
            this.orbClose = new System.Windows.Forms.RibbonButton();
            this.btnAyuda = new System.Windows.Forms.RibbonButton();
            this.btnForo = new System.Windows.Forms.RibbonButton();
            this.fileExit = new System.Windows.Forms.RibbonButton();
            this.fileOptions = new System.Windows.Forms.RibbonOrbOptionButton();
            this.qbtnOpen = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.btnImportQex = new System.Windows.Forms.RibbonButton();
            this.btnItemImportExcel = new System.Windows.Forms.RibbonButton();
            this.btnItemResourcesImportExcel = new System.Windows.Forms.RibbonButton();
            this.btnItemAbrirPlantillas = new System.Windows.Forms.RibbonButton();
            this.btnGestionRevit = new System.Windows.Forms.RibbonButton();
            this.btnItemExportExcel = new System.Windows.Forms.RibbonButton();
            this.btnResourceImportExcel = new System.Windows.Forms.RibbonButton();
            this.btnOpenPlantillaImportarRecursos = new System.Windows.Forms.RibbonButton();
            this.btnResourceExportExcel = new System.Windows.Forms.RibbonButton();
            this.btnRubroNuevo = new System.Windows.Forms.RibbonButton();
            this.btnRubroEditar = new System.Windows.Forms.RibbonButton();
            this.btnRubroEliminar = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.btnPresNuevo = new System.Windows.Forms.RibbonButton();
            this.btnPresAbrir = new System.Windows.Forms.RibbonButton();
            this.btnAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbNew);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbOpen);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbClose);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btnAyuda);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btnAbout);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.fileExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.fileOptions);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 339);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "Archivo";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Items.Add(this.qbtnOpen);
            this.ribbon1.QuickAcessToolbar.Tag = "";
            this.ribbon1.QuickAcessToolbar.Text = "Qex Studio";
            this.ribbon1.QuickAcessToolbar.Value = "";
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1259, 148);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.tabEstimates);
            this.ribbon1.Tabs.Add(this.tabItems);
            this.ribbon1.Tabs.Add(this.tabResources);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 0, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            this.ribbon1.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
            // 
            // tabEstimates
            // 
            this.tabEstimates.Panels.Add(this.ribbonPanel5);
            this.tabEstimates.Panels.Add(this.ribbonPanelItems);
            this.tabEstimates.Text = "Presupuesto";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton1);
            this.ribbonPanel5.Items.Add(this.ribbonButton2);
            this.ribbonPanel5.Items.Add(this.ribbonButton3);
            this.ribbonPanel5.Text = "General";
            // 
            // ribbonPanelItems
            // 
            this.ribbonPanelItems.ButtonMoreVisible = false;
            this.ribbonPanelItems.Items.Add(this.btnImportQex);
            this.ribbonPanelItems.Text = "Importar Items";
            // 
            // tabItems
            // 
            this.tabItems.Panels.Add(this.ribbonPanel8);
            this.tabItems.Panels.Add(this.ribbonPanel9);
            this.tabItems.Text = "Catálogo Items";
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.ButtonMoreVisible = false;
            this.ribbonPanel8.Items.Add(this.btnItemImportExcel);
            this.ribbonPanel8.Items.Add(this.btnItemResourcesImportExcel);
            this.ribbonPanel8.Items.Add(this.btnItemAbrirPlantillas);
            this.ribbonPanel8.Items.Add(this.btnGestionRevit);
            this.ribbonPanel8.Text = "Importar";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.btnItemExportExcel);
            this.ribbonPanel9.Text = "Exportar Items";
            // 
            // tabResources
            // 
            this.tabResources.Panels.Add(this.ribbonPanel1);
            this.tabResources.Panels.Add(this.ribbonPanel3);
            this.tabResources.Text = "Catálogo Recursos";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnResourceImportExcel);
            this.ribbonPanel1.Items.Add(this.btnOpenPlantillaImportarRecursos);
            this.ribbonPanel1.Text = "Importar Recursos";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.btnResourceExportExcel);
            this.ribbonPanel3.Text = "Exportar Recursos";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "General";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 666);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgbProgress, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 664);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "NodoEstimate";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Presupuesto";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodoResources";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Recursos";
            treeNode3.BackColor = System.Drawing.Color.Silver;
            treeNode3.Name = "NodeWorkFlow";
            treeNode3.Text = "Flujo de Trabajo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(256, 625);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder16.png");
            this.imageList1.Images.SetKeyName(1, "bullet_black.png");
            this.imageList1.Images.SetKeyName(2, "bullet_green.png");
            this.imageList1.Images.SetKeyName(3, "document_empty16.png");
            this.imageList1.Images.SetKeyName(4, "book16.png");
            this.imageList1.Images.SetKeyName(5, "calendar16.png");
            this.imageList1.Images.SetKeyName(6, "box16.png");
            // 
            // pgbProgress
            // 
            this.pgbProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbProgress.Location = new System.Drawing.Point(4, 637);
            this.pgbProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(256, 23);
            this.pgbProgress.TabIndex = 3;
            this.pgbProgress.Visible = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnRubroNuevo);
            this.ribbonPanel2.Items.Add(this.btnRubroEditar);
            this.ribbonPanel2.Items.Add(this.btnRubroEliminar);
            this.ribbonPanel2.Text = "Groups";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // orbNew
            // 
            this.orbNew.Image = ((System.Drawing.Image)(resources.GetObject("orbNew.Image")));
            this.orbNew.SmallImage = global::uiGR2020.Properties.Resources.document_empty;
            this.orbNew.Text = "Nuevo Presupuesto";
            this.orbNew.ToolTip = "Crea un nuevo Presupuesto en la base de datos de Qex Studio";
            this.orbNew.ToolTipImage = global::uiGR2020.Properties.Resources.document_empty;
            this.orbNew.ToolTipTitle = "Nuevo Presupuesto";
            this.orbNew.Click += new System.EventHandler(this.orbNew_Click);
            // 
            // orbOpen
            // 
            this.orbOpen.Image = global::uiGR2020.Properties.Resources.folder;
            this.orbOpen.SmallImage = global::uiGR2020.Properties.Resources.folder;
            this.orbOpen.Text = "Abrir Presupuesto";
            this.orbOpen.ToolTip = "Abre un Presupuesto existente en la base de datos de QexStudio";
            this.orbOpen.ToolTipImage = global::uiGR2020.Properties.Resources.folder;
            this.orbOpen.ToolTipTitle = "Abrir Presupuesto";
            this.orbOpen.Click += new System.EventHandler(this.orbOpen_Click);
            // 
            // orbClose
            // 
            this.orbClose.Image = ((System.Drawing.Image)(resources.GetObject("orbClose.Image")));
            this.orbClose.SmallImage = global::uiGR2020.Properties.Resources.cancel;
            this.orbClose.Text = "Cerrar Presupuesto";
            this.orbClose.ToolTip = "Cierra el Presupuesto actual";
            this.orbClose.ToolTipImage = global::uiGR2020.Properties.Resources.cancel;
            this.orbClose.ToolTipTitle = "Cerrar Presupuesto";
            this.orbClose.Click += new System.EventHandler(this.orbClose_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnAyuda.DropDownItems.Add(this.btnForo);
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.SmallImage = global::uiGR2020.Properties.Resources.help;
            this.btnAyuda.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.ToolTip = "En esta sección se encuentran los temas de ayuda";
            this.btnAyuda.ToolTipImage = global::uiGR2020.Properties.Resources.help;
            this.btnAyuda.ToolTipTitle = "Menu Ayuda";
            // 
            // btnForo
            // 
            this.btnForo.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnForo.Image = ((System.Drawing.Image)(resources.GetObject("btnForo.Image")));
            this.btnForo.SmallImage = global::uiGR2020.Properties.Resources.help;
            this.btnForo.Text = "Foro de consultas";
            this.btnForo.ToolTip = "Foro de consultas sobre QexStudio";
            this.btnForo.ToolTipTitle = "Foro";
            this.btnForo.Click += new System.EventHandler(this.btnForo_Click);
            // 
            // fileExit
            // 
            this.fileExit.Image = global::uiGR2020.Properties.Resources.door_in;
            this.fileExit.SmallImage = global::uiGR2020.Properties.Resources.door_in;
            this.fileExit.Text = "Salir";
            this.fileExit.ToolTip = "Sale del programa Qex Studio";
            this.fileExit.ToolTipImage = global::uiGR2020.Properties.Resources.door_in;
            this.fileExit.ToolTipTitle = "Salir";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // fileOptions
            // 
            this.fileOptions.Enabled = false;
            this.fileOptions.Image = global::uiGR2020.Properties.Resources.setting_tools16;
            this.fileOptions.SmallImage = global::uiGR2020.Properties.Resources.setting_tools16;
            this.fileOptions.Text = "Opciones";
            this.fileOptions.ToolTip = "Establece las opciones generales y del Presupuesto activo";
            this.fileOptions.ToolTipImage = global::uiGR2020.Properties.Resources.setting_tools;
            this.fileOptions.ToolTipTitle = "Opciones";
            this.fileOptions.Click += new System.EventHandler(this.fileOptions_Click);
            // 
            // qbtnOpen
            // 
            this.qbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("qbtnOpen.Image")));
            this.qbtnOpen.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.qbtnOpen.SmallImage = global::uiGR2020.Properties.Resources.folder16;
            this.qbtnOpen.ToolTip = "Abrir un Presupuesto de la base de datos de GR2020";
            this.qbtnOpen.Click += new System.EventHandler(this.qbtnOpen_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::uiGR2020.Properties.Resources.document_empty;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Nuevo Presupuesto";
            this.ribbonButton1.ToolTip = "Crea un nuevo Presupuesto en la base de datos de Qex Studio";
            this.ribbonButton1.ToolTipImage = global::uiGR2020.Properties.Resources.document_empty;
            this.ribbonButton1.ToolTipTitle = "Nuevo Presupuesto";
            this.ribbonButton1.Click += new System.EventHandler(this.orbNew_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::uiGR2020.Properties.Resources.folder;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Abrir Presupuesto";
            this.ribbonButton2.ToolTip = "Abre un Presupuesto existente en la base de datos de QexStudio";
            this.ribbonButton2.ToolTipImage = global::uiGR2020.Properties.Resources.folder;
            this.ribbonButton2.ToolTipTitle = "Abrir Presupuesto";
            this.ribbonButton2.Click += new System.EventHandler(this.orbOpen_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::uiGR2020.Properties.Resources.cancel;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Cerrar Presupuesto";
            this.ribbonButton3.ToolTip = "Cierra el Presupuesto actual";
            this.ribbonButton3.ToolTipImage = global::uiGR2020.Properties.Resources.cancel;
            this.ribbonButton3.ToolTipTitle = "Cerrar Presupuesto";
            this.ribbonButton3.Click += new System.EventHandler(this.orbClose_Click);
            // 
            // btnImportQex
            // 
            this.btnImportQex.Image = global::uiGR2020.Properties.Resources.Qex_32x32;
            this.btnImportQex.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnImportQex.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnImportQex.SmallImage")));
            this.btnImportQex.Text = "De Archivo Qex";
            this.btnImportQex.ToolTip = "Importa las Quantificaciones de un Modelo BIM";
            this.btnImportQex.ToolTipImage = global::uiGR2020.Properties.Resources.Qex_32x32;
            this.btnImportQex.ToolTipTitle = "Importar Items desde Archivo Qex";
            this.btnImportQex.Click += new System.EventHandler(this.btnImportQex_Click);
            // 
            // btnItemImportExcel
            // 
            this.btnItemImportExcel.Image = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnItemImportExcel.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnItemImportExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnItemImportExcel.SmallImage")));
            this.btnItemImportExcel.Text = "Items desde Excel";
            this.btnItemImportExcel.ToolTip = "Importa una Lista de Items desde un archivo de Excel";
            this.btnItemImportExcel.ToolTipImage = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnItemImportExcel.ToolTipTitle = "Importar Items desde Archivo Excel";
            this.btnItemImportExcel.Click += new System.EventHandler(this.btnItemImportExcel_Click);
            // 
            // btnItemResourcesImportExcel
            // 
            this.btnItemResourcesImportExcel.Image = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnItemResourcesImportExcel.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnItemResourcesImportExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnItemResourcesImportExcel.SmallImage")));
            this.btnItemResourcesImportExcel.Text = "Recursos de Items";
            this.btnItemResourcesImportExcel.ToolTip = "Importa una Lista de Recursos asociados a Items, desde un archivo de Excel";
            this.btnItemResourcesImportExcel.ToolTipImage = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnItemResourcesImportExcel.ToolTipTitle = "Importar Recursos de Items desde Archivo Excel";
            this.btnItemResourcesImportExcel.Click += new System.EventHandler(this.btnItemResourcesImportExcel_Click);
            // 
            // btnItemAbrirPlantillas
            // 
            this.btnItemAbrirPlantillas.Image = global::uiGR2020.Properties.Resources.table_excel;
            this.btnItemAbrirPlantillas.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnItemAbrirPlantillas.SmallImage")));
            this.btnItemAbrirPlantillas.Text = "Abrir Plantillas";
            this.btnItemAbrirPlantillas.ToolTip = "Abre la carpeta que contiene las planillas de Excel, con el formato necesario par" +
    "a importar Items y Recursos";
            this.btnItemAbrirPlantillas.ToolTipImage = global::uiGR2020.Properties.Resources.table_excel;
            this.btnItemAbrirPlantillas.ToolTipTitle = "Abrir la carpeta de Plantillas de importación";
            this.btnItemAbrirPlantillas.Click += new System.EventHandler(this.btnItemAbrirPlantillas_Click);
            // 
            // btnGestionRevit
            // 
            this.btnGestionRevit.Image = global::uiGR2020.Properties.Resources.GR_Logo_32x31;
            this.btnGestionRevit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGestionRevit.SmallImage")));
            this.btnGestionRevit.Text = "Importar GR-2013";
            this.btnGestionRevit.Visible = false;
            this.btnGestionRevit.Click += new System.EventHandler(this.btnGestionRevit_Click);
            // 
            // btnItemExportExcel
            // 
            this.btnItemExportExcel.Image = global::uiGR2020.Properties.Resources.excel_exports;
            this.btnItemExportExcel.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnItemExportExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnItemExportExcel.SmallImage")));
            this.btnItemExportExcel.Text = "Exportar a Excel";
            this.btnItemExportExcel.ToolTip = "Exporta el Catálogo de Items a un archivo de Excel";
            this.btnItemExportExcel.ToolTipImage = global::uiGR2020.Properties.Resources.excel_exports;
            this.btnItemExportExcel.ToolTipTitle = "Exportar Items a Excel";
            this.btnItemExportExcel.Click += new System.EventHandler(this.btnItemExportExcel_Click);
            // 
            // btnResourceImportExcel
            // 
            this.btnResourceImportExcel.Image = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnResourceImportExcel.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnResourceImportExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnResourceImportExcel.SmallImage")));
            this.btnResourceImportExcel.Text = "Importar desde Excel";
            this.btnResourceImportExcel.ToolTip = "Importa una Lista de Recursos desde un archivo de Excel. Si el Recurso ya existe," +
    " sus propiedades se actualizan";
            this.btnResourceImportExcel.ToolTipImage = global::uiGR2020.Properties.Resources.excel_imports;
            this.btnResourceImportExcel.ToolTipTitle = "Importar Recursos desde archivo de Excel";
            this.btnResourceImportExcel.Click += new System.EventHandler(this.btnResourceImportExcel_Click);
            // 
            // btnOpenPlantillaImportarRecursos
            // 
            this.btnOpenPlantillaImportarRecursos.Image = global::uiGR2020.Properties.Resources.table_excel;
            this.btnOpenPlantillaImportarRecursos.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnOpenPlantillaImportarRecursos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOpenPlantillaImportarRecursos.SmallImage")));
            this.btnOpenPlantillaImportarRecursos.Text = "Abrir Plantillas";
            this.btnOpenPlantillaImportarRecursos.ToolTip = "Abre la carpeta que contiene las planillas de Excel, con el formato necesario par" +
    "a importar los Recursos";
            this.btnOpenPlantillaImportarRecursos.ToolTipImage = global::uiGR2020.Properties.Resources.table_excel;
            this.btnOpenPlantillaImportarRecursos.ToolTipTitle = "Abrir la carpeta de Plantillas de importación";
            this.btnOpenPlantillaImportarRecursos.Click += new System.EventHandler(this.btnOpenPlantillaImportarRecursos_Click);
            // 
            // btnResourceExportExcel
            // 
            this.btnResourceExportExcel.Image = global::uiGR2020.Properties.Resources.excel_exports;
            this.btnResourceExportExcel.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnResourceExportExcel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnResourceExportExcel.SmallImage")));
            this.btnResourceExportExcel.Text = "Exportar a Excel";
            this.btnResourceExportExcel.ToolTip = "Exporta el Catálogo de Recursos a un archivo de Excel";
            this.btnResourceExportExcel.ToolTipImage = global::uiGR2020.Properties.Resources.excel_exports;
            this.btnResourceExportExcel.ToolTipTitle = "Exportar Recursos a Excel";
            this.btnResourceExportExcel.Click += new System.EventHandler(this.btnResourceExportExcel_Click);
            // 
            // btnRubroNuevo
            // 
            this.btnRubroNuevo.Enabled = false;
            this.btnRubroNuevo.Image = global::uiGR2020.Properties.Resources.folder_add;
            this.btnRubroNuevo.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnRubroNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRubroNuevo.SmallImage")));
            this.btnRubroNuevo.Text = "Nuevo Rubro";
            // 
            // btnRubroEditar
            // 
            this.btnRubroEditar.Enabled = false;
            this.btnRubroEditar.Image = global::uiGR2020.Properties.Resources.folder_edit;
            this.btnRubroEditar.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnRubroEditar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRubroEditar.SmallImage")));
            this.btnRubroEditar.Text = "Editar  Rubro";
            // 
            // btnRubroEliminar
            // 
            this.btnRubroEliminar.Enabled = false;
            this.btnRubroEliminar.Image = global::uiGR2020.Properties.Resources.folder_delete;
            this.btnRubroEliminar.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnRubroEliminar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRubroEliminar.SmallImage")));
            this.btnRubroEliminar.Text = "Eliminar Rubro";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "Importar";
            // 
            // btnPresNuevo
            // 
            this.btnPresNuevo.Image = global::uiGR2020.Properties.Resources.document_empty;
            this.btnPresNuevo.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnPresNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPresNuevo.SmallImage")));
            this.btnPresNuevo.Text = "Nuevo Presupuesto";
            this.btnPresNuevo.ToolTip = "Crea un nuevo Presupuesto en blanco";
            this.btnPresNuevo.Click += new System.EventHandler(this.btnPresNuevo_Click);
            // 
            // btnPresAbrir
            // 
            this.btnPresAbrir.Image = global::uiGR2020.Properties.Resources.folder;
            this.btnPresAbrir.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnPresAbrir.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPresAbrir.SmallImage")));
            this.btnPresAbrir.Text = "Abrir Presupuesto";
            this.btnPresAbrir.ToolTip = "Abre un Presupuesto guardado en la base de datos de GR2020";
            this.btnPresAbrir.Click += new System.EventHandler(this.btnPresAbrir_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnAbout.Image = global::uiGR2020.Properties.Resources.help;
            this.btnAbout.SmallImage = global::uiGR2020.Properties.Resources.help;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qex Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab tabEstimates;
        private System.Windows.Forms.RibbonOrbOptionButton fileOptions;
        //private System.Windows.Forms.RibbonOrbMenuItem fileNew;
        private System.Windows.Forms.RibbonButton fileOpen;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton fileExit;
        private System.Windows.Forms.RibbonPanel ribbonPanelItems;
        private System.Windows.Forms.RibbonButton btnImportQex;
        private System.Windows.Forms.RibbonButton qbtnOpen;
        private System.Windows.Forms.RibbonButton orbOpen;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnPresNuevo;
        private System.Windows.Forms.RibbonButton btnPresAbrir;
        private System.Windows.Forms.RibbonButton orbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RibbonButton btnRubroEliminar;
        private System.Windows.Forms.RibbonButton btnRubroEditar;
        private System.Windows.Forms.RibbonButton btnRubroNuevo;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton orbNew;
        private System.Windows.Forms.RibbonTab tabResources;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnResourceImportExcel;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnResourceExportExcel;
        private System.Windows.Forms.RibbonTab tabItems;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton btnItemImportExcel;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonButton btnItemExportExcel;
        private System.Windows.Forms.RibbonButton btnItemResourcesImportExcel;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton btnOpenPlantillaImportarRecursos;
        private System.Windows.Forms.RibbonButton btnItemAbrirPlantillas;
        private System.Windows.Forms.RibbonButton btnGestionRevit;
        private System.Windows.Forms.RibbonButton btnAyuda;
        private System.Windows.Forms.RibbonButton btnForo;
        private System.Windows.Forms.RibbonOrbMenuItem btnAbout;
    }
}