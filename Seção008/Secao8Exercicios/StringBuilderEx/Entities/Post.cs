using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx.Entities
{
    public class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post()
        {

        }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void removeComment(Comment comment){
            Comments.Remove(comment);
        }

        override public string ToString(){
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes + " Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mmss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach(Comment c in Comments){
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }
    }
}