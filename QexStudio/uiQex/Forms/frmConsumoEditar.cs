/*   Qex Studio License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2017-2021 Luciano Gorosito <lucianogorosito@hotmail.com>   *
*                                                                             *
*    This file is part of Qex Studio                                          *
*                                                                             *
*    Qex Studio is free software: you can redistribute it and/or modify       *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    Qex Studio is distributed in the hope that it will be useful,            *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/

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
    public partial class frmConsumoEditar : Form
    {
        public string _categoria;
        public int _tarea_id;
        public int _recurso_id;

        public frmConsumoEditar(string categoria, int tarea_id, int recurso_id)
        {
            InitializeComponent();
            _categoria = categoria;
            _tarea_id = tarea_id;
            _recurso_id = recurso_id;

            if (categoria == "Material")
                this.Imagen.Image = imageList1.Images[0];
            if (categoria == "Trabajo")
                this.Imagen.Image = imageList1.Images[1];
            if (categoria == "Equipo")
                this.Imagen.Image = imageList1.Images[2];
            try
            {
                ConsumoRecurso cm = ConsumoRecurso.getByCodigos(tarea_id, recurso_id); //, categoria);
                Recurso rec = Recurso.getById(_recurso_id);
                this.txtNombre.Text = rec.nombre;
                this.txtConsumo.Text = cm.consumo.ToString();
                this.txtUnidad.Text = rec.unidad;
                this.txtPrecio.Text = string.Format("{0:c}", rec.precio.ToString());
                this.txtCoeficiente.Text = cm.coeficiente.ToString();
                double subtotal = cm.consumo * cm.coeficiente * rec.precio;
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
                int tarea_id = _tarea_id;
                int recurso_id = _recurso_id;
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                double coeficiente = Convert.ToDouble(this.txtCoeficiente.Text);
                string categoria = _categoria;
                ConsumoRecurso cm = ConsumoRecurso.getByCodigos(tarea_id, recurso_id); //, categoria);
                cm.consumo = consumo;
                cm.coeficiente = coeficiente;
                cm.update();
                MessageBox.Show("El consumo se guardó correctamente", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
