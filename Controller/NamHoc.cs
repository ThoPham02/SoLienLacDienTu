using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class NamHoc
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.nam_hoc> GetYearList()
        {
            return dbContext.nam_hoc.ToList();
        }
        public bool CreateYear(Model.EF.nam_hoc year)
        {
            try
            {
                dbContext.nam_hoc.Add(year);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteYear(Model.EF.nam_hoc year)
        {
            try
            {
                dbContext.nam_hoc.Remove(year);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateYear(Model.EF.nam_hoc year)
        {
            try
            {
                dbContext.nam_hoc.AddOrUpdate(year);
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
    