using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas
{
    public class Comment
    {
        public int commentId { get; private set; }
        public int itemId { get; private set; }

        public int userId { get; private set; }

        public string text { get; private set; }

        public string date { get; private set; }

        public Comment(int commentId, int itemId, int userId, string text, string date)
        {
            this.commentId = commentId;
            this.itemId = itemId;
            this.userId = userId;
            this.text = text;
            this.date = date;
        }

    }
}
