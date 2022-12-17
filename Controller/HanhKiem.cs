using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class HanhKiem
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.hanh_kiem> GetConductList()
        {
            return dbContext.hanh_kiem.ToList();
        }

        public string GetConductName(int maHanhKiem) {
            return dbContext.hanh_kiem.Single(b => b.ma_hanh_kiem.Equals(maHanhKiem)).loai;
        }
        public bool CreateConduct(Model.EF.hanh_kiem conduct)
        {
            try
            {
                dbContext.hanh_kiem.Add(conduct);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteConduct(Model.EF.hanh_kiem conduct)
        {
            try
            {
                dbContext.hanh_kiem.Remove(conduct);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateConduct(Model.EF.hanh_kiem conduct)
        {
            try
            {
                dbContext.hanh_kiem.AddOrUpdate(conduct);
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
