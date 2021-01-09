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
    public partial class frmImportarQexSplash : Form
    {
        public string _status = "";
        public string _path = "";
        public Presupuesto _pres;

        public frmImportarQexSplash(string path, Presupuesto pres)
        {
            InitializeComponent();
            _path = path;
            _pres = pres;
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int actual = 0;
                int progreso = 0;

                _status = "Iniciando...";

                List<Quantity> lstQuantities = Tools.qexReadFileGetQuantities(_path);
                int total = lstQuantities.Count;

                foreach (Quantity q in lstQuantities)
                {
                    Tools.qexAppendQuantity2(_pres, q);
                    progreso = 100 * actual / total;
                    this.backgroundWorker1.ReportProgress(progreso);
                    _status = "Procesando Quantificación (" + actual.ToString() + "/" +
                        total.ToString() + "): " + q.name;
                    actual++;
                }
                MessageBox.Show("Archivo Qex importado correctamente", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.lblStatus.Text = _status;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
