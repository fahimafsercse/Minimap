using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;

namespace Minimap.Core.Services
{
    public class UserService:IUserService
    {
        private DataContext context;
        public UserService() { this.context = new DataContext(); }

        //Add
        public int AddUser(User user)
        {
            this.context.Users.Add(user);
            return this.context.SaveChanges();
        }       
        //Update
        public int EditUser(User user)
        {
            User userToUpdate = this.context.Users.SingleOrDefault(d => d.UserId == user.UserId);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.MobileNo = user.MobileNo;
            userToUpdate.Username = user.Username;
            userToUpdate.Password = user.Password;
            userToUpdate.Email = user.Email;
            userToUpdate.Gender = user.Gender;
            return this.context.SaveChanges();
        } 
        public  string Deactivate(int id)
        {
            User userToDeactive = this.context.Users.SingleOrDefault(d => d.UserId == id);
            if (userToDeactive.IsValid)
            {
                userToDeactive.IsValid = false;
                this.context.SaveChanges();
                return "Your Account Is Successfully Deactivated";
            }
            else
            {
                return "Your Account is Currently Deactivated";
            }
            
        }

        //Delete
        public int DeleteAccount(int id)
        {
            User userToDelete = this.context.Users.SingleOrDefault(d => d.UserId == id);
            this.context.Users.Remove(userToDelete);
            return this.context.SaveChanges();
        }            
        //Get
        public User GetById(int id)
        {
            return this.context.Users.SingleOrDefault(d => d.UserId == id);
        }
        public User GetByUsername(string txt)
        {
            return this.context.Users.SingleOrDefault(d => d.Username == txt);
        }
        public User GetByName(string txt)
        {
              return this.context.Users.SingleOrDefault(d => d.FirstName ==txt );
        }
        public List<User> GetAllUser()
        {
            return this.context.Users.ToList();
        }
    }
}