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
    public partial class frmRubroPresEditar : Form
    {
        public RubroPres _rubroPres;
        public bool _edit = false;

        public frmRubroPresEditar(RubroPres rubro, bool edit)
        {
            InitializeComponent();
            _rubroPres = rubro;
            _edit = edit;
            this.txtOrden.Text = rubro.orden.ToString();
            this.txtNombre.Text = rubro.nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (this.txtOrden.Text == "")
            {
                MessageBox.Show("Debes completar la información del Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.txtOrden.Focus();
                return;
            }
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Debes completar la información del Grupo", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.txtNombre.Focus();
                return;
            }
            // Todo Ok

            // Nuevo Grupo
            if (!_edit)
            {
                try
                {
                    int orden = Convert.ToInt32(this.txtOrden.Text);
                    string nombre = this.txtNombre.Text;
                    _rubroPres.orden = orden;
                    _rubroPres.nombre = nombre;
                    _rubroPres.insert();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Editar Grupo
            if (_edit)
            {
                try
                {
                    int orden = Convert.ToInt32(this.txtOrden.Text);
                    string nombre = this.txtNombre.Text;
                    _rubroPres.orden = orden;
                    _rubroPres.nombre = nombre;
                    _rubroPres.update();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
