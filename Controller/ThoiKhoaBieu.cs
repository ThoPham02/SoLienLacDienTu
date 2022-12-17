using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ThoiKhoaBieu
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.thoi_khoa_bieu> GetScheduleList()
        {
            return dbContext.thoi_khoa_bieu.ToList();
        }
        public List<Model.EF.thoi_khoa_bieu> GetScheduleByCondition(int maLop, int maHocKi, int maNamHoc)
        {
            return dbContext.thoi_khoa_bieu
                .Where(db => db.ma_lop == maLop && db.ma_hoc_ki == maHocKi && db.ma_nam_hoc == maNamHoc)
                .ToList();
        }
        public bool CreateSchedule(Model.EF.thoi_khoa_bieu schedule)
        {
            try
            {
                dbContext.thoi_khoa_bieu.Add(schedule);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSchedule(Model.EF.thoi_khoa_bieu schedule)
        {
            try
            {
                dbContext.thoi_khoa_bieu.Remove(schedule);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSchedule(Model.EF.thoi_khoa_bieu schedule)
        {
            try
            {
                dbContext.thoi_khoa_bieu.AddOrUpdate(schedule);
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
