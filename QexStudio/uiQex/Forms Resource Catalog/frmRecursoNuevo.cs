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
    public partial class frmRecursoNuevo : Form
    {
        public int _grupo_id;
        public Recurso _rec;
        public bool _duplicate;

        // Create New Resource
        public frmRecursoNuevo(int grupo_id)
        {
            InitializeComponent();
            this.Text = "Crear nuevo Recurso";
            this.btnCrear.Text = "Crear";
            _grupo_id = grupo_id;
            fillComboGrupo(this.cmbGrupo);
            fillComboCategoria(this.cmbCategoria);
        }

        // Edit Resource
        public frmRecursoNuevo(Recurso rec, bool duplicate)
        {
            InitializeComponent();
            this.Text = "Editar Recurso";
            this.btnCrear.Text = "Guardar";
            _rec = rec;
            _grupo_id = 0;
            _duplicate = duplicate;
            fillComboGrupo(this.cmbGrupo);
            fillComboCategoria(this.cmbCategoria);
            this.cmbCategoria.SelectedItem = rec.categoria;
            this.cmbGrupo.SelectedValue = rec.grupo_id;
            this.txtNombre.Text = rec.nombre;
            this.txtPrecio.Text = rec.precio.ToString();
            this.txtPrecioVenta.Text = rec.precio_venta.ToString();
            this.txtUnidad.Text = rec.unidad;
            this.txtVentaCantidad.Text = rec.venta_cantidad.ToString();
            this.txtVentaUnidad.Text = rec.venta_unidad;
            fillImage(rec.categoria);
        }

        #region General
        private void fillImage(string categoria)
        {
            if (this.cmbCategoria.SelectedItem.ToString() == "Material")
            {
                this.Imagen.BackgroundImage = this.imageList1.Images[3];
            }
            if (this.cmbCategoria.SelectedItem.ToString() == "Trabajo")
            {
                this.Imagen.BackgroundImage = this.imageList1.Images[4];
            }
            if (this.cmbCategoria.SelectedItem.ToString() == "Equipo")
            {
                this.Imagen.BackgroundImage = this.imageList1.Images[5];
            }
        }
        #endregion
        #region Buttons
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
            if (this.txtUnidad.Text == "")
            {
                MessageBox.Show("Debe completar el campo Unidad", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUnidad.Focus();
                return;
            }
            if (this.txtPrecio.Text == "")
            {
                MessageBox.Show("Debe completar el campo Costo", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPrecio.Focus();
                return;
            }
            if (this.txtPrecioVenta.Text == "")
            {
                MessageBox.Show("Debe completar el campo Costo comercial", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPrecioVenta.Focus();
                return;
            }
            //Validaciones OK
            try
            {
                string nombre = this.txtNombre.Text;
                string categoria = this.cmbCategoria.SelectedItem.ToString();
                double precio = Convert.ToDouble(this.txtPrecio.Text);
                string unidad = this.txtUnidad.Text;
                DateTime ultima_actualizacion = DateTime.Now;
                int proveedor_id = 0;
                double venta_cantidad = Convert.ToDouble(this.txtVentaCantidad.Text);
                string venta_unidad = this.txtVentaUnidad.Text;
                double precio_venta = Convert.ToDouble(this.txtPrecioVenta.Text);
                int grupo_id = ((KeyValuePair<int, string>)this.cmbGrupo.SelectedItem).Key;
                string codigo_comercial = string.Empty;
                string nombre_comercial = string.Empty;

                Recurso mat = new Recurso();
                mat.nombre = nombre;
                mat.categoria = categoria;
                mat.precio = precio;
                mat.unidad = unidad;
                mat.ultima_actualizacion = ultima_actualizacion;
                mat.proveedor_id = proveedor_id;
                mat.venta_cantidad = venta_cantidad;
                mat.venta_unidad = venta_unidad;
                mat.precio_venta = precio_venta;
                mat.grupo_id = grupo_id;
                mat.codigo_comercial = codigo_comercial;
                mat.nombre_comercial = nombre_comercial;

                // New Resource
                if (_grupo_id != 0)
                {
                    if ((Recurso.read()).Exists(x => x.nombre == this.txtNombre.Text))
                    {
                        MessageBox.Show("El Nombre ingresado ya existe. Debe ingresar un Nombre único", Tools._title,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtNombre.Focus();
                        return;
                    }
                    mat.insert();
                    //MessageBox.Show("Recurso creado correctamente", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    this.Close();
                }

                // Edit Resource
                if (_rec != null && _duplicate == false)
                {
                    mat.id = _rec.id;
                    mat.update();
                    //MessageBox.Show("Recurso guardado correctamente", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    this.Close();
                }

                // Duplicate Resource
                if (_rec != null && _duplicate == true)
                {
                    if ((Recurso.read()).Exists(x => x.nombre == this.txtNombre.Text))
                    {
                        MessageBox.Show("El Nombre ingresado ya existe. Debe ingresar un Nombre único", Tools._title,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtNombre.Focus();
                        return;
                    }
                    mat.insert();
                    //MessageBox.Show("Recurso creado correctamente", Tools._title, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message,
                           Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region TextBox change
        private void txtUnidad_TextChanged(object sender, EventArgs e)
        {
            this.lblUnidad.Text = this.txtUnidad.Text;
        }
        private void txtVentaCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double ventaCantidad = Convert.ToDouble(this.txtVentaCantidad.Text);
                double precioVenta = Convert.ToDouble(this.txtPrecioVenta.Text);
                double precioTotal = Math.Round(precioVenta / ventaCantidad, 2);
                this.lblPrecio.Text = precioTotal.ToString();
            }
            catch (Exception)
            {
                this.lblPrecio.Text = "0";
            }
        }
        private void lblPrecio_TextChanged(object sender, EventArgs e)
        {
            //this.txtPrecio.Text = this.lblPrecio.Text.ToString();
        }
        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double ventaCantidad = Convert.ToDouble(this.txtVentaCantidad.Text);
                double precioVenta = Convert.ToDouble(this.txtPrecioVenta.Text);
                double precioTotal = Math.Round(precioVenta / ventaCantidad, 2);
                this.lblPrecio.Text = precioTotal.ToString();
            }
            catch (Exception)
            {
                this.lblPrecio.Text = "0";
            }
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtVentaCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
        #region ComboBoxes
        private void fillComboGrupo(ComboBox combo)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            List<GrupoRecurso> lst = GrupoRecurso.read();
            lst = lst.OrderBy(x => x.nombre).ToList();
            foreach (GrupoRecurso grupo in lst)
            {
                comboSource.Add(grupo.id, grupo.nombre);
            }
            combo.DataSource = new BindingSource(comboSource, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            if (_grupo_id != 0) //Nuevo Recurso
            {
                //string grupoNombre = GrupoRecurso.getById(_grupo_id).nombre;
                combo.SelectedValue = _grupo_id;
            }
            if (_rec != null) //Editar Recurso
            {
                combo.SelectedValue = _rec.grupo_id;
            }

            //Retrieve Key and value
            //string key = ((KeyValuePair)comboBox1.SelectedItem).Key;
            //string value = ((KeyValuePair)comboBox1.SelectedItem).Value;
        }
        private void fillComboCategoria(ComboBox combo)
        {
            combo.DataSource = new BindingSource(Tools.ListaCategorias(), null);
            if (_grupo_id != 0) //Nuevo Recurso
            {
                combo.SelectedItem = "Material";
            }
            if (_rec != null) //Editar Recurso
            {
                combo.SelectedItem = _rec.categoria;
            }
        }
        private void cmbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (_grupo_id != 0) //Nuevo Recurso
            {
                if (this.cmbCategoria.SelectedItem.ToString() == "Material")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[0];
                }
                if (this.cmbCategoria.SelectedItem.ToString() == "Trabajo")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[1];
                }
                if (this.cmbCategoria.SelectedItem.ToString() == "Equipo")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[2];
                }
            }
            if (_rec != null) //Editar Recurso
            {
                if (this.cmbCategoria.SelectedItem.ToString() == "Material")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[3];
                }
                if (this.cmbCategoria.SelectedItem.ToString() == "Trabajo")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[4];
                }
                if (this.cmbCategoria.SelectedItem.ToString() == "Equipo")
                {
                    this.Imagen.BackgroundImage = this.imageList1.Images[5];
                }
            }
            
        }
        #endregion
    }
}
