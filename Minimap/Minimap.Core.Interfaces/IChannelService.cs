using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Interfaces
{
    public interface IChannelService
    {
         int CreateChannel(Channel channel);
         int DeleteChannel(Channel channel);
         int EditChannel(Channel channel);


         /*List<Channel> GetMyChannels();
         List<Channel> GetAllChannels();
         List<Channel> GetSubscribedChannels();*/


    }
}