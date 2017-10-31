using System;
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
            if (author.CommentHistory.Contains(comment) && !(comment == null) && !(string.IsNullOrEmpty(newBody)))
            {
                comment.Body = newBody;
                comment.EditTime = DateTime.Now;
            }
        }

        //true is upvote, false is downvote. not sure how else to do that?
        public static void RateComment(Author author, Comment comment, bool? rate)
        {
            if (!author.HasRated.ContainsKey(comment) && !(comment == null) && !(rate == null))
            {
                if ((bool)rate) { comment.Rating += 1; }
                else if ((bool)!rate) { comment.Rating -= 1; }
                author.HasRated.Add(comment, true);
            }
        }

        //checks if author has already reported the comment 
        public static void ReportComment(Author author, Comment comment, bool? reported)
        {
            if ((bool)reported && !(author.HasReported.ContainsKey(comment)))
            {
                Console.WriteLine("{0} reported a comment, that's messed up!", author.Name);
                author.HasReported.Add(comment, true);
            }
            if ((author is Admin) && (!(bool)reported))
            {
                author.HasReported[comment] = false;
            }
        }

        public static Comment CreateComment(Author author, Comment comment, string body)
        {
            if (Verify.VerifyComment(author, comment, body))
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
            if (Verify.VerifyComment(author, post, body))
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

        public static Comment CreateComment(Author author, Comment comment, string body, string quote)
        {
            if (Verify.VerifyComment(author, comment, body, quote))
            {
                Comment myComment = new Comment(body);
                myComment.Body = quote.Quotes() + myComment.Body;
                author.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(author.Signature))
                {
                    myComment.SignatureBlock = author.Signature;
                }
                return myComment;
            }
            return null;
        }

        public static Comment CreateComment(Author author, Post post, string body, string quote)
        {
            if (Verify.VerifyComment(author, post, body, quote))
            {
                Comment myComment = new Comment(body);
                myComment.Body = quote.Quotes() + myComment.Body;
                author.CommentHistory.Add(myComment);
                post.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(author.Signature))
                {
                    myComment.SignatureBlock = author.Signature;
                }
                return myComment;
            }
            return null;
        }

        public static void CreatePost(Admin admin, string title, string body)
        {
            if (Verify.VerifyPost(admin, title, body))
            {
                Post myPost = new Post(title, body);
                admin.PostHistory.Add(myPost);
                Blog.Posts.Add(myPost);
            }
        }
    }
}