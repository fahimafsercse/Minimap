using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Minimap.Core.Service
{
    public class AdminService:IAdminService
    {
        DbContext _context;

        public AdminService(DbContext context)
        {
            _context = context;
        }
        public IEnumerable<AccountDetail> GetAllUser()
        {
            throw new NotImplementedException();
        }
        /*public int DeleteChannel(Channel channel)
        {
            channel.ChannelMarkers
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Set<Student>().ToList();
        }

        public IEnumerable<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student student)
        {
            throw new NotImplementedException();
        }*/
    }
}