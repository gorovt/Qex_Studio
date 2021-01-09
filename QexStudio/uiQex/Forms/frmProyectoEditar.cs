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
    public partial class frmProyectoEditar : Form
    {
        public int _id;
        public Proyecto _proy;

        public frmProyectoEditar(Proyecto proy)
        {
            InitializeComponent();
            _id = proy.id;
            _proy = proy;
            this.txtNombre.Text = proy.nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                string newNombre = this.txtNombre.Text;
                string newUbicacion = "";
                string newPropietario = "";
                if (!Proyecto.read().Exists(x => x.nombre == newNombre))
                {
                    try
                    {
                        Proyecto proy = Proyecto.getById(_id);
                        proy.nombre = newNombre;
                        proy.ubicacion = newUbicacion;
                        proy.propietario = newPropietario;
                        proy.update();
                        //MessageBox.Show("Proyecto guardado con éxito", Tools._title, MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede editar la carpeta. Detalles: \n" + ex.Message,
                            Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ingresado ya existe. Ingrese un nombre único",
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
