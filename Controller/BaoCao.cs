using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public bool CreateReport(string ma_hs, int maHanhkiem, string nhanXet, int maHocKi, int maNamHoc)
        {
            try
            {
                Model.EF.bao_cao bc = new Model.EF.bao_cao();
                Model.EF.hoc_sinh hs = dbContext.hoc_sinh.Find(ma_hs);
                HanhKiem hanhKiemCtrl = new HanhKiem();
                HocKi hocKiCtrl = new HocKi();
                NamHoc namHocCtrl = new NamHoc();

                bc.ma_hs = hs.ma_hs;
                bc.nhan_xet = nhanXet;
                bc.ma_hanh_kiem = maHanhkiem;
                bc.ma_nam = maNamHoc;
                bc.ma_hoc_ki = maHocKi;

                dbContext.bao_cao.Add(bc);
                try
                {
                      dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
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

        public bool UpdateReport(string maHS, int maHocKi, int maNamHoc, int maHanhKiem, string nhanXet)
        {
            try
            {
                Model.EF.bao_cao bc = GetReportByStudentAndYear(maHS, maHocKi, maNamHoc);

                bc.ma_hanh_kiem = maHanhKiem;
                bc.nhan_xet = nhanXet;

                dbContext.bao_cao.AddOrUpdate(bc);
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
            var listBaoCao = dbContext.bao_cao.
                Where(baocao =>
                    baocao.ma_hs == maHs
                    && baocao.ma_hoc_ki == maHocKi
                    && baocao.ma_nam == maNam).
                ToList();
            if (listBaoCao.Count > 0)
            {
                baoCao = listBaoCao[0];
            }
            return baoCao;
        }
    }
}
