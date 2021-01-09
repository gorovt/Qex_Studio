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
    public partial class frmProcess : Form
    {
        public static string _status = "";
        public static string _title = "";
        public int _opcion = 1;

        /// <summary>
        /// Opciones (1 Procesar Presupuesto)
        /// </summary>
        public frmProcess(int opcion)
        {
            InitializeComponent();
            _opcion = opcion;
            switch (_opcion)
            {
                case 1:
                    this.txtTitle.Text = "Cargando Presupuesto";
                    break;
            }
            this.worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (_opcion)
            {
                case 1:
                    frmEstimate._pres.UpdateAll(this.worker);
                    break;
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pgbProgress.Value = e.ProgressPercentage;
            this.txtStatus.Text = Tools._status;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (_opcion)
            {
                case 1:
                    this.Close();
                    break;
            }
        }
    }
}
