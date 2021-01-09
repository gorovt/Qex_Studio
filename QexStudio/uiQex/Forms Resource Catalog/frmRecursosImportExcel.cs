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
    public partial class frmRecursosImportExcel : Form
    {
        public static List<RecursoImportadoExcel> _lst;
        public static string _status = "";
        public static string _category = "";

        public frmRecursosImportExcel()
        {
            InitializeComponent();
            fillComboColumns();
            fillComboRanges();
            fillComboCategory();
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
            cmbSheets.Items.Clear();
            foreach (string s in Tools.GetSheetsFromExcel(this.txtPath.Text))
            {
                cmbSheets.Items.Add(s);
            }
            cmbSheets.SelectedIndex = 0;
        }
        private void fillComboCategory()
        {
            cmbCategory.Items.Add("Material");
            cmbCategory.Items.Add("Trabajo");
            cmbCategory.Items.Add("Equipo");
            cmbCategory.SelectedIndex = 0;
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
                cmbCost.Items.Add(s);
                cmbComUnit.Items.Add(s);
                cmbComCost.Items.Add(s);
                cmbEquv.Items.Add(s);
                cmbTipoRecurso.Items.Add(s);
            }
            cmbGroup.SelectedIndex = 0;
            cmbName.SelectedIndex = 1;
            cmbCost.SelectedIndex = 2;
            cmbUnit.SelectedIndex = 3;
            cmbComUnit.SelectedIndex = 4;
            cmbComCost.SelectedIndex = 5;
            cmbEquv.SelectedIndex = 6;
            cmbTipoRecurso.SelectedIndex = 7;
        }
        private void fillComboRanges()
        {
            List<string> numbers = Enumerable.Range(1, 10000)
                                    .Select(x => x.ToString())
                                    .ToList();
            foreach (string s in numbers)
            {
                cmbFrom.Items.Add(s);
                //cmbTo.Items.Add(s);
            }
            cmbFrom.SelectedIndex = 1;
            //cmbTo.SelectedIndex = 9999;
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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                int groupCol = cmbGroup.SelectedIndex + 1;
                int nameCol = cmbName.SelectedIndex + 1;
                int costCol = cmbCost.SelectedIndex + 1;
                int unitCol = cmbUnit.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = 19999 + 1;
                int comUnitCol = cmbComUnit.SelectedIndex + 1;
                int comCostCol = cmbComCost.SelectedIndex + 1;
                int equivCol = cmbEquv.SelectedIndex + 1;
                int tipoCol = cmbTipoRecurso.SelectedIndex + 1;
                bool addInfo = this.chkAddInfo.Checked;
                
                List<RecursoImportadoExcel> lst = Tools.ImportRecursosFromExcel(this.txtPath.Text, 
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, unitCol, costCol, from, to,
                    addInfo, comUnitCol, comCostCol, equivCol, tipoCol);
                this.dgvPreview.DataBindings.Clear();
                this.dgvPreview.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
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
                int unitCol = cmbUnit.SelectedIndex + 1;
                int costCol = cmbCost.SelectedIndex + 1;
                int from = cmbFrom.SelectedIndex + 1;
                int to = 19999 + 1;
                int comUnitCol = cmbComUnit.SelectedIndex + 1;
                int comCostCol = cmbComCost.SelectedIndex + 1;
                int equivCol = cmbEquv.SelectedIndex + 1;
                int tipoRec = cmbTipoRecurso.SelectedIndex + 1;
                bool addInfo = this.chkAddInfo.Checked;
                _category = this.cmbCategory.SelectedItem.ToString();

                _lst = Tools.ImportRecursosFromExcel(this.txtPath.Text,
                    this.cmbSheets.SelectedItem.ToString(), groupCol, nameCol, unitCol, costCol, from, to,
                    addInfo, comUnitCol, comCostCol, equivCol, tipoRec);

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

        private void chkAddInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAddInfo.Checked)
            {
                this.tableLayoutPanel2.Enabled = true;
                this.cmbCategory.Enabled = false;
            }
            else
            {
                this.tableLayoutPanel2.Enabled = false;
                this.cmbCategory.Enabled = true;
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 1;
            int count = 1;

            foreach (RecursoImportadoExcel rec in _lst)
            {
                //Grupos
                GrupoRecurso grupo0;
                if (!GrupoRecurso.read().Exists(xx => xx.nombre == rec.Group))
                {
                    GrupoRecurso grupo = new GrupoRecurso(rec.Group);
                    grupo.insert();
                    grupo0 = GrupoRecurso.getLast();
                }
                else
                {
                    grupo0 = GrupoRecurso.read().Find(xx => xx.nombre == rec.Group);
                }
                //Recursos
                Recurso rec0 = new Recurso();
                rec0.grupo_id = grupo0.id;
                rec0.categoria = _category;
                rec0.nombre = rec.Name;
                rec0.unidad = rec.Unit;
                rec0.precio = rec.Cost;
                rec0.venta_unidad = rec.CommercialUnit;
                rec0.precio_venta = rec.CommercialCost;
                rec0.venta_cantidad = rec.Equivalence;
                rec0.categoria = rec.Categoria;

                if (!Recurso.read().Exists(xx => xx.nombre == rec.Name))
                {
                    rec0.insert();
                }
                else
                {
                    Recurso rec00 = Recurso.getByNombre(rec.Name);
                    rec0.id = rec00.id;
                    rec0.update();
                }
                progress = 100 * count / _lst.Count;
                _status = "Procesando " + count + "/" + _lst.Count + " elementos";
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
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            int total = _lst.Count;
            MessageBox.Show(total.ToString() + " Recursos importados correctamente", Tools._title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
