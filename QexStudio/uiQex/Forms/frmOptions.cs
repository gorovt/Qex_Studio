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
    public partial class frmOptions : Form
    {
        public Presupuesto _pres;
        public bool _presOpen = false;

        public frmOptions()
        {
            InitializeComponent();
            this.tabPresupuesto.Enabled = false;
        }

        public frmOptions(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            _presOpen = true;
            // Fill Presupuesto actual
            txtDecimales.Text = _pres.op_decimales.ToString();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_presOpen)
            {
                // Update Presupuesto
                try
                {
                    _pres.op_decimales = Convert.ToInt32(txtDecimales.Text);
                }
                catch (Exception)
                {

                }
                _pres.Update();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
