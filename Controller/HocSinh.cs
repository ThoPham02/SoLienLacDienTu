using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class HocSinh
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public Model.EF.hoc_sinh GetStudentByID(string maHs)
        {
            return dbContext.hoc_sinh.Single(b => b.ma_hs.Equals(maHs));
        }
        public List<Model.EF.hoc_sinh> GetStudentList()
        {
            return dbContext.hoc_sinh.ToList();
        }
        public bool CreateStudent(Model.EF.hoc_sinh student)
        {
            try
            {
                dbContext.hoc_sinh.Add(student);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteStudent(Model.EF.hoc_sinh student)
        {
            try
            {
                dbContext.hoc_sinh.Remove(student);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateStudent(string ten, string ngaySinh, string gioiTinh, string sdt)
        {
            Model.EF.hoc_sinh hs = dbContext.hoc_sinh.Find(Const.userID);

            hs.ten = ten;
            hs.ngaySinh = DateTime.Parse(ngaySinh);
            hs.sdt = sdt;
            if(gioiTinh == "Nam")
            {
                hs.gioiTinh = 1;
            } else if (gioiTinh == "Nữ")
            {
                hs.gioiTinh = 0;
            } else
            {
                return false;
            }

            dbContext.SaveChanges();
            return true;
            
        }
    }
}
