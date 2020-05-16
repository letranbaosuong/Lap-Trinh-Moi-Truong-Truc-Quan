using DbCrudContext;
using LinQToPostgreSQLDemo.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQToPostgreSQLDemo.DaoImpls
{
    class DaoImpl : IDao
    {
        private DbCrudDataContext _db = new DbCrudDataContext();

        public int dem()
        {
            return _db.Cruds.Count();
        }

        public List<Crud> layTatCaDanhSach()
        {
            var danhSach = (from crud in _db.Cruds
                 orderby crud.Id
                 select crud).ToList<Crud>();

            return danhSach;
        }

        public void sua(int id, string firstName, string lastName, string gender)
        {
            var up_item = (from d in _db.Cruds
                           where d.Id == id
                           select d).FirstOrDefault();
            if (up_item != null)
            {
                up_item.FirstName = firstName;
                up_item.LastName = lastName;
                up_item.Gender = gender;

                _db.SubmitChanges();
                MessageBox.Show("Đã cập nhật thành công ID = " + id, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void them(string firstName, string lastName, string gender)
        {
            Crud newCrud = new Crud();
            newCrud.FirstName = firstName;
            newCrud.LastName = lastName;
            newCrud.Gender = gender;
            _db.Cruds.InsertOnSubmit(newCrud);
            _db.SubmitChanges();
            MessageBox.Show("Đã thêm thành công.", "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Crud> timKiem(string tuKhoa)
        {
            var query = _db.Cruds.Where(c => /*c.Id == Int64.Parse(txtSearch.Text.Trim())
                                                ||*/ c.LastName.Contains(tuKhoa)
                                                || c.FirstName.Contains(tuKhoa)
                                                || c.Gender.Contains(tuKhoa))
                                                .OrderBy(c => c.Id);
            return query.ToList<Crud>();
        }

        public void xoa(int id)
        {
            var del_item = (from d in _db.Cruds
                            where d.Id == id
                            select d).FirstOrDefault();
            if (del_item != null)
            {
                _db.Cruds.DeleteOnSubmit(del_item);
                _db.SubmitChanges();
                MessageBox.Show("Đã xóa thành công ID = " + id, "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
