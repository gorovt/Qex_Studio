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
    public partial class frmTareas2 : Form
    {
        public frmTareas2()
        {
            InitializeComponent();
            fillDataGridRubros(this.dgvRubros, 0);
            fillDataGrid(this.dgvItems, this.dgvRubros);
            this.dgvRubros.Columns["_Editar"].CellTemplate = new EditCell();
            this.dgvRubros.Columns["_Eliminar"].CellTemplate = new DeleteCell();
            this.dgvItems.Columns["Editar"].CellTemplate = new OpenCell();
            this.dgvItems.Columns["Eliminar"].CellTemplate = new DeleteCell();
        }
        public void fillDataGridRubros(DataGridView grid, int selectedIndex)
        {
            List<Rubro> lst = Rubro.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            grid.DataBindings.Clear();
            grid.DataSource = lst;
            if (grid.Rows.Count > 0)
            {
                grid.Rows[selectedIndex].Selected = true;
                grid.CurrentCell = grid.Rows[selectedIndex].Cells[0];
            }
        }
        public void fillDataGrid(DataGridView dview, DataGridView dgrupos)
        {
            if (dgrupos.SelectedRows.Count == 0)
            {
                List<Tarea> lst = new List<Tarea>();
                dview.DataBindings.Clear();
                dview.DataSource = lst;
            }
            if (dgrupos.SelectedRows.Count > 0)
            {
                int rubroId = Convert.ToInt32(dgrupos.SelectedRows[0].Cells["id"].Value);
                List<Tarea> lst = Tarea.read();
                lst = lst.FindAll(x => x.rubro_Id == rubroId).ToList();
                lst = lst.OrderBy(x => x.nombre).ToList();

                dview.DataBindings.Clear();
                dview.DataSource = lst;

                if (this.dgvItems.RowCount > 0)
                {
                    dview.Rows[0].Selected = true;
                }
            }
        }
        private void regenAll()
        {
            this.txtBuscarItem.Text = "";
            fillDataGridRubros(this.dgvRubros, 0);
            fillDataGrid(this.dgvItems, this.dgvRubros);
        }
        private void btnRubroNuevo_Click(object sender, EventArgs e)
        {
            (new frmRubroNuevo()).ShowDialog();
            regenAll();
        }
        private void btnItemNuevo_Click(object sender, EventArgs e)
        {
            if (this.dgvRubros.SelectedRows == null)
            {
                MessageBox.Show("Debes seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvRubros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar un Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvRubros.SelectedRows.Count > 0)
            {
                int rubro_Id = Convert.ToInt32(this.dgvRubros.SelectedRows[0].Cells["id"].Value);
                (new frmTareaNueva(rubro_Id)).ShowDialog();
                fillDataGrid(this.dgvItems, this.dgvRubros);
            }
        }
        private void txtBuscarItem_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarItem.Text != "")
            {
                string buscar = txtBuscarItem.Text;
                List<Rubro> lstG = new List<Rubro>();
                dgvRubros.DataBindings.Clear();
                dgvRubros.DataSource = lstG;

                List<Tarea> lst = Tarea.read();
                List<Tarea> resultados = new List<Tarea>();
                lst = lst.OrderBy(x => x.nombre).ToList();
                foreach (Tarea  ta in lst)
                {
                    if (ta.toNodeText().ToLower().Contains(buscar))
                    {
                        resultados.Add(ta);
                    }
                }
                this.dgvItems.DataBindings.Clear();
                this.dgvItems.DataSource = resultados;
            }
            else
            {
                regenAll();
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
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
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
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
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
                int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["_id"].Value);
                Tarea ta = Tarea.getById(id);
                (new frmTareaEditar(id)).ShowDialog();
                this.txtBuscarItem.Text = "";
                int indexG = 0;
                int indexR = 0;
                foreach (DataGridViewRow row in dgvRubros.Rows)
                {
                    if (row.Cells["id"].Value.ToString() == ta.rubro_Id.ToString())
                    {
                        indexG = row.Index;
                    }
                }
                fillDataGridRubros(this.dgvRubros, indexG);

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["_id"].Value.ToString() == ta.id.ToString())
                    {
                        indexR = row.Index;
                    }
                }
                fillDataGrid(this.dgvItems, this.dgvRubros);
                this.dgvItems.Rows[indexR].Selected = true;
            }
            #endregion
            #region ChekBox
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "check")
            {
                if (Convert.ToBoolean(this.dgvItems.Rows[e.RowIndex].Cells["check"].Value))
                {
                    this.dgvItems.Rows[e.RowIndex].Cells["check"].Value = false;
                }
                else
                {
                    this.dgvItems.Rows[e.RowIndex].Cells["check"].Value = true;
                }
            }
            #endregion
            #region Eliminar Recurso
            //Eliminar Recurso
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["_id"].Value);
                Tarea ta = Tarea.getById(id);
                try
                {

                    DialogResult result = MessageBox.Show("¿Desea eliminar el Item " +
                        "y todos sus Consumos?", Tools._title, MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                ta.delete();
                                int indexG = 0;
                                foreach (DataGridViewRow row in this.dgvRubros.Rows)
                                {
                                    if (row.Cells["id"].Value.ToString() == ta.rubro_Id.ToString())
                                    {
                                        indexG = row.Index;
                                    }
                                }
                                fillDataGridRubros(this.dgvRubros, indexG);
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
            #endregion
        }
        private void dgvRubros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvRubros.Columns[e.ColumnIndex].Name == "_Imagen")
            {
                e.Value = imageList1.Images[0];
            }
        }
        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvItems.Columns[e.ColumnIndex].Name == "Imagen")
            {
                e.Value = imageList1.Images[1];
            }
        }
        private void dgvRubros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar Grupo
            if (this.dgvRubros.Columns[e.ColumnIndex].Name == "_Editar")
            {
                try
                {
                    int id = Convert.ToInt32(this.dgvRubros.SelectedRows[0].Cells["id"].Value);
                    Rubro rubro = Rubro.getById(id);
                    (new frmRubroEditar(rubro)).ShowDialog();
                    int index = 0;
                    foreach (DataGridViewRow row in this.dgvRubros.Rows)
                    {
                        if (row.Cells["id"].Value.ToString() == id.ToString())
                        {
                            index = row.Index;
                        }
                    }
                    fillDataGridRubros(this.dgvRubros, index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Eliminar Grupo
            if (this.dgvRubros.Columns[e.ColumnIndex].Name == "_Eliminar")
            {
                int id = Convert.ToInt32(this.dgvRubros.SelectedRows[0].Cells["id"].Value);
                Rubro rubro = Rubro.getById(id);
                if (rubro.getChilds().Count == 0)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("¿Desea aliminar el Grupo?",
                            Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
                        switch (result)
                        {
                            case DialogResult.OK:
                                {
                                    if (rubro.getChilds().Count == 0)
                                    {
                                        rubro.delete();
                                        regenAll();
                                    }
                                    if (rubro.getChilds().Count > 0)
                                    {
                                        MessageBox.Show("El Grupo debe estar vacío. Este Grupo no se puede eliminar",
                                            Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
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
                if (rubro.getChilds().Count > 0)
                {
                    MessageBox.Show("El Grupo debe estar vacío. Este Grupo no se puede eliminar", Tools._title,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dgvGrupos_SelectionChanged(object sender, EventArgs e)
        {
            fillDataGrid(this.dgvItems, this.dgvRubros);
        }
        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvItems.Rows[e.RowIndex].Cells["_id"].Value);
            Tarea ta = Tarea.getById(id);
            (new frmTareaEditar(id)).ShowDialog();
            this.txtBuscarItem.Text = "";
            int indexG = 0;
            int indexR = 0;
            foreach (DataGridViewRow row in dgvRubros.Rows)
            {
                if (row.Cells["id"].Value.ToString() == ta.rubro_Id.ToString())
                {
                    indexG = row.Index;
                }
            }
            fillDataGridRubros(this.dgvRubros, indexG);

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["_id"].Value.ToString() == ta.id.ToString())
                {
                    indexR = row.Index;
                }
            }
            fillDataGrid(this.dgvItems, this.dgvRubros);
            this.dgvItems.Rows[indexR].Selected = true;
        }
        private void orbImportGR_Click(object sender, EventArgs e)
        {
            (new frmImportarTareasGR()).ShowDialog();
            regenAll();
        }

        private void mnuImportarGR_Click(object sender, EventArgs e)
        {
            (new frmImportarTareasGR()).ShowDialog();
            regenAll();
        }
        #region Menu Contextual
        private void mnuBtnCopiarConsumos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvItems.SelectedRows[0].Cells["_id"].Value);
            Tarea tarea = Tarea.getById(id);
            List<ConsumoRecurso> lst = new List<ConsumoRecurso>();
            foreach (ConsumoRecurso cr in tarea.getConsumos())
            {
                lst.Add(cr);
            }
            Tools.lstClipboardConsumos = lst;
        }
        private void mnuBtnPegarConsumos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dgvItems.SelectedRows[0].Cells["_id"].Value);
                Tarea tarea = Tarea.getById(id);
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
                            foreach (ConsumoRecurso cr in Tools.lstClipboardConsumos)
                            {
                                cr.tarea_id = tarea.id;
                                cr.insert();
                            }
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
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportGR_Click(object sender, EventArgs e)
        {
            (new frmImportarTareasGR()).ShowDialog();
            regenAll();
        }

        private void btnImportGR_Click_1(object sender, EventArgs e)
        {
            (new frmImportarTareasGR()).ShowDialog();
            regenAll();
        }

        private void btnSeletAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                row.Cells["check"].Value = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                row.Cells["check"].Value = false;
            }
        }

        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            Tools.MouseWait();
            int count = 0;
            foreach (DataGridViewRow row in this.dgvItems.Rows)
            {
                if (Convert.ToBoolean(row.Cells["check"].Value))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar los Items seleccionados?",
                            Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            List<Tarea> lst = new List<Tarea>();
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Detalles:");
                            foreach (DataGridViewRow row in this.dgvItems.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells["check"].Value))
                                {
                                    int id = Convert.ToInt32(row.Cells["_id"].Value.ToString());
                                    Tarea tr = Tarea.getById(id);
                                    lst.Add(tr);
                                }
                            }
                            foreach (Tarea tr in lst)
                            {
                                tr.delete();
                                sb.AppendLine("Borrado: " + tr.nombre);
                            }

                            int indexG = this.dgvRubros.SelectedRows[0].Index;
                            MessageBox.Show(sb.ToString(), Tools._title,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDataGridRubros(this.dgvRubros, indexG);
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
                MessageBox.Show("Nada seleccionado", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Tools.MouseArrow();
        }
    }
}
