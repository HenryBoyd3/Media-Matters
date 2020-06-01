using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class AlbumRepo : IAlbumRepo
    {
        //I feel that I could have used string writer or something like that to get all of the info 
        //for the lists in the program, I also feel like there are a lot of better ways I could have made
        //this program I just don't fully grasp them I know they are out there and that will be a goal for the summer
        //to learn more about how to be more efficaint with my code.
        public IEnumerable<Album> GetAlbums() =>
            new List<Album>
        {
            new Album{ title="Awake", artist="Tycho",
                image="~/images/Awake.png",
                note="I enjoy this album because it is instrumental and what I use to help get into " +
                "a study mindset. I try to use it when I want to write or work on school " +
                "work when it doesn’t involve watching a video. It also is not intrusive" +
                " on my thoughts but gets rid of background noise." },

            new Album{ title="Hollow knight “soundtrack”", artist="Christopher Larkin",
                image="~/images/HollowKnight.jpg",
                note="This is one of my favorite games and I enjoy all of the music from the game." +
                " It is a great background soundtrack that reminds me of my favorite" +
                " parts of the game. " },

            new Album{ title="Multiply", artist="Ed Sheeran",
                image="~/images/Ed.jpg",
                note="This album is one of a few albums my wife and I will listen to on road trips." +
                " It also has a lot of songs that reminds me of her." },

            new Album{ title="Ten", artist="Pearl Jam",
                image="~/images/Ten.jpg",
                note="I used to listen to and play this album a lot on the game Rock band with my" +
                " brother and close friend who I don't get to see much anymore, and when I" +
                " listen to this it reminds of when we would play together. " +
                "I also like the sound of Pearl Jam" },

            new Album{ title="Shapes & Patterns", artist="Patty Gurdy",
                image="~/images/Patty.jpg",
                note="I love the unique sounds of the hurdy gurdy and I have been listening " +
                "to all of the songs of this album for the last few weeks." }

        };

    }
}
