using Minimap.Entity.IServices;
using Minimap.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Entity.Services
{
    public class ChannelService: IChannelService
    {
        public int CreateChannel(Channel channel){
            return 1;
        }

        public int EditChannel(Channel channel){
            return 1;
        }

        public int DeleteChannel(Channel channel){
            return 1;
        }

        public List<Channel> GetMyChannels(){
            
        }

        public List<Channel> GetAllChannels(){

        }

        public List<Channel> GetSubscribedChannels(){  

        }
    }
}