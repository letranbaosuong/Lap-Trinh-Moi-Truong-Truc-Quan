using DbCrudContext;
using LinQToPostgreSQLDemo.DaoImpls;
using LinQToPostgreSQLDemo.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToPostgreSQLDemo.Services
{
    class Service
    {
        private IDao dao = new DaoImpl();

        public List<Crud> layTatCaDanhSach()
        {
            return dao.layTatCaDanhSach();
        }
        public int dem()
        {
            return dao.dem();
        }
        public void them(string firstName, string lastName, string gender)
        {
            dao.them(firstName, lastName, gender);
        }
        public void sua(int id, string firstName, string lastName, string gender)
        {
            dao.sua(id, firstName, lastName, gender);
        }
        public void xoa(int id)
        {
            dao.xoa(id);
        }
        public List<Crud> timKiem(string tuKhoa)
        {
            return dao.timKiem(tuKhoa);
        }
    }
}
