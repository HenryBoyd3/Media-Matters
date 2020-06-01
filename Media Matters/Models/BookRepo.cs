using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class BookRepo : IBookRepo
    {
        public IEnumerable<Book> GetBooks() =>
            new List<Book>
        {
            new Book{ ISBN="978-0544003415",lastname="Tolkien",firstname="John (J) R R",
                title ="Lord of the rings",edition="The first single-volume edition",
                publishedDate="1968" ,image="~/images/Lord.jpg ",
                note="This is my favorite IP out of all media. I like all of the side stories " +
                "and games that the series has spawned, the movies as well. I always enjoy the " +
                "stories of the good guys fighting evil and winning through strong bonds and" +
                " people willing to sacrifice for the greater good." },

            new Book{ ISBN="0-9666213-3-6 ",lastname="Paolini",firstname="Christopher",
                title ="Eragon",edition="First edition",
                publishedDate="2002" ,image="~/images/Eragon.jpg",
                note="I found this book when I was much younger and it was written by a someone" +
                " my age at the time and his story showed me I could do whatever" +
                " I want as long as I put the time and effort into it." +
                " I also like dragons and magic and this has lots of both with a " +
                "coming of age story that reminds me of star wars and lord of the rings." },

            new Book{ ISBN="978-0-7564-0407-9",lastname="Rothfuss",firstname="Patrick",
                title ="Name of the wind",edition="First edition",
                publishedDate="2007" ,image="~/images/Name.jpg",
                note="This is a newer favorite for me. I enjoy the story of how a boy who grew up as" +
                " a traveling performer with a knack for learning, and music grows up into someone" +
                " stories are told about.It also is a slow start with a lot of world building and " +
                "expanding on how the world is different from ours without revealing too much." },

            new Book{ ISBN="9781760558208",lastname="Babin & Willink",firstname=" Leif & Jocko",
                title ="Extreme ownership",edition="First edition",
                publishedDate="2015" ,image="~/images/Extream.jpg",
                note="This book was suggested to me by a few people I know so I could learn how to be a better leader." +
                " While I am not in a leadership role right now, learning good habits now was great." +
                " I enjoyed how they broke down why they think the points are important and how to " +
                "use the skills anywhere." },

            new Book{ ISBN="978-0544456235",lastname="Ericsson & Pool",firstname="K. Anders & Robert",
                title ="Peak: Secrets from the New Science of Expertise",edition="First edition",
                publishedDate="2016" ,image="~/images/Peak.jpg",
                note="I like this book because it breaks down how to be better at anything, and how people aren’t" +
                " born with unnatural talent, but work hard at what they want to be good at, explaining that people" +
                " like Michael Phelps worked hard to get where they are now, and that really helped me to realize that" +
                " if I study how to learn my skills and make sure to practice deliberately I can learn and master anything." +
                " The book also explains that the 10,000 hour rule isn’t for everything some " +
                "things take longer to master and other things will take less time." }

            };
    }
}
