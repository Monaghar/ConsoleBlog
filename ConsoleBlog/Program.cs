using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;


/*Please dont change namespace, Dcoder 
and class must not be public*/

//Compiler version 4.0, .NET Framework 4.5

namespace CodeSchoolBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Author Jeff = new Author("Jeff", "test.com", "pro blogger", "12345");
            //Blog myBlog = new Blog(Jeff, "Code School Blog", "Blogging Code School");
            //Post helloWorld = new Post(Jeff, "Hello World!", "Sup Nerds?!");
            //Comment firstComment = new Comment("Code School Rocks!", Jeff, helloWorld);
            //Console.WriteLine("Hello, " + Jeff.Name);
            //Console.WriteLine(Jeff.MyComments[0].Body);
            //Console.WriteLine(firstComment.Body);
            //Console.WriteLine(myBlog.Title);
            //Console.ReadLine();

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryan\Documents\Visual Studio 2017\Projects\ConsoleBlog\ConsoleBlog\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        Console.Write("u did it kiddo");
            //        connection.Close();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message); 
            //    }
            //}
            using (var db = new BlogContext())
            {
                string name = "Haagggaaarrr";
                string eMail = "HOR@DOR";
                string bio = "I got turned simple by my time traveling master";
                string password = "432221";

                var author = new Author(name, eMail, bio, password);

                db.Authors.Add(author);
                db.SaveChanges();

                var query = db.Authors.Select(p => p);

                Console.WriteLine("All Authors in the database");
                foreach(var item in query)
                {

                    Console.Write(item.Name);
                }

            }

            Console.ReadKey();

        }
    }
}