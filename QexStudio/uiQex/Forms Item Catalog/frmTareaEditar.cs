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
    public partial class frmTareaEditar : Form
    {
        public int _rubro_Id;
        public int _tareaId;

        public frmTareaEditar(int id)
        {
            InitializeComponent();
            Tarea tarea = Tarea.getById(id);
            this.txtNombre.Text = tarea.nombre;
            this.txtUnidad.Text = tarea.unidad;
            this.txtDetalles.Text = tarea.detalles;
            _rubro_Id = tarea.rubro_Id;
            _tareaId = id;
            fillDataGrid(this.dgvConsumos, tarea);
            fillComboGrupo(this.cmbGrupo);
            this.dgvConsumos.Columns["Editar"].CellTemplate = new EditCell();
            this.dgvConsumos.Columns["Eliminar"].CellTemplate = new DeleteCell();
            calcularPrecioTotal(this.dgvConsumos);
        }

        private void fillComboGrupo(ComboBox combo)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            List<Rubro> lst = Rubro.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (Rubro grupo in lst)
            {
                comboSource.Add(grupo.id, grupo.nombre);
            }
            combo.DataSource = new BindingSource(comboSource, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.SelectedValue = _rubro_Id;

            //Retrieve Key and value
            //string key = ((KeyValuePair)comboBox1.SelectedItem).Key;
            //string value = ((KeyValuePair)comboBox1.SelectedItem).Value;
        }

        public void fillDataGrid(DataGridView dview, Tarea tarea)
        {
            List<ConsumoItem> lst = new List<ConsumoItem>();
            foreach (ConsumoItem item in tarea.getConsumoItems())
            {
                lst.Add(item);
            }
            dview.DataBindings.Clear();
            dview.DataSource = lst;
        }
        private void calcularPrecioTotal(DataGridView dview)
        {
            double total = 0;
            foreach (DataGridViewRow row in dview.Rows)
            {
                double subtotal = Convert.ToDouble(row.Cells["_subTotal"].Value);
                total += subtotal;
            }
            this.txtPrecio.Text = String.Format("{0:c}", total);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Inicio._status = "";
            this.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtUnidad.Text != "")
            {
                string nombre = this.txtNombre.Text;
                string unidad = this.txtUnidad.Text;
                string detalles = this.txtDetalles.Text;
                int grupo_id = ((KeyValuePair<int, string>)this.cmbGrupo.SelectedItem).Key;
                //int rubro_id = _rubro_Id;

                try
                {
                    Tarea tarea = Tarea.getById(_tareaId);
                    tarea.nombre = nombre;
                    tarea.unidad = unidad;
                    tarea.detalles = detalles;
                    tarea.rubro_Id = grupo_id;
                    tarea.update();
                    //MessageBox.Show("Item de Presupuesto guardado con éxito", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    //Inicio._status = "Item: " + tarea.nombre + " creado correctamente";
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede guardar el Item de Presupuesto. Detalles: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos de Información básica", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnMaterialAgregar_Click(object sender, EventArgs e)
        {
            (new frmSelectRecursos(_tareaId)).ShowDialog();
            Tarea tarea = Tarea.getById(_tareaId);
            fillDataGrid(this.dgvConsumos, tarea);
            calcularPrecioTotal(this.dgvConsumos);
        }
        private void btnImportExcelMaterial_Click(object sender, EventArgs e)
        {

        }
        private void dgvConsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvConsumos.Columns[e.ColumnIndex].Name == "_imagen")
            {
                if (this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString() == "Material")
                {
                    e.Value = imageList1.Images[0];
                }
                if (this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString() == "Trabajo")
                {
                    e.Value = imageList1.Images[1];
                }
                if (this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString() == "Equipo")
                {
                    e.Value = imageList1.Images[2];
                }
            }
        }
        private void dgvConsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            #region Editar Consumo
            //Editar Consumo
            if (this.dgvConsumos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int tarea_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_tarea_id"].Value);
                int recurso_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_recurso_id"].Value);
                string categoria = this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString();
                ConsumoRecurso cm = ConsumoRecurso.getByCodigos(tarea_id, recurso_id); //, categoria);
                (new frmConsumoEditar(categoria, tarea_id, recurso_id)).ShowDialog();
                Tarea tarea = Tarea.getById(_tareaId);
                fillDataGrid(this.dgvConsumos, tarea);
                calcularPrecioTotal(this.dgvConsumos);
            }
            #endregion

            #region Eliminar Recurso
            //Eliminar Recurso
            if (this.dgvConsumos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int tarea_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_tarea_id"].Value);
                int recurso_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_recurso_id"].Value);
                string categoria = this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString();
                ConsumoRecurso cm = ConsumoRecurso.getByCodigos(tarea_id, recurso_id); //, categoria);
                try
                {

                    DialogResult result = MessageBox.Show("¿Desea eliminar el Consumo?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                        {
                            cm.delete();
                                Tarea tarea = Tarea.getById(_tareaId);
                                fillDataGrid(this.dgvConsumos, tarea);
                                calcularPrecioTotal(this.dgvConsumos);
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

        private void dgvConsumos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
