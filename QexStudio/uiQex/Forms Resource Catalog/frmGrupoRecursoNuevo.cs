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
    public partial class frmGrupoRecursoNuevo : Form
    {
        public GrupoRecurso _grupo;

        // New Group
        public frmGrupoRecursoNuevo()
        {
            InitializeComponent();
            _grupo = null;
        }

        // Edit Group
        public frmGrupoRecursoNuevo(GrupoRecurso grupo)
        {
            InitializeComponent();
            _grupo = grupo;
            this.Text = "Editar Grupo";
            this.btnCrear.Text = "Guardar";
            this.txtNombre.Text = grupo.nombre;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar el campo Nombre", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNombre.Focus();
                return;
            }

            string nombre = this.txtNombre.Text;

            // New Group, validate Name already exist
            if (null == _grupo && (GrupoRecurso.read()).Exists(x => x.nombre == nombre))
            {
                MessageBox.Show("El Nombre ingresado ya existe. Debe ingresar un Nombre único", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNombre.Focus();
                return;
            }
            //Validaciones OK
            try
            {
                // New Group
                if (null == _grupo)
                {
                    GrupoRecurso grupo = new GrupoRecurso(nombre);
                    grupo.insert();
                    //MessageBox.Show("Grupo creado correctamente", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                // Edit Group
                if (null != _grupo)
                {
                    _grupo.nombre = nombre;
                    _grupo.update();
                    //MessageBox.Show("Grupo guardado correctamente", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message,
                           Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
