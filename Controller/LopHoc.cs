using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LopHoc
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.lop_hoc> GetClassList()
        {
            return dbContext.lop_hoc.ToList();
        }
        public Model.EF.lop_hoc GetClassByStudent(string maHocSinh)
        {
            try
            {
                var classDetail = dbContext.chi_tiet_lop_hoc.Single(db => db.ma_hs.Equals(maHocSinh));

                return dbContext.lop_hoc.Single(db => db.ma_lop == classDetail.ma_lop);
            } catch
            {
                return null;
            }
        }
        public List<Model.EF.lop_hoc> SearchClass(int maLop, string tenLop, string maGv)
        {
            return dbContext.lop_hoc
                .Where(db => (maLop == -1 || db.ma_lop == maLop)
                            && (tenLop == "" || db.ten == tenLop)
                            && (maGv == "" || db.ma_gv == maGv))
                .ToList();
        }

        public bool CreateClass(string tenLop, string maGv)
        {
            try
            {
                Model.EF.lop_hoc clas = new Model.EF.lop_hoc()
                {
                    ten = tenLop,
                    ma_gv = maGv
                };
                dbContext.lop_hoc.Add(clas);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteClass(int maLop)
        {
            try
            {
                Model.EF.lop_hoc clas = dbContext.lop_hoc.Find(maLop);
                dbContext.lop_hoc.Remove(clas);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateClass(int maLop, string tenLop, string maGv)
        {
            try
            {

                var lop = dbContext.lop_hoc.Find(maLop);
                lop.ten = tenLop;
                lop.ma_gv = maGv;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetClassNameByID(int maLop)
        {
            return dbContext.lop_hoc.Single(c => c.ma_lop == maLop).ten;
        }

        public List<Model.EF.hoc_sinh> GetClassListByTeacherID(string maGV)
        {
            List<Model.EF.hoc_sinh> listHs = new List<Model.EF.hoc_sinh>();
            int maLop = dbContext.lop_hoc.Single(c => c.ma_gv.Equals(maGV)).ma_lop;

            var chiTietLops = from c in dbContext.chi_tiet_lop_hoc
                       where c.ma_lop == maLop
                       select c;

            foreach (var item in chiTietLops)
            {
                var hocSinhs = from c in dbContext.hoc_sinh
                               where c.ma_hs == item.ma_hs
                               select c;
                listHs.Add(hocSinhs.ToList()[0]);
            }
                
            return listHs;
        }
    }
}
