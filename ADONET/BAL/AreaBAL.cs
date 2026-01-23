using ADONET.DAL;
using ADONET.Model;
using System.Collections.Generic;

namespace ADONET.BAL
{
    public class AreaBAL
    {
        AreaDAL dal = new AreaDAL();
        public List<AreaBEL> ReadAreaList() => dal.ReadAreaList();
    }
}