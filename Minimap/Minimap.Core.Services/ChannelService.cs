using Minimap.Core.Entities;
using Minimap.Core.Interfaces;
using Minimap.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minimap.Core.Services
{
    public class ChannelService: IChannelService
    {
        private DataContext context;
        public ChannelService() { this.context = new DataContext(); }


        public void AddChannel(Channel channel)
        {
            //this.context.Database.SqlQuery("");
            this.context.Channels.Add(channel);
            this.context.SaveChanges();
        }

        public void AddChannel(Channel channel, List<MarkerChannel> markerList)
        {
            this.context.Channels.Add(channel);
            this.context.SaveChanges();           
            foreach(var markers in markerList)
            {
                markers.ChannelId = channel.ChannelId;                
                this.context.MarkerChannels.Add(markers);
                this.context.SaveChanges();
            }           
        }

        public void EditChannel(Channel channel,List<MarkerChannel> markerChannelList)
        {
            Channel channelToUpdate = this.context.Channels.SingleOrDefault(d => d.ChannelId == channel.ChannelId);
            channelToUpdate.ChannelName = channel.ChannelName;
            channelToUpdate.ChannelDescription = channel.ChannelDescription;              
            this.context.SaveChanges();


            List<MarkerChannel> mChannelList = this.context.MarkerChannels.ToList();
            foreach(var m in mChannelList)
            {
                if (m.ChannelId == channel.ChannelId)
                {
                    this.context.MarkerChannels.Remove(m);
                    this.context.SaveChanges();
                }   
            }
            foreach (var m in markerChannelList)
            {
                m.ChannelId = channel.ChannelId;
                this.context.MarkerChannels.Add(m);
                this.context.SaveChanges();
            }
        }

        public int DeleteChannelById(int id)
        {
            Channel channel = this.context.Channels.SingleOrDefault(d => d.ChannelId == id);
            this.context.Channels.Remove(channel);
            return this.context.SaveChanges();
        }

        public List<Channel> GetMyChannels (int  id)
        {
            List<Channel> channels = this.context.Channels.ToList();
            List<Channel> MyChannels = new List<Channel>();
            foreach (var ch in channels)
            {
                if (ch.UserId == id)
                {
                    MyChannels.Add(ch);
                }
            }
            return MyChannels;
        }

        public Channel GetChannel(int id)
        {
            Channel channel = this.context.Channels.SingleOrDefault(d => d.ChannelId == id);
            return channel;
        }

        public List<MarkerChannel> GetChannelMarkers(int id)
        {
            List<MarkerChannel> mChannel = this.context.MarkerChannels.ToList();
            List<MarkerChannel> markersChannel = new List<MarkerChannel>();
            foreach (var chd in mChannel)
            {
                if (chd.MarkerId == id)
                {
                    markersChannel.Add(chd);
                }
            }
            return markersChannel;
        }

        public void DeleteChannel(int id)
        {
            Channel ch = this.context.Channels.SingleOrDefault(d => d.ChannelId == id);
            List<MarkerChannel> mc = this.context.MarkerChannels.ToList();
            if (mc != null)
            {
                foreach (var m in mc)
                {
                    if (m.ChannelId == id)
                    {
                        this.context.MarkerChannels.Remove(m);
                        this.context.SaveChanges();
                    }
                }
                this.context.Channels.Remove(ch);
                
            }
            this.context.SaveChanges();
        }


        public List<Channel> GetAllChannel()
        {
            return this.context.Channels.ToList();
        }


        public void SubscribeChannel(int channelId,int userid)
        {
            Subscription subs = new Subscription();
            subs.ChannelId = channelId;
            subs.UserId = userid;
            this.context.Subsriptions.Add(subs);
            this.context.SaveChanges();
            
        }
        public List<Subscription> GetSubList()
        {
            List<Subscription> subList = this.context.Subsriptions.ToList();
            return subList;
        }
        public void UnsubscribeChannel(int chId,int userId)
        {
            List<Subscription> subList = this.context.Subsriptions.ToList();
            foreach(var sub in subList)
            {
                if(sub.UserId == userId && sub.ChannelId == chId)
                {
                    this.context.Subsriptions.Remove(sub);
                    this.context.SaveChanges();
                    break;
                }
            }
        }

        /* 
         public Channel GetChannelById(int Id)
         {

         }

         public List<Channel> SearchMySubscribe(string txt)
         {

         }
         public List<Channel> SearchChannelByName(string txt)
         {

         }
         public List<Channel> SearchChannelByUsername(string txt)
         {

         }

         public void SubscribeChannel(int Id)
         {

         }
         public void UnSubscribeChannel(int Id)
         {

         }
         public void AddRating(Channel channel, int val)
         {

         }


         public void ApproveChannel(Channel channel)
         {

         }*/
    }
}