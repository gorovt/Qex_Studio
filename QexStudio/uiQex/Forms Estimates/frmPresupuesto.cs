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
using System.Threading;
using System.Collections;

namespace uiGR2020
{
    public partial class frmPresupuesto : Form
    {
        public Presupuesto _pres;

        public frmPresupuesto(Presupuesto pres)
        {
            InitializeComponent();
            
            _pres = pres;
            this.lblPresupuesto.Text = pres.nombre;
            //fillDataGrid2();
            this.progressBar.Visible = false;
            this.lblAvance.Text = "";
            this.dgvItems.Columns["Editar"].CellTemplate = new OpenCell();
            this.dgvItems.Columns["Eliminar"].CellTemplate = new DeleteCell();
            this.treeGrupos.CanExpandGetter = delegate (object x)
            {
                var rubro = (RubroPres)x;
                return (rubro.getChilds().Count > 0);
            };
            this.treeGrupos.ChildrenGetter = delegate (object x)
            {
                var rubro = (RubroPres)x;
                return new ArrayList(rubro.getChilds());
            };
            this.treeGrupos.SetObjects(_pres.getRubrosParent());
            this.treeGrupos.ExpandAll();
            this.treeGrupos.Columns[0].ImageIndex = 1;
        }
        #region DataGrid Items
        public void fillDataGrid2()
        {
            if (null != this.treeGrupos.SelectedItem)
            {
                RubroPres rubro = (RubroPres)this.treeGrupos.SelectedObject;
                List<TareaPres> lst = rubro.getTareas();
                lst = lst.OrderBy(x => x.orden).ToList();

                this.dgvItems.DataBindings.Clear();
                this.dgvItems.DataSource = lst;

                if (this.dgvItems.RowCount > 0)
                {
                    this.dgvItems.Rows[0].Selected = true;
                }
            }
        }
        public void fillItems(RubroPres rubro)
        {
            this.dgvItems.DataBindings.Clear();
            this.dgvItems.DataSource = rubro.getTareas();
            if (this.dgvItems.RowCount > 0)
            {
                this.dgvItems.Rows[0].Selected = true;
            }
        }
        private void btnItemNuevo_Click(object sender, EventArgs e)
        {
            if (null == this.treeGrupos.SelectedItem)
            {
                MessageBox.Show("Debe seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                RubroPres rubro = (RubroPres)this.treeGrupos.SelectedObject;
                (new frmTareaPresNueva(rubro)).ShowDialog();
                fillDataGrid2();
            }
        }
        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Imagen")
            {
                e.Value = imageList1.Images[2];
            }
        }
        public class DeleteCell : DataGridViewButtonCell
        {
            Image del = Resource1.delete_28;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, 
                int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, 
                string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, 
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(del, cellBounds);
            }
        }
        public class DeleteColumn : DataGridViewButtonColumn
        {
            public DeleteColumn()
            {
                this.CellTemplate = new DeleteCell();
                this.Width = 20;
                //set other options here 
            }
        }
        public class EditCell : DataGridViewButtonCell
        {
            Image del = Resource1.edit_28;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, 
                int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, 
                string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, 
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(del, cellBounds);
            }
        }
        public class EditColumn : DataGridViewButtonColumn
        {
            public EditColumn()
            {
                this.CellTemplate = new EditCell();
                this.Width = 20;
                //set other options here 
            }
        }
        public class OpenCell : DataGridViewButtonCell
        {
            Image open = Resource1.opened_folder_27;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, 
                int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, 
                string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, 
                DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(open, cellBounds);
            }
        }
        public class OpenColumn : DataGridViewButtonColumn
        {
            public OpenColumn()
            {
                this.CellTemplate = new OpenCell();
                this.Width = 20;
                //set other options here 
            }
        }
        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            #region Editar Recurso
            //Editar Recurso
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["id"].Value);
                TareaPres ta = TareaPres.getById(id);
                (new frmTareaPresEditar(ta)).ShowDialog();
                int indexR = 0;

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["id"].Value.ToString() == ta.id.ToString())
                    {
                        indexR = row.Index;
                    }
                }
                fillDataGrid2();
                //this.dgvItems.Rows[indexR].Selected = true;
            }
            #endregion
            #region ChekBox
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Check")
            {
                if (Convert.ToBoolean(this.dgvItems.Rows[e.RowIndex].Cells["Check"].Value))
                {
                    this.dgvItems.Rows[e.RowIndex].Cells["Check"].Value = false;
                }
                else
                {
                    this.dgvItems.Rows[e.RowIndex].Cells["Check"].Value = true;
                }
            }
            #endregion
            #region Eliminar Recurso
            //Eliminar Recurso
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["id"].Value);
                TareaPres ta = TareaPres.getById(id);
                try
                {

                    DialogResult result = MessageBox.Show("¿Desea eliminar el Item " + ta.nombre + "?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                foreach (ConsumoPres cp in ta.getConsumos())
                                {
                                    cp.delete();
                                }
                                ta.delete();
                                fillDataGrid2();
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
                    MessageBox.Show("Error desconocido. Detalles: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion
        }
        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["id"].Value);
            TareaPres ta = TareaPres.getById(id);
            (new frmTareaPresEditar(ta)).ShowDialog();
            int indexR = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["id"].Value.ToString() == ta.id.ToString())
                {
                    indexR = row.Index;
                }
            }
            fillDataGrid2();
            //this.dgvItems.Rows[indexR].Selected = true;
        }
        private void dgvItems_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Add this
                this.dgvItems.CurrentCell = this.dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Can leave these here - doesn't hurt
                this.dgvItems.Rows[e.RowIndex].Selected = true;
                this.dgvItems.Focus();
            }
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain._pres_id = 0;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            if (null == this.treeGrupos.SelectedItem)
            {
                MessageBox.Show("Debe seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                RubroPres rubro = (RubroPres)this.treeGrupos.SelectedObject;
                (new frmSelectTareasPres(_pres, rubro)).ShowDialog();
                fillDataGrid2();
                if (this.dgvItems.Rows.Count > 0)
                {
                    this.dgvItems.Rows[0].Selected = true;
                }
            }
        }
        #region Menu Contextual
        private void mnuBtnCopiarConsumos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvItems.SelectedRows[0].Cells["id"].Value);
            TareaPres tarea = TareaPres.getById(id);
            List<ConsumoRecurso> lst = new List<ConsumoRecurso>();
            foreach (ConsumoPres cp in tarea.getConsumos())
            {
                ConsumoRecurso cr = new ConsumoRecurso();
                cr.recurso_id = cp.recurso_id;
                cr.consumo = cp.consumo;
                cr.coeficiente = cp.coeficiente;
                //cr.categoria = cp.categoria;
                lst.Add(cr);
            }
            Tools.lstClipboardConsumos = lst;
        }

        private void mnuBtnPegarConsumos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dgvItems.SelectedRows[0].Cells["id"].Value);
                TareaPres tarea = TareaPres.getById(id);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se van a pegar los siguientes consumos:");
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
                            foreach (ConsumoRecurso cr in Tools.lstClipboardConsumos)
                            {
                                Recurso rec = Recurso.getById(cr.recurso_id);
                                double costoTotal = cr.consumo * cr.coeficiente * rec.precio;
                                ConsumoPres cp = new ConsumoPres(rec.nombre, cr.consumo, rec.unidad, rec.categoria,
                                    rec.venta_cantidad, rec.venta_unidad, rec.precio, costoTotal, 0, "",
                                    tarea.id, cr.recurso_id, cr.coeficiente, _pres.id);
                                cp.insert();
                            }
                            MessageBox.Show("Consumos pegados con éxito", Tools._title,
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
                MessageBox.Show("Error . Detalles: " + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void mnuRubroNew_Click(object sender, EventArgs e)
        {
            RubroPres newRubro = new RubroPres();
            newRubro.nombre = "New Group";
            newRubro.pres_id = _pres.id;

            if (null == this.treeGrupos.SelectedItem)
            {
                newRubro.rubropres_id = 0;
            }
            else
            {
                newRubro.rubropres_id = ((RubroPres)this.treeGrupos.SelectedObject).id;
            }
            newRubro.insert();

            RubroPres rubro = RubroPres.getLast();
            this.treeGrupos.DataBindings.Clear();
            this.treeGrupos.SetObjects(_pres.getRubrosParent());
            this.treeGrupos.ExpandAll();
            this.lblImage.Image = Resource1.pencil;
            this.lblStatus.Text = "Group created Correctly";
            GoroTimer.Start(this.lblImage, this.lblStatus);
        }

        private void mnuRubroRename_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuRubroEliminar_Click(object sender, EventArgs e)
        {
            if (null != this.treeGrupos.SelectedItem)
            {
                RubroPres rubro = (RubroPres)this.treeGrupos.SelectedObject;
                RubroPres parent = rubro.getParent();
                try
                {
                    DialogResult result = MessageBox.Show("¿Desea eliminar el Rubro " + rubro.nombre +
                        " y todos sus Items?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                rubro.delete();
                                int index = this.treeGrupos.IndexOf(parent);
                                this.treeGrupos.DataBindings.Clear();
                                this.treeGrupos.SetObjects(_pres.getRubrosParent());
                                this.treeGrupos.ExpandAll();
                                this.treeGrupos.SelectedIndex = index;
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
                    MessageBox.Show("Error desconocido. Detalles: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void treeGrupos_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            mnuRubros.Show(Cursor.Position);
        }

        private void treeGrupos_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            RubroPres rubro = (RubroPres)e.Model;
            if (null != rubro)
            {
                fillItems(rubro);
            }
        }

        private void treeGrupos_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            RubroPres grupo = (RubroPres)e.RowObject;
            grupo.update();
            //if (e.Column.Name == "_orden")
            //{
            //    grupo.orden = Convert.ToInt32(e.NewValue);
            //    grupo.update();
            //    this.lblImage.Image = Resource1.pencil;
            //    this.lblStatus.Text = "Grupo actualizado correctamente";
            //}
            //if (e.Column.Name == "nombre")
            //{
            //    grupo.nombre = e.NewValue.ToString();
            //    grupo.update();
            //    this.lblImage.Image = Resource1.pencil;
            //    this.lblStatus.Text = "Grupo actualizado correctamente";
            //}
        }

        private void btnAutoWBS_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Tools.AutoWbs(_pres);
            this.treeGrupos.DataBindings.Clear();
            this.treeGrupos.SetObjects(_pres.getRubrosParent());
            this.treeGrupos.ExpandAll();
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                row.Cells["Check"].Value = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                row.Cells["Check"].Value = false;
            }
        }

        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Check"].Value))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete the selected Items?",
                            Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            List<TareaPres> lst = new List<TareaPres>();
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Details:");
                            foreach (DataGridViewRow row in this.dgvItems.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells["Check"].Value))
                                {
                                    int id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                                    TareaPres tr = TareaPres.getById(id);
                                    lst.Add(tr);
                                }
                            }
                            foreach (TareaPres tr in lst)
                            {
                                tr.delete();
                                sb.AppendLine("Deleted: " + tr.nombre);
                            }

                            MessageBox.Show(sb.ToString(), Tools._title,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDataGrid2();
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void treeGrupos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RubroPres rubro = (RubroPres)this.treeGrupos.SelectedObject;
            if (null != rubro)
            {
                fillItems(rubro);
            }
        }
    }
}
