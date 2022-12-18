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

        public int GetSemesterID(string hocKy)
        {
            return dbContext.hoc_ki.Single(b => b.ten_hoc_ki.Equals(hocKy)).ma_hoc_ki;
        }

        public string GetSemesterName(int maHK)
        {
            return dbContext.hoc_ki.Single(b => b.ma_hoc_ki.Equals(maHK)).ten_hoc_ki;
        }
        public List<Model.EF.hoc_ki> GetSemesterByCondition(int maHocKi, string tenHocKi)
        {
            return dbContext.hoc_ki
                .Where(db => (maHocKi == 0 || db.ma_hoc_ki == maHocKi) && (tenHocKi == "" || db.ten_hoc_ki ==tenHocKi))
                .ToList();
        }

        public bool CreateSemester(string tenHocKi)
        {
            try
            {
                Model.EF.hoc_ki hk = new Model.EF.hoc_ki()
                {
                    ten_hoc_ki = tenHocKi
                };
                dbContext.hoc_ki.Add(hk);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSemester(int maHk)
        {
            try
            {
                var hk = dbContext.hoc_ki.Find(maHk);
                dbContext.hoc_ki.Remove(hk);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSemester(int maHocKi, string tenHocKi)
        {
            try
            {
                var hk = dbContext.hoc_ki.Find(maHocKi);
                hk.ten_hoc_ki = tenHocKi;
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
