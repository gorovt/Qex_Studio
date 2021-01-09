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
    public partial class frmProyectoNuevo : Form
    {
        public frmProyectoNuevo()
        {
            InitializeComponent();
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            createFolder();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                createFolder();
            }
        }

        private void createFolder()
        {
            if (this.txtNombre.Text != "")
            {
                string nombre = this.txtNombre.Text;
                try
                {
                    Proyecto proy = new Proyecto();
                    proy.nombre = nombre;
                    proy.insert();
                    MessageBox.Show("Carpeta creada correctamente", Tools._title, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo Nombre", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
