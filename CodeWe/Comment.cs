using System;

namespace code_Comment
{
    public class Comment
    {
        private int id = 0;
        private int ownerId = 0;
        private int storeId = 0;
        private string ownerName = "";
        private int rating = 0;
        private string textBlock1 = "";
        private string textBlock2 = "";
        private string textBlock3 = "";

        private int like = 0;
        private int dislike = 0;

       // List<SubComment> subCommentList;

        DateTime createdAt;
        DateTime updatedAt;

        public Comment(string textBlock1, int rating)
        {
            if (rating > 5 || rating < 0)
                throw new Exception("Error invalid value");

            this.textBlock1 = textBlock1;

            createdAt = DateTime.Now.AddDays(-4);
        }

        public int addLike()
        {
            like++;
            return like;
        }

        public int removeLike()
        {
            like--;
            return like;
        }

        public long getTimestamp()
        {
            return (long)createdAt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}