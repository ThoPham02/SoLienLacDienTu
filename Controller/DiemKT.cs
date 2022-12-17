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
        public bool DeleteScore(Model.EF.diem_kt score)
        {
            try
            {
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
                var score = dbContext.diem_kt.Find(maHS, loai, maMon, maHocKi, maNam);
                if (score == null)
                {
                    return false;
                }
                score.diem = diem;
            }
            catch (Exception)
            {
                return false;
            }
            dbContext.SaveChanges();
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
    }
}
