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
    public partial class frmSelectTareasPres : Form
    {
        public Presupuesto _pres;
        public RubroPres _rubro;
        public TareaPres _tarea;
        public int _estado = 0;
        // Estados:
        // 0 - Insertar Tareas en un Rubro
        // 1 - Insertar Recursos a un Item

        // Insertar Tareas en un Rubro determinado
        public frmSelectTareasPres(Presupuesto pres, RubroPres rubro)
        {
            InitializeComponent();
            _pres = pres;
            _rubro = rubro;
            _estado = 0;

            this.trvElements.Nodes.Add(Tools.nodeSeleccionarTareas());
        }
        // Insertar Recursos en un Item determinado
        public frmSelectTareasPres(TareaPres tarea)
        {
            InitializeComponent();
            _tarea = tarea;
            _estado = 1;

            this.trvElements.Nodes.Add(Tools.nodeSeleccionarTareas());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            switch (_estado)
            {
                case 0:
                    // Se agregan Items a un Rubro
                    InsertaItemsEnRubro(this.trvElements, _rubro);
                    break;
                case 1:
                    // Se agregan Recursos a un Item
                    InsertaRecursosEnItem(this.trvElements, _tarea);
                    break;
            }
            Cursor.Current = Cursors.Arrow;
            this.Close();
        }

        private void InsertaItemsEnRubro(TreeView tree, RubroPres rubro)
        {
            try
            {
                foreach (TreeNode node in tree.Nodes)
                {
                    foreach (TreeNode node1 in node.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Checked == true)
                            {
                                int id = Convert.ToInt32(node2.Name);
                                Tarea tarea = Tarea.getById(id);
                                TareaPres tareaPres = new TareaPres("0", tarea.nombre, 1, tarea.unidad, 0, 0,
                                    1, 0, 0, rubro.id, _pres.id);
                                if (!rubro.getTareas().Exists(x => x.nombre == tarea.nombre))
                                {
                                    tareaPres.insert();
                                    TareaPres final = rubro.getTareas().Find(x => x.nombre == tareaPres.nombre);
                                    foreach (ConsumoRecurso cr in tarea.getConsumos())
                                    {
                                        Recurso rec = cr.getRecurso();
                                        double costoTotal = cr.consumo * cr.coeficiente * rec.precio;
                                        ConsumoPres cp = new ConsumoPres(rec.nombre, cr.consumo, rec.unidad,
                                            rec.categoria, rec.venta_cantidad, rec.venta_unidad, rec.precio,
                                            costoTotal, 0, "", final.id, cr.recurso_id, cr.coeficiente,
                                            rubro.pres_id);
                                        cp.insert();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InsertaRecursosEnItem(TreeView tree, TareaPres tareaP)
        {
            try
            {
                foreach (TreeNode node in tree.Nodes)
                {
                    foreach (TreeNode node1 in node.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Checked == true)
                            {
                                int id = Convert.ToInt32(node2.Name);
                                Tarea tarea = Tarea.getById(id);
                                RubroPres rubro = RubroPres.getByid(tareaP.rubropres_id);
                                TareaPres tareaPres = new TareaPres("0", tarea.nombre, 1, tarea.unidad, 0, 0, 1, 
                                    0, 0, rubro.id, rubro.pres_id);
                                foreach (ConsumoRecurso cr in tarea.getConsumos())
                                {
                                    if (!tareaP.getConsumos().Exists(x => x.recurso_id == cr.recurso_id))
                                    {
                                        Recurso rec = Recurso.getById(cr.recurso_id);
                                        double costoTotal = cr.consumo * cr.coeficiente * rec.precio;
                                        ConsumoPres cp = new ConsumoPres(rec.nombre, cr.consumo, rec.unidad, 
                                            rec.categoria, rec.venta_cantidad, rec.venta_unidad, rec.precio,
                                            costoTotal, 0, "", tareaP.id, cr.recurso_id, cr.coeficiente, 
                                            tareaP.pres_id);
                                        cp.insert();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message, Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text != "")
            {
                string buscar = txtBuscar.Text;
                this.trvElements.Nodes.Clear();
                //Treenodes
                TreeNode node0 = new TreeNode();
                node0.Name = "Items";
                node0.Text = "Items";
                node0.ExpandAll();
                TreeNode node1 = new TreeNode();
                node1.Name = "00";
                node1.Text = "Resultados";
                node1.ImageIndex = 0;
                node1.SelectedImageIndex = 0;
                node1.ExpandAll();
                List<Tarea> lst = Tarea.read();
                lst = lst.OrderBy(x => x.nombre).ToList();
                foreach (Tarea tarea in lst)
                {
                    if (tarea.toNodeText().ToLower().Contains(buscar))
                    {
                        TreeNode node2 = new TreeNode();
                        node2.Name = tarea.id.ToString();
                        node2.Text = tarea.toNodeText();
                        node2.SelectedImageIndex = 1;
                        node2.ImageIndex = 1;
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
                this.trvElements.Nodes.Add(Tools.nodeSeleccionarTareas());
            }
        }

        private void trvElements_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1 && e.Node.Checked)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                }
            }
            if (e.Node.Level == 1 && !e.Node.Checked)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                }
            }
        }

        private void btnCopiarConsumos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.trvElements.SelectedNode.Name);
            Tarea tarea = Tarea.getById(id);
            List<ConsumoRecurso> lst = tarea.getConsumos();
            Tools.lstClipboardConsumos = lst;
        }

        private void trvElements_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.trvElements.SelectedNode = e.Node;
            }
        }
    }
}
