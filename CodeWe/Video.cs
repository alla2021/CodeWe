using CodeWe;
using CodeWe_Channel;
using System;
using System.Collections.Generic;

namespace CodeWe_video
{
    class Video
    {
        Random rnd;
        private int id;
        private string srcVideo = "";
        private string title = "";
        private string discription;

        private bool isTag;
        private List<string> tagsList; 

        private bool playlist = false; 
        private int playlistId = 0;

        private int like = 0;
        private int dislike = 0;

        private int views;
       
        
        DateTime createdAt;

        List<CommentsList> commentsList;

        public Video(string SrcVideo,string Title, string Discription, bool isTag = false, bool playlist = false) 
        {
            if (isTag) {
                tagsList=new List<string>();
            }
            if (playlist)
            {
                this.playlistId = PlaylistId;
            }
            this.rnd = new Random();
            this.Id = id;
            this.createdAt = DateTime.Now;
            this.srcVideo = SrcVideo;
            this.title = Title;
            this.discription = Discription;
        }
        public int Id
        {
            get { return id; }
            set { id = rnd.Next(1000000); }
        }

        public string SrcVideo
        {
            get { return this.srcVideo; }
            set { this.srcVideo = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public int PlaylistId
        {
            get { return this.playlistId; }
            set { this.playlistId = value; }
        }
        public string Discription
        {
            get { return this.discription; }
            set { this.discription = value; }
        }
        public DateTime getTime()
        {
            return createdAt;
        }

        public long getTimestamp()
        {
            return (long)createdAt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public List<string> addTag(string tag)
        {
            tagsList.Add(tag);
            return tagsList;
        }

        public List<string> getTagsList()
        {
            return tagsList;
        }

        public int addLike()
        {
            this.like++;
            return this.like;
        }

        public int removeLike()
        {
            this.like--;
            return this.like;
        }

        public int addDislike()
        {
            this.dislike++;
            return this.dislike;
        }

        public int removeDislike()
        {
            this.dislike--;
            return this.dislike;
        }

        public int addViews()
        {
            this.views++;
            return this.views;
        }
    }
}

