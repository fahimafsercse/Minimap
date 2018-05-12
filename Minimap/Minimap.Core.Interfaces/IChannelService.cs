using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimap.Core.Interfaces
{
    public interface IChannelService
    {
        void AddChannel(Channel channel, List<MarkerChannel> markerList);
        void AddChannel(Channel channel);
        void EditChannel(Channel channel, List<MarkerChannel> markers);     
        int DeleteChannelById(int Id);
        List<Channel> GetMyChannels(int id);
        Channel GetChannel(int id);
        List<MarkerChannel> GetChannelMarkers(int id);
        void DeleteChannel(int id);
        List<Channel> GetAllChannel();
        void SubscribeChannel(int channelId, int userid);
        List<Subscription> GetSubList();
        void UnsubscribeChannel(int chId, int userId);

        /*List<Channel> GetAllChannel();
        Channel GetChannelById(int Id);

        List<Channel> SearchMySubscribe(string txt);
        List<Channel> SearchChannelByName(string txt);
        List<Channel> SearchChannelByUsername(string txt);

        void SubscribeChannel(int Id);
        void UnSubscribeChannel(int Id);
        void AddRating(Channel channel,int val);


        void ApproveChannel(Channel channel);*/


    }
}
