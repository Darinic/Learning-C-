using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Post
    {
        private static int currentPostId;

        //properties

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }

        public bool IsPublic { get; set; }

        //Default constructor. if a derived class does not invoke a base-class constructor explicitly
        //the default constructor is called implicitly

        public Post()
        {
            ID = 0;
            Title = "My first Post";
            IsPublic = true;
            SendByUsername = "Daniil Arinic";
        }

        public Post(string title, bool isPublic, string sendByUsername) 
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
