using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectsLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class UserBL
    {
        public CustomBO AddUser(UserBO objUserBO)
        {
            return new UserDAL().AddUser(objUserBO);
        }
    }
}
