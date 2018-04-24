using Minimap.Core.Entities;
using Minimap.Core.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service
{
    public class AccountDetailService: IAccountDetailService
    {
        public int Add(AccountDetail accountDetail)
        {
            return 1;
        }
        public int Delete(string id)
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