using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.EF;

namespace Controller
{
    public class BaoCao
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.bao_cao> GetReportList()
        {
            return dbContext.bao_cao.ToList();
        }
        public bool CreateReport(string ma_hs, string hanhkiem, string nhanXet, string hocKi, string namHoc)
        {
            try
            {
                Model.EF.bao_cao bc = new Model.EF.bao_cao();
                HanhKiem hanhKiemCtrl = new HanhKiem();
                HocKi hocKiCtrl = new HocKi();
                NamHoc namHocCtrl = new NamHoc();

                bc.ma_hs = ma_hs;
                bc.nhan_xet = nhanXet;
                bc.ma_hanh_kiem = hanhKiemCtrl.GetConductID(hanhkiem);
                bc.ma_hoc_ki = hocKiCtrl.GetSemesterID(hocKi);
                bc.ma_nam = namHocCtrl.GetYearID(namHoc);

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AdminCreateReport(string maHs, int maHanhKiem, string nx, int maHocKi, int maNam)
        {
            try
            {
                Model.EF.bao_cao bc = new Model.EF.bao_cao();
                bc.ma_hs = maHs;
                bc.nhan_xet = nx;
                bc.ma_hanh_kiem = maHanhKiem;
                bc.ma_hoc_ki = maHocKi;
                bc.ma_nam = maNam;
                dbContext.bao_cao.Add(bc);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Model.EF.bao_cao> GetReportByCondition(int id, string maHs,float diemTk, int maHanhKiem, string nx, int maHocKi, int maNam)
        {
            return dbContext.bao_cao
                .Where(db =>
                    (id == 0 || db.id == id)
                    &&(maHs == "" || db.ma_hs == maHs)
                    &&(diemTk == -1 || db.diem_tong_ket == diemTk)
                    &&(maHanhKiem == 0 || db.ma_hanh_kiem == maHanhKiem)
                    &&(nx == "" || db.nhan_xet == nx)
                    &&(maHocKi == 0 || db.ma_hoc_ki == maHocKi)
                    &&(maNam == 0 || db.ma_nam == maNam))
                .ToList();
        }
        public bool DeleteReport(int id)
        {
            try
            {
                var report = dbContext.bao_cao.Find(id);
                dbContext.bao_cao.Remove(report);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateReport(int id, string maHs, int maHanhKiem, float diemTK, string nx, int maHocKi, int maNam)
        {
            try
            {
                var report = dbContext.bao_cao.Find(id);
                report.ma_hs = maHs;
                report.ma_hanh_kiem = maHanhKiem;
                report.diem_tong_ket = diemTK;
                report.nhan_xet = nx;
                report.ma_hoc_ki = maHocKi;
                report.ma_nam = maNam;
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
