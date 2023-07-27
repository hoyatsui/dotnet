using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectsLayer;
namespace DataAccessLayer
{
    public class UserDAL
    {
        private UserDBEntities objUserDBEntities;


        public UserDAL()
        {
            objUserDBEntities = new UserDBEntities();
        }

        public CustomBO AddUser(UserBO objUserBo)
        {
            CustomBO objCustomBo = new CustomBO();
            User objUser = new User()
            {
                EmailAddress = objUserBo.EmailAddress,
                UserName = objUserBo.UserName,
                Password = objUserBo.Password
            };
            objUserDBEntities.User.Add(objUser);
            //try
            //{
            int returnValue = objUserDBEntities.SaveChanges();

            if (returnValue > 0)
            {
                objCustomBo.CustomMessage = "User Added Successfully";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            else
            {
                objCustomBo.CustomMessage = "User Not Added Successfully";
                objCustomBo.CustomMessageNumber = returnValue;
            }
            //}
            //catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //{
            //    Exception raise = dbEx;
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            string message = string.Format("{0}:{1}",
            //                validationErrors.Entry.Entity.ToString(),
            //                validationError.ErrorMessage);
            //            // raise a new exception nesting
            //            // the current instance as InnerException
            //            raise = new InvalidOperationException(message, raise);
            //        }
            //    }
            //    throw raise;
            //}


            return objCustomBo;
        }


    }
}
