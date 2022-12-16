﻿using System;
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
        public bool CreateClass(Model.EF.lop_hoc clas)
        {
            try
            {
                dbContext.lop_hoc.Add(clas);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteClass(Model.EF.lop_hoc clas)
        {
            try
            {
                dbContext.lop_hoc.Remove(clas);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateClass(Model.EF.lop_hoc clas)
        {
            try
            {
                dbContext.lop_hoc.AddOrUpdate(clas);
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
