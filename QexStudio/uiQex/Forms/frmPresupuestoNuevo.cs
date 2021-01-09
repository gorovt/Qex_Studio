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
    public partial class frmPresupuestoNuevo : Form
    {
        public bool _editar = false;
        public Presupuesto _pres;
        //public ItemPres _item;

        // Nuevo Presupuesto
        public frmPresupuestoNuevo()
        {
            InitializeComponent();
            fillComboFolder();
        }
        // Nuevo Presupuesto
        public frmPresupuestoNuevo(int proy_Id)
        {
            InitializeComponent();
            fillComboFolder();
            Proyecto proy = Proyecto.getById(proy_Id);
            this.cmbFolder.SelectedValue = proy.id;
        }
        // Editar Presupuesto
        public frmPresupuestoNuevo(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            //_item = item;
            _editar = true;
            fillComboFolder();
            this.cmbFolder.SelectedValue = pres.proyecto_id;
            this.txtNombre.Text = pres.nombre;
            this.btnCrear.Text = "Guardar";
            this.Text = "Editar Presupuesto";
            this.pictureBox1.Image = Resource1.edit_26;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain._pres_id = 0;
            this.Close();
        }
        private void fillComboFolder()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            List<Proyecto> lst = Proyecto.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (Proyecto proy in lst)
            {
                comboSource.Add(proy.id, proy.nombre);
            }
            this.cmbFolder.DataSource = new BindingSource(comboSource, null);
            this.cmbFolder.DisplayMember = "Value";
            this.cmbFolder.ValueMember = "Key";
            Proyecto proy0 = Proyecto.getByNombre("Qex Studio");
            this.cmbFolder.SelectedValue = proy0.id;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Nuevo Presupuesto
            if (!_editar)
            {
                if (this.txtNombre.Text != "")
                {
                    string nombre = this.txtNombre.Text;
                    int proy_id = ((KeyValuePair<int, string>)this.cmbFolder.SelectedItem).Key;

                    if ((Presupuesto.read()).Exists(x => x.nombre == nombre && x.proyecto_id == proy_id))
                    {
                        MessageBox.Show("El nombre ingresado ya existe. Ingrese un nombre único", Tools._title,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            Presupuesto pres = new Presupuesto();
                            pres.nombre = nombre;
                            pres.proyecto_id = proy_id;

                            pres.insert();
                            //MessageBox.Show("Presupuesto creado correctamente", Tools._title, MessageBoxButtons.OK,
                            //    MessageBoxIcon.Information);
                            Presupuesto pres0 = Presupuesto.GetLast();
                            frmMain._pres_id = pres0.id;
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
                    MessageBox.Show("Debe completar los campos de información básica", Tools._title, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            // Editar Presupuesto
            else
            {
                // Validaciones
                string name = this.txtNombre.Text;
                if (name == "")
                {
                    MessageBox.Show("Debe ingresar un nombre de Presupuesto", Tools._title, 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtNombre.Focus();
                    return;
                }
                int proyId = Convert.ToInt32(this.cmbFolder.SelectedValue);
                if (Presupuesto.read().Exists(x => x.proyecto_id == proyId && x.nombre == name &&
                x.id != _pres.id))
                {
                    MessageBox.Show("Debe ingresar un nombre único. Este nombre ya existe", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtNombre.Focus();
                    return;
                }
                // Todo Ok. Editar
                _pres.nombre = this.txtNombre.Text;
                _pres.proyecto_id = proyId;
                _pres.Update();
                //_item.update(_pres.toItem());
                this.Close();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.Close();
            (new frmProyectos3()).ShowDialog();
        }
    }
}
