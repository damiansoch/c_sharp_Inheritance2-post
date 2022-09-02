using System;

using System.Threading;//timer

namespace Inheritance2
{
    internal class VideoPost : Post
    {
        public VideoPost()
        { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            ID = GetNextID();
            VideoURL = videoURL;
            Length = length;
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, - by {2}, URL - {3}, length: {4}s ", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Length);
        }

        public void Play()
        {
            if (!isPlaing)
            {
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);//check how to build
                isPlaing = true;
            }


        }
        public void Stop()
        {
            if (isPlaing)
            {
                Console.WriteLine("Stopped @ {0} sec", curDuration);
                curDuration = 0;
                timer.Dispose();
                isPlaing = false;
            }

        }
        //private -> only this class can call it
        private void TimerCallback(Object o)
        {
            if (curDuration < Length)
            {
                curDuration++;
                Console.Write("Video @ {0} sec", curDuration);
                Console.Write("\r");
                GC.Collect(); //garbage collector 
            }
            else
            {
                Stop();
            }
        }

        //member fields for timer
        protected bool isPlaing = false;
        protected int curDuration = 0;
        Timer timer;

        //prop
        protected string VideoURL { get; set; }
        protected int Length { get; set; }




    }
}
