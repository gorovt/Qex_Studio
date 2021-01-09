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
    public partial class frmProyectos3 : Form
    {
        public frmProyectos3()
        {
            InitializeComponent();
            fillDataGridProyectos(this.dgvProyectos, 0);
            fillDataGrid(this.dgvPresupuestos, this.dgvProyectos);
            this.progressBar.Visible = false;
            this.lblAvance.Text = "";
            this.dgvProyectos.Columns["_Editar"].CellTemplate = new EditCell();
            this.dgvProyectos.Columns["_Eliminar"].CellTemplate = new DeleteCell();
            this.dgvPresupuestos.Columns["Editar"].CellTemplate = new OpenCell();
            this.dgvPresupuestos.Columns["Eliminar"].CellTemplate = new DeleteCell();
            
        }
        public void fillDataGridProyectos(DataGridView grid, int selectedIndex)
        {
            List<Proyecto> lst = Proyecto.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            grid.DataBindings.Clear();
            grid.DataSource = lst;
            if (grid.Rows.Count > 0)
            {
                grid.Rows[selectedIndex].Selected = true;
                grid.CurrentCell = grid.Rows[selectedIndex].Cells[0];
            }
        }
        public void fillDataGrid(DataGridView dview, DataGridView dproy)
        {
            if (dproy.SelectedRows.Count == 0)
            {
                List<Presupuesto> lst = new List<Presupuesto>();
                dview.DataBindings.Clear();
                dview.DataSource = lst;
            }
            if (dproy.SelectedRows.Count > 0)
            {
                int proyecto_id = Convert.ToInt32(dproy.SelectedRows[0].Cells["_id"].Value);
                List<Presupuesto> lst = Presupuesto.read();
                lst = lst.FindAll(x => x.proyecto_id == proyecto_id).ToList();
                lst = lst.OrderBy(x => x.nombre).ToList();

                dview.DataBindings.Clear();
                dview.DataSource = lst;

                if (this.dgvPresupuestos.RowCount > 0)
                {
                    dview.Rows[0].Selected = true;
                }
            }
        }
        public void regenAll()
        {
            fillDataGridProyectos(this.dgvProyectos, 0);
            fillDataGrid(this.dgvPresupuestos, this.dgvProyectos);
        }
        private void btnProyectoNuevo_Click(object sender, EventArgs e)
        {
            (new frmProyectoNuevo()).ShowDialog();
            regenAll();
        }
        private void btnPresNuevo_Click(object sender, EventArgs e)
        {
            if (this.dgvProyectos.SelectedRows == null)
            {
                MessageBox.Show("Selecciona una Carpeta", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvProyectos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una Carpeta", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (this.dgvProyectos.SelectedRows.Count > 0)
            {
                int proyecto_id = Convert.ToInt32(this.dgvProyectos.SelectedRows[0].Cells["_id"].Value);
                (new frmPresupuestoNuevo(proyecto_id)).ShowDialog();
                //fillDataGrid(this.dgvPresupuestos, this.dgvProyectos);
                this.Close();
            }
        }
        private void dgvPres_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvPresupuestos.Columns[e.ColumnIndex].Name == "icono")
            {
                e.Value = imageList1.Images[1];
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
                this.Width = 28;
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
                this.Width = 28;
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
                this.Width = 28;
                //set other options here 
            }
        }
        private void dgvPres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            #region Editar Presupuesto
            //Editar Presupuesto
            if (this.dgvPresupuestos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(this.dgvPresupuestos.Rows[e.RowIndex].Cells["id"].Value);
                Presupuesto pres = Presupuesto.getById(id);
                frmMain._pres_id = pres.id;
                this.Close();
            }
            #endregion

            #region Eliminar Presupuesto
            //Eliminar Presupuesto
            if (this.dgvPresupuestos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Tools.MouseWait();
                int id = Convert.ToInt32(this.dgvPresupuestos.Rows[e.RowIndex].Cells["id"].Value);
                Presupuesto pres = Presupuesto.getById(id);
                try
                {

                    DialogResult result = MessageBox.Show("¿Desea eliminar el Presupuesto: " + pres.nombre + "?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                pres.delete();
                                int indexG = 0;
                                foreach (DataGridViewRow row in this.dgvProyectos.Rows)
                                {
                                    if (row.Cells["_id"].Value.ToString() == pres.proyecto_id.ToString())
                                    {
                                        indexG = row.Index;
                                    }
                                }
                                fillDataGridProyectos(this.dgvProyectos, indexG);
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
                Tools.MouseArrow();
            }
            #endregion
        }

        private void dgvProyectos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProyectos.Columns[e.ColumnIndex].Name == "_Imagen")
            {
                e.Value = imageList1.Images[0];
            }
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar Proyecto
            if (this.dgvProyectos.Columns[e.ColumnIndex].Name == "_Editar")
            {
                try
                {
                    int id = Convert.ToInt32(this.dgvProyectos.SelectedRows[0].Cells["_id"].Value);
                    Proyecto proy = Proyecto.getById(id);
                    if (proy.nombre == "Qex Studio")
                    {
                        MessageBox.Show("Esta Carpeta no puede ser editada", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        (new frmProyectoEditar(proy)).ShowDialog();
                        int index = 0;
                        foreach (DataGridViewRow row in this.dgvProyectos.Rows)
                        {
                            if (row.Cells["_id"].Value.ToString() == id.ToString())
                            {
                                index = row.Index;
                            }
                        }
                        fillDataGridProyectos(this.dgvProyectos, index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Eliminar Proyecto
            if (this.dgvProyectos.Columns[e.ColumnIndex].Name == "_Eliminar")
            {
                int id = Convert.ToInt32(this.dgvProyectos.SelectedRows[0].Cells["_id"].Value);
                Proyecto proy = Proyecto.getById(id);
                if (proy.nombre == "Qex Studio")
                {
                    MessageBox.Show("Esta Carpeta no puede ser eliminada", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (proy.getChilds().Count == 0)
                    {
                        try
                        {
                            DialogResult result = MessageBox.Show("¿Desea borrar la Carpeta " + proy.nombre + "?",
                                Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
                            switch (result)
                            {
                                case DialogResult.OK:
                                    {
                                        proy.delete();
                                        regenAll();
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
                    if (proy.getChilds().Count > 0)
                    {
                        MessageBox.Show("Esta carpeta contiene Presupuestos. No puede ser borrada", Tools._title,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvProyectos_SelectionChanged(object sender, EventArgs e)
        {
            fillDataGrid(this.dgvPresupuestos, this.dgvProyectos);
        }

        private void dgvPres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dgvPresupuestos.Rows[e.RowIndex].Cells["id"].Value);
            Presupuesto pres = Presupuesto.getById(id);
            frmMain._pres_id = pres.id;
            this.Close();
        }

        private void mnuImportarQex_Click(object sender, EventArgs e)
        {
            int proyecto_id = Convert.ToInt32(this.dgvProyectos.SelectedRows[0].Cells["_id"].Value);
            Proyecto proy = Proyecto.getById(proyecto_id);
            (new frmImportarQex()).ShowDialog();
            regenAll();
        }
    }
}
