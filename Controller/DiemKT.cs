using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DiemKT
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.diem_kt> GetScoreList()
        {
            return dbContext.diem_kt.ToList();
        }
        public bool CreateScore(string maHS, float diem, byte loai, byte maMon, byte maHocKi, byte maNam)
        {
            try
            {
                dbContext.diem_kt.Add(new Model.EF.diem_kt()
                {
                    ma_hs = maHS,
                    diem = diem,
                    loai = loai,
                    ma_mon = maMon,
                    ma_hoc_ki = maHocKi,
                    ma_nam = maNam
                });
                dbContext.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool DeleteScore(string maHS, byte loai, byte maMon, byte maHocKi, byte maNam)
        {
            try
            {
                var score = dbContext.diem_kt.First(db => db.ma_hs == maHS && db.loai == loai && db.ma_hoc_ki == maHocKi && db.ma_nam == maNam && db.ma_mon == maMon);
                dbContext.diem_kt.Remove(score);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateScore(string maHS, float diem, byte loai, byte maMon, byte maHocKi, byte maNam)
        {
            try
            {
                var score = dbContext.diem_kt.First(db => db.ma_hs == maHS && db.loai == loai && db.ma_hoc_ki == maHocKi && db.ma_nam == maNam && db.ma_mon == maMon);
                if (score == null)
                {
                    return false;
                }
                score.diem = diem;
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Model.EF.diem_kt> GetScoreByCondition(string maHs, int maMon, int maHocKi, int maNamHoc)
        {
            return dbContext.diem_kt
                .Where(diem =>
                    diem.ma_hs == maHs
                    && diem.ma_mon == maMon
                    && diem.ma_hoc_ki == maHocKi
                    && diem.ma_nam == maNamHoc)
                .ToList();
        }

        public List<Model.EF.diem_kt> SearchScore(string maHs, int loai, int maMon, int maHocKi, int maNamHoc)
        {
            return dbContext.diem_kt
                .Where(diem =>
                    (maHs == "" || diem.ma_hs == maHs) && (loai == -1 || diem.loai == loai) && (maMon == -1 || diem.ma_mon == maMon) && (maHocKi == -1 || diem.ma_hoc_ki == maHocKi) && maNamHoc == -1 || diem.ma_nam == maNamHoc)
                .ToList();
        }
    }
}
