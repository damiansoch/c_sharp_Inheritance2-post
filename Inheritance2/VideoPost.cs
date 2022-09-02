using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Inheritance2
{
    internal class VideoPost : Post
    {
        public VideoPost()
        { }

        public VideoPost(string title, string sendByUsername, string videoURL, float lenght, bool isPublic)
        {
            ID = GetNextID();
            VideoURL = videoURL;
            Lenght = lenght;
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, - by {2}, URL - {3}, lenght: {4} ", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Lenght);
        }

        public void Play()
        {


        }
        public void Stop()
        {

        }



        public string VideoURL { get; set; }
        public float Lenght { get; set; }


    }
}
