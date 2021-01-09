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
    public partial class frmSelectRecursos : Form
    {
        public int _tarea_Id;

        public frmSelectRecursos(int tareaId)
        {
            InitializeComponent();
            _tarea_Id = tareaId;

            this.Text = "Seleccionar Recursos";
            this.trvElements.Nodes.Add(Tools.nodeSeleccionarMateriales());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Tarea tarea = Tarea.getById(_tarea_Id);

            try
            {
                foreach (TreeNode node in this.trvElements.Nodes)
                {
                    foreach (TreeNode node1 in node.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Checked == true)
                            {
                                Recurso rec = Recurso.getById(Convert.ToInt32(node2.Name));
                                ConsumoRecurso cm = new ConsumoRecurso();
                                cm.tarea_id = _tarea_Id;
                                cm.recurso_id = rec.id;
                                cm.consumo = 1;
                                cm.coeficiente = 1;
                                //cm.categoria = rec.categoria;
                                cm.insert();
                            }
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text != "")
            {
                string buscar = txtBuscar.Text;
                this.trvElements.Nodes.Clear();
                //Treenodes
                TreeNode node0 = new TreeNode();
                node0.Name = "Recursos";
                node0.Text = "Recursos";
                node0.ExpandAll();
                TreeNode node1 = new TreeNode();
                node1.Name = "00";
                node1.Text = "Resultados";
                node1.ImageIndex = 0;
                node1.SelectedImageIndex = 0;
                node1.ExpandAll();
                List<Recurso> lst = Recurso.read();
                lst = lst.OrderBy(x => x.nombre).ToList();
                foreach (Recurso mat in lst)
                {
                    if (mat.toNodeText().ToLower().Contains(buscar))
                    {
                        TreeNode node2 = new TreeNode();
                        node2.Name = mat.id.ToString();
                        node2.Text = mat.toNodeText();
                        if (mat.categoria == "Material")
                        {
                            node2.SelectedImageIndex = 1;
                            node2.ImageIndex = 1;
                        }
                        if (mat.categoria == "Trabajo")
                        {
                            node2.SelectedImageIndex = 2;
                            node2.ImageIndex = 2;
                        }
                        if (mat.categoria == "Equipo")
                        {
                            node2.SelectedImageIndex = 3;
                            node2.ImageIndex = 3;
                        }
                        node1.Nodes.Add(node2);
                    }
                }
                node0.Nodes.Add(node1);
                this.trvElements.Nodes.Clear();
                this.trvElements.Nodes.Add(node0);
            }
            else
            {
                this.trvElements.Nodes.Clear();
                this.trvElements.Nodes.Add(Tools.nodeSeleccionarMateriales());
            }
        }
    }
}
