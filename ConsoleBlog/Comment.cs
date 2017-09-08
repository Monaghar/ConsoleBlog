﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Comment : IComment
    {
        public string Body { get; set; }
        public string SignatureBlock {get; set;}
        public DateTime dateTime { get; set; }
        public DateTime EditTime {get; set;}
        public List<Comment> CommentChain {get; set;}

        public Comment() { }

        public Comment(string body, string signature)
        {
            if(!string.IsNullOrEmpty(body) && !string.IsNullOrEmpty(signature))
            {
                Body = body;
                SignatureBlock = signature;
                this.dateTime = DateTime.Now;
                CommentChain = new List<Comment>();
            }
            else{throw new ArgumentNullException("Yo your Comment params are null fix em");}
        }
        
         public Comment(string body)
        {
            if(!string.IsNullOrEmpty(body))
            {
                Body = body;
                this.dateTime = DateTime.Now;
                CommentChain = new List<Comment>();
            }
            else{throw new ArgumentNullException("Yo your Comment params are null fix em");}
        }
    }
}
