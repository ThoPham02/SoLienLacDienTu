using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class BaoCao
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.bao_cao> GetReportList()
        {
            return dbContext.bao_cao.ToList();
        }
        public bool CreateReport(Model.EF.bao_cao report)
        {
            try
            {
                dbContext.bao_cao.Add(report);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteReport(Model.EF.bao_cao report)
        {
            try
            {
                dbContext.bao_cao.Remove(report);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateReport(Model.EF.bao_cao report)
        {
            try
            {
                dbContext.bao_cao.AddOrUpdate(report);
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
