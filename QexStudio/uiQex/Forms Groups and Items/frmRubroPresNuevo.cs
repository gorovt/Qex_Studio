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
    public partial class frmRubroPresNuevo : Form
    {
        public Presupuesto _pres;

        public frmRubroPresNuevo(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.txtOrden.Text != "" && this.txtNombre.Text != "")
            {
                int orden = Convert.ToInt32(this.txtOrden.Text);
                string nombre = this.txtNombre.Text;
                List<RubroPres> lst = RubroPres.getRubrosByPresId(_pres.id);
                if (lst.Exists(x=> x.nombre == nombre))
                {
                    MessageBox.Show("El nombre ingresado ya existe. Ingrese un nombre único", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        RubroPres rubro = new RubroPres("", nombre, 0, "", 0, 0, 1, 0, orden, 0, _pres.id);
                        rubro.insert();
                        MessageBox.Show("Rubro creado con éxito", Tools._title, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede crear el Rubro. Detalles: \n" + ex.Message,
                            Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
    }
}
