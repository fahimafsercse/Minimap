using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service
{
    public class AccountDetailService: IAccountDetailService
    {

        public int AddAccount(AccountDetail accountDetail)
        {
            string query = string.Format("Insert into AccountDetail(Username,Firstname,Lastname,Email,Gender,Usertype,Joindate,Totalmarker,Totalchannel,Totalsubscription,Mobileno) VALUES('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", 
                accountDetail.Username,accountDetail.FirstName,accountDetail.LastName,accountDetail.Email,accountDetail.Gender,accountDetail.UserTypeId,accountDetail.JoinDate,
                accountDetail.TotalMarker,accountDetail.TotalChaneel,accountDetail.TotalSubscription,accountDetail.MobileNo);
             return DataAccess.ExecuteQuery(query);
        }

        public int DeleteAccount(string username)
        {
            string query = string.Format("DELETE FROM AccountDetail WHERE Username ='{0}'",username);
            return DataAccess.ExecuteQuery(query);
            
        }
        /*public int Edit(AccountDetail accountDetail)
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

        }*/
        //public AccountDetail GetByUsernamePassword(string username, string password);
        // public List<string> GetUserNameList();
        //int checkValidUser(string dept, string email);
        // string ValidUserPass(string userName);
    }
}