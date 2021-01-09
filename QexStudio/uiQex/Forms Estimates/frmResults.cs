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
    public partial class frmResults : Form
    {
        public Presupuesto _pres;
        public AnalisisItem _item;
        public int _decimal;
        public string _status;

        public frmResults(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            _decimal = 2;

            backgroundWorker1.RunWorkerAsync();
        }
        private void calcularTodo()
        {
            double costoDirecto = _pres.costoTotal;
            double indirecto = Math.Round(Convert.ToDouble(this.txtIndirecto.Text), _decimal);
            double general = Math.Round(Convert.ToDouble(this.txtGeneral.Text), _decimal);
            double coefRes = Math.Round(Convert.ToDouble(this.txtCoefRes.Text), _decimal);
            double costoIndirecto = Math.Round(_pres.costoTotal * indirecto, _decimal);
            double costoGeneral = Math.Round(_pres.costoTotal * general, _decimal);
            double costoTotal = Math.Round(_pres.costoTotal + costoIndirecto + costoGeneral, _decimal);
            double finalPrice = Math.Round(coefRes * costoDirecto, _decimal);
            double coefSugerido = Math.Round(costoTotal / costoDirecto, _decimal);
            this.txtDirectCost.Text = string.Format("{0:C}", costoDirecto);
            this.txtIndirectCost.Text = string.Format("{0:C}", costoIndirecto);
            this.txtGeneralCost.Text = string.Format("{0:C}", costoGeneral);
            this.txtTotalCost.Text = string.Format("{0:C}", costoTotal);
            this.txtFinalPrice.Text = string.Format("{0:C}", finalPrice);
            this.lblCoefSugerido.Text = coefSugerido.ToString();
            //double costoDirecto = Math.Round(_item.costoTotal, _decimal);
            //double indirecto = Math.Round(Convert.ToDouble(this.txtIndirecto.Text), _decimal);
            //double general = Math.Round(Convert.ToDouble(this.txtGeneral.Text), _decimal);
            //double coefRes = Math.Round(Convert.ToDouble(this.txtCoefRes.Text), _decimal);
            //double costoIndirecto = Math.Round(_item.costoTotal * indirecto, _decimal);
            //double costoGeneral = Math.Round(_item.costoTotal * general, _decimal);
            //double costoTotal = Math.Round(_item.costoTotal + costoIndirecto + costoGeneral, _decimal);
            //double finalPrice = Math.Round(coefRes * costoDirecto, _decimal);
            //double coefSugerido = Math.Round(costoTotal / costoDirecto, _decimal);
            //this.txtDirectCost.Text = string.Format("{0:C}", costoDirecto);
            //this.txtIndirectCost.Text = string.Format("{0:C}", costoIndirecto);
            //this.txtGeneralCost.Text = string.Format("{0:C}", costoGeneral);
            //this.txtTotalCost.Text = string.Format("{0:C}", costoTotal);
            //this.txtFinalPrice.Text = string.Format("{0:C}", finalPrice);
            //this.lblCoefSugerido.Text = coefSugerido.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolRecalculate_Click(object sender, EventArgs e)
        {
            calcularTodo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Presupuesto pres = Presupuesto.getById(_pres.id);
                pres.indirectos = Convert.ToDouble(this.txtIndirecto.Text);
                pres.generales = Convert.ToDouble(this.txtGeneral.Text);
                pres.coef_resumen = Convert.ToDouble(this.txtCoefRes.Text);
                pres.Update();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //this.Enabled = false;
            //_item = Tools.GetItemFromPresupuesto(_pres);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            double costoDirecto = Math.Round(_pres.costoTotal, _decimal);
            double costoIndirecto = Math.Round(_pres.costoTotal * _pres.indirectos, _decimal);
            double costoGeneral = Math.Round(_pres.costoTotal * _pres.generales, _decimal);
            double costoTotal = Math.Round(_pres.costoTotal + costoIndirecto + costoGeneral, _decimal);
            double finalPrice = Math.Round(_pres.coef_resumen * costoDirecto, _decimal);
            double coefSugerido = Math.Round(costoTotal / costoDirecto, _decimal);
            this.txtIndirecto.Text = _pres.indirectos.ToString();
            this.txtGeneral.Text = _pres.generales.ToString();
            this.txtCoefRes.Text = _pres.coef_resumen.ToString();
            this.txtDirectCost.Text = string.Format("{0:C}", costoDirecto);
            this.txtIndirectCost.Text = string.Format("{0:C}", costoIndirecto);
            this.txtGeneralCost.Text = string.Format("{0:C}", costoGeneral);
            this.txtTotalCost.Text = string.Format("{0:C}", costoTotal);
            this.txtFinalPrice.Text = string.Format("{0:C}", finalPrice);
            this.lblCoefSugerido.Text = coefSugerido.ToString();
            //calcularTodo();
            //this.Enabled = true;
        }
    }
}
