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
using System.Collections;

namespace uiGR2020
{
    public partial class frmGrupoMove : Form
    {
        Presupuesto _pres;
        ItemPres _item;

        public frmGrupoMove(Presupuesto pres, ItemPres item)
        {
            InitializeComponent();
            _pres = pres;
            _item = item;
            this.treeListView1.UseHotItem = false;
            this.treeListView1.UseHyperlinks = false;
            this.treeListView1.UseHotControls = false;
        }

        private void fillTree()
        {
            this.treeListView1.DataBindings.Clear();
            List<ItemPres> lst = new List<ItemPres>();
            lst.Add(_pres);
            this.treeListView1.SetObjects(lst);
            this.treeListView1.ExpandAll();
        }

        private void frmGrupoMove_Load(object sender, EventArgs e)
        {
            // Can the given object be expanded?
            this.treeListView1.CanExpandGetter = delegate (object x)
            {
                var item = (ItemPres)x;
                return (item.GetChildrens().Count > 0);
            };

            // What objects should belong underneath the given model object?
            this.treeListView1.ChildrenGetter = delegate (object x)
            {
                var item = (ItemPres)x;
                return new ArrayList(item.GetGrupos());
            };
            // Which image should be used for which model
            this.olvColumn2.ImageGetter = delegate (Object x) {
                var item = (ItemPres)x;
                if (item.categoria == "Presupuesto")
                    return 0;
                else if (item.categoria == "Grupo")
                {
                    return 1;
                }
                else
                {
                    if (item.tieneRecursos())
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            };

            fillTree();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Verify Selction Null
            if (this.treeListView1.SelectedObject == null)
            {
                MessageBox.Show("Debes elegir un Grupo", Tools._title,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Get the Selected Item
            ItemPres item = (ItemPres)this.treeListView1.SelectedObject;

            // Verify selection: cannot select an Item
            if (item.categoria == "Item")
            {
                MessageBox.Show("Los Items no se pueden elegir", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no se mueva sobre si mismo
            if (item.id == _item.id)
            {
                MessageBox.Show("No se puede mover sobre si mismo", Tools._title,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Selection is an Estimate
            if (item.categoria == "Presupuesto")
            {
                if (_item.categoria == "Grupo")
                {
                    RubroPres rubro = RubroPres.getByid(_item.id);
                    rubro.rubropres_id = 0;
                    rubro.update();
                    this.Close();
                    return;
                }
                if (_item.categoria == "Item")
                {
                    MessageBox.Show("Debes elegir un Grupo", Tools._title,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // Selection is a Group
            if (item.categoria == "Grupo")
            {
                if (_item.categoria == "Grupo")
                {
                    RubroPres rubro = RubroPres.getByid(_item.id);
                    rubro.rubropres_id = item.id;
                    rubro.update();
                    this.Close();
                    return;
                }
                if (_item.categoria == "Item")
                {
                    TareaPres tarea = TareaPres.getById(_item.id);
                    tarea.rubropres_id = item.id;
                    tarea.update();
                    this.Close();
                    return;
                }
            }
            
        }

        private void treeListView1_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            ItemPres item = (ItemPres)e.Model;
            if (item.categoria == "Presupuesto")
            {
                e.Item.BackColor = Color.LightBlue;
            }
            if (item.categoria == "Grupo")
            {
                e.Item.BackColor = Color.AliceBlue;
            }
        }
    }
}
