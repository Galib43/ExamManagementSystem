using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
   public class UserAccountManager
    {
       UserAccountRepository _userAccountRepository=new UserAccountRepository();


       //login register Add
       public UserAcount Add(UserAcount userAcount)
       {
           return _userAccountRepository.Add(userAcount);
       }

       //login

       public UserAcount Login(UserAcount userAcount)
       {
           return _userAccountRepository.Login(userAcount);
       }

       //GetAll Register
       public List<UserAcount> GetAll()
       {
           return _userAccountRepository.GetAll();
       } 
    }
}
