using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class HocKi
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.hoc_ki> GetSemesterList()
        {
            return dbContext.hoc_ki.ToList();
        }
        public bool CreateSemester(Model.EF.hoc_ki semester)
        {
            try
            {
                dbContext.hoc_ki.Add(semester);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSemester(Model.EF.hoc_ki semester)
        {
            try
            {
                dbContext.hoc_ki.Remove(semester);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSemester(Model.EF.hoc_ki semester)
        {
            try
            {
                dbContext.hoc_ki.AddOrUpdate(semester);
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
