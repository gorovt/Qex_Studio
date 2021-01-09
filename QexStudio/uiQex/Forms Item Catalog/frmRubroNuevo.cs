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
    public partial class frmRubroNuevo : Form
    {
        public frmRubroNuevo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                string nombre = this.txtNombre.Text;
                if ((Rubro.read()).Exists(x=> x.nombre == nombre))
                {
                    MessageBox.Show("El Nombre ingresado ya existe. Ingrese un Nombre único", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Rubro rubro = new Rubro(nombre, string.Empty);
                        rubro.insert();
                        //MessageBox.Show("Rubro creado con éxito", Tools._title, MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information);
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
    }
}
