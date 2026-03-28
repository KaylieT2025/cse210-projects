using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //Video video = new Video();

        //Videos
        Video video1 = new Video("Programming", "Penny", 300);
        Video video2 = new Video("Animation", "Selvester Stone", 900);
        Video video3 = new Video("Dress Making", "Kimmy", 750);

        //Comments for video1
        video1.AddComments(new Comment("Mary Anne", "Good information"));
        video1.AddComments(new Comment("JJ327", "Very helpful!"));
        video1.AddComments(new Comment("Daniel", "Can you do a video on encapulation next?"));

        //Comments for video2
        video2.AddComments(new Comment("Jack", "This is very informative"));
        video2.AddComments(new Comment("Lucy", "What programs do you use?"));
        video2.AddComments(new Comment("Mira4567zzy", "Nice modeling."));

        //Comments for video3
        video3.AddComments(new Comment("Hailey", "I love it!"));
        video3.AddComments(new Comment("Matt", "Where do I get that fabric?"));
        video3.AddComments(new Comment("Ben", "How do I get them template?"));

        //Video list
        List<Video> videos = new List<Video>{

            video1, video2, video3
        };

        //Display
        foreach (Video video in videos)
        {

          Console.WriteLine(video.GetDisplayText());
          Console.WriteLine($"Total of comments: {video.NumberOfComments()}");

          foreach (Comment comment in video.GetComments())
          {
            Console.WriteLine(comment.GetDisplayText());
          }  
        }
    }
}