﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeSchoolBlog
{
    public static class Interact
    {
        public static void EditComment(Author author, Comment comment, string newBody)
        {
            if (author.CommentHistory.Contains(comment))
            {
                comment.Body = newBody;
                comment.EditTime = DateTime.Now;
            }
        }

        //true is upvote, false is downvote. not sure how else to do that?
        public static void RateComment(Author author, Comment comment, bool rate)
        {
            if (!author.HasRated.ContainsKey(comment))
            {
                if (rate) { comment.Rating += 1; }
                else if (!rate) { comment.Rating -= 1; }
                author.HasRated.Add(comment, true);
            }
        }

        //true is upvote, false is downvote. not sure how else to do that?
        public static void ReportComment(Author author, Comment comment, bool reported)
        {
            if (reported)
            {
                Console.WriteLine("{0} reported a comment, that's messed up!", author.Name);
                comment.IsReported = true;
            }
            if ((author is Admin) && (!reported))
            {
                comment.IsReported = false;
            }
        }
    }
}