﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{

    public class GiaoVien
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public Model.EF.giao_vien GetTeacherByID(string maGv)
        {
            return dbContext.giao_vien.Single(b => b.ma_gv.Equals(maGv));
        }
        public bool CreateTeacher(string ma_gv, string ten, string ngay_sinh, string sdt, byte gioitinh, string pass)
        {
            try
            {
                Model.EF.giao_vien teacher = new Model.EF.giao_vien();
                teacher.ma_gv = ma_gv;
                teacher.ten = ten;
                teacher.sdt = sdt;
                teacher.gioiTinh = gioitinh;
                teacher.ngaySinh = DateTime.Parse(ngay_sinh);
                teacher.pass = pass;
                dbContext.giao_vien.Add(teacher);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Model.EF.giao_vien> GetTeacherList()
        {
            return dbContext.giao_vien.ToList();
        }
        public bool DeleteTeacher(string id)
        {
            try
            {
                Model.EF.giao_vien teacher = GetTeacherByID(id);
                dbContext.giao_vien.Remove(teacher);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateTeacher(string ma_gv, string ten, string ngay_sinh, string sdt, string gioitinh)
        {
            try
            {
                Model.EF.giao_vien gv = dbContext.giao_vien.Find(ma_gv);

                gv.ten = ten;

                if (sdt.Length == 10) { gv.sdt = sdt; }
                else { return false; }

                //Check hợp lệ ngày sinh
                try
                {
                    gv.ngaySinh = DateTime.Parse(ngay_sinh);
                }
                catch
                {
                    return false;
                }

                //Check giới tính
                if (gioitinh.Equals("Nữ")) { gv.gioiTinh = 0; }
                else
                if (gioitinh.Equals("Nam")) { gv.gioiTinh = 1; }
                else { return false; }

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangePassword(string ma_gv, string oldPass, string newPass, string confirmPass)
        {
            try
            {
                Model.EF.giao_vien gv = dbContext.giao_vien.Find(ma_gv);

                if (gv.pass.Equals(oldPass))
                {
                    if (newPass.Equals(confirmPass))
                    {
                        gv.pass = newPass;
                        dbContext.SaveChanges();
                        return true;
                    }
                    return false;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
