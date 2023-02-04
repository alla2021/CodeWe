using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWe_Channel
{
    public class Channel
    {
        protected string chanalName;
        protected string chanalID;
        protected string imgAvatar;
        protected int subscribersCount;

        Random rnd;
        private int id;

        public Channel() {
            this.rnd = new Random();
            this.id = rnd.Next(100000000);
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
