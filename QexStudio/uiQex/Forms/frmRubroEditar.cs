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
    public partial class frmRubroEditar : Form
    {
        public frmRubroEditar(Rubro rubro)
        {
            InitializeComponent();
            this.txtNombre.Text = rubro.nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                string nombre = this.txtNombre.Text;
                try
                {
                    Rubro rubro = (Rubro.read()).Find(x => x.nombre == nombre);
                    rubro.update();
                    MessageBox.Show("Rubro guardado con éxito", Tools._title, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar el Rubro. Detalles: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo nombre", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
