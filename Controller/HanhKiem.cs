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

        public int GetConductID(string hanhkiem)
        {
            return dbContext.hanh_kiem.Single(b => b.ma_hanh_kiem.Equals(hanhkiem)).ma_hanh_kiem;
        }
        public List<Model.EF.hanh_kiem> GetConductByCondition(int maHK, string loai)
        {
            return dbContext.hanh_kiem
                .Where(db => (maHK == 0 || db.ma_hanh_kiem == maHK) && (loai == "" || db.loai == loai))
                .ToList();
        }

        public bool CreateConduct(string loai)
        {
            Model.EF.hanh_kiem hk = new Model.EF.hanh_kiem()
            {
                loai = loai,
            };
            try
            {
                dbContext.hanh_kiem.Add(hk);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteConduct(int maHk)
        {
            try
            {
                var hk = dbContext.hanh_kiem.Find(maHk);
                dbContext.hanh_kiem.Remove(hk);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateConduct(int maHk, string loai)
        {
            Model.EF.hanh_kiem hk = new Model.EF.hanh_kiem()
            {
                ma_hanh_kiem= maHk,
                loai= loai,
            };
            try
            {
                dbContext.hanh_kiem.AddOrUpdate(hk);
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
