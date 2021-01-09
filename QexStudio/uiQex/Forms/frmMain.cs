using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qex;

namespace uiGR2020
{
    public partial class frmMain : Form
    {
        public static int _pres_id = 0;
        public List<AnalisisItem> _lst1;
        public List<AnalisisItem> _lst2;

        public frmMain()
        {
            // Incio
            this.Text = Tools._title;
            Tools.SetInitialOptions();
            InitializeComponent();
            using (var datos = new DataAccess())
            {
            };
            Tools.CrearCarpetaInicial("Qex Studio");
            this.treeView1.Nodes[0].ExpandAll();
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private PictureBox logo()
        {
            PictureBox logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Dock = DockStyle.None;
            logo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logo.Image = Resource1.GR2020_building;
            logo.Width = 350;
            logo.Height = 350;
            return logo;
        }
        #region Ribbon Tabs
        private void ribbon1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tabEstimates.Active == true)
            {
                Tools.MouseWait();
                // Si hay ventanas abiertas, cerrar todo
                if (this.MdiChildren.Count() > 0)
                {
                    foreach (Form item in this.MdiChildren)
                    {
                        item.Close();
                    }
                }

                // Si hay un Presupuesto cargado, mostrar el Arbol de Flujo
                if (_pres_id != 0)
                {
                    this.panel1.Visible = true;
                    this.treeView1.SelectedNode = null;
                    this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes["NodoEstimate"];
                    //Presupuesto pres = Presupuesto.getById(_pres_id);
                    //frmEstimate form = new frmEstimate(pres);

                    //form.MdiParent = this;
                    //form.Dock = DockStyle.Fill;
                    //this.Text = pres.nombre;
                    //form.Show();
                }
                Tools.MouseArrow();
                return;
            }
            if (tabResources.Active == true)
            {
                Tools.MouseWait();
                if (this.MdiChildren.Count() > 0)
                {
                    foreach (Form item in this.MdiChildren)
                    {
                        item.Close();
                    }
                }
                this.panel1.Visible = false;
                frmRecursos form = new frmRecursos();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
                Tools.MouseArrow();
                return;
            }
            if (tabItems.Active == true)
            {
                if (this.MdiChildren.Count() > 0)
                {
                    foreach (Form item in this.MdiChildren)
                    {
                        item.Close();
                    }
                }
                this.panel1.Visible = false;
                frmTareas2 form = new frmTareas2();
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
                Tools.MouseArrow();
                return;
            }
        }
        private void showTabProyectos()
        {
            Tools.MouseWait();
            // Hay ventanas abiertas, cerrar todo
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
            }
            // Hay un Presupuesto cargado, y no hay ventanas abiertas
            if (_pres_id != 0 && this.MdiChildren.Count() == 0)
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmPresupuesto form = new frmPresupuesto(pres);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                this.Text = pres.nombre;
                form.Show();
            }
            // Hay un Presupuesto cargado, y hay ventanas abiertas
            if (_pres_id != 0 && this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmPresupuesto form = new frmPresupuesto(pres);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                this.Text = pres.nombre;
                form.Show();
            }
            Tools.MouseArrow();
        }
        private void showTabAnalisis()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (_pres_id == 0)
            {

            }
            if (_pres_id != 0 && this.MdiChildren.Count() == 0)
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmResources form = new frmResources(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            if (_pres_id != 0 && this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmResources form = new frmResources(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void showTabPresConsumos()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (_pres_id == 0)
            {

            }
            if (_pres_id != 0 && this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmEstimate form = new frmEstimate(pres);
                //frmPresAnalisis form = new frmPresAnalisis(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            if (_pres_id != 0 && this.MdiChildren.Count() == 0)
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmEstimate form = new frmEstimate(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void showTabResultados()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (_pres_id == 0)
            {
                
            }
            if (_pres_id != 0 && this.MdiChildren.Count() == 0)
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmResults form = new frmResults(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            if (_pres_id != 0 && this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmResults form = new frmResults(pres);
                form.MdiParent = this;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void showTabBasesDatos()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if (_pres_id == 0)
            {

            }
            if (_pres_id != 0 && this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void showItems()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            frmTareas2 form = new frmTareas2();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            tabResources.Visible = false;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void showRecursos()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            frmRecursos form = new frmRecursos();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            this.tabResources.Visible = true;
            this.ribbon1.ActiveTab = tabResources;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        #endregion
        #region Ribbon Buttons
        private void btnPresNuevo_Click(object sender, EventArgs e)
        {
            (new frmPresupuestoNuevo()).ShowDialog();
            if (_pres_id != 0)
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmPresupuesto form = new frmPresupuesto(pres);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                this.Text = Tools._title + ": " + pres.nombre;
                form.Show();
            }
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            showItems();
        }
        private void btnRecurso_Click(object sender, EventArgs e)
        {
            showRecursos();
        }
        private void orbNew_Click(object sender, EventArgs e)
        {
            (new frmPresupuestoNuevo()).ShowDialog();
            if (_pres_id != 0)
            {
                this.panel1.Visible = true;
                Presupuesto pres = Presupuesto.getById(_pres_id);
                frmEstimate form = new frmEstimate(pres);
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                this.Text = Tools._title + ": " + pres.nombre;
                form.Show();
                this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes[0];
            }
        }
        private void btnPresAbrir_Click(object sender, EventArgs e)
        {
            abrirPresupuesto();
        }
        private void qbtnOpen_Click(object sender, EventArgs e)
        {
            abrirPresupuesto();
        }
        private void orbOpen_Click(object sender, EventArgs e)
        {
            closePresupuesto();
            abrirPresupuesto();
        }
        private void fileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnItemDbOpen_Click(object sender, EventArgs e)
        {
            ribbon1.ActiveTab = tabItems;
        }
        private void btnRecursoDbOpen_Click(object sender, EventArgs e)
        {
            ribbon1.ActiveTab = tabResources;
        }
        private void orbClose_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
            }
            this.panel1.Visible = false;
            _pres_id = 0;
            this.Text = Tools._title;
        }
        private void closePresupuesto()
        {
            // Si hay ventanas abiertas, cerrarlas
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form item in this.MdiChildren)
                    item.Close();
            }
            this.panel1.Visible = false;
            _pres_id = 0;
            this.Text = Tools._title;
        }
        private void orbImportQex_Click(object sender, EventArgs e)
        {
            (new frmImportarQex()).ShowDialog();
            abrirPresupuesto();
        }
        private void btnImportQex_Click(object sender, EventArgs e)
        {
            if (frmMain._pres_id == 0)
            {
                MessageBox.Show("Primero debe abrir un Presupuesto", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                (new frmImportarQex()).ShowDialog();
                if (_pres_id != 0)
                {
                    Tools.MouseWait();
                    this.panel1.Visible = true;
                    Presupuesto pres = Presupuesto.getById(_pres_id);
                    frmEstimate form = new frmEstimate(pres);
                    form.MdiParent = this;
                    form.Dock = DockStyle.Fill;
                    this.Text = Tools._title + ": " + pres.nombre;
                    form.Show();
                    this.treeView1.SelectedNode = this.treeView1.Nodes[0].Nodes["NodoEstimate"];
                    Tools.MouseArrow();
                }
            }
        }
        #endregion
        #region Procesos
        private void abrirPresupuesto()
        {
            (new frmProyectos3()).ShowDialog();
            ribbon1.ActiveTab = tabEstimates;
        }
        #endregion
        #region TreeView
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //this.treeView1.SelectedNode = e.Node;
            switch (e.Node.Name)
            {
                case "NodoEstimate":
                    if (this.MdiChildren.Count() > 0)
                    {
                        this.MdiChildren[0].Close();
                    }
                    showTabPresConsumos();
                    break;
                case "NodoResources":
                    if (this.MdiChildren.Count() > 0)
                    {
                        this.MdiChildren[0].Close();
                    }
                    showTabAnalisis();
                    break;
                //case "NodoItems":
                //    if (this.MdiChildren.Count() > 0)
                //    {
                //        this.MdiChildren[0].Close();
                //    }
                //    showTabProyectos();
                //    break;
                //case "NodoResult":
                //    if (this.MdiChildren.Count() > 0)
                //    {
                //        this.MdiChildren[0].Close();
                //    }
                //    showTabResultados();
                //    break;
                //case "NodoReport":
                //    if (this.MdiChildren.Count() > 0)
                //    {
                //        this.MdiChildren[0].Close();
                //    }
                //    break;
            }
        }
        
        #endregion

        private void btnResourceImportExcel_Click(object sender, EventArgs e)
        {
            (new frmRecursosImportExcel()).ShowDialog();
            foreach (Form item in this.MdiChildren)
                item.Close();
            showRecursos();
        }
        private void btnResourceExportExcel_Click(object sender, EventArgs e)
        {
            
            //Exporting to Excel
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento Excel|*.xlsx";
            string title = "Catalogo Recursos";
            sfd.FileName = title + ".xlsx";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                folderPath = sfd.FileName;
                try
                {
                    Tools.crearExcelRecursos(title, Recurso.read(), folderPath);
                    DialogResult result2 = MessageBox.Show("Documento creado correctamente. " + 
                        "¿Quiere abrir el archivo creado?",
                        Tools._title, MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                    switch(result2)
                    {
                        case DialogResult.Yes:
                            {
                                System.Diagnostics.Process.Start(folderPath);
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            }
            
        }
        private void btnControlRecursoIsUsed_Click(object sender, EventArgs e)
        {
            frmRecursos frmChild = (frmRecursos)this.MdiChildren[0];
            DataGridView dgvRecursos = (DataGridView)frmChild.Controls["dgvRecursos"];
            if (dgvRecursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Recurso", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
        }
        private void btnItemImportGR_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quiere importar Tareas y Recursos desde Gestion Revit?",
                Tools._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch(result)
            {
                case DialogResult.Yes:
                    {
                        (new frmImportarTareasGR()).ShowDialog();
                        ribbon1.ActiveTab = tabItems;
                        return;
                    }
                case DialogResult.No:
                    {
                        return;
                    }
            }
        }
        private void btnItemImportExcel_Click(object sender, EventArgs e)
        {
            (new frmTareasImportExcel()).ShowDialog();
            ribbon1.ActiveTab = tabItems;
        }
        private void btnItemExportExcel_Click(object sender, EventArgs e)
        {
            //Exporting to Excel
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento Excel|*.xlsx";
            string title = "Catalogo Items";
            sfd.FileName = title + ".xlsx";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                folderPath = sfd.FileName;
                try
                {
                    Tools.crearExcelTareas(title, Tarea.read(), folderPath);
                    DialogResult result2 = MessageBox.Show("Documento creado correctamente. " +
                        "¿Quiere abrir el archivo creado?",
                        Tools._title, MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                    switch (result2)
                    {
                        case DialogResult.Yes:
                            {
                                System.Diagnostics.Process.Start(folderPath);
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            }
        }
        private void btnItemResourcesImportExcel_Click(object sender, EventArgs e)
        {
            (new frmConsumoItemsExcel()).ShowDialog();
            ribbon1.ActiveTab = tabItems;
        }

        private void fileOptions_Click(object sender, EventArgs e)
        {
            if (_pres_id == 0)
            {
                (new frmOptions()).ShowDialog();
            }
            else
            {
                Presupuesto pres = Presupuesto.getById(_pres_id);
                (new frmOptions(pres)).ShowDialog();
            }
        }

        

        private void btnOpenPlantillaImportarRecursos_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillas Excel");
            System.Diagnostics.Process.Start(path);
        }

        private void btnItemAbrirPlantillas_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantillas Excel");
            System.Diagnostics.Process.Start(path);
        }

        private void btnGestionRevit_Click(object sender, EventArgs e)
        {
            (new frmImportarTareasGR()).ShowDialog();
        }

        private void btnActivarLicencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gorovt/Qex_Studio/discussions");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }
    }
}
