using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MonHoc
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public List<Model.EF.mon_hoc> GetSubjectsList()
        {
            return dbContext.mon_hoc.ToList();
        }
        public Model.EF.mon_hoc GetSubjectsById(int maMonHoc)
        {
            return dbContext.mon_hoc.Single(b => b.ma_mon.Equals(maMonHoc));
        }
        public List<Model.EF.mon_hoc> SearchSubject(int maMonHoc, string tenMon)
        {
            return dbContext.mon_hoc
                .Where(db => (maMonHoc == -1 || db.ma_mon == maMonHoc) && (tenMon == "" || db.ten == tenMon))
                .ToList();
        }
        public bool CreateSubjects(string tenMonHoc)
        {
            try
            {
                var subject = new Model.EF.mon_hoc()
                {
                    ten = tenMonHoc
                };
                dbContext.mon_hoc.Add(subject);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteSubjects(int maMonHoc)
        {
            try
            {
                var subject = dbContext.mon_hoc.Find(maMonHoc);
                dbContext.mon_hoc.Remove(subject);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSubjects(int maMonHoc, string tenMonHoc)
        {
            try
            {
                var subject = dbContext.mon_hoc.Find(maMonHoc);
                subject.ten = tenMonHoc;
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
