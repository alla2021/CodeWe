using System;

namespace CodeWe_Channel
{
    public class Channel
    {
        private string channelName;
        private int channelID;
        private string imgAvatar;
        private string channelUrl;

        protected int subscribersCount;

        Random rnd;

        public Channel(string ChannelName, string ChannelUrl) {
            this.rnd = new Random();
            this.channelID = ChannelID;
            this.channelName = ChannelName;
            this.imgAvatar = ImgAvatar;
            this.channelUrl = ChannelUrl;
        }

        public string ChannelName
        {
            get { return this.channelName; }
            set { this.channelName = value; }
        }
        public string ImgAvatar
        {
            get { return this.imgAvatar; }
            set { this.imgAvatar = value; }
        }
        public string ChannelUrl
        {
            get { return this.channelUrl; }
            set { this.channelUrl = value; }
        }

        public int ChannelID
        {
            get { return this.channelID; }
            set { this.channelID = rnd.Next(1000000); }
        }

        public int addSubscriber()
        {
            subscribersCount++;
            return subscribersCount;
        }

        public int removeSubscriber()
        {
            subscribersCount--;
            return subscribersCount;
        }

    }
}
