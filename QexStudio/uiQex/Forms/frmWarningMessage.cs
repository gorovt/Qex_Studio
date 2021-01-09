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
    public partial class frmWarningMessage : Form
    {
        public frmWarningMessage(string title, string description, List<WarningItem> lst)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.txtDescription.Text = description;
            this.dgvWarnings.DataSource = lst;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvWarnings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvWarnings.Columns[e.ColumnIndex].Name == "image")
            {
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Item")
                {
                    e.Value = imageList1.Images[3];
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Item de Presupuesto")
                {
                    e.Value = imageList1.Images[1];
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Material")
                {
                    e.Value = imageList1.Images[4];
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Trabajo")
                {
                    e.Value = imageList1.Images[5];
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Equipo")
                {
                    e.Value = imageList1.Images[6];
                }
            }
        }

        private void dgvWarnings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvWarnings.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Item")
                {
                    int id = Convert.ToInt32(this.dgvWarnings.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    (new frmTareaEditar(id)).ShowDialog();
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Item de Presupuesto")
                {
                    int id = Convert.ToInt32(this.dgvWarnings.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    TareaPres tarea = TareaPres.getById(id);
                    (new frmTareaPresEditar(tarea)).ShowDialog();
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Material")
                {
                    int id = Convert.ToInt32(this.dgvWarnings.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    Recurso rec = Recurso.getById(id);
                    (new frmRecursoNuevo(rec, false)).ShowDialog();
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Trabajo")
                {
                    int id = Convert.ToInt32(this.dgvWarnings.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    Recurso rec = Recurso.getById(id);
                    (new frmRecursoNuevo(rec, false)).ShowDialog();
                }
                if (this.dgvWarnings.Rows[e.RowIndex].Cells["Category"].Value.ToString() == "Equipo")
                {
                    int id = Convert.ToInt32(this.dgvWarnings.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    Recurso rec = Recurso.getById(id);
                    (new frmRecursoNuevo(rec, false)).ShowDialog();
                }
            }
        }
    }
}
