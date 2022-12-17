using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
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

        public Model.EF.bao_cao GetReportByStudentAndYear(string maHs, int maHocKi, int maNam)
        {
            Model.EF.bao_cao baoCao = new Model.EF.bao_cao()
            {
                
            };
            var listBaoCao =    dbContext.bao_cao.
                Where(baocao => 
                    baocao.ma_hs == maHs 
                    && baocao.ma_hoc_ki == maHocKi 
                    && baocao.ma_nam == maNam).
                ToList();
            if(listBaoCao.Count > 0 )
            {
                baoCao = listBaoCao[0];
            }
            return baoCao;
        }
    }
}
