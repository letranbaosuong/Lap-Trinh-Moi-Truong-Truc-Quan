using DbCrudContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToPostgreSQLDemo.Daos
{
    interface IDao
    {
        List<Crud> layTatCaDanhSach();
        int dem();
        void them(string firstName,string lastName,string gender);
        void sua(int id, string firstName, string lastName, string gender);
        void xoa(int id);
        List<Crud> timKiem(string tuKhoa);
    }
}
