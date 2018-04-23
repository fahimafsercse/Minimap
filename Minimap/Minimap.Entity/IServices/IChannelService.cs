using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.IServices
{
    public class IChannelService
    {
         int CreateChannel(Channel channel);
         int DeleteChannel(Channel channel);
         int EditChannel(Channel channel);


         List<Channel> GetMyChannels();
         List<Channel> GetAllChannels();
         List<Channel> GetSubscribedChannels();


    }
}