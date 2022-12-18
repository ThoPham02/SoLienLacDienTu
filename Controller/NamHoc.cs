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
        public List<Model.EF.nam_hoc> SearchYear(int maNam, string tenNam)
        {
            return dbContext.nam_hoc
                .Where(db => (maNam == -1 || db.ma_nam == maNam) && (tenNam == "" || db.ten_nam_hoc == tenNam))
                .ToList();
        }
        public bool CreateYear(string tenNam)
        {
            try
            {
                var year = new Model.EF.nam_hoc()
                {
                    ten_nam_hoc = tenNam
                };
                dbContext.nam_hoc.Add(year);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteYear(int maNam)
        {
            try
            {
                var year = dbContext.nam_hoc.Find(maNam);
                dbContext.nam_hoc.Remove(year);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateYear(int maNam, string tenNam)
        {
            try
            {
                var nh = dbContext.nam_hoc.Find(maNam);
                nh.ten_nam_hoc = tenNam;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetYearID(string namHoc)
        {
            return dbContext.nam_hoc.Single(b => b.ten_nam_hoc.Equals(namHoc)).ma_nam;
        }

        public string GetYearName(int maNam)
        {
            return dbContext.nam_hoc.Single(b => b.ma_nam.Equals(maNam)).ten_nam_hoc;
        }
    }
}
    