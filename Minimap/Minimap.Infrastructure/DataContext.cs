using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Minimap.Infrastructure
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Marker> Markers { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Subscription> Subsriptions { get; set; }
        public DbSet<Notification> Notifications{ get; set; }
        public DbSet<UserType> Usertypes { get; set; }
        public DbSet<ChannelType> Channeltypes { get; set; }
        public DbSet<MarkerChannel> MarkerChannels { get; set; }

    }
}