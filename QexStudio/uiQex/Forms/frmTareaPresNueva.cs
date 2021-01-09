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
    public partial class frmTareaPresNueva : Form
    {
        public RubroPres _rubroPres;

        public frmTareaPresNueva(RubroPres rubro)
        {
            InitializeComponent();
            _rubroPres = rubro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Inicio._status = "";
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.txtOrden.Text != "" && this.txtNombre.Text != "" && this.txtConsumo.Text != "" &&
                this.txtUnidad.Text != "")
            {
                int orden = Convert.ToInt32(this.txtOrden.Text);
                string nombre = this.txtNombre.Text;
                double consumo = Convert.ToDouble(this.txtConsumo.Text);
                string unidad = this.txtUnidad.Text;
                List<TareaPres> lst = _rubroPres.getTareas();
                if (lst.Exists(x => x.nombre == nombre))
                {
                    MessageBox.Show("El Nombre ingresado ya existe. Ingrese un Nombre único", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        TareaPres tarea = new TareaPres();
                        tarea.orden = orden;
                        tarea.nombre = nombre;
                        tarea.consumo = consumo;
                        tarea.unidad = unidad;
                        tarea.rubropres_id = _rubroPres.id;
                        tarea.pres_id = _rubroPres.pres_id;

                        tarea.insert();
                        //MessageBox.Show("Item de Presupuesto creado con éxito", Tools._title, 
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Inicio._status = "Item: " + tarea.nombre + " creado correctamente";
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede crear el Item de Presupuesto. Detalles: \n" + ex.Message,
                            Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos de Información básica", Tools._title, 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
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
    }
}
