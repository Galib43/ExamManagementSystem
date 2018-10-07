using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContexts;
using Models;

namespace Repository
{
   public class UserAccountRepository
    {
       ExamManagementDbContext db=new ExamManagementDbContext();

       //Add Register
       public UserAcount Add(UserAcount userAcount)
       {
           db.UserAcounts.Add(userAcount);
           db.SaveChanges();
           return userAcount;
       }
       //login user
       public UserAcount Login(UserAcount userAcount)
       {
           db.UserAcounts.FirstOrDefault(u => u.UserName == userAcount.UserName && u.Password == userAcount.Password);
            db.SaveChanges();
           return userAcount;
       }

       //getAll Useraccount
       public List<UserAcount> GetAll()
       {

           List<UserAcount> userAcounts = db.UserAcounts.ToList();
           return userAcounts;
       }
    }
}
