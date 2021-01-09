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
    public partial class frmConsumoItemsExcel : Form
    {
        public List<ConsumoItemExcel> _lst;
        public string _status = "";

        public frmConsumoItemsExcel()
        {
            InitializeComponent();
            fillComboColumns();
            fillComboRanges();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Archivo Excel (*.xlsx)|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = sfd.FileName;
                    this.txtPath.Text = path;
                    fillComboSheets();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void fillComboSheets()
        {
            foreach (string s in Tools.GetSheetsFromExcel(this.txtPath.Text))
            {
                cmbSheets.Items.Add(s);
            }
            cmbSheets.SelectedIndex = 0;
        }
        private void fillComboColumns()
        {
            List<string> aToZ = Enumerable.Range('A', 26)
                              .Select(x => ((char)x).ToString())
                              .ToList();
            foreach (string s in aToZ)
            {
                cmbGroup.Items.Add(s);
                cmbName.Items.Add(s);
                cmbQuantity.Items.Add(s);
                cmbUnit.Items.Add(s);
            }
            cmbGroup.SelectedIndex = 0;
            cmbName.SelectedIndex = 1;
            cmbQuantity.SelectedIndex = 2;
            cmbUnit.SelectedIndex = 3;
        }
        private void fillComboRanges()
        {
            List<string> numbers = Enumerable.Range(1, 10000)
                                    .Select(x => x.ToString())
                                    .ToList();
            foreach (string s in numbers)
            {
                cmbFrom.Items.Add(s);
                cmbTo.Items.Add(s);
            }
            cmbFrom.SelectedIndex = 1;
            cmbTo.SelectedIndex = 9999;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text == "")
            {
                MessageBox.Show("Selecciona un archivo de Excel", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnOpen.Focus();
                return;
            }
            if (this.cmbSheets.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una Hoja de cálculo", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbSheets.Focus();
                return;
            }
            try
            {
                int groupCol = cmbGroup.SelectedIndex + 1;
                int nameCol = cmbName.SelectedIndex + 1;
                int quantityCol = cmbQuantity.SelectedIndex + 1;
                int unitCol = cmbUnit.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = cmbTo.SelectedIndex + 1;
                List<ConsumoItemExcel> lst = Tools.ImportConsumoItemsFromExcel(this.txtPath.Text, 
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, quantityCol, unitCol, from, to);
                this.dgvPreview.DataBindings.Clear();
                this.dgvPreview.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text == "")
            {
                MessageBox.Show("Selecciona un archivo de Excel", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnOpen.Focus();
                return;
            }
            if (this.cmbSheets.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una Hoja de cálculo", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbSheets.Focus();
                return;
            }
            try
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                int groupCol = cmbGroup.SelectedIndex + 1;
                int nameCol = cmbName.SelectedIndex + 1;
                int quantityCol = cmbQuantity.SelectedIndex + 1;
                int unitCol = cmbUnit.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = cmbTo.SelectedIndex + 1;
                _lst = Tools.ImportConsumoItemsFromExcel(this.txtPath.Text,
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, quantityCol, unitCol, from, to);
                this.pgbProgress.Visible = true;
                this.groupBox1.Enabled = false;
                this.groupBox2.Enabled = false;
                this.btnImport.Enabled = false;
                worker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 1;
            int count = 1;
            int total = _lst.Count;

            foreach (ConsumoItemExcel ci in _lst)
            {
                //Items
                Tarea tarea0 = Tarea.read().Find(xx => xx.nombre == ci.tarea);
                Recurso rec0;
                if (!Recurso.read().Exists(xx => xx.nombre == ci.recurso))
                {
                    GrupoRecurso grupo0;
                    if (!GrupoRecurso.read().Exists(xx => xx.nombre == "Importado"))
                    {
                        GrupoRecurso grupo = new GrupoRecurso("Importado");
                        grupo.insert();
                        grupo0 = GrupoRecurso.getLast();
                    }
                    else
                    {
                        grupo0 = GrupoRecurso.getByNombre("Importado");
                    }
                    Recurso rec = new Recurso();
                    rec.grupo_id = grupo0.id;
                    rec.nombre = ci.recurso;
                    rec.unidad = ci.consumo_unidad;
                    rec.categoria = "Material";
                    rec.insert();
                    rec0 = Recurso.getLast();
                }
                else
                {
                    rec0 = Recurso.read().Find(xx => xx.nombre == ci.recurso);
                }
                //Consumo Recursos
                ConsumoRecurso cr0 = new ConsumoRecurso();
                cr0.tarea_id = tarea0.id;
                cr0.recurso_id = rec0.id;
                cr0.consumo = ci.consumo;
                //cr0.categoria = rec0.categoria;
                if (!ConsumoRecurso.read().Exists(xx => xx.tarea_id == cr0.tarea_id &&
                xx.recurso_id == cr0.recurso_id))
                {
                    cr0.insert();
                }
                else
                {
                    ConsumoRecurso cr00 = ConsumoRecurso.getByCodigos(cr0.tarea_id, cr0.recurso_id); //, cr0.categoria);
                    cr0.id = cr00.id;
                    cr0.update();
                }
                progress = 100 * count / total;
                _status = "Procesando " + count + "/" + total + " Recursos";
                worker.ReportProgress(progress);
                count++;
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.txtStatus.Text = _status;
            this.pgbProgress.Value = e.ProgressPercentage;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tools.MouseArrow();
            int total = _lst.Count;
            MessageBox.Show(total.ToString() + " Recursos de Items importados correctamente", Tools._title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
