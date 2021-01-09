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
using System.Globalization;

namespace uiGR2020
{
    public partial class frmTareaPresEditar : Form
    {
        public TareaPres _tareaPres;

        public frmTareaPresEditar(TareaPres tareaPres)
        {
            InitializeComponent();
            _tareaPres = tareaPres;
            this.txtOrden.Text = tareaPres.orden.ToString();
            this.txtNombre.Text = tareaPres.nombre;
            this.txtConsumo.Text = tareaPres.consumo.ToString();
            this.txtUnidad.Text = tareaPres.unidad;
            fillDataGrid(this.dgvConsumos, tareaPres);
            this.dgvConsumos.Columns["Editar"].CellTemplate = new EditCell();
            this.dgvConsumos.Columns["Eliminar"].CellTemplate = new DeleteCell();
            calcularPrecioTotal(this.dgvConsumos);
        }

        public void fillDataGrid(DataGridView dview, TareaPres tarea)
        {
            List<ConsumoPresItem> lst = new List<ConsumoPresItem>();
            foreach (ConsumoPresItem item in tarea.getConsumoItems())
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
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtOrden.Text != "" && this.txtNombre.Text != "" && this.txtUnidad.Text != "" &&
                this.txtConsumo.Text != "")
            {
                try
                {
                    int orden = Convert.ToInt32(this.txtOrden.Text);
                    string nombre = this.txtNombre.Text;
                    double consumo = Convert.ToDouble(this.txtConsumo.Text);
                    string unidad = this.txtUnidad.Text;
                    int rubropres_id = _tareaPres.rubropres_id;

                    _tareaPres.orden = orden;
                    _tareaPres.nombre = nombre;
                    _tareaPres.consumo = consumo;
                    _tareaPres.unidad = unidad;
                    _tareaPres.rubropres_id = rubropres_id;
                    _tareaPres.update();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos de Información Básica", Tools._title, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaterialAgregar_Click(object sender, EventArgs e)
        {
            (new frmSelectRecursosPres(_tareaPres)).ShowDialog();
            fillDataGrid(this.dgvConsumos, _tareaPres);
            calcularPrecioTotal(this.dgvConsumos);
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
                int tareapres_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_tareapres_id"].Value);
                int recurso_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_recurso_id"].Value);
                string categoria = this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString();
                ConsumoPres cp = ConsumoPres.getByCodigos(tareapres_id, recurso_id);
                (new frmConsumoPresEditar(cp)).ShowDialog();
                fillDataGrid(this.dgvConsumos, _tareaPres);
                calcularPrecioTotal(this.dgvConsumos);
            }
            #endregion

            #region Eliminar Recurso
            //Eliminar Recurso
            if (this.dgvConsumos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int tareapres_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_tareapres_id"].Value);
                int recurso_id = Convert.ToInt32(this.dgvConsumos.Rows[e.RowIndex].Cells["_recurso_id"].Value);
                string categoria = this.dgvConsumos.Rows[e.RowIndex].Cells["_categoria"].Value.ToString();
                ConsumoPres cp = ConsumoPres.getByCodigos(tareapres_id, recurso_id);
                try
                {

                    DialogResult result = MessageBox.Show("Desea borrar el Recurso?",
                        Tools._title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.OK:
                        {
                            cp.delete();
                                fillDataGrid(this.dgvConsumos, _tareaPres);
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

        private void txtConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||
                e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator ||
                e.KeyChar == (char)Keys.Back
                )
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
