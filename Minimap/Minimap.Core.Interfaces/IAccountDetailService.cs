using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service.Interfaces
{
    public interface IAccountDetailService
    {
        int Add(AccountDetail accountDetail);
        int Delete(string userName);
        int Edit(AccountDetail accountDetail);
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