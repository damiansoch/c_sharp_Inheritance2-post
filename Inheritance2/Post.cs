using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Post
    {
        private static int currentPostId;

        //  ----------------------------------props
        //protected means that only this class or the child classes can use it

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class doesn't invoke a base constructor explicitly, the default constructor is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "damiansoch";
        }

        //instance constructor 
        public Post(string title, string sendByUsername, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        //method to get the ID
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //updating the post
        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        //overwriting System.Object.ToString
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
