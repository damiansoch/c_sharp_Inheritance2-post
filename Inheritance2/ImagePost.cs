using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        // constructor
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //inherited
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
            //own property
            ImageURL = imageURL;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2} URL - {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }

    }
}
