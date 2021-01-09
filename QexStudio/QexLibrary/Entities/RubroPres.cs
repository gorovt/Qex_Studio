#region 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
#endregion

namespace Qex
{
    public class RubroPres : ItemPres
    {
        //public int orden { get; set; }
        //public int pres_id { get; set; }

        #region Constructores
        public RubroPres()
        {
            //orden = 1;
            //this.pres_id = 0;
            this.categoria = "Grupo";
        }
        public RubroPres(string wbs, string nombre, double consumo, string unidad, double costoUnit,
             double costoTotal, double coef_resumen, double precioVenta, int orden, int rubropres_id, int pres_id) :
            base(wbs, nombre, consumo, unidad, costoUnit, costoTotal, precioVenta, rubropres_id, orden, pres_id)
        {
            this.id = 0;
            this.categoria = "Grupo";
            //this.orden = orden;
            //this.pres_id = pres_id;
        }
        #endregion

        #region Conversiones
        public string toNodeText()
        {
            string cadena = string.Format("{0} - {1}", orden, nombre);
            return cadena;
        }
        public TreeNode toNode()
        {
            TreeNode node = new TreeNode();
            node.Name = this.id.ToString();
            node.Text = this.nombre;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            return node;
        }
        public void updateWbs()
        {
            if (null != this.getParent())
            {
                this.wbs = this.getParent().wbs + "." + this.orden.ToString();
            }
            else
            {
                this.wbs = this.orden.ToString();
            }
        }
        public AnalisisItem toItems()
        {
            Presupuesto pres = Presupuesto.getById(this.pres_id);
            AnalisisItem item = new AnalisisItem();
            item.Category = "Grupo";
            item.id = this.id;
            item.parentId = this.rubropres_id;
            item.orden = this.orden;
            item.wbs = this.wbs;
            item.nombre = this.nombre;
            item.consumo = 0;
            item.unidad = "";
            item.coeficiente = pres.coef_resumen;
            item.tieneRecursos = false;
            return item;
        }
        public Task toMppTask(int id, int level)
        {
            Task tarea = new Task();
            tarea.UID = this.id;
            tarea.ID = id;
            tarea.Name = this.nombre;
            tarea.IsNull = 0;
            tarea.OutlineLevel = level;
            return tarea;
        }
        #endregion

        #region Get
        //public double getCostoMaterial()
        //{
        //    double costo = 0;
        //    foreach (TareaPres tarea in getAllTareas(this))
        //    {
        //        costo += (tarea.getCostoMaterial() * tarea.consumo);
        //    }
        //    return costo;
        //}
        //public double getCostoManoObra()
        //{
        //    double costo = 0;
        //    foreach (TareaPres tarea in getAllTareas(this))
        //    {
        //        costo += (tarea.getCostoManoObra() * tarea.consumo);
        //    }
        //    return costo;
        //}
        //public double getCostoEquipo()
        //{
        //    double costo = 0;
        //    foreach (TareaPres tarea in getAllTareas(this))
        //    {
        //        costo += (tarea.getCostoEquipo() * tarea.consumo);
        //    }
        //    return costo;
        //}
        //public double getCostoTotal()
        //{
        //    double costo = 0;
        //    foreach (TareaPres tarea in getAllTareas(this))
        //    {
        //        costo += (tarea.getCostoTotal() * tarea.consumo);
        //    }
        //    return costo;
        //}

        /// <summary>
        /// Obtiene el último RubroPres creado en la Base de Datos
        /// </summary>
        public static RubroPres getLast()
        {
            using (var datos = new DataAccess())
            {
                return datos.getLastRubroPres();
            };
        }
        #endregion

        #region Base Datos
        /// <summary>
        /// Inserta un RubroPres en la Base de Datos
        /// </summary>
        public void insert()
        {
            this.updateWbs();
            this.UpdateCostos();
            //this.tieneHijos = false;
            using (var datos = new DataAccess())
            {
                datos.InsertRubrosPres(this);
            };
        }

        /// <summary>
        /// Inserta una Lista de RubroPres en la Base de Datos
        /// </summary>
        public static void InsertList(List<RubroPres> lst)
        {
            foreach (var item in lst)
            {
                item.updateWbs();
                item.UpdateCostos();
            }
            using (var datos = new DataAccess())
            {
                datos.InsertRubroPresList(lst);
            };
        }

        /// <summary>
        /// Borra el RubroPres de la Base de Datos
        /// </summary>
        public void delete()
        {
            foreach (RubroPres rubro in getChilds())
            {
                rubro.delete();
            }
            //Borrar TareaPres
            foreach (TareaPres tarea in getTareas())
            {
                tarea.delete();
            }

            //Borrar RubroPres
            using (var datos = new DataAccess())
            {
                datos.DeleteRubroPres(this);
            };
        }

        /// <summary>
        /// Borra una Lista de RubroPres de la Base de Datos
        /// </summary>
        public static void DeleteList(List<RubroPres> lst)
        {
            using (var datos = new DataAccess())
            {
                datos.DeleteRubroPresList(lst);
            };
        }

        /// <summary>
        /// Actualiza un RubroPres en la Base de Datos
        /// </summary>
        public void update()
        {
            this.updateWbs();
            this.UpdateCostos();
            using (var datos = new DataAccess())
            {
                datos.UpdateRubroPres(this);
            };
        }

        /// <summary>
        /// Actualiza una Lista de RubroPres en la Base de Datos
        /// </summary>
        public static void UpdateList(List<RubroPres> lst)
        {
            foreach (var item in lst)
            {
                item.updateWbs();
                item.UpdateCostos();
            }
            using (var datos = new DataAccess())
            {
                datos.UpdateRubroPresList(lst);
            };
        }

        /// <summary>
        /// Actualiza una Lista de RubroPres en la Base de Datos
        /// </summary>
        public static void UpdateList(List<RubroPres> lst, BackgroundWorker work)
        {
            foreach (var item in lst)
            {
                item.updateWbs();
                item.UpdateCostos();
            }
            using (var datos = new DataAccess())
            {
                datos.UpdateRubroPresList(lst, work);
            };
        }

        public static RubroPres getByid(int id)
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubroPresById(id);
            };
        }
        public static List<RubroPres> read()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubrosPres();
            };
        }
        #endregion

        #region Listas
        public static List<RubroPres> getRubrosByPresId(int pres_id)
        {
            List<RubroPres> lst = new List<RubroPres>();
            foreach (RubroPres rubro in RubroPres.read().FindAll(x => x.pres_id == pres_id))
            {
                lst.Add(rubro);
            }
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            return lst;
        }

        public RubroPres getParent()
        {
            using (var datos = new DataAccess())
            {
                return datos.GetRubroPresById(this.rubropres_id);
            };
        }

        /// <summary>
        /// It obtains a list of the Items of the Group (only children)
        /// </summary>
        public List<TareaPres> getTareas()
        {
            return TareaPres.read().FindAll(x => x.rubropres_id == this.id);
        }

        /// <summary>
        /// Obtains a list of ALL elements of the Group (parents and children)
        /// </summary>
        public static List<TareaPres> getAllTareas(RubroPres rubro)
        {
            List<TareaPres> lst = new List<TareaPres>();
            RubroPres.TareasChild(rubro, lst);
            return lst;
        }
        /// <summary>
        /// Devuelve la lista de Rubros hijos
        /// </summary>
        public List<RubroPres> getChilds()
        {
            return read().FindAll(x => x.rubropres_id == this.id);
            //lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            //return lst;
        }
        /// <summary>
        /// Completa una Lista con TODAS las TareaPres de un RubroPres (padres e hijos)
        /// </summary>
        public static void TareasChild(RubroPres rubro, List<TareaPres> lst)
        {
            foreach (TareaPres tarea in rubro.getTareas())
            {
                lst.Add(tarea);
            }
            foreach (RubroPres rubro2 in rubro.getChilds())
            {
                TareasChild(rubro2, lst);
            }
        }
        /// <summary>
        /// Completa una Lista con TODOS los RubroPres de un RubroPres
        /// </summary>
        public static void RubrosChild(RubroPres rubro, List<RubroPres> lst)
        {
            foreach (RubroPres rubro1 in rubro.getChilds())
            {
                lst.Add(rubro1);
                List<RubroPres> lista = rubro1.getChilds();
                if (lista.Count > 0)
                {
                    RubrosChild(rubro1, lst);
                }
            }
        }
        #endregion

        /// <summary>
        /// Recursive. Gets the child groups of each Group, and converts them to Tasks
        /// </summary>
        public void mppTareaChild(List<Task> lst, int count, int level)
        {
            level++;
            foreach (TareaPres ta in getTareas())
            {
                Task tarea2 = ta.toMppTask(count, level);
                lst.Add(tarea2);
                count++;
            }
            foreach (RubroPres rubro in getChilds())
            {
                Task tarea = rubro.toMppTask(count, level);
                lst.Add(tarea);
                count++;
                //if (rubro.getTareas().Count > 0)
                //{
                //    level++;
                //}
                //foreach (TareaPres ta in rubro.getTareas())
                //{
                //    Task tarea2 = ta.toMppTask(count, level);
                //    lst.Add(tarea2);
                //    count++;
                //}
                //if (rubro.getTareas().Count > 0)
                //{
                //    level--;
                //}
                rubro.mppTareaChild(lst, count, level);
            }
            level--;
        }
        public void WbsChild(RubroPres rubro, int orden)
        {
            //int countRubro = 1;
            int countTarea = 1;
            foreach (TareaPres tarea in rubro.getTareas().OrderBy(x => x.orden).ThenBy(x => x.nombre))
            {
                tarea.orden = countTarea;
                tarea.update();
                countTarea++;
            }
            foreach (RubroPres subRubro in rubro.getChilds().OrderBy(x => x.orden).ThenBy(x => x.nombre))
            {
                subRubro.orden = countTarea;
                subRubro.update();
                countTarea++;
                WbsChild(subRubro, subRubro.orden);
            }
        }
        /// <summary>
        /// Obtiene el Presupuesto padre de este RubroPres
        /// </summary>
        public Presupuesto GetPresupuesto()
        {
            return Presupuesto.getById(this.pres_id);
        }
        #region Abstract Override
        /// <summary>
        /// Obtiene la sumatoria de todos los CostosUnitarios de las TareasPres Hijas
        /// </summary>
        public override double GetCostoUnitario()
        {
            return 0;
        }
        /// <summary>
        /// Se suman todos los Costos totales de todas las TareasPres hijas
        /// </summary>
        public override double GetCostoTotal()
        {
            double costoTotal = 0;
            foreach (var item in getAllTareas(this))
            {
                costoTotal += item.costoTotal;
            }
            return costoTotal;
        }
        /// <summary>
        /// Se suman todos los Precios de Venta de todas las TareasPres hijas
        /// </summary>
        public override double GetPrecioVenta()
        {
            double precioVenta = 0;
            foreach (var item in getAllTareas(this))
            {
                precioVenta += item.precioVenta;
            }
            return precioVenta;
        }
        /// <summary>
        /// Se obtiene una Lista con los ItemPres hijos (TareasPres y RubrosPres)
        /// </summary>
        public override List<ItemPres> GetChildrens()
        {
            List<ItemPres> lst = new List<ItemPres>();
            foreach (var item in getTareas())
            {
                lst.Add(item);
            }
            foreach (var item in getChilds())
            {
                lst.Add(item);
            }
            return lst;
        }
        public override List<ItemPres> GetChildrensOrden()
        {
            List<ItemPres> lst = new List<ItemPres>();
            foreach (var item in getTareas())
            {
                lst.Add(item);
            }
            foreach (var item in getChilds())
            {
                lst.Add(item);
            }
            lst = lst.OrderBy(x => x.orden).ThenBy(x => x.nombre).ToList();
            return lst;
        }
        public override bool tieneRecursos()
        {
            return false;
        }

        public override void UpdateCostos()
        {
            this.costoUnitario = GetCostoUnitario();
            this.costoTotal = GetCostoTotal();
            //this.coef_resumen = GetPresupuesto().coef_resumen;
            this.precioVenta = GetPrecioVenta();
        }
        public override List<ItemPres> GetGrupos()
        {
            List<ItemPres> lst = new List<ItemPres>();
            foreach (var item in getChilds())
            {
                lst.Add(item);
            }
            return lst;
        }
        //public override void UpdateTieneHijos()
        //{
        //    bool hijos = false;
        //    if (this.GetChildrens().Count > 0)
        //    {
        //        hijos = true;
        //    }
        //    this.tieneHijos = hijos;
        //}
        #endregion
    }
}