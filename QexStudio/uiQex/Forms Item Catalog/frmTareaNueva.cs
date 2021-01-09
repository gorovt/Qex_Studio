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
    public partial class frmTareaNueva : Form
    {
        public int _rubro_Id;

        public frmTareaNueva(int rubro_Id)
        {
            InitializeComponent();
            _rubro_Id = rubro_Id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Inicio._status = "";
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtUnidad.Text != "")
            {
                string nombre = this.txtNombre.Text;
                string unidad = this.txtUnidad.Text;
                string detalles = this.txtDetalles.Text;

                if ((Tarea.read()).Exists(x => x.nombre == nombre))
                {
                    MessageBox.Show("El Nombre ingresado ya existe. Ingrese un Nombre único", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Tarea tarea = new Tarea();
                        tarea.nombre = nombre;
                        tarea.unidad = unidad;
                        tarea.detalles = detalles;
                        tarea.rubro_Id = _rubro_Id;

                        tarea.insert();
                        //MessageBox.Show("Item creado con éxito", Tools._title, MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information);
                        //Inicio._status = "Item: " + tarea.nombre + " creado correctamente";
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: \n" + ex.Message,
                            Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos de Información básica", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
