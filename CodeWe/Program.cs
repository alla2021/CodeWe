
using CodeWe_Channel;
using CodeWe_video;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel obj = new Channel("Comedy Bites", "https://www.youtube.com/@ComedyBites");

            Video video1 = new Video(obj.ChannelID, "https://www.youtube.com/watch?v=iFselLmOXI8",
                "captain holt being a badass for ten minutes straight | Brooklyn Nine-Nine | Comedy Bites", 
                "Here's some of our favourite Captain Holt BADASS moments! Whether he's fighting off muggers, " +
                "rescuing Jake/Cheddar or embracing Velvet Thunder, it's here. Did we miss your favourite badass Holt" +
                " moment? Let us know in the comments!", true);
            video1.addTag("#Brooklyn9-9");
            video1.addTag("#Comedy");


            string relPath = "file.txt";
            using (FileStream fS = new FileStream(relPath, FileMode.Append))
            {
                using (StreamWriter sW = new StreamWriter(fS))
                {
                    sW.WriteLine("ChannelId: " + video1.ChannelId);
                    sW.WriteLine("Id: " + video1.Id);
                    sW.WriteLine("Time: " + video1.getTime());
                    sW.WriteLine("src: "+video1.SrcVideo);
                    sW.WriteLine("Title: " + video1.Title);
                    sW.WriteLine(video1.Discription);
                    foreach (string tag in video1.getTagsList())
                    {
                        sW.Write(tag + " ");
                    }
                }
            }
        }
    }
}
