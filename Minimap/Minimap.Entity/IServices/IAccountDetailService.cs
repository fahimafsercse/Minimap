using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.IServices
{
    public interface IAccountDetailService
    {
        int Add(AccountDetail account);
        int Delete(string userName);
        int Edit(AccountDetail account);
        List<AccountDetail> GetAllSortedByUserName();
        List<AccountDetail> GetAll();



        int GetTotalSubscribe(string username);
        int GetTotalChannel(string username);
        int GetTotalMarker(string username);

        //AccountDetail GetByUsernamePassword(string username, string password);
        // List<string> GetUserNameList();//ADMIN
        // int checkValidUser(string dept, string email);
        //string ValidUserPass(string userName);
    }
}