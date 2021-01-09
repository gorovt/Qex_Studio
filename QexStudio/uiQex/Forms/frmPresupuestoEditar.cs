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
    public partial class frmPresupuestoEditar : Form
    {
        public Presupuesto _pres;

        public frmPresupuestoEditar(Presupuesto pres)
        {
            InitializeComponent();
            _pres = pres;
            this.txtNombre.Text = pres.nombre;
            //if (pres.imagen != "")
            //{
            //    this.picImagen.BackgroundImage = Tools.Base64toImage(pres.imagen);
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Inicio._status = "";
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                string nombre = this.txtNombre.Text;
                string imagen = string.Empty;
                //if (this.picImagen.BackgroundImage != null)
                //{
                //    imagen = Tools.ImageToBase64(this.picImagen.BackgroundImage, 
                //        System.Drawing.Imaging.ImageFormat.Jpeg);
                //}
                try
                {
                    Presupuesto pres = Presupuesto.getByNombre(nombre);
                    pres.nombre = nombre;
                    pres.imagen = imagen;
                    pres.Update();
                    MessageBox.Show("Presupuesto guardado con éxito", Tools._title, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede guardar el Presupuesto. Detalles: \n" + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos de Datos del Presupuesto", Tools._title, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Open the file
            string folderPath = string.Empty;
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Imagen|*.jpg";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = sfd.FileName;
                try
                {
                    Image foto = new Bitmap(folderPath);
                    byte[] pic = Tools.ImageToByte(foto, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //this.picImagen.BackgroundImage = foto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error desconocido. Detalles: " + ex.Message,
                        Tools._title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
