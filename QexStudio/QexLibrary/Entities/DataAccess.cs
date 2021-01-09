using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Platform.Win32;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace Qex
{
    public class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            string exePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataBase\\QexStudio.db3");
            connection = new SQLiteConnection(new SQLitePlatformWin32(), exePath);
            //Create Tables
            connection.CreateTable<GrupoRecurso>();
            connection.CreateTable<Recurso>();
            connection.CreateTable<ConsumoRecurso>();
            connection.CreateTable<Presupuesto>();
            connection.CreateTable<ConsumoPres>();
            connection.CreateTable<Proyecto>();
            connection.CreateTable<Rubro>();
            connection.CreateTable<RubroPres>();
            connection.CreateTable<Tarea>();
            connection.CreateTable<TareaPres>();
            connection.CreateTable<GrOptions>();
            connection.CreateTable<loginDb>();
        }
        #region GrupoRecurso
        public void InsertGrupoRecurso(GrupoRecurso gru)
        {
            connection.Insert(gru);
        }
        public void DeleteGrupoRecurso(GrupoRecurso gru)
        {
            connection.Delete(gru);
        }
        public void UpdateGrupoRecurso(GrupoRecurso gru)
        {
            connection.Update(gru);
        }
        public GrupoRecurso GetGrupoRecursoById(int id)
        {
            return connection.Table<GrupoRecurso>().FirstOrDefault(y => y.id == id);
        }
        public List<GrupoRecurso> GetGrupoRecursos()
        {
            return connection.Table<GrupoRecurso>().ToList();
        }
        #endregion
        #region Recurso
        public void InsertRecurso(Recurso rec)
        {
            connection.Insert(rec);
        }
        public void DeleteRecurso(Recurso rec)
        {
            connection.Delete(rec);
        }
        public void UpdateRecurso(Recurso rec)
        {
            connection.Update(rec);
        }
        public Recurso GetRecursoById(int id)
        {
            return connection.Table<Recurso>().FirstOrDefault(xx => xx.id == id);
        }
        public List<Recurso> GetRecursos()
        {
            return connection.Table<Recurso>().ToList();
        }
        #endregion
        #region Consumo Recurso
        public void InsertConsumoRecurso(ConsumoRecurso rec)
        {
            connection.Insert(rec);
        }
        public void UpdateConsumoRecurso(ConsumoRecurso rec)
        {
            connection.Update(rec);
        }
        public void DeleteConsumoRecurso(ConsumoRecurso rec)
        {
            connection.Delete(rec);
        }
        public ConsumoRecurso GetConsumoRecursoById(int id)
        {
            return connection.Table<ConsumoRecurso>().FirstOrDefault(xx => xx.id == id);
        }
        public List<ConsumoRecurso> GetConsumoRecurso()
        {
            return connection.Table<ConsumoRecurso>().ToList();
        }
        #endregion
        #region Presupuesto
        public void InsertPresupuesto(Presupuesto pres)
        {
            connection.Insert(pres);
        }
        public void DeletePresupuesto(Presupuesto pres)
        {
            connection.Delete(pres);
        }
        public void UpdatePresupuesto(Presupuesto pres)
        {
            connection.Update(pres);
        }
        public Presupuesto GetPresupuestoById(int id)
        {
            return connection.Table<Presupuesto>().FirstOrDefault(xx => xx.id == id);
        }
        public List<Presupuesto> GetPresupuestos()
        {
            return connection.Table<Presupuesto>().ToList();
        }
        #endregion
        #region ConsumosPres
        public void InsertConsumoPres(ConsumoPres pres)
        {
            connection.Insert(pres);
        }
        public void DeleteConsumoPres(ConsumoPres pres)
        {
            connection.Delete(pres);
        }
        public void UpdateConsumoPres(ConsumoPres pres)
        {
            connection.Update(pres);
        }
        public ConsumoPres GetConsumoPresById(int id)
        {
            return connection.Table<ConsumoPres>().FirstOrDefault(xx => xx.id == id);
        }
        public List<ConsumoPres> GetConsumoPres()
        {
            return connection.Table<ConsumoPres>().ToList();
        }
        #endregion
        #region Proyecto
        public void InsertProyecto(Proyecto proy)
        {
            connection.Insert(proy);
        }
        public void DeleteProyecto(Proyecto proy)
        {
            connection.Delete(proy);
        }
        public void UpdateProyecto(Proyecto proy)
        {
            connection.Update(proy);
        }
        public Proyecto GetProyectoById(int id)
        {
            return connection.Table<Proyecto>().FirstOrDefault(xx => xx.id == id);
        }
        public List<Proyecto> GetProyectos()
        {
            return connection.Table<Proyecto>().ToList();
        }
        #endregion
        #region Rubros
        public void InsertRubro(Rubro rubro)
        {
            connection.Insert(rubro);
        }
        public void DeleteRubro(Rubro rubro)
        {
            connection.Delete(rubro);
        }
        public void UpdateRubro(Rubro rubro)
        {
            connection.Update(rubro);
        }
        public Rubro GetRubroById(int id)
        {
            return connection.Table<Rubro>().FirstOrDefault(xx => xx.id == id);
        }
        public List<Rubro> GetRubros()
        {
            return connection.Table<Rubro>().ToList();
        }
        #endregion
        #region RubrosPres
        public void InsertRubrosPres(RubroPres rubro)
        {
            connection.Insert(rubro);
        }
        public void InsertRubroPresList(List<RubroPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Insert(item);
            }
        }
        public void DeleteRubroPres(RubroPres rubro)
        {
            connection.Delete(rubro);
        }
        public void DeleteRubroPresList(List<RubroPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Delete(item);
            }
        }
        public void UpdateRubroPres(RubroPres rubro)
        {
            connection.Update(rubro);
        }
        public void UpdateRubroPresList(List<RubroPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Update(item);
            }
        }
        public void UpdateRubroPresList(List<RubroPres> lst, BackgroundWorker work)
        {
            int count = 1;
            int total = lst.Count;
            int progress = 0;

            foreach (var item in lst)
            {
                connection.Update(item);
                progress = 100 * count / total;
                Tools._status = "Procesando Grupos (" + count + "/" + total + ")";
                work.ReportProgress(progress);
                count++;
            }
        }
        public RubroPres GetRubroPresById(int id)
        {
            return connection.Table<RubroPres>().FirstOrDefault(xx => xx.id == id);
        }
        public List<RubroPres> GetRubrosPres()
        {
            return connection.Table<RubroPres>().ToList();
        }
        public List<RubroPres> GetRubrosPresFromPres(int id)
        {
            return connection.Table<RubroPres>().ToList().FindAll(x => x.pres_id == id);
        }
        public RubroPres getLastRubroPres()
        {
            return connection.Table<RubroPres>().Last();
        }
        #endregion
        #region Tarea
        public void InsertTarea(Tarea tr)
        {
            connection.Insert(tr);
        }
        public void DeleteTarea(Tarea tr)
        {
            connection.Delete(tr);
        }
        public void UpdateTarea(Tarea tr)
        {
            connection.Update(tr);
        }
        public Tarea GetTareaById(int id)
        {
            return connection.Table<Tarea>().FirstOrDefault(xx => xx.id == id);
        }
        public List<Tarea> GetTareas()
        {
            return connection.Table<Tarea>().ToList();
        }
        #endregion
        #region TareaPres
        public void InsertTareaPres(TareaPres tr)
        {
            connection.Insert(tr);
        }
        public void InsertTareaPresList(List<TareaPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Insert(item);
            }
        }
        public void InsertTareaPresList(List<TareaPres> lst, BackgroundWorker work)
        {
            int count = 1;
            int total = lst.Count;
            int progress = 0;

            foreach (var item in lst)
            {
                connection.Insert(item);
                progress = 100 * count / total;
                Tools._status = "Procesando Items (" + count + "/" + total + ")";
                work.ReportProgress(progress);
                count++;
            }
        }
        public void DeleteTareaPres(TareaPres tr)
        {
            connection.Delete(tr);
        }
        public void DeleteTareaPresList(List<TareaPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Delete(item);
            }
        }
        public void UpdateTareaPres(TareaPres tr)
        {
            connection.Update(tr);
        }
        public void UpdateTareaPresList(List<TareaPres> lst)
        {
            foreach (var item in lst)
            {
                connection.Update(item);
            }
        }
        public void UpdateTareaPresList(List<TareaPres> lst, BackgroundWorker work)
        {
            int count = 1;
            int total = lst.Count;
            int progress = 0;

            foreach (var item in lst)
            {
                connection.Update(item);
                progress = 100 * count / total;
                Tools._status = "Procesando Items (" + count + "/" + total + ")";
                work.ReportProgress(progress);
                count++;
            }
        }
        public TareaPres GetTareaPresById(int id)
        {
            return connection.Table<TareaPres>().FirstOrDefault(xx => xx.id == id);
        }
        public List<TareaPres> GetTareasPres()
        {
            return connection.Table<TareaPres>().ToList();
        }
        #endregion
        #region Options
        public void InsertOption(GrOptions opt)
        {
            connection.Insert(opt);
        }
        public void DeleteOption(GrOptions opt)
        {
            connection.Delete(opt);
        }
        public void UpdateOption(GrOptions opt)
        {
            connection.Update(opt);
        }
        public GrOptions GetOptionById(int id)
        {
            return connection.Table<GrOptions>().FirstOrDefault(xx => xx.Id == id);
        }
        public List<GrOptions> GetOptions()
        {
            return connection.Table<GrOptions>().ToList();
        }
        #endregion
        #region loginDb
        public void insertLoginDb(loginDb login)
        {
            connection.Insert(login);
        }
        public void updateLoginDb(loginDb login)
        {
            connection.Update(login);
        }
        public void deleteLoginDb(loginDb login)
        {
            connection.Delete(login);
        }
        public loginDb getLoginById(int id)
        {
            return connection.Table<loginDb>().FirstOrDefault(xx => xx.id == id);
        }
        public List<loginDb> getLoginDbs()
        {
            return connection.Table<loginDb>().ToList();
        }
        #endregion
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
