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
    public partial class frmImportarQex : Form
    {
        public List<string> _lstLibros;

        public frmImportarQex()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Archivo Qex (*.qex)|*.qex";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = sfd.FileName;
                    this.txtRuta.Text = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (this.txtRuta.Text == "")
            {
                MessageBox.Show("Debe seleccionar un Archivo Qex", Tools._title,
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnAbrir.Focus();
                return;
            }
            try
            {
                string ruta = this.txtRuta.Text;
                Presupuesto pres = Presupuesto.getById(frmMain._pres_id);
                this.Close();
                (new frmImportarQexSplash(ruta, pres)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.universobim.com/qex/");
        }
    }
}
