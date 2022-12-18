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
        public List<Model.EF.hoc_sinh> SearchStudent(string maHs, string ten, int khoa, string ngaySinh, int gioiTinh, string sdt, string trangThai)
        {
            if(ngaySinh != "")
            {
                var date = DateTime.Parse(ngaySinh);
            return dbContext.hoc_sinh
                .Where(db => 
                    (maHs == "" || db.ma_hs == maHs)
                    &&(ten == "" || db.ten == ten)
                    &&(khoa == -1 || db.khoa == khoa)
                    &&(ngaySinh == "" || db.ngaySinh == date)
                    &&(gioiTinh == -1 || db.gioiTinh == gioiTinh)
                    &&(sdt == "" || db.sdt == sdt)
                    &&(trangThai == "" || db.trang_thai == trangThai))
                .ToList();
            }
            return dbContext.hoc_sinh
                .Where(db =>
                    (maHs == "" || db.ma_hs == maHs)
                    && (ten == "" || db.ten == ten)
                    && (khoa == -1 || db.khoa == khoa)
                    && (gioiTinh == -1 || db.gioiTinh == gioiTinh)
                    && (sdt == "" || db.sdt == sdt)
                    && (trangThai == "" || db.trang_thai == trangThai))
                .ToList();
        }
        public bool CreateStudent(string maHs, string ten, string pass, string khoa, string ngaySinh, string gioiTinh, string sdt, string trangThai)
        {
            try
            {
                
                Model.EF.hoc_sinh student = new Model.EF.hoc_sinh()
                {
                    ma_hs = maHs,
                    ten = ten,
                    pass = pass,
                    khoa = int.Parse(khoa),
                    ngaySinh = DateTime.Parse(ngaySinh),
                    sdt = sdt,
                    trang_thai = trangThai
                };
                if(gioiTinh == "Nam")
                {
                    student.gioiTinh = 1;
                }
                else
                {
                    student.gioiTinh = 0;
                }
                dbContext.hoc_sinh.Add(student);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteStudent(string maHs)
        {
            try
            {
                var hs = dbContext.hoc_sinh.Find(maHs);
                dbContext.hoc_sinh.Remove(hs);
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
        public bool AdminUpdateStudent(string maHs, string ten,string pass, string khoa, string ngaySinh, string gioiTinh, string sdt, string trangThai)
        {
            Model.EF.hoc_sinh hs = dbContext.hoc_sinh.Find(maHs);
            hs.khoa = int.Parse(khoa);
            hs.pass = pass;
            hs.ten = ten;
            hs.ngaySinh = DateTime.Parse(ngaySinh);
            hs.sdt = sdt;
            hs.trang_thai = trangThai;
            if (gioiTinh == "Nam")
            {
                hs.gioiTinh = 1;
            }
            else if (gioiTinh == "Nữ")
            {
                hs.gioiTinh = 0;
            }
            else
            {
                return false;
            }

            dbContext.SaveChanges();
            return true;
        }
    }
}
