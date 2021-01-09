#region
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
using System.Collections;
#endregion

namespace uiGR2020
{
    public partial class frmResources : Form
    {
        Presupuesto _pres;
        List<ItemRecurso> _lstItems;

        public frmResources(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            lblPresupuesto.Text = pres.nombre;
            this.pgbProgress.Visible = true;
            this.lblStatus.Text = "Calculando materiales...";
            Refresh();
            // Worker
            //Worker = new BackgroundWorker();
            //Worker.WorkerReportsProgress = true;
            //Worker.WorkerSupportsCancellation = false;
            // Declarar los eventos de BackgroundWorker
            //Worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            //Worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            //Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            //Worker.RunWorkerAsync();
        }

        #region General
        private void frmResources_Load(object sender, EventArgs e)
        {
            // Can the given object be expanded?
            this.treeListView1.CanExpandGetter = delegate (object x)
            {
                var item = (ItemRecurso)x;
                return (item.GetChildrens().Count > 0);
            };

            // What objects should belong underneath the given model object?
            this.treeListView1.ChildrenGetter = delegate (object x)
            {
                var item = (ItemRecurso)x;
                //return new ArrayList(_lstItems);
                return new ArrayList(item.GetChildrensOrden());
            };

            // Which image should be used for which model
            this.olvColumn1.ImageGetter = delegate (Object x) {
                var item = (ItemRecurso)x;
                switch (item.categoria)
                {
                    case "Presupuesto":
                        return 0;
                    case "Material":
                        return 2;
                    case "Trabajo":
                        return 3;
                    case "Equipo":
                        return 4;
                    default:
                        return 2;
                };
            };
            this.treeListView1.ExpandAll();
        }
        private void Refresh()
        {
            Tools.MouseWait();
            _pres = Presupuesto.getById(_pres.id);
            ItemRecurso item = _pres.ToConsumoPres();
            //(new frmProcess(2)).ShowDialog();
            _lstItems = new List<ItemRecurso>();
            _lstItems.Add(item);
            this.treeListView1.Roots = _lstItems;
            this.treeListView1.ExpandAll();
            this.lblStatus.Text = "";
            this.lblPresupuesto.Text = _pres.nombre;
            this.pgbProgress.Value = 0;
            this.pgbProgress.Visible = false;
            Tools.MouseArrow();
        }
        #endregion

        #region Worker
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Tools.MouseWait();
            this.treeListView1.DataBindings.Clear();
            _lstItems = new List<ItemRecurso>();
            //_lstItems.Add(_pres.toItemRecurso(Worker));
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pgbProgress.Value = e.ProgressPercentage;
            this.lblStatus.Text = Tools._status;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.treeListView1.SetObjects(_lstItems);
            this.treeListView1.ExpandAll();
            this.pgbProgress.Visible = false;
            Tools.MouseArrow();
            this.lblStatus.Text = "";
        }
        #endregion

        #region TreeListView
        private void treeListView1_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            ItemRecurso item = (ItemRecurso)e.Model;
            if (item.categoria == "Presupuesto")
            {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Bold);
                e.Item.BackColor = Color.LightBlue;
            }
        }
        #endregion

        #region Toolbar

        #endregion

        private void toolPrint_Click(object sender, EventArgs e)
        {
            (new frmPrintPreview(this.treeListView1)).ShowDialog();
        }

        private void treeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolExportExcel_Click(object sender, EventArgs e)
        {
            //Exporting to Excel
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento Excel|*.xlsx";
            Presupuesto pres = Presupuesto.getById(frmMain._pres_id);
            string title = pres.nombre;
            sfd.FileName = title + ".xlsx";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Tools.MouseWait();
                folderPath = sfd.FileName;
                try
                {
                    Tools.crearExcelRecursos(_pres, this.treeListView1, folderPath);
                    MessageBox.Show("Documento creado correctamente", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result2 = MessageBox.Show("¿Desea abrir el documento creado?",
                        Tools._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (result2)
                    {
                        case DialogResult.Yes:
                            System.Diagnostics.Process.Start(folderPath);
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Tools.MouseArrow();
            }
        }

        private void toolActualizar_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
