using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    #region Author Verifications
    public static class Verify
    {

        public static bool VerifyAuthorIsLogged(Author author)
        {
            try { return author.IsLoggedIn; }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool VerifyAuthorCanEdit(Author author, Comment comment)
        {
            try { return author.CommentHistory.Contains(comment); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool VerifyAuthorCanRate(Author author, Comment comment)
        {
            try { return !(author.HasRated.ContainsKey(comment)); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool VerifyAuthorCanReport(Author author, Comment comment)
        {
            try { return !(author.HasReported.ContainsKey(comment)); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion

        #region Comment Verifications
        public static bool VerifyComment(Author author, Comment comment, string body)
        {
            if (author.IsLoggedIn && !(comment == null) && !(string.IsNullOrWhiteSpace(body)))
            {
                return true;
            }
            else return false;
        }

        public static bool VerifyComment(Author author, Post post, string body)
        {
            if (author.IsLoggedIn && !(post == null) && !(string.IsNullOrWhiteSpace(body)))
            {
                return true;
            }
            else return false;
        }

        public static bool VerifyComment(Author author, Comment comment, string body, string quote)
        {
            if (author.IsLoggedIn && !(comment == null) && !(string.IsNullOrWhiteSpace(body)) && !(string.IsNullOrWhiteSpace(quote)))
            {
                return true;
            }
            else return false;
        }

        public static bool VerifyComment(Author author, Post post, string body, string quote)
        {
            if (author.IsLoggedIn && !(post == null) && !(string.IsNullOrWhiteSpace(body)) && !(string.IsNullOrWhiteSpace(quote)))
            {
                return true;
            }
            else return false;
        }
        #endregion

        #region Post Verifications
        public static bool VerifyPost(string title, string body)
        {
            if (!(string.IsNullOrWhiteSpace(title)) && !(string.IsNullOrWhiteSpace(body)))
            {
                return true;
            }
            else return false;
        }

        public static bool VerifyPost(Admin admin, string title, string body)
        {
            if (admin.IsLoggedIn && !(string.IsNullOrWhiteSpace(title)) && !(string.IsNullOrWhiteSpace(body)))
            {
                return true;
            }
            else return false;
        }

        #endregion
    }
}