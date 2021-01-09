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
using BrightIdeasSoftware;
using System.Collections;

namespace uiGR2020
{
    public partial class frmEstimate : Form
    {
        public static Presupuesto _pres;
        public static List<ItemPres> _lstItems;
        public string _status = "";
        public int _index = 0;
        public BackgroundWorker _work;
        

        public frmEstimate(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            lblPresupuesto.Text = pres.nombre;
            this.treeListView1.UseHotItem = false;
            this.treeListView1.UseHyperlinks = false;
            this.treeListView1.UseHotControls = false;
            Refresh(_pres);

            // Menu Headers
            this.mnuGrupos.Items.Insert(0, new ToolStripLabel("ELEMENTO")
            { Font = new Font(DefaultFont, FontStyle.Bold | FontStyle.Underline), BackColor = Color.DarkGray });
            this.mnuGrupos.Items.Insert(5, new ToolStripLabel("SUB-ELEMENTOS")
            { Font = new Font(DefaultFont, FontStyle.Bold | FontStyle.Underline), BackColor = Color.DarkGray });
            // Menu Item Labels
            this.mnuItems.Items.Insert(0, new ToolStripLabel("ELEMENTO")
            { Font = new Font(DefaultFont, FontStyle.Bold | FontStyle.Underline), BackColor = Color.DarkGray });
            this.mnuItems.Items.Insert(5, new ToolStripLabel("RECURSOS")
            { Font = new Font(DefaultFont, FontStyle.Bold | FontStyle.Underline), BackColor = Color.DarkGray });
        }

        #region General
        private void frmEstimate_Load(object sender, EventArgs e)
        {
            // Can the given object be expanded?
            this.treeListView1.CanExpandGetter = delegate (object x)
            {
                var item = (ItemPres)x;
                return (item.GetChildrens().Count > 0);
            };

            // What objects should belong underneath the given model object?
            this.treeListView1.ChildrenGetter = delegate (object x)
            {
                var item = (ItemPres)x;
                return new ArrayList(item.GetChildrensOrden());
            };
            // Which image should be used for which model
            this.olvColumn1.ImageGetter = delegate (Object x) {
                var item = (ItemPres)x;
                if (item.categoria == "Presupuesto")
                    return 0;
                else if (item.categoria == "Grupo")
                    return 1;
                else
                {
                    if (item.tieneRecursos())
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
                
            };
            this.treeListView1.ExpandAll();
        }

        private void Refresh(ItemPres item)
        {
            Tools.MouseWait();
            _pres = Presupuesto.getById(_pres.id);
            (new frmProcess(1)).ShowDialog();
            _lstItems = new List<ItemPres>();
            _lstItems.Add(_pres);
            this.treeListView1.Roots = _lstItems;
            
            this.lblStatus.Text = "";
            this.lblPresupuesto.Text = _pres.nombre;
            this.pgbProgress.Value = 0;
            this.pgbProgress.Visible = false;
            // Levels
            switch (Tools._level)
            {
                case 1:
                    this.treeListView1.CollapseAll();
                    this.treeListView1.Expand(this.treeListView1.GetModelObject(0));
                    break;
                case 2:
                    this.treeListView1.ExpandAll();
                    break;
            }
            Tools.MouseArrow();
        }
        #endregion

        #region Worker
        private void work_DoWork(object sender, DoWorkEventArgs e)
        {
            Tools.MouseWait();
            _lstItems = new List<ItemPres>();
            _pres = Presupuesto.getById(_pres.id);
            _pres.UpdateAll(this.work);
        }
        private void work_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pgbProgress.Value = e.ProgressPercentage;
            this.lblStatus.Text = Tools._status;
        }
        private void work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _lstItems.Clear();
            _lstItems.Add(_pres);
            this.treeListView1.Roots = _lstItems;
            this.treeListView1.ExpandAll();
            this.lblStatus.Text = "";
            this.lblPresupuesto.Text = _pres.nombre;
            this.pgbProgress.Value = 0;
            this.pgbProgress.Visible = false;
            Tools.MouseArrow();
        }
        private void work_RunWorkerCompletedIndex(object sender, RunWorkerCompletedEventArgs e)
        {
            var expanded = treeListView1.ExpandedObjects;
            this.treeListView1.DataBindings.Clear();
            this.treeListView1.SetObjects(_lstItems);
            //this.treeListView1.Expand(this.treeListView1.GetModelObject(0));
            //this.treeListView1.ExpandAll();
            //this.treeListView1.ExpandedObjects = lst;
            this.treeListView1.ExpandedObjects = expanded;
            //this.treeListView1.SelectedIndex = _index;
            this.lblStatus.Text = "";
            this.pgbProgress.Visible = false;
            Tools.MouseArrow();
        }
        #endregion

        #region Menu Contextual
        private void treeListView1_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (this.treeListView1.SelectedObject != null)
            {
                ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
                if (item.categoria == "Presupuesto" || item.categoria == "Grupo")
                {
                    mnuGrupos.Show(Cursor.Position);
                }
                if (item.categoria == "Item")
                {
                    mnuItems.Show(Cursor.Position);
                }
            }
        }
        private void mnuGrupoNew_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            RubroPres newRubro = new RubroPres();
            newRubro.nombre = "Nuevo Grupo";
            newRubro.pres_id = _pres.id;

            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            if (item.categoria == "Presupuesto")
            {
                newRubro.rubropres_id = 0;
            }
            if (item.categoria == "Grupo")
            {
                newRubro.rubropres_id = item.id;
            }
            if (item.categoria == "Item")
            {
                MessageBox.Show("Debes seleccionar el Presupuesto o un Grupo", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            (new frmRubroPresEditar(newRubro, false)).ShowDialog();
            int index = this.treeListView1.IndexOf(item);
            Refresh(item);
        }

        private void mnuGrupoEdit_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            if (item.categoria == "Presupuesto")
            {
                (new frmPresupuestoNuevo(_pres)).ShowDialog();
                //item.update();
            }
            if (item.categoria == "Grupo")
            {
                RubroPres rubro = RubroPres.getByid(item.id);
                (new frmRubroPresEditar(rubro, true)).ShowDialog();
                //item.update();
            }
            if (item.categoria == "Item")
            {
                TareaPres tarea = TareaPres.getById(item.id);
                (new frmTareaPresEditar(tarea)).ShowDialog();
                //item.update();
            }
            //int index = this.treeListView1.IndexOf(item);
            Refresh(_pres);
        }

        private void mnuGrupoDelete_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            if (item.categoria == "Grupo")
            {
                RubroPres rubro = RubroPres.getByid(item.id);
                RubroPres parent = null;
                ItemPres itemParent = null;
                if (rubro.rubropres_id == 0)
                {
                    itemParent = _pres;
                }
                else
                {
                    parent = rubro.getParent();
                    itemParent = rubro.getParent();
                }
                
                try
                {
                    DialogResult result = MessageBox.Show("¿Deseas eliminar el Grupo y todos sus elementos?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                rubro.delete();
                                int index = this.treeListView1.IndexOf(itemParent);
                                Refresh(itemParent);
                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                Tools.MouseArrow();
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Tools.MouseArrow();
        }

        private void mnuItemNew_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            if (item.categoria == "Presupuesto" || item.categoria == "Item")
            {
                MessageBox.Show("Debes seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Tools.MouseArrow();
                return;
            }
            if (item.categoria == "Grupo")
            {
                RubroPres rubro = RubroPres.getByid(item.id);
                (new frmTareaPresNueva(rubro)).ShowDialog();
                //int index = this.treeListView1.IndexOf(item);
                Refresh(item);
            }
        }
        #endregion

        #region TreeListView
        private void treeListView1_FormatRow(object sender, FormatRowEventArgs e)
        {
            ItemPres item = (ItemPres)e.Model;
            if (item.categoria == "Presupuesto")
            {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Bold);
                e.Item.BackColor = Color.LightBlue;
            }
            if (item.categoria == "Grupo")
            {
                e.Item.BackColor = Color.AliceBlue;
            }
        }
        private void treeListView1_ItemActivate(object sender, EventArgs e)
        {
            Object model = this.treeListView1.SelectedObject;
            if (model != null)
                this.treeListView1.ToggleExpansion(model);
        }
        #endregion

        #region Group Contextual Menu
        private void mnuInsertItemFromCatalog_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            if (item.categoria == "Presupuesto" || item.categoria == "Item")
            {
                MessageBox.Show("Debes seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Tools.MouseArrow();
                return;
            }
            if (item.categoria == "Grupo")
            {
                RubroPres rubro = RubroPres.getByid(item.id);
                (new frmSelectTareasPres(_pres, rubro)).ShowDialog();
                //int index = this.treeListView1.IndexOf(item);
                Refresh(item);
            }
        }


        #endregion

        #region Item Contextual Menu
        private void mnuCopyResource_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            TareaPres tarea = TareaPres.getById(item.id);
            List<ConsumoRecurso> lst = new List<ConsumoRecurso>();
            foreach (ConsumoPres cp in tarea.getConsumos())
            {
                ConsumoRecurso cr = new ConsumoRecurso();
                cr.recurso_id = cp.recurso_id;
                cr.consumo = cp.consumo;
                cr.coeficiente = cp.coeficiente;
                lst.Add(cr);
            }
            Tools.lstClipboardConsumos = lst;
        }

        private void mnuPasteResource_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
                TareaPres tarea = TareaPres.getById(item.id);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se pegarán los siguientes Recursos:");
                foreach (ConsumoRecurso cr in Tools.lstClipboardConsumos)
                {
                    sb.AppendLine(cr.toNodeText());
                }
                DialogResult result = MessageBox.Show(sb.ToString(), Tools._title,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            Tools.MouseWait();
                            foreach (ConsumoRecurso cr in Tools.lstClipboardConsumos)
                            {
                                Recurso rec = cr.getRecurso();
                                double costoTotal = cr.consumo * cr.coeficiente * rec.precio;
                                ConsumoPres cp = new ConsumoPres(rec.nombre, cr.consumo, rec.unidad, rec.categoria,
                                    rec.venta_cantidad, rec.venta_unidad, rec.precio, costoTotal, 0, "", tarea.id, 
                                    cr.recurso_id, cr.coeficiente, _pres.id); //, cr.categoria);
                                cp.insert();
                            }
                            //int index = this.treeListView1.IndexOf(item);
                            Refresh(item);
                            Tools.MouseArrow();
                            MessageBox.Show("Recursos pegados correctamente", Tools._title,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: /n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuItemEdit_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            TareaPres tarea = TareaPres.getById(item.id);
            (new frmTareaPresEditar(tarea)).ShowDialog();
            //int index = this.treeListView1.IndexOf(item);
            Refresh(item);
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            TareaPres tarea = TareaPres.getById(item.id);
            RubroPres parent = tarea.getParent();
            try
            {
                DialogResult result = MessageBox.Show("¿Deseas eliminar el Item y todos sus Recursos?",
                    Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            tarea.delete();
                            Refresh(_pres);
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            Tools.MouseArrow();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        
        #region ToolBar
        private void toolAutoWbs_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            Tools.AutoWbs(_pres);
            Refresh(_pres);
        }

        private void toolPrint_Click(object sender, EventArgs e)
        {
            (new frmPrintPreview(this.treeListView1)).ShowDialog();
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
                    Tools.crearExcelPresupuesto(_pres, this.treeListView1, folderPath);
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
        #endregion

        private void toolExportProject_Click(object sender, EventArgs e)
        {
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo Xml|*.xml";
            string title = _pres.nombre;
            sfd.FileName = title + ".xml";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Tools.MouseWait();
                folderPath = sfd.FileName;
                try
                {
                    _pres.toMppProject().SaveToXml(folderPath);
                    MessageBox.Show("Archivo Xml guardado correctamente", Tools._title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            }
        }

        private void toolReadXml_Click(object sender, EventArgs e)
        {
            
            //Presupuesto pres = Presupuesto.GetEstimateFromXml(@"c:\temp\presupuesto.xml");
            //MessageBox.Show("Estimate: " + pres.nombre + " loading successfully");
        }

        private void mnuGrupoMove_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            (new frmGrupoMove(_pres, item)).ShowDialog();
            //int index = this.treeListView1.IndexOf(item);
            Refresh(item);
        }

        private void mnuItemMove_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            (new frmGrupoMove(_pres, item)).ShowDialog();
            //int index = this.treeListView1.IndexOf(item);
            Refresh(item);
        }

        private void mnuItemCopyFromCatalog_Click(object sender, EventArgs e)
        {
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;
            TareaPres tarea = TareaPres.getById(item.id);
            (new frmSelectTareasPres(tarea)).ShowDialog();
            //int index = this.treeListView1.IndexOf(item);
            Refresh(item);
            // No hace falta actualizar. No pasa nada
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            (new frmResults(_pres)).ShowDialog();
            _pres = Presupuesto.getById(_pres.id);
            Refresh(_pres);
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Tools._level = 1;
            this.treeListView1.CollapseAll();
            this.treeListView1.Expand(this.treeListView1.GetModelObject(0));
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            Tools._level = 2;
            this.treeListView1.ExpandAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Refresh(_pres);
            //refresh((ItemPres)this.treeListView1.SelectedObject);
        }

        private void frmEstimate_Shown(object sender, EventArgs e)
        {
        }

        private void treeListView1_FormatCell(object sender, FormatCellEventArgs e)
        {
            //ItemPres item = (ItemPres)e.Model;
            //if (item.categoria == "Presupuesto")
            //{
            //    if (e.ColumnIndex == 2)
            //    {
            //        e.Item.Text = "";
            //    }
            //}
        }

        private void toolExportPresXml_Click(object sender, EventArgs e)
        {
            string folderPath = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo Xml|*.xml";
            string title = _pres.nombre;
            sfd.FileName = title + ".xml";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Tools.MouseWait();
                folderPath = sfd.FileName;
                try
                {
                    Tools.SavePresupuestoToXml(_pres, folderPath);
                    MessageBox.Show("Archivo Xml guardado correctamente", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Tools.MouseArrow();
            }
        }
    }
}
