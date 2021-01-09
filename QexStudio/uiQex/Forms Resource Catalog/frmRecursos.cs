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

namespace uiGR2020
{
    public partial class frmRecursos : Form
    {
        public static List<WarningItem> _lstWarning;
        public static List<Recurso> _lst;
        public static List<DataGridViewRow> _lstRows;
        public static string _status = "";

        public frmRecursos()
        {
            InitializeComponent();
            fillDataGridGrupos(this.dgvGrupos, 0);
            fillDataGrid(this.dgvRecursos, this.dgvGrupos);
            this.dgvRecursos.Columns["Editar"].CellTemplate = new EditCell();
            this.dgvRecursos.Columns["Eliminar"].CellTemplate = new DeleteCell();
            updateLabels();
        }
        #region General
        private void regenAll()
        {
            this.txtBuscarRecurso.Text = "";
            fillDataGridGrupos(this.dgvGrupos, 0);
            fillDataGrid(this.dgvRecursos, this.dgvGrupos);
        }
        private void updateLabels()
        {
            int countG = GrupoRecurso.read().Count();
            int countI = Recurso.read().Count();
            lblGrupos.Text = "Grupos: " + countG.ToString();
            lblRecursos.Text = "Recursos: " + countI.ToString();
        }
        private void mnuImportarDesdeGr_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Esta herramienta permite importar y actualizar los recursos " +
                "desde Gestión Revit 2013 o 2015. ¿Desea continuar?",
                        Tools._title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        this.tableLayoutPanel3.Enabled = false;
                        this.tableLayoutPanel4.Enabled = false;
                        this.backgroundWorker1.RunWorkerAsync();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                //Grupos
                List<GrupoRecurso> lstGrupos = Tools.importGruposFromExcel();
                List<Recurso> lstMats = Tools.importMaterialFromExcel();
                List<Recurso> lstMo = Tools.importManoObraFromExcel();
                List<Recurso> lstEq = Tools.importEquiposFromExcel();
                int total = lstGrupos.Count + lstMats.Count + lstMo.Count + lstEq.Count;

                int count = 0;
                int gruposNuevos = 0;
                foreach (GrupoRecurso grupo in lstGrupos)
                {
                    if (!GrupoRecurso.read().Exists(x => x.nombre == grupo.nombre))
                    {
                        grupo.insert();
                        gruposNuevos += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                    else
                    {
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                }
                sb.AppendLine("Grupos nuevos: " + gruposNuevos.ToString());
                //Materiales


                int matNuevo = 0;
                int matActualizado = 0;
                foreach (Recurso mat in lstMats)
                {
                    if (!Recurso.read().Exists(x => x.nombre == mat.nombre))
                    {
                        mat.insert();
                        matNuevo += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                    else
                    {
                        Recurso existente = Recurso.getByNombre(mat.nombre);
                        existente.nombre = mat.nombre;
                        existente.categoria = mat.categoria;
                        existente.precio = mat.precio;
                        existente.unidad = mat.unidad;
                        existente.ultima_actualizacion = DateTime.Now;
                        existente.proveedor_id = mat.proveedor_id;
                        existente.venta_cantidad = mat.venta_cantidad;
                        existente.venta_unidad = mat.venta_unidad;
                        existente.precio_venta = mat.precio_venta;
                        existente.grupo_id = mat.grupo_id;
                        existente.codigo_comercial = mat.codigo_comercial;
                        existente.nombre_comercial = mat.codigo_comercial;
                        existente.update();
                        matActualizado += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                }
                //Mano de Obra

                foreach (Recurso mo in lstMo)
                {
                    if (!Recurso.read().Exists(x => x.nombre == mo.nombre))
                    {
                        mo.insert();
                        matNuevo += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                    else
                    {
                        Recurso existente = Recurso.getByNombre(mo.nombre);
                        existente.nombre = mo.nombre;
                        existente.categoria = mo.categoria;
                        existente.precio = mo.precio;
                        existente.unidad = mo.unidad;
                        existente.ultima_actualizacion = DateTime.Now;
                        existente.proveedor_id = mo.proveedor_id;
                        existente.venta_cantidad = mo.venta_cantidad;
                        existente.venta_unidad = mo.venta_unidad;
                        existente.precio_venta = mo.precio_venta;
                        existente.grupo_id = mo.grupo_id;
                        existente.codigo_comercial = mo.codigo_comercial;
                        existente.nombre_comercial = mo.nombre_comercial;
                        existente.update();
                        matActualizado += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                }
                //Equipos



                foreach (Recurso eq in lstEq)
                {
                    if (!Recurso.read().Exists(x => x.nombre == eq.nombre))
                    {
                        eq.insert();
                        matNuevo += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                    else
                    {
                        Recurso existente = Recurso.getByNombre(eq.nombre);
                        existente.nombre = eq.nombre;
                        existente.categoria = eq.categoria;
                        existente.precio = eq.precio;
                        existente.unidad = eq.unidad;
                        existente.ultima_actualizacion = DateTime.Now;
                        existente.proveedor_id = eq.proveedor_id;
                        existente.venta_cantidad = eq.venta_cantidad;
                        existente.venta_unidad = eq.venta_unidad;
                        existente.precio_venta = eq.precio_venta;
                        existente.grupo_id = eq.grupo_id;
                        existente.codigo_comercial = eq.codigo_comercial;
                        existente.nombre_comercial = eq.nombre_comercial;
                        existente.update();
                        matActualizado += 1;
                        count += 1;
                        int value = Convert.ToInt32(100 * count / total);
                        this.backgroundWorker1.ReportProgress(value);
                    }
                }
                sb.AppendLine("Recursos nuevos: " + matNuevo.ToString());
                sb.AppendLine("Recursos actualizados: " + matActualizado.ToString());
                MessageBox.Show(sb.ToString(), Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.progressBar.Value = e.ProgressPercentage;
            //this.lblAvance.Text = e.ProgressPercentage.ToString() + "%";
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tableLayoutPanel3.Enabled = true;
            this.tableLayoutPanel4.Enabled = true;
            //this.progressBar.Visible = false;
            //this.lblStatus.Text = "";
            //this.lblAvance.Text = "";
            regenAll();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Grupos
        public void fillDataGridGrupos(DataGridView grid, int selectedIndex)
        {
            grid.Columns["_Editar"].CellTemplate = new EditCell();
            grid.Columns["_Eliminar"].CellTemplate = new DeleteCell();

            List<GrupoRecurso> lst = GrupoRecurso.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            grid.DataBindings.Clear();
            grid.DataSource = lst;
            if (grid.Rows.Count > 0)
            {
                grid.Rows[selectedIndex].Selected = true;
                grid.CurrentCell = grid.Rows[selectedIndex].Cells[0];
            }
        }
        private void btnGrupoNuevo_Click(object sender, EventArgs e)
        {
            (new frmGrupoRecursoNuevo()).ShowDialog();
            regenAll();
        }
        private void dgvGrupos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvGrupos.Columns[e.ColumnIndex].Name == "_Imagen")
            {
                e.Value = imageList1.Images[0];
            }
        }
        private void dgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar Grupo
            if (this.dgvGrupos.Columns[e.ColumnIndex].Name == "_Editar")
            {
                try
                {
                    GrupoEditar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Eliminar Grupo
            if (this.dgvGrupos.Columns[e.ColumnIndex].Name == "_Eliminar")
            {
                GrupoEliminar();
            }
        }
        private void GrupoEditar()
        {
            int grupo_id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["_Id"].Value);
            GrupoRecurso grupo = GrupoRecurso.getById(grupo_id);
            (new frmGrupoRecursoNuevo(grupo)).ShowDialog();
            int index = 0;
            foreach (DataGridViewRow row in this.dgvGrupos.Rows)
            {
                if (row.Cells["_Id"].Value.ToString() == grupo_id.ToString())
                {
                    index = row.Index;
                }
            }
            fillDataGridGrupos(this.dgvGrupos, index);
        }
        private void GrupoEliminar()
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este Grupo y todos sus Recursos?",
                            Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        int grupo_id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["_Id"].Value);
                        GrupoRecurso grupo = GrupoRecurso.getById(grupo_id);
                        try
                        {
                            this.pgbProgreso.Visible = true;
                            this.pgbProgreso.Value = 0;
                            this.MdiParent.Enabled = false;
                            _lstWarning = new List<WarningItem>();
                            workGrupoDelete.RunWorkerAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
            }
        }
        private void dgvGrupos_SelectionChanged(object sender, EventArgs e)
        {
            fillDataGrid(this.dgvRecursos, this.dgvGrupos);
        }
        private void mnuGrupoEdit_Click(object sender, EventArgs e)
        {
            GrupoEditar();
        }
        private void mnuGrupoDelete_Click(object sender, EventArgs e)
        {
            GrupoEliminar();
        }
        private void dgvGrupos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Add this
                this.dgvGrupos.CurrentCell = this.dgvGrupos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Can leave these here - doesn't hurt
                this.dgvGrupos.Rows[e.RowIndex].Selected = true;
                this.dgvGrupos.Focus();
            }
        }
        #endregion
        #region Recursos
        public void fillDataGrid(DataGridView dview, DataGridView dgrupos)
        {
            if (dgrupos.SelectedRows.Count == 0)
            {
                List<Recurso> lst = new List<Recurso>();
                dview.DataBindings.Clear();
                dview.DataSource = lst;
            }
            if (dgrupos.SelectedRows.Count > 0)
            {
                int grupo_id = Convert.ToInt32(dgrupos.SelectedRows[0].Cells["_Id"].Value);
                List<Recurso> lst = Recurso.read();
                lst = lst.FindAll(x => x.grupo_id == grupo_id).ToList();
                lst = lst.OrderBy(x => x.nombre).ToList();

                dview.DataBindings.Clear();
                dview.DataSource = lst;

                if (this.dgvRecursos.RowCount > 0)
                {
                    dview.Rows[0].Selected = true;
                }
            }
        }
        private void btnRecursoNuevo_Click(object sender, EventArgs e)
        {
            if (this.dgvGrupos.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvGrupos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvGrupos.SelectedRows.Count > 0)
            {
                int grupo_id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["_Id"].Value);
                (new frmRecursoNuevo(grupo_id)).ShowDialog();
                fillDataGrid(this.dgvRecursos, this.dgvGrupos);
            }
        }
        private void btnResourceDuplicate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvRecursos.SelectedRows[0].Cells["Id"].Value.ToString());
            Recurso rec = Recurso.getById(id);
            (new frmRecursoNuevo(rec, true)).ShowDialog();
            this.txtBuscarRecurso.Text = "";
            int indexG = 0;
            foreach (DataGridViewRow row in dgvGrupos.Rows)
            {
                if (row.Cells["_Id"].Value.ToString() == rec.grupo_id.ToString())
                {
                    indexG = row.Index;
                }
            }
            fillDataGridGrupos(this.dgvGrupos, indexG);
        }
        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            int count = 0;
            _lstRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in this.dgvRecursos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check"].Value))
                {
                    _lstRows.Add(row);
                    count++;
                }
            }
            if (count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar los Recursos seleccionados?",
                            Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    this.pgbProgreso.Visible = true;
                    this.pgbProgreso.Value = 0;
                    this.MdiParent.Enabled = false;
                    _lst = new List<Recurso>();
                    _lstWarning = new List<WarningItem>();
                    workDelete.RunWorkerAsync();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nada seleccionado", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void txtBuscarRecurso_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarRecurso.Text != "")
            {
                string buscar = txtBuscarRecurso.Text;
                List<GrupoRecurso> lstG = new List<GrupoRecurso>();
                dgvGrupos.DataBindings.Clear();
                dgvGrupos.DataSource = lstG;

                List<Recurso> lst = Recurso.read();
                List<Recurso> resultados = new List<Recurso>();
                lst = lst.OrderBy(x => x.nombre).ToList();
                foreach (Recurso mat in lst)
                {
                    if (mat.toNodeText().ToLower().Contains(buscar))
                    {
                        resultados.Add(mat);
                    }
                }
                this.dgvRecursos.DataBindings.Clear();
                this.dgvRecursos.DataSource = resultados;
            }
            else
            {
                regenAll();
            }
        }
        private void dgvRecursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvRecursos.Columns[e.ColumnIndex].Name == "Imagen")
            {
                if (this.dgvRecursos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString() == "Material")
                {
                    e.Value = imageList1.Images[1];
                }
                if (this.dgvRecursos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString() == "Trabajo")
                {
                    e.Value = imageList1.Images[2];
                }
                if (this.dgvRecursos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString() == "Equipo")
                {
                    e.Value = imageList1.Images[3];
                }
            }

        }
        public class DeleteCell : DataGridViewButtonCell
        {
            Image del = Resource1.delete_28;
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
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
        private void dgvRecursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // Editar Recurso
            if (this.dgvRecursos.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditResource();
            }
            // ChekBox
            if (this.dgvRecursos.Columns[e.ColumnIndex].Name == "check")
            {
                if (Convert.ToBoolean(this.dgvRecursos.Rows[e.RowIndex].Cells["check"].Value))
                {
                    this.dgvRecursos.Rows[e.RowIndex].Cells["check"].Value = false;
                }
                else
                {
                    this.dgvRecursos.Rows[e.RowIndex].Cells["check"].Value = true;
                }
            }
            // Eliminar Recurso
            if (this.dgvRecursos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DeleteResource();
            }
        }
        private void dgvRecursos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexUnidad = this.dgvRecursos.Columns["Unidad"].Index;
            int indexNombre = this.dgvRecursos.Columns["ColumnaNombre"].Index;
            int indexActualizado = this.dgvRecursos.Columns["Actualizado"].Index;

            if (e.ColumnIndex == indexUnidad)
            {
                MessageBox.Show("Va a ordenar por Unidad");
            }
            if (e.ColumnIndex == indexNombre)
            {
                MessageBox.Show("Va a ordenar por Nombre");
            }
            if (e.ColumnIndex == indexActualizado)
            {
                MessageBox.Show("Va a ordenar por Fecha");
            }
        }
        private void btnRecursoIsUsed_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            int id = Convert.ToInt32(dgvRecursos.SelectedRows[0].Cells["Id"].Value.ToString());
            Recurso rec = Recurso.getById(id);
            if (rec.isUsed())
            {
                string title = rec.nombre + " USADO EN:";
                string description = "Esta es una lista de Items que utilizan este Recurso:";
                List<Tarea> lst = rec.getTareaUsed();
                List<WarningItem> lstWarnings = new List<WarningItem>();
                foreach (Tarea ta in lst)
                {
                    WarningItem war = new WarningItem("Item", ta.id, ta.nombre, "Usado en el Catálogo de Items");
                    lstWarnings.Add(war);
                }
                List<TareaPres> lst2 = rec.getTareaPresUsed();
                foreach (TareaPres ta in lst2)
                {
                    Presupuesto pres = Presupuesto.getById(ta.getParent().pres_id);
                    WarningItem war = new WarningItem("Item de Presupuesto", ta.id, ta.nombre, "Usado en " + pres.nombre);
                    lstWarnings.Add(war);
                }
                (new frmWarningMessage(title, description, lstWarnings)).ShowDialog();
            }
            else
            {
                MessageBox.Show(rec.nombre + " NO está siendo usado", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
        private void dgvRecursos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Add this
                this.dgvRecursos.CurrentCell = this.dgvRecursos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Can leave these here - doesn't hurt
                this.dgvRecursos.Rows[e.RowIndex].Selected = true;
                this.dgvRecursos.Focus();
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvRecursos.Rows)
            {
                row.Cells["check"].Value = true;
            }
        }
        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvRecursos.Rows)
            {
                row.Cells["check"].Value = false;
            }
        }
        private void dgvRecursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvRecursos.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            Recurso rec = Recurso.getById(id);
            (new frmRecursoNuevo(rec, false)).ShowDialog();
            this.txtBuscarRecurso.Text = "";
            int indexG = 0;
            int indexR = 0;
            foreach (DataGridViewRow row in dgvGrupos.Rows)
            {
                if (row.Cells["_Id"].Value.ToString() == rec.grupo_id.ToString())
                {
                    indexG = row.Index;
                }
            }
            fillDataGridGrupos(this.dgvGrupos, indexG);

            foreach (DataGridViewRow row in dgvRecursos.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == rec.id.ToString())
                {
                    indexR = row.Index;
                }
            }
            fillDataGrid(this.dgvRecursos, this.dgvGrupos);
            this.dgvGrupos.Rows[indexG].Selected = true;
            //this.dgvRecursos.Rows[indexR].Selected = true;
        }
        private void EditResource()
        {
            int id = Convert.ToInt32(this.dgvRecursos.SelectedRows[0].Cells["Id"].Value.ToString());
            Recurso rec = Recurso.getById(id);
            (new frmRecursoNuevo(rec, false)).ShowDialog();
            this.txtBuscarRecurso.Text = "";
            int indexG = 0;
            int indexR = 0;
            foreach (DataGridViewRow row in dgvGrupos.Rows)
            {
                if (row.Cells["_Id"].Value.ToString() == rec.grupo_id.ToString())
                {
                    indexG = row.Index;
                }
            }
            fillDataGridGrupos(this.dgvGrupos, indexG);

            foreach (DataGridViewRow row in dgvRecursos.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == rec.id.ToString())
                {
                    indexR = row.Index;
                }
            }
            fillDataGrid(this.dgvRecursos, this.dgvGrupos);
            this.dgvGrupos.Rows[indexG].Selected = true;
            //this.dgvRecursos.Rows[indexR].Selected = true;
        }
        private void DeleteResource()
        {
            int id = Convert.ToInt32(this.dgvRecursos.SelectedRows[0].Cells["Id"].Value.ToString());
            Recurso rec = Recurso.getById(id);
            if (!rec.isUsed())
            {
                try
                {
                    DialogResult result = MessageBox.Show("¿Desea eliminar el Recurso?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                rec.delete();
                                int indexG = 0;
                                foreach (DataGridViewRow row in this.dgvGrupos.Rows)
                                {
                                    if (row.Cells["_Id"].Value.ToString() == rec.grupo_id.ToString())
                                    {
                                        indexG = row.Index;
                                    }
                                }
                                fillDataGridGrupos(this.dgvGrupos, indexG);
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
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (rec.isUsed())
            {
                MessageBox.Show("Este Recurso está siendo usado por 1 o más Items. " +
                    "No puede ser eliminado", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnResourceEdit_Click(object sender, EventArgs e)
        {
            EditResource();
        }
        private void btnResourceDelete_Click(object sender, EventArgs e)
        {
            DeleteResource();
        }
        #endregion

        private void workDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            _lstWarning.Clear();
            int count = 1;
            int progress = 0;
            int total = _lstRows.Count;

            foreach (DataGridViewRow row in _lstRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                Recurso rec = Recurso.getById(id);
                if (rec.isUsed())
                {
                    string mensaje = "NO borrado. Actualmente en USO";
                    WarningItem war = new WarningItem(rec.categoria, rec.id, rec.nombre, mensaje);
                    _lstWarning.Add(war);
                }
                else
                {
                    rec.delete();
                }
                _status = "Procesando " + count + "/" + total + ": " + rec.nombre;
                progress = 100 * count / total;
                workDelete.ReportProgress(progress);
                count++;
            }
        }

        private void workDelete_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pgbProgreso.Value = e.ProgressPercentage;
            this.lblStatus.Text = _status;
        }

        private void workDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int indexG = this.dgvGrupos.SelectedRows[0].Index;
            fillDataGridGrupos(this.dgvGrupos, indexG);
            this.pgbProgreso.Visible = false;
            this.MdiParent.Enabled = true;
            if (_lstWarning.Count > 0)
            {
                (new frmWarningMessage("Borrar seleccionados", "Lista de Recursos que no pueden eliminarse", 
                    _lstWarning)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Recursos eliminados correctamente", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void workGrupoDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 1;
            int progress = 0;
            int id = Convert.ToInt32(this.dgvGrupos.SelectedRows[0].Cells["_Id"].Value.ToString());
            GrupoRecurso grupo = GrupoRecurso.getById(id);
            int total = 1;
            if (grupo.getChilds().Count > 0)
            {
                total = grupo.getChilds().Count;
                foreach (Recurso rec in grupo.getChilds())
                {
                    if (rec.isUsed())
                    {
                        string mensaje = "NO borrado. Actualmente en USO";
                        WarningItem war = new WarningItem(rec.categoria, rec.id, rec.nombre, mensaje);
                        _lstWarning.Add(war);
                    }
                    else
                    {
                        rec.delete();
                    }
                    _status = "Procesando " + count + "/" + total + ": " + rec.nombre;
                    progress = 100 * count / total;
                    workGrupoDelete.ReportProgress(progress);
                    count++;
                }
                if (_lstWarning.Count == 0)
                {
                    grupo.delete();
                }
            }
            if (grupo.getChilds().Count == 0)
            {
                grupo.delete();
            }
        }

        private void workGrupoDelete_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pgbProgreso.Value = e.ProgressPercentage;
            this.lblStatus.Text = _status;
        }

        private void workGrupoDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fillDataGridGrupos(this.dgvGrupos, 0);
            this.pgbProgreso.Visible = false;
            this.MdiParent.Enabled = true;
            if (_lstWarning.Count > 0)
            {
                (new frmWarningMessage("Eliminar seleccionados", "Lista de Recursos que no pueden ser eliminados",
                    _lstWarning)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Grupo borrado correctamente", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
