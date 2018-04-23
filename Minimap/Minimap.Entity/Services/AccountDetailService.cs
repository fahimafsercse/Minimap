using Minimap.Entity.IServices;
using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Services
{
    public class AccountDetailService:IAccountDetailService
    {
        public int Add(AccountDetail accountDetail)
        {
            return 1;
        }
        public int Remove(string id)
        {
            return 1;
        }
        public int Edit(AccountDetail accountDetail)
        {
            return 1;
        }
        public List<AccountDetail> GetAllSortedByUserName()
        {

        }
        public List<AccountDetail> GetAll()
        {

        }


        public int GetTotalSubscribe(string username)
        {

        }
        public int GetTotalChannel(string username)
        {

        }
        public int GetTotalMarker(string username)
        {

        }
        //public AccountDetail GetByUsernamePassword(string username, string password);
        // public List<string> GetUserNameList();
        //int checkValidUser(string dept, string email);
        // string ValidUserPass(string userName);

    }
}