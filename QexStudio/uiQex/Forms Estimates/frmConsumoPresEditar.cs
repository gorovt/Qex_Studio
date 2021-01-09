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
    public partial class frmConsumoPresEditar : Form
    {
        public ConsumoPres _cp;

        public frmConsumoPresEditar(ConsumoPres consumoPres)
        {
            InitializeComponent();
            _cp = consumoPres;
            string categoria = consumoPres.getCategoria();
            if (categoria == "Material")
                this.Imagen.Image = imageList1.Images[0];
            if (categoria == "Trabajo")
                this.Imagen.Image = imageList1.Images[1];
            if (categoria == "Equipo")
                this.Imagen.Image = imageList1.Images[2];
            try
            {
                Recurso rec = Recurso.getById(_cp.recurso_id);
                this.txtNombre.Text = rec.nombre;
                this.txtConsumo.Text = _cp.consumo.ToString();
                this.txtUnidad.Text = rec.unidad;
                this.txtPrecio.Text = _cp.costoUnit.ToString();
                this.txtCoeficiente.Text = _cp.coeficiente.ToString();
                double subtotal = _cp.costoTotal; // _cp.consumo * _cp.coeficiente * _cp.costoUnit;
                this.txtSubTotal.Text = String.Format("{0:c}", subtotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tareapres_id = _cp.tareapres_id;
                int recurso_id = _cp.recurso_id;
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                double coeficiente = Convert.ToDouble(this.txtCoeficiente.Text);
                double precioUnit = Convert.ToDouble(this.txtPrecio.Text);
                string categoria = _cp.getCategoria();
                ConsumoPres cp = ConsumoPres.getByCodigos(tareapres_id, recurso_id);
                cp.consumo = consumo;
                cp.coeficiente = coeficiente;
                cp.costoUnit = precioUnit;
                cp.update();
                //MessageBox.Show("Recurso guardado correctamente", Tools._title,
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                double coeficiente = Convert.ToDouble(this.txtCoeficiente.Text);
                double precio = Convert.ToDouble(this.txtPrecio.Text);
                double subtotal = consumo * coeficiente * precio;
                this.txtSubTotal.Text = String.Format("{0:c}", subtotal);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error desconocido. Detalles: " + ex.Message, Tools._title,
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCoeficiente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                double coeficiente = Convert.ToDouble(this.txtCoeficiente.Text);
                double precio = Convert.ToDouble(this.txtPrecio.Text);
                double subtotal = consumo * coeficiente * precio;
                this.txtSubTotal.Text = String.Format("{0:c}", subtotal);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error desconocido. Detalles: " + ex.Message, Tools._title,
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                double coeficiente = Convert.ToDouble(this.txtCoeficiente.Text);
                double precio = Convert.ToDouble(this.txtPrecio.Text);
                double subtotal = consumo * coeficiente * precio;
                this.txtSubTotal.Text = String.Format("{0:c}", subtotal);
            }
            catch (Exception)
            {
                //MessageBox.Show("Error desconocido. Detalles: " + ex.Message, Tools._title,
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtCoeficiente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
