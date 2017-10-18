using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public static class Poaster
    {
        public static Comment CreateComment(Author author, Comment comment, string body)
        {
            if (author.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                author.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(comment.SignatureBlock))
                {
                    myComment.SignatureBlock = comment.SignatureBlock;
                }
                return myComment;
            }
            return null;
        }

        public static Comment CreateComment(Author author, Post post, string body)
        {
            if (author.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                author.CommentHistory.Add(myComment);
                post.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(post.SignatureBlock))
                {
                    myComment.SignatureBlock = post.SignatureBlock;
                }
                return myComment;
            }
            return null;
        }

        //public static void CreateComment(Author author, Comment comment, string body, string quote)
        //{
        //    if (author.IsLoggedIn)
        //    {
        //        Comment myComment = new Comment(body);
        //        myComment.Body = string.Quotes(quote) + myComment.Body;
        //        author.CommentHistory.Add(myComment);
        //        comment.CommentChain.Add(myComment);
        //        if (!string.IsNullOrEmpty(author.Signature))
        //        {
        //            myComment.SignatureBlock = author.Signature;
        //        }
        //    }
        //}

        //public static void CreateComment(Author author, Post post, string body, string quote)
        //{
        //    if (author.IsLoggedIn)
        //    {
        //        Comment myComment = new Comment(body);
        //        myComment.Body = string.Quotes(quote) + myComment.Body;
        //        author.CommentHistory.Add(myComment);
        //        post.CommentChain.Add(myComment);
        //        if (!string.IsNullOrEmpty(author.Signature))
        //        {
        //            myComment.SignatureBlock = author.Signature;
        //        }
        //    }
        //}
    }
}