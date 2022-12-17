using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MonHoc
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.mon_hoc> GetSubjectsList()
        {
            return dbContext.mon_hoc.ToList();
        }
        public Model.EF.mon_hoc GetSubjectsById(int maMonHoc)
        {
            return dbContext.mon_hoc.Single(b => b.ma_mon.Equals(maMonHoc));
        }
        public bool CreateSubjects(Model.EF.mon_hoc subjects)
        {
            try
            {
                dbContext.mon_hoc.Add(subjects);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSubjects(Model.EF.mon_hoc subjects)
        {
            try
            {
                dbContext.mon_hoc.Remove(subjects);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSubjects(Model.EF.mon_hoc subjects)
        {
            try
            {
                dbContext.mon_hoc.AddOrUpdate(subjects);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
