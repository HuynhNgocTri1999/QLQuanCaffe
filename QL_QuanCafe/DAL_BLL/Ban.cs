using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class Ban
    {
        QL_QuanCafeDataContext da = new QL_QuanCafeDataContext();
        public Ban()
        { }
        public List<BAN> getDSBan()
        {
             var b = da.BANs.ToList();
            return b;
        }
    }
}
