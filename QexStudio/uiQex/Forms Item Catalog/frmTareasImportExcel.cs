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
    public partial class frmTareasImportExcel : Form
    {
        public List<TareaImportadaExcel> _lst;
        public string _status = "";

        public frmTareasImportExcel()
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
                cmbUnit.Items.Add(s);
                cmbDetalles.Items.Add(s);
            }
            cmbGroup.SelectedIndex = 0;
            cmbName.SelectedIndex = 1;
            cmbUnit.SelectedIndex = 2;
            cmbDetalles.SelectedIndex = 3;
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
                int unitCol = cmbUnit.SelectedIndex + 1;
                int detalleCol = cmbDetalles.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = cmbTo.SelectedIndex + 1;
                List<TareaImportadaExcel> lst = Tools.ImportItemsFromExcel(this.txtPath.Text, 
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, unitCol, detalleCol, from, to);
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
                Tools.MouseWait();
                int groupCol = cmbGroup.SelectedIndex + 1;
                int nameCol = cmbName.SelectedIndex + 1;
                int unitCol = cmbUnit.SelectedIndex + 1;
                int detalleCol = cmbDetalles.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = cmbTo.SelectedIndex + 1;
                _lst = Tools.ImportItemsFromExcel(this.txtPath.Text,
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, unitCol, detalleCol, from, to);
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

            foreach (TareaImportadaExcel tr in _lst)
            {
                //Grupos
                Rubro rubro0;
                if (!Rubro.read().Exists(xx => xx.nombre == tr.grupo))
                {
                    Rubro rubro = new Rubro(tr.grupo, string.Empty);
                    rubro.insert();
                    rubro0 = Rubro.getLast();
                }
                else
                {
                    rubro0 = Rubro.read().Find(xx => xx.nombre == tr.grupo);
                }
                //Items
                Tarea tr0 = new Tarea();
                tr0.rubro_Id = rubro0.id;
                tr0.nombre = tr.nombre;
                tr0.unidad = tr.unidad;
                tr0.detalles = tr.detalles;
                if (!Tarea.read().Exists(xx => xx.nombre == tr.nombre))
                {
                    tr0.insert();
                }
                else
                {
                    Tarea tr00 = Tarea.getByNombre(tr.nombre);
                    tr0.id = tr00.id;
                    tr0.update();
                }
                progress = 100 * count / total;
                _status = "Procesando " + count + "/" + total + " items";
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
            MessageBox.Show(total.ToString() + " Items importados correctamente", Tools._title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
